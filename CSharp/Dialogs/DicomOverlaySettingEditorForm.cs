using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


using Vintasoft.Imaging.Codecs.ImageFiles.Dicom;
using Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools;
using Vintasoft.Imaging.Dicom.UI.VisualTools;
using Vintasoft.Imaging;
using Vintasoft.Imaging.UI.VisualTools;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// A form that allows to change the overlay text settings of DICOM viewer.
    /// </summary>
    public partial class DicomOverlaySettingEditorForm : Form
    {

        #region Fields

        /// <summary>
        /// The collection owner name.
        /// </summary>
        string _collectionOwnerName;

        /// <summary>
        /// The customizable visual tool (<see cref="DicomViewerTool"/> or <see cref="MprImageTool"/>).
        /// </summary>
        VisualTool _visualTool;

        /// <summary>
        /// The default color.
        /// </summary>
        Color _defaultColor = Color.FromArgb(255, 255, 64);

        /// <summary>
        /// The current selected anchor.
        /// </summary>
        AnchorType _currentSelectedAnchor = AnchorType.None;

        /// <summary>
        /// The supported text overlay items.
        /// </summary>
        List<TextOverlay> _supportedItems = new List<TextOverlay>();

        /// <summary>
        /// The dictionary: owner name => text overlay collection.
        /// </summary>
        private static Dictionary<string, TextOverlayCollection> _ownerNameToTextOverlayDictionary = new Dictionary<string, TextOverlayCollection>();

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DicomOverlaySettingEditorForm"/> class.
        /// </summary>
        /// <param name="ownerName">The collection owner name.</param>
        /// <param name="visualTool">The customizable visual tool (<see cref="DicomViewerTool"/> or
        /// <see cref="MprImageTool"/>).</param>
        public DicomOverlaySettingEditorForm(string ownerName, VisualTool visualTool)
        {
            InitializeComponent();

            _visualTool = visualTool;
            _collectionOwnerName = ownerName;

            CheckAndInitOwnerInDictionary(ownerName, visualTool);
            InitVisualToolItems();
            Init();
            UpdateSelectedItemsListBox();
            UpdateUI();
        }

        #endregion



        #region Methods

        /// <summary>
        /// Sets the text overlay collection for visual tool.
        /// </summary>
        /// <param name="ownerName">The name of collection owner.</param>
        /// <param name="visualTool">The visual tool for which the text overlay collection must be set.</param>
        public static void SetTextOverlay(string ownerName, VisualTool visualTool)
        {
            // the text overlay collection of visual tool
            TextOverlayCollection toolTextOverlayCollection = null;
            // if visual tool is DICOM viewer tool
            if (visualTool is DicomViewerTool)
                toolTextOverlayCollection = ((DicomViewerTool)visualTool).TextOverlay;
            // if visual tool is DICOM MPR tool
            if (visualTool is DicomMprTool)
                toolTextOverlayCollection = ((DicomMprTool)visualTool).TextOverlay;

            if (toolTextOverlayCollection != null)
            {
                toolTextOverlayCollection.Clear();
                foreach (TextOverlay item in _ownerNameToTextOverlayDictionary[ownerName])
                {
                    toolTextOverlayCollection.Add((TextOverlay)item.Clone());
                }
            }
        }

        /// <summary>
        /// Updates all text overlay elements in visual tool.
        /// </summary>
        private void DicomOverlaySettingEditorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetTextOverlay(_collectionOwnerName, _visualTool);
        }


        #region Update UI

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            bool multipleViewIsSelected = selectedItemsListBox.SelectedIndices.Count > 1;
            bool singleViewIsSelected = selectedItemsListBox.SelectedIndex != -1 && !multipleViewIsSelected;

            addButton.Enabled = supportedItemsListBox.SelectedIndex != -1;

            removeButton.Enabled = multipleViewIsSelected || singleViewIsSelected;
            moveUpButton.Enabled = singleViewIsSelected && selectedItemsListBox.SelectedIndex > 0;
            moveDownButton.Enabled = singleViewIsSelected && selectedItemsListBox.SelectedIndex != selectedItemsListBox.Items.Count - 1;

            groupButton.Enabled = multipleViewIsSelected;
            ungroupButton.Enabled = (selectedItemsListBox.SelectedItem is TextOverlayGroup) && singleViewIsSelected;
        }

        /// <summary>
        /// Index of selected anchor is changed.
        /// </summary>
        private void anchorTypeEditor_SelectedAnchorTypeChanged(object sender, EventArgs e)
        {
            UpdateSelectedItemsListBox();

            UpdateUI();
        }

        /// <summary>
        /// Updates list box that contains text items with selected anchor property.
        /// </summary>
        private void UpdateSelectedItemsListBox()
        {
            // get selected anchor
            AnchorType selectedAnchor = anchorTypeEditor.SelectedAnchorType;

            if (selectedAnchor == _currentSelectedAnchor)
                return;

            _currentSelectedAnchor = selectedAnchor;

            selectedItemsListBox.BeginUpdate();
            // clear selected items list box
            selectedItemsListBox.Items.Clear();

            // for each text overlay item
            foreach (TextOverlay item in _ownerNameToTextOverlayDictionary[_collectionOwnerName])
            {
                // if item has selected anchor
                if (item.Anchor == selectedAnchor)
                {
                    // add item to the selected items list box
                    selectedItemsListBox.Items.Add(item);
                }
            }
            selectedItemsListBox.EndUpdate();
        }

        /// <summary>
        /// Index of selected text overlay elements is changed.
        /// </summary>
        private void supportedItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        /// <summary>
        /// Index of selected text overlay elements is changed.
        /// </summary>
        private void selectedItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTextOverlayPropertyGrid.SelectedObject = selectedItemsListBox.SelectedItem;

            UpdateUI();
        }

        /// <summary>
        /// Updates list box with supported items.
        /// </summary>
        private void UpdateSupportedItemsListBox()
        {
            supportedItemsListBox.BeginUpdate();

            // clear supported items list
            supportedItemsListBox.Items.Clear();

            foreach (TextOverlay textOverlay in _supportedItems)
            {
                if (textOverlay is DicomMprToolTextOverlay)
                {
                    if (_visualTool is DicomMprTool)
                        supportedItemsListBox.Items.Add(textOverlay);
                }
                else
                {
                    supportedItemsListBox.Items.Add(textOverlay);
                }
            }

            supportedItemsListBox.EndUpdate();
        }

        /// <summary>
        /// Property value is changed.
        /// </summary>
        private void selectedTextOverlayPropertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            // update selected item in list box
            TextOverlay textOverlay = (TextOverlay)selectedItemsListBox.SelectedItem;
            int index = selectedItemsListBox.SelectedIndex;
            selectedItemsListBox.Items[index] = textOverlay;
        }

        #endregion


        #region Init

        /// <summary>
        /// Initializes form controls.
        /// </summary>
        private void Init()
        {
            // init supported items
            _supportedItems.Add(new TextOverlay());


            _supportedItems.Add(new CustomDicomDataElementTextOverlay(0, 0));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.Unknown));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.PatientName));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.PatientID));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.PatientBirthDate));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.PatientSex));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.Manufacturer));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.StudyID));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.StudyDescription));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.SeriesDescription));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.ImageComments));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.StudyDate));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.StudyTime));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.XRayTubeCurrent, "{0}mA"));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.KVP, "{0}kV"));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.RepetitionTime, "RT: {0}"));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.EchoTime, "ET: {0}"));
            _supportedItems.Add(new StandardDicomDataElementTextOverlay(DicomDataElementId.MagneticFieldStrength, "FS: {0}"));
            _supportedItems.Add(new DicomImageVoiLutTextOverlay());
            _supportedItems.Add(new PatientOrientationTextOverlay());


            _supportedItems.Add(new MprSliceOrientationTextOverlay());
            _supportedItems.Add(new MprSliceRenderingModeTextOverlay());
            _supportedItems.Add(new DicomMprFillDataProgressTextOverlay());
            _supportedItems.Add(new MprPlanarSliceLocationTextOverlay());
            _supportedItems.Add(new MprPlanarSliceThicknessTextOverlay());


            _supportedItems.Sort(TextOverlayComparer);
            foreach (TextOverlay textOverlay in _supportedItems)
                textOverlay.TextColor = _defaultColor;

            UpdateSupportedItemsListBox();
        }

        /// <summary>
        /// Compares the <see cref="TextOverlay"/>.
        /// </summary>
        /// <param name="firstTextOverlay">The first text overlay.</param>
        /// <param name="secondTextOverlay">The second text overlay.</param>
        private int TextOverlayComparer(
            TextOverlay firstTextOverlay,
            TextOverlay secondTextOverlay)
        {
            return string.Compare(
                firstTextOverlay.ToString(),
                secondTextOverlay.ToString());
        }

        /// <summary>
        /// Checks owner name in dictionary and initializes if necessary.
        /// </summary>
        /// <param name="ownerName">The text overlay collection owner name.</param>
        /// <param name="tool">The visual tool.</param>
        private void CheckAndInitOwnerInDictionary(string ownerName, VisualTool tool)
        {
            // if dictionary does not contain owner name
            if (!_ownerNameToTextOverlayDictionary.ContainsKey(ownerName))
            {
                // create new text overlay collection
                TextOverlayCollection textOverlayCollection = new TextOverlayCollection();

                // get visual tool text overlay collection
                TextOverlayCollection toolTextOverlayCollection = null;
                // if tool is DICOM viewer tool
                if (tool is DicomViewerTool)
                    toolTextOverlayCollection = ((DicomViewerTool)tool).TextOverlay;
                // if tool is DICOM MPR tool
                if (tool is DicomMprTool)
                    toolTextOverlayCollection = ((DicomMprTool)tool).TextOverlay;

                if (toolTextOverlayCollection != null)
                {
                    // copy text overlay items
                    foreach (TextOverlay item in toolTextOverlayCollection)
                        textOverlayCollection.Add((TextOverlay)item.Clone());
                }

                // add owner to the dictionary
                _ownerNameToTextOverlayDictionary.Add(ownerName, textOverlayCollection);
            }
        }

        /// <summary>
        /// Initializes the visual tool text overlay elements for updating dynamically.
        /// </summary>
        private void InitVisualToolItems()
        {
            // get visual tool text overlay collection
            TextOverlayCollection toolTextOverlayCollection = null;
            // if tool is DICOM viewer tool
            if (_visualTool is DicomViewerTool)
                toolTextOverlayCollection = ((DicomViewerTool)_visualTool).TextOverlay;
            // if tool is DICOM MPR tool
            if (_visualTool is DicomMprTool)
                toolTextOverlayCollection = ((DicomMprTool)_visualTool).TextOverlay;

            if (toolTextOverlayCollection != null)
            {
                toolTextOverlayCollection.Clear();
                // copy text overlay items
                foreach (TextOverlay item in _ownerNameToTextOverlayDictionary[_collectionOwnerName])
                    toolTextOverlayCollection.Add(item);
            }
        }

        #endregion


        #region Add Selected Item

        /// <summary>
        /// Adds text overlay element into elements, which should be displayed on viewer.
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            AddSelectedItem();
        }

        /// <summary>
        /// Adds text overlay element into elements, which should be displayed on viewer.
        /// </summary>
        private void supportedItemsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = supportedItemsListBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                AddSelectedItem();
            }
        }

        /// <summary>
        /// Adds the selected item to the listbox with selected text overlay elements.
        /// </summary>
        private void AddSelectedItem()
        {
            // copy a text overlay item
            TextOverlay textOverlay = (TextOverlay)((TextOverlay)supportedItemsListBox.SelectedItem).Clone();
            // set anchor to the item
            textOverlay.Anchor = anchorTypeEditor.SelectedAnchorType;
            AddItem(textOverlay);
        }

        /// <summary>
        /// Adds specified item to the listbox with selected text overlay elements.
        /// </summary>
        /// <param name="textOverlay">The text overlay item.</param>
        private void AddItem(TextOverlay textOverlay)
        {
            // add item to the list
            selectedItemsListBox.Items.Add(textOverlay);
            _ownerNameToTextOverlayDictionary[_collectionOwnerName].Add(textOverlay);

            // get visual tool collection
            TextOverlayCollection toolTextOverlayCollection = null;
            if (_visualTool is DicomViewerTool)
                toolTextOverlayCollection = ((DicomViewerTool)_visualTool).TextOverlay;
            if (_visualTool is DicomMprTool)
                toolTextOverlayCollection = ((DicomMprTool)_visualTool).TextOverlay;

            if (toolTextOverlayCollection != null)
                toolTextOverlayCollection.Add(textOverlay);

            UpdateUI();
        }

        #endregion


        #region Remove Selected Item

        /// <summary>
        /// Removes the selected item from the listbox with selected text overlay elements.
        /// </summary>
        private void removeButton_Click(object sender, EventArgs e)
        {
            // save selected items to the new array
            int selectedItemsCount = selectedItemsListBox.SelectedItems.Count;
            TextOverlay[] selectedItems = new TextOverlay[selectedItemsCount];
            int selectedItemsIndex = 0;
            foreach (int index in selectedItemsListBox.SelectedIndices)
            {
                selectedItems[selectedItemsIndex] = (TextOverlay)selectedItemsListBox.Items[index];
                selectedItemsIndex++;
            }

            RemoveItems(selectedItems);
        }

        /// <summary>
        /// Removes the specified items from the listbox with selected text overlay elements.
        /// </summary>
        /// <param name="items">The items to remove.</param>
        private void RemoveItems(params TextOverlay[] items)
        {
            // get visual tool collection
            TextOverlayCollection toolTextOverlayCollection = null;
            if (_visualTool is DicomViewerTool)
                toolTextOverlayCollection = ((DicomViewerTool)_visualTool).TextOverlay;
            if (_visualTool is DicomMprTool)
                toolTextOverlayCollection = ((DicomMprTool)_visualTool).TextOverlay;

            foreach (TextOverlay item in items)
            {
                // remove text overlay from selected items list box
                selectedItemsListBox.Items.Remove(item);
                _ownerNameToTextOverlayDictionary[_collectionOwnerName].Remove(item);

                if (toolTextOverlayCollection != null)
                    toolTextOverlayCollection.Remove(item);
            }

            UpdateUI();
        }

        #endregion


        #region Move/Group Selected Item

        /// <summary>
        /// Data element view is moved up.
        /// </summary>
        private void moveUpButton_Click(object sender, EventArgs e)
        {
            MoveItemInSelectedItemsCollection(-1);
        }

        /// <summary>
        /// Data element view is moved down.
        /// </summary>
        private void moveDownButton_Click(object sender, EventArgs e)
        {
            MoveItemInSelectedItemsCollection(+1);
        }

        /// <summary>
        /// Moves selected item in selected items collection on specified step count.
        /// </summary>
        /// <param name="steps">The step count.</param>
        private void MoveItemInSelectedItemsCollection(int steps)
        {
            int selectedIndex = selectedItemsListBox.SelectedIndex;
            int movedIndex = selectedIndex + steps;
            if (movedIndex < 0)
                movedIndex = 0;
            if (movedIndex > selectedItemsListBox.Items.Count - 1)
                movedIndex = selectedItemsListBox.Items.Count - 1;

            TextOverlay movedItem = (TextOverlay)selectedItemsListBox.Items[movedIndex];
            TextOverlay selectedTextOverlay = (TextOverlay)selectedItemsListBox.Items[selectedIndex];
            selectedItemsListBox.Items.Remove(selectedTextOverlay);
            selectedItemsListBox.Items.Insert(selectedIndex + steps, selectedTextOverlay);
            selectedItemsListBox.SelectedIndex = selectedIndex + steps;

            // get text overlay collection
            TextOverlayCollection collection = _ownerNameToTextOverlayDictionary[_collectionOwnerName];
            MoveTextOverlayItemInCollection(movedItem, selectedTextOverlay, collection, steps);

            // get visual tool collection
            TextOverlayCollection toolTextOverlayCollection = null;
            if (_visualTool is DicomViewerTool)
                toolTextOverlayCollection = ((DicomViewerTool)_visualTool).TextOverlay;
            if (_visualTool is DicomMprTool)
                toolTextOverlayCollection = ((DicomMprTool)_visualTool).TextOverlay;

            if (toolTextOverlayCollection != null)
                MoveTextOverlayItemInCollection(movedItem, selectedTextOverlay, toolTextOverlayCollection, steps);

            UpdateUI();
        }

        /// <summary>
        /// Moves specified item in specified collection in position of moved item.
        /// </summary>
        /// <param name="movedItem">The moved item.</param>
        /// <param name="selectedItem">The selected item.</param>
        /// <param name="collection">The collection.</param>
        /// <param name="direction">The insert direction.</param>
        private void MoveTextOverlayItemInCollection(
            TextOverlay movedItem,
            TextOverlay selectedItem,
            TextOverlayCollection collection,
            int direction)
        {
            // remove from collection
            collection.Remove(selectedItem);
            // get index of previous item
            int indexOfPreviousItem = collection.IndexOf(movedItem);
            int indexToMove = indexOfPreviousItem;
            if (direction > 0)
                indexToMove++;

            if (indexToMove < 0)
                indexToMove = 0;
            if (indexToMove > collection.Count - 1)
                indexToMove = collection.Count - 1;
            // insert item
            collection.Insert(indexToMove, selectedItem);
        }

        /// <summary>
        /// Groups the selected items.
        /// </summary>
        private void groupButton_Click(object sender, EventArgs e)
        {
            // save selected items to the new array
            int selectedItemsCount = selectedItemsListBox.SelectedItems.Count;
            TextOverlay[] selectedItems = new TextOverlay[selectedItemsCount];
            int selectedItemsIndex = 0;
            foreach (int index in selectedItemsListBox.SelectedIndices)
            {
                selectedItems[selectedItemsIndex] = (TextOverlay)selectedItemsListBox.Items[index];
                selectedItemsIndex++;
            }

            RemoveItems(selectedItems);

            TextOverlayGroup group = new TextOverlayGroup(anchorTypeEditor.SelectedAnchorType, selectedItems);
            group.TextFont = selectedItems[0].TextFont;
            group.TextColor = selectedItems[0].TextColor;
            AddItem(group);
        }

        /// <summary>
        /// Ungroups the selected items.
        /// </summary>
        private void ungroupButton_Click(object sender, EventArgs e)
        {
            TextOverlayGroup group = selectedItemsListBox.SelectedItem as TextOverlayGroup;
            RemoveItems(group);

            foreach (TextOverlay item in group.Items)
            {
                AddItem(item);
            }
        }

        #endregion

        #endregion

    }
}
