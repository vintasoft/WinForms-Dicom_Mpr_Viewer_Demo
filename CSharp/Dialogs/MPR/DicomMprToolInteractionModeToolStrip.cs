using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Annotation.Measurements;
using Vintasoft.Imaging.Annotation.UI;
using Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools;
using Vintasoft.Imaging.UI.VisualTools;

using DemosCommonCode;
using DemosCommonCode.CustomControls;
using System.ComponentModel;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// A toolbar for DicomMprTool.
    /// </summary>
    public partial class DicomMprToolInteractionModeToolStrip : ToolStrip
    {

        #region Nested enums

        /// <summary>
        /// Specifies available types of measurement annotations.
        /// </summary>
        private enum MeasurementType
        {
            /// <summary>
            /// The length.
            /// </summary>
            Length,

            /// <summary>
            /// The ellipse.
            /// </summary>
            Ellipse,

            /// <summary>
            /// The angle.
            /// </summary>
            Angle,
        }

        #endregion



        #region Fields

        /// <summary>
        /// Dictionary: the DICOM MPR tool interaction mode => menu button.
        /// </summary>
        Dictionary<DicomMprToolInteractionMode, ToolStripItem> _interactionModeToMenuButton =
            new Dictionary<DicomMprToolInteractionMode, ToolStripItem>();

        /// <summary>
        /// Dictionary: menu button => the DICOM MPR tool interaction mode.
        /// </summary>
        Dictionary<ToolStripItem, DicomMprToolInteractionMode> _menuButtonToInteractionMode =
            new Dictionary<ToolStripItem, DicomMprToolInteractionMode>();

        /// <summary>
        /// Dictionary: the DICOM MPR tool interaction mode => icon name format for menu button.
        /// </summary>
        Dictionary<DicomMprToolInteractionMode, string> _interactionModeToIconNameFormat =
            new Dictionary<DicomMprToolInteractionMode, string>();


        /// <summary>
        /// The current measurement menu button.
        /// </summary>
        ToolStripMenuItem _currentMeasurementAnnotationTypeMenuButton = null;

        /// <summary>
        /// The current unit of measure menu button.
        /// </summary>
        ToolStripMenuItem _currentMeasurementAnnotationUnitOfMeasureMenuButton = null;


        /// <summary>
        /// The menu button that deletes focused measurement annotation in focused image viewer.
        /// </summary>
        ToolStripMenuItem _measurementAnnotationDeleteMenuButton;

        /// <summary>
        /// The menu button that deletes all measurement annotations in focused image viewer.
        /// </summary>
        ToolStripMenuItem _measurementAnnotationDeleteAllMenuButton;

        /// <summary>
        /// The menu button that deletes all measurement annotations in all image viewers.
        /// </summary>
        ToolStripMenuItem _measurementAnnotationDeleteAllOnViewersMenuButton;


        /// <summary>
        /// The icon name of mouse wheel button.
        /// </summary>
        readonly string MOUSE_WHEEL_BUTTON_ICON_NAME;

        /// <summary>
        /// The available mouse buttons.
        /// </summary>
        MouseButtons[] _availableMouseButtons = new MouseButtons[] { 
            MouseButtons.Left, MouseButtons.Middle, MouseButtons.Right
        };

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="DicomMprToolInteractionModeToolStrip"/> class.
        /// </summary>
        public DicomMprToolInteractionModeToolStrip()
            : base()
        {
            InitializeComponent();

            // initialize interaction mode of DicomMprTool
            _supportedInteractionModes = new DicomMprToolInteractionMode[] {
                        DicomMprToolInteractionMode.Browse,
                        DicomMprToolInteractionMode.Pan,
                        DicomMprToolInteractionMode.Roll,
                        DicomMprToolInteractionMode.Rotate3D,
                        DicomMprToolInteractionMode.Zoom,
                        DicomMprToolInteractionMode.WindowLevel,
                        DicomMprToolInteractionMode.Measure};

            // initilize name of icons

            MOUSE_WHEEL_BUTTON_ICON_NAME = "Dialogs.MPR.Icons.MouseWheel.png";

            _interactionModeToIconNameFormat.Add(DicomMprToolInteractionMode.Browse,
                "Dialogs.MPR.Icons.Browse_{0}{1}{2}.png");
            _interactionModeToIconNameFormat.Add(DicomMprToolInteractionMode.Measure,
                "Dialogs.MPR.Icons.Measure_{0}{1}{2}.png");
            _interactionModeToIconNameFormat.Add(DicomMprToolInteractionMode.Pan,
                "Dialogs.MPR.Icons.Pan_{0}{1}{2}.png");
            _interactionModeToIconNameFormat.Add(DicomMprToolInteractionMode.Rotate3D,
                "Dialogs.MPR.Icons.Rotate3D_{0}{1}{2}.png");
            _interactionModeToIconNameFormat.Add(DicomMprToolInteractionMode.Roll,
                "Dialogs.MPR.Icons.Roll_{0}{1}{2}.png");
            _interactionModeToIconNameFormat.Add(DicomMprToolInteractionMode.WindowLevel,
                "Dialogs.MPR.Icons.WindowLevel_{0}{1}{2}.png");
            _interactionModeToIconNameFormat.Add(DicomMprToolInteractionMode.Zoom,
                "Dialogs.MPR.Icons.Zoom_{0}{1}{2}.png");

            // initialize buttons
            InitButtons();
        }

        #endregion



        #region Properties

        DicomMprTool[] _dicomMprTools = null;
        /// <summary>
        /// Gets or sets an array of DicomMprTool objects.
        /// </summary>
        /// <value>
        /// Default value is <b>null</b>.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DicomMprTool[] DicomMprTools
        {
            get
            {
                return _dicomMprTools;
            }
            set
            {
                // if value is changed
                if (_dicomMprTools != value)
                {
                    if (_dicomMprTools != null)
                    {
                        foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                            UnsubscribeFromDicomMprToolEvents(dicomMprTool);
                    }

                    _dicomMprTools = value;

                    if (_dicomMprTools != null && _dicomMprTools.Length > 0)
                    {
                        foreach (MouseButtons mouseButton in _availableMouseButtons)
                        {
                            DicomMprToolInteractionMode interactionMode = _dicomMprTools[0].GetInteractionMode(mouseButton);
                            SubscribeToDicomMprToolEvents(_dicomMprTools[0]);

                            for (int i = 1; i < _dicomMprTools.Length; i++)
                            {
                                _dicomMprTools[i].SetInteractionMode(mouseButton, interactionMode);
                                SubscribeToDicomMprToolEvents(_dicomMprTools[i]);
                            }

                            if (_measurementAnnotationDeleteAllOnViewersMenuButton != null)
                            {
                                if (_dicomMprTools.Length == 1)
                                    _measurementAnnotationDeleteAllOnViewersMenuButton.Visible = false;
                                else
                                    _measurementAnnotationDeleteAllOnViewersMenuButton.Visible = true;
                            }
                        }
                    }

                    ResetUnsupportedInteractionModes();
                    UpdateInteractionButtonIcons();
                }
            }
        }

        DicomMprToolInteractionMode[] _supportedInteractionModes;
        /// <summary>
        /// Gets or sets the supported interaction modes of toolbar.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown if <i>value</i> is <b>null</b>.</exception>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DicomMprToolInteractionMode[] SupportedInteractionModes
        {
            get
            {
                return _supportedInteractionModes;
            }
            set
            {
                if (_supportedInteractionModes != value)
                {
                    if (value == null)
                        throw new ArgumentNullException();

                    _supportedInteractionModes = value;

                    InitButtons();

                    ResetUnsupportedInteractionModes();
                }
            }
        }

        DicomMprToolInteractionMode[] _disabledInteractionModes = null;
        /// <summary>
        /// Gets or sets the disabled interaction modes of toolbar.
        /// </summary>
        /// <value>
        /// Default value is <b>null</b>.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DicomMprToolInteractionMode[] DisabledInteractionModes
        {
            get
            {
                return _disabledInteractionModes;
            }
            set
            {
                // if value is changed
                if (_disabledInteractionModes != value)
                {
                    // save new value
                    _disabledInteractionModes = value;

                    // for each interaction mode
                    foreach (DicomMprToolInteractionMode interactionMode in _interactionModeToMenuButton.Keys)
                        // enable button for interaction mode
                        _interactionModeToMenuButton[interactionMode].Enabled = true;

                    // if disabled interaction modes are specified
                    if (_disabledInteractionModes != null)
                    {
                        // the menu button of interaction mode
                        ToolStripItem menuButton = null;

                        // for each interaction mode
                        foreach (DicomMprToolInteractionMode interactionMode in _disabledInteractionModes)
                        {
                            // if button is enabled
                            if (_interactionModeToMenuButton.TryGetValue(interactionMode, out menuButton))
                                // disable the button for interaction mode
                                menuButton.Enabled = false;
                        }
                    }
                }
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Initializes the buttons.
        /// </summary>
        private void InitButtons()
        {
            // remove old buttons
            Items.Clear();

            InitMouseWheelButtons();

            if (Items.Count > 0)
                Items.Add(new ToolStripSeparator());

            InitInteractionModeMenuButtons();
        }

        /// <summary>
        /// Initializes the mouse wheel buttons.
        /// </summary>
        private void InitMouseWheelButtons()
        {
            // the button name
            string name = "Mouse Wheel";
            // create the "Mouse Wheel" button
            ToolStripDropDownButton mouseWheelMenuButton = new ToolStripDropDownButton(name);
            mouseWheelMenuButton.ToolTipText = name;

            // set the button icon
            SetToolStripButtonIcon(mouseWheelMenuButton, MOUSE_WHEEL_BUTTON_ICON_NAME);

            // available interaction modes of mouse wheel
            DicomMprToolInteractionMode[] mouseWheelInteractionMode =
                new DicomMprToolInteractionMode[] {
                     DicomMprToolInteractionMode.None,
                     DicomMprToolInteractionMode.Browse,
                     DicomMprToolInteractionMode.Zoom };
            // for each interaction mode
            foreach (DicomMprToolInteractionMode interactionMode in mouseWheelInteractionMode)
            {
                // create button
                ToolStripMenuItem menuButton = new ToolStripMenuItem(interactionMode.ToString());

                // if interaction mode is "Browse"
                if (interactionMode == DicomMprToolInteractionMode.Browse)
                {
                    // mark button as checked
                    menuButton.Checked = true;
                }

                // save information about interaction mode in button
                menuButton.Tag = interactionMode;
                // subscribe to the button click event
                menuButton.Click += new EventHandler(mouseWheelInteractionModeButton_Click);

                // add button
                mouseWheelMenuButton.DropDownItems.Add(menuButton);
            }

            // add button to ToolStrip
            Items.Add(mouseWheelMenuButton);
        }

        /// <summary>
        /// Initializes the interaction mode menu buttons.
        /// </summary>
        private void InitInteractionModeMenuButtons()
        {
            // clear dictionaries
            _interactionModeToMenuButton.Clear();
            _menuButtonToInteractionMode.Clear();
            _measurementAnnotationDeleteMenuButton = null;
            _measurementAnnotationDeleteAllMenuButton = null;

            // for each suported interaction mode
            foreach (DicomMprToolInteractionMode interactionMode in _supportedInteractionModes)
            {
                // create button

                // get button name
                string name = interactionMode.ToString();

                ToolStripItem menuButton = null;

                // if interaction mode is measurement
                if (interactionMode == DicomMprToolInteractionMode.Measure)
                {
                    menuButton = new CheckedToolStripSplitButton(name);
                    // init measurement buttons for this button
                    InitMeasurementMenuButtons((CheckedToolStripSplitButton)menuButton);
                }
                else
                {
                    menuButton = new ToolStripButton(name);
                }

                menuButton.ToolTipText = name;

                // set the button icon
                SetToolStripButtonIcon(menuButton, interactionMode, MouseButtons.None);

                // add button to the dictionaries
                _interactionModeToMenuButton.Add(interactionMode, menuButton);
                _menuButtonToInteractionMode.Add(menuButton, interactionMode);

                // if button must be disabled
                if (_disabledInteractionModes != null &&
                    Array.IndexOf(_disabledInteractionModes, interactionMode) >= 0)
                    // disable the button
                    menuButton.Enabled = false;

                menuButton.MouseDown += new MouseEventHandler(interactionModeButton_MouseDown);

                // add button to the ToolStrip
                Items.Add(menuButton);
            }
        }


        #region Interaction Mode

        /// <summary>
        /// Selects the interaction mode button.
        /// </summary>
        private void dicomMprTool_InteractionModeChanged(object sender, DicomMprToolInteractionModeChangedEventArgs e)
        {
            UpdateInteractionMode(e.Button, e.InteractionMode);
        }

        /// <summary>
        /// Selects the interaction mode of DicomMprTools.
        /// </summary>
        private void interactionModeButton_MouseDown(object sender, MouseEventArgs e)
        {
            ToolStripSplitButton splitMenuButton = sender as ToolStripSplitButton;
            if (splitMenuButton != null && !splitMenuButton.ButtonPressed)
                return;

            ToolStripItem menuButton = (ToolStripItem)sender;
            DicomMprToolInteractionMode interactionMode = _menuButtonToInteractionMode[menuButton];

            UpdateInteractionMode(e.Button, interactionMode);
        }

        /// <summary>
        /// Updates the interaction mode in DicomMprTools.
        /// </summary>
        /// <param name="mouseButton">Mouse button.</param>
        /// <param name="interactionMode">Interaction mode.</param>
        private void UpdateInteractionMode(MouseButtons mouseButton, DicomMprToolInteractionMode interactionMode)
        {
            // if interaction mode is NOT supported
            if (Array.IndexOf(SupportedInteractionModes, interactionMode) == -1)
                interactionMode = DicomMprToolInteractionMode.None;

            // if mouse button is NOT supported
            if (Array.IndexOf(_availableMouseButtons, mouseButton) == -1)
                interactionMode = DicomMprToolInteractionMode.None;

            // for each DICOM MPR tool
            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
            {
                // if interaction mode is NOT Measure
                if (interactionMode != DicomMprToolInteractionMode.Measure)
                {
                    // clear focused annotation in measure tool
                    dicomMprTool.MeasureTool.FocusedAnnotationView = null;
                    // clear selected annotations in measure tool
                    dicomMprTool.MeasureTool.SelectedAnnotations.Clear();
                }

                // set the interaction mode for DICOM MPR tool
                dicomMprTool.SetInteractionMode(mouseButton, interactionMode);
            }

            // update icons of interaction buttons
            UpdateInteractionButtonIcons();
        }

        #endregion


        #region Measurements

        /// <summary>
        /// Initializes the measurement menu buttons.
        /// </summary>
        /// <param name="measureButton">Measure menu button.</param>
        private void InitMeasurementMenuButtons(CheckedToolStripSplitButton measureMenuButton)
        {
            measureMenuButton.DropDownOpening += new EventHandler(measureButton_DropDownOpening);
            measureMenuButton.DropDownClosed += new EventHandler(measureButton_DropDownClosed);

            ToolStripItemCollection measureMenuButtonItems = measureMenuButton.DropDownItems;

            // available measurement annotation types
            MeasurementType[] measurementTypes = new MeasurementType[] {
                MeasurementType.Length,
                MeasurementType.Ellipse,
                MeasurementType.Angle };
            // for each measurement annotation types
            foreach (MeasurementType measurementType in measurementTypes)
            {
                // create button
                ToolStripMenuItem menuButton = new ToolStripMenuItem(measurementType.ToString());

                // if measurement type is Length (default)
                if (measurementType == MeasurementType.Length)
                {
                    // check the button
                    menuButton.Checked = true;
                    // save reference to the current button
                    _currentMeasurementAnnotationTypeMenuButton = menuButton;
                }

                menuButton.Tag = measurementType;
                menuButton.Click += new EventHandler(measurementAnnotationTypeButton_Click);

                // add button
                measureMenuButtonItems.Add(menuButton);
            }

            // add seperator
            measureMenuButtonItems.Add(new ToolStripSeparator());

            // add "Delete" button
            _measurementAnnotationDeleteMenuButton = new ToolStripMenuItem("Delete");
            _measurementAnnotationDeleteMenuButton.ShortcutKeys = Keys.Delete;
            _measurementAnnotationDeleteMenuButton.Click += new EventHandler(measurementAnnotationDeleteButton_Click);
            measureMenuButtonItems.Add(_measurementAnnotationDeleteMenuButton);

            // add "Delete All" button
            _measurementAnnotationDeleteAllMenuButton = new ToolStripMenuItem("Delete All");
            _measurementAnnotationDeleteAllMenuButton.ShortcutKeys = Keys.Delete | Keys.Alt;
            _measurementAnnotationDeleteAllMenuButton.Click += new EventHandler(measurementAnnotationDeleteAllButton_Click);
            measureMenuButtonItems.Add(_measurementAnnotationDeleteAllMenuButton);

            // add "Delete All On Viewers" button
            _measurementAnnotationDeleteAllOnViewersMenuButton = new ToolStripMenuItem("Delete All On Viewers");
            _measurementAnnotationDeleteAllOnViewersMenuButton.ShortcutKeys = Keys.Delete | Keys.Control;
            _measurementAnnotationDeleteAllOnViewersMenuButton.Click += new EventHandler(measurementAnnotationDeleteAllOnViewersButton_Click);
            measureMenuButtonItems.Add(_measurementAnnotationDeleteAllOnViewersMenuButton);


            // add seperator
            measureMenuButtonItems.Add(new ToolStripSeparator());

            // add "Units of Measure" button
            ToolStripMenuItem unitsOfMeasureButton = new ToolStripMenuItem("Units of Measure");
            InitUnitsOfMeasureButtons(unitsOfMeasureButton);
            measureMenuButtonItems.Add(unitsOfMeasureButton);


            measureMenuButton.DropDown.AutoSize = true;
        }

        /// <summary>
        /// Initializes the units of measure buttons.
        /// </summary>
        private void InitUnitsOfMeasureButtons(ToolStripMenuItem unitsOfMeasureButton)
        {
            // available units of measure
            UnitOfMeasure[] unitOfMeasures = new UnitOfMeasure[] {
                UnitOfMeasure.Millimeters,
                UnitOfMeasure.Centimeters,
                UnitOfMeasure.Inches,
                UnitOfMeasure.Pixels};
            // for each unit of measure
            foreach (UnitOfMeasure unitOfMeasure in unitOfMeasures)
            {
                // create button
                ToolStripMenuItem menuButton = new ToolStripMenuItem(unitOfMeasure.ToString());
                menuButton.Tag = unitOfMeasure;

                // if unit of measure is millimeter (default value)
                if (unitOfMeasure == UnitOfMeasure.Millimeters)
                {
                    // check the button
                    menuButton.Checked = true;
                    // save reference to the current unit of measure button
                    _currentMeasurementAnnotationUnitOfMeasureMenuButton = menuButton;
                }

                menuButton.Click += new EventHandler(measurementAnnotationUnitOfMeasureButton_Click);

                // add button
                unitsOfMeasureButton.DropDownItems.Add(menuButton);
            }
        }

        /// <summary>
        /// The drop down menu of "Units of Measure" button is opening.
        /// </summary>
        private void measureButton_DropDownOpening(object sender, EventArgs e)
        {
            CheckedToolStripSplitButton menuButton = (CheckedToolStripSplitButton)sender;

            bool deleteButtonEnabled = false;
            bool deleteAllButtonEnabled = false;

            // get the active DICOM MPR tool
            DicomMprTool dicomMprTool = GetActiveMprTool();
            // if active DICOM MPR tool exists
            if (dicomMprTool != null)
            {
                deleteButtonEnabled = dicomMprTool.MeasureTool.DeleteAction.IsEnabled;
                deleteAllButtonEnabled = dicomMprTool.MeasureTool.DeleteAllAction.IsEnabled;
            }

            // update "Delete measurement annotation" buttons

            if (_measurementAnnotationDeleteMenuButton != null)
                _measurementAnnotationDeleteMenuButton.Enabled = deleteButtonEnabled;

            if (_measurementAnnotationDeleteAllMenuButton != null)
                _measurementAnnotationDeleteAllMenuButton.Enabled = deleteAllButtonEnabled;
        }

        /// <summary>
        /// The drop down menu of "Units of Measure" button is closed.
        /// </summary>
        private void measureButton_DropDownClosed(object sender, EventArgs e)
        {
            if (_measurementAnnotationDeleteMenuButton != null)
                _measurementAnnotationDeleteMenuButton.Enabled = true;

            if (_measurementAnnotationDeleteAllMenuButton != null)
                _measurementAnnotationDeleteAllMenuButton.Enabled = true;
        }

        /// <summary>
        /// The building annotation type is changed.
        /// </summary>
        private void measurementAnnotationTypeButton_Click(object sender, EventArgs e)
        {
            // if button with previous measurement annotation type exists
            if (_currentMeasurementAnnotationTypeMenuButton != null)
                // disable the button with previous measurement annotation type
                _currentMeasurementAnnotationTypeMenuButton.Checked = false;

            // save reference to the button with new measurement annotation type
            _currentMeasurementAnnotationTypeMenuButton = (ToolStripMenuItem)sender;
            // check the button
            _currentMeasurementAnnotationTypeMenuButton.Checked = true;
        }

        /// <summary>
        /// The units of measure are changed.
        /// </summary>
        private void measurementAnnotationUnitOfMeasureButton_Click(object sender, EventArgs e)
        {
            // if button with previous unit of measure exists
            if (_currentMeasurementAnnotationUnitOfMeasureMenuButton != null)
                // disable button with previous unit of measure
                _currentMeasurementAnnotationUnitOfMeasureMenuButton.Checked = false;

            // save reference to the button with new unit of measure
            _currentMeasurementAnnotationUnitOfMeasureMenuButton = (ToolStripMenuItem)sender;
            // check the button
            _currentMeasurementAnnotationUnitOfMeasureMenuButton.Checked = true;

            // get unit of measure from the button
            UnitOfMeasure unitOfMeasure = (UnitOfMeasure)_currentMeasurementAnnotationUnitOfMeasureMenuButton.Tag;

            // for each DICOM MPR tool
            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                // set unit of measure for DICOM MPR tool
                dicomMprTool.MeasureTool.UnitsOfMeasure = unitOfMeasure;
        }

        /// <summary>
        /// Deletes the selected measurement annotation.
        /// </summary>
        private void measurementAnnotationDeleteButton_Click(object sender, EventArgs e)
        {
            // get active DICOM MPR tool
            DicomMprTool dicomMprTool = GetActiveMprTool();
            if (dicomMprTool == null)
                return;

            // if focused measurement annotation can be removed
            if (dicomMprTool.MeasureTool.DeleteAction.IsEnabled)
                // remove focused measurement annotation
                dicomMprTool.MeasureTool.DeleteAction.Execute();
        }

        /// <summary>
        /// Deletes all measurement annotations in active DICOM MPR tool.
        /// </summary>
        private void measurementAnnotationDeleteAllButton_Click(object sender, EventArgs e)
        {
            // get active DICOM MPR tool
            DicomMprTool dicomMprTool = GetActiveMprTool();
            if (dicomMprTool == null)
                return;

            // if all measurement annotations can be removed
            if (dicomMprTool.MeasureTool.DeleteAllAction.IsEnabled)
                // remove all measurement annotations
                dicomMprTool.MeasureTool.DeleteAllAction.Execute();
        }

        /// <summary>
        /// Deletes all measurement annotations in all DICOM MPR tools.
        /// </summary>
        private void measurementAnnotationDeleteAllOnViewersButton_Click(object sender, EventArgs e)
        {
            // for each DICOM MPR tool
            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
            {
                // if all measurement annotations can be removed
                if (dicomMprTool.MeasureTool.DeleteAllAction.IsEnabled)
                    // remove all measurement annotations
                    dicomMprTool.MeasureTool.DeleteAllAction.Execute();
            }
        }

        /// <summary>
        /// Begins building the measurement annotation.
        /// </summary>
        /// <param name="measureTool">The measure tool.</param>
        private void StartBuildMeasurementAnnotation(ImageMeasureTool measureTool)
        {
            if (_currentMeasurementAnnotationTypeMenuButton == null)
                return;

            // get the annotation type, which should be built
            MeasurementType measurementType = (MeasurementType)_currentMeasurementAnnotationTypeMenuButton.Tag;

            MeasurementAnnotationView annotationView = null;
            // begin the building of annotation
            switch (measurementType)
            {
                case MeasurementType.Length:
                    annotationView = measureTool.BeginLineMeasurement();
                    break;

                case MeasurementType.Ellipse:
                    annotationView = measureTool.BeginEllipseMeasurement();
                    break;

                case MeasurementType.Angle:
                    annotationView = measureTool.BeginAngleMeasurement();
                    break;
            }

            if (annotationView == null)
                throw new NotImplementedException();

            // update the measuring text template
            annotationView.MeasurementAnnotationData.MeasuringTextTemplate =
                DicomMeasureToolUtils.GetMeasuringTextTemplate(annotationView.MeasurementAnnotationData);
        }

        /// <summary>
        /// Begins the building of measurement annotation.
        /// </summary>
        private void measureTool_MouseDown(object sender, VisualToolMouseEventArgs e)
        {
            ImageMeasureTool measureTool = (ImageMeasureTool)sender;

            if (measureTool.ActionButton == MouseButtons.None)
                return;

            if ((measureTool.ActionButton & e.Button) != MouseButtons.None)
            {
                // if mouse cursor is over interaction area
                if (measureTool.IsPointOnInteractionArea(e.X, e.Y, e.Button))
                    return;
                // if mouse cursor is over annotation
                if (measureTool.FindAnnotationView(e.X, e.Y) != null)
                    return;

                // begin the building of measurement annotation
                StartBuildMeasurementAnnotation(measureTool);
            }
        }

        /// <summary>
        /// Units of measure is changed.
        /// </summary>
        private void measureTool_UnitsOfMeasureChanged(object sender, PropertyChangedEventArgs<UnitOfMeasure> e)
        {
            ImageMeasureTool measureTool = (ImageMeasureTool)sender;
            // if image viewer is not empty
            if (measureTool.ImageViewer != null)
            {
                // for each image
                foreach (VintasoftImage image in measureTool.ImageViewer.Images)
                {
                    // get annotation list
                    IList<AnnotationView> annotations = measureTool.GetAnnotationsFromImage(image);
                    if (annotations != null)
                    {
                        // for each annotation
                        foreach (AnnotationView annotation in annotations)
                        {
                            MeasurementAnnotationData annotationData = annotation.Data as MeasurementAnnotationData;
                            // if annotation is measurement annotation
                            if (annotationData != null)
                                // set new measuring text template
                                annotationData.MeasuringTextTemplate = DicomMeasureToolUtils.GetMeasuringTextTemplate(annotationData);
                        }
                    }
                }
            }

            // update the measurement unit of measure in DicomMprTools
            UpdateMeasurementUnitOfMeasure(e.NewValue);
        }

        /// <summary>
        /// Updates the measurement unit of measure in DicomMprTools.
        /// </summary>
        /// <param name="unitOfMeasure">The unit of measure.</param>
        private void UpdateMeasurementUnitOfMeasure(UnitOfMeasure unitOfMeasure)
        {
            // for each DICOM MPR tool
            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
            {
                // set the unit of measure for measurement tool
                dicomMprTool.MeasureTool.UnitsOfMeasure = unitOfMeasure;
            }
        }

        #endregion


        #region Buttons Icon

        /// <summary>
        /// Updates the icon of interaction buttons.
        /// </summary>
        private void UpdateInteractionButtonIcons()
        {
            // for each interaction mode
            foreach (DicomMprToolInteractionMode interactionMode in _interactionModeToMenuButton.Keys)
            {
                // get the menu button of interaction mode
                ToolStripItem menuButton = _interactionModeToMenuButton[interactionMode];

                // get mouse buttons of interaction mode
                MouseButtons mouseButtons = GetMouseButtonsForInteractionMode(interactionMode);

                // update icon for menu button
                SetToolStripButtonIcon(menuButton, interactionMode, mouseButtons);
            }
        }

        /// <summary>
        /// Returns the icon name of specified interaction mode and buttons.
        /// </summary>
        /// <param name="interactionMode">The interaction mode.</param>
        /// <param name="mouseButtons">The mouse buttons of interaction mode.</param>
        /// <returns>
        /// The icon name.
        /// </returns>
        private string GetInteractionModeIconName(DicomMprToolInteractionMode interactionMode, MouseButtons mouseButtons)
        {
            // indices of action buttons (left, middle, right)
            byte[] indexes = new byte[] { 0, 0, 0 };

            // if mouse buttons are not empty
            if (mouseButtons != MouseButtons.None)
            {
                // if left mouse button is active
                if ((mouseButtons & MouseButtons.Left) != 0)
                    indexes[0] = 1;
                // if middle mouse button is active
                if ((mouseButtons & MouseButtons.Middle) != 0)
                    indexes[1] = 1;
                // if right mouse button is active
                if ((mouseButtons & MouseButtons.Right) != 0)
                    indexes[2] = 1;
            }

            // get the icon name format
            string iconNameFormat = _interactionModeToIconNameFormat[interactionMode];

            // return the icon name
            return string.Format(iconNameFormat, indexes[0], indexes[1], indexes[2]);
        }

        /// <summary>
        /// Sets the icon for the tool strip button.
        /// </summary>
        /// <param name="menuButton">The menu button.</param>
        /// <param name="interactionMode"></param>
        /// <param name="mouseButtons"></param>
        private void SetToolStripButtonIcon(
            ToolStripItem menuButton,
            DicomMprToolInteractionMode interactionMode,
            MouseButtons mouseButtons)
        {
            // get icon name for interaction mode
            string iconName = GetInteractionModeIconName(interactionMode, mouseButtons);

            // set the icon for button
            SetToolStripButtonIcon(menuButton, iconName);
        }

        /// <summary>
        /// Sets the icon for the tool strip button.
        /// </summary>
        /// <param name="menuButton">The menu button.</param>
        /// <param name="iconName">The icon name.</param>
        private void SetToolStripButtonIcon(ToolStripItem menuButton, string iconName)
        {
            // if the icon name is NOT specified
            if (string.IsNullOrEmpty(iconName))
                return;

            // if menu button contains infomation about the button icon
            if (menuButton.Tag is string)
            {
                // get the icon name
                string currentIconName = menuButton.Tag.ToString();

                // if icon is not changed
                if (String.Equals(currentIconName, iconName, StringComparison.InvariantCultureIgnoreCase))
                    return;
            }

            menuButton.ImageTransparentColor = Color.Magenta;
            // load resource stream
            Stream stream = DemosResourcesManager.GetResourceAsStream(iconName);
            // if stream is loaded
            if (stream != null)
            {
                // if icon must be removed
                if (menuButton.Image != null)
                    menuButton.Image.Dispose();

                // load image
                menuButton.Image = Image.FromStream(stream);
                // save icon name
                menuButton.Tag = iconName;
                stream.Dispose();
            }

            menuButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            menuButton.ImageScaling = ToolStripItemImageScaling.None;
        }

        #endregion


        #region Common

        /// <summary>
        /// Returns the active <see cref="DicomMprTool"/>.
        /// </summary>
        /// <returns>
        /// The active <see cref="DicomMprTool"/>.
        /// </returns>
        private DicomMprTool GetActiveMprTool()
        {
            if (_dicomMprTools != null)
            {
                foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                {
                    if (dicomMprTool.ImageViewer != null &&
                        dicomMprTool.ImageViewer.Focused)
                    {
                        return dicomMprTool;
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Returns the mouse buttons for interaction mode.
        /// </summary>
        /// <param name="interactionMode">The interaction mode.</param>
        /// <returns>
        /// The mouse buttons for interaction mode.
        /// </returns>
        private MouseButtons GetMouseButtonsForInteractionMode(DicomMprToolInteractionMode interactionMode)
        {
            // the result mouse buttons
            MouseButtons resultMouseButton = MouseButtons.None;

            // get the active DICOM MPR tool
            DicomMprTool dicomMprTool = GetActiveMprTool();

            // if active tool exists
            if (dicomMprTool != null)
            {
                // for each available mouse button
                foreach (MouseButtons button in _availableMouseButtons)
                {
                    // get an interaction mode for mouse button
                    DicomMprToolInteractionMode mouseButtonInteractionMode = dicomMprTool.GetInteractionMode(button);
                    // if interaction mode for mouse button equals to the analyzing interaction mode
                    if (mouseButtonInteractionMode == interactionMode)
                        // add mouse button to the result
                        resultMouseButton |= button;
                }
            }

            return resultMouseButton;
        }

        /// <summary>
        /// Resets the unsupported interaction modes.
        /// </summary>
        private void ResetUnsupportedInteractionModes()
        {
            if (_dicomMprTools == null)
                return;

            // for each DICOM MPR tool
            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
            {
                // for each mouse button
                foreach (MouseButtons mouseButton in _availableMouseButtons)
                {
                    // get the interaction mode for mouse button
                    DicomMprToolInteractionMode interactionMode = dicomMprTool.GetInteractionMode(mouseButton);

                    // if interaction mode is None
                    if (interactionMode == DicomMprToolInteractionMode.None)
                        continue;

                    // is interaction mode is not supported
                    if (Array.IndexOf(SupportedInteractionModes, interactionMode) == -1)
                        // reset the interaction mode for mouse button
                        dicomMprTool.SetInteractionMode(mouseButton, DicomMprToolInteractionMode.None);
                }
            }
        }

        /// <summary>
        /// The mouse wheel interaction mode is changed.
        /// </summary>
        private void mouseWheelInteractionModeButton_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem currentMenuButton = (ToolStripMenuItem)sender;
            // get the interaction mode
            DicomMprToolInteractionMode interactionMode = (DicomMprToolInteractionMode)currentMenuButton.Tag;

            // for each DICOM MPR tool
            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                // update the interaction mode for mouse wheel
                dicomMprTool.MouseWheelInteractionMode = interactionMode;


            // uncheck all buttons

            ToolStripDropDownButton parentMenuButton = currentMenuButton.OwnerItem as ToolStripDropDownButton;
            // if parent menu button exists
            if (parentMenuButton != null)
            {
                // for each item in parent menu item
                foreach (ToolStripItem item in parentMenuButton.DropDownItems)
                {
                    // if item is menu button
                    if (item is ToolStripMenuItem)
                        // uncheck the menu button
                        ((ToolStripMenuItem)item).Checked = false;
                }
            }

            // check the current menu button
            currentMenuButton.Checked ^= true;
        }

        /// <summary>
        /// Subscribes to the DicomMprTool events.
        /// </summary>
        /// <param name="tool">The DicomMprTool.</param>
        private void SubscribeToDicomMprToolEvents(DicomMprTool tool)
        {
            tool.ImageViewer.GotFocus += new EventHandler(imageViewer_GotFocus);
            tool.InteractionModeChanged +=
                new EventHandler<DicomMprToolInteractionModeChangedEventArgs>(dicomMprTool_InteractionModeChanged);

            tool.MeasureTool.MouseDown += new VisualToolMouseEventHandler(measureTool_MouseDown);
            tool.MeasureTool.UnitsOfMeasureChanged +=
                new EventHandler<PropertyChangedEventArgs<UnitOfMeasure>>(measureTool_UnitsOfMeasureChanged);
        }

        /// <summary>
        /// Unsubscribes from the DicomMprTool events.
        /// </summary>
        /// <param name="tool">The DicomMprTool.</param>
        private void UnsubscribeFromDicomMprToolEvents(DicomMprTool tool)
        {
            tool.InteractionModeChanged -= dicomMprTool_InteractionModeChanged;
            tool.MeasureTool.UnitsOfMeasureChanged -= measureTool_UnitsOfMeasureChanged;
        }

        /// <summary>
        /// Updates the focused measurement annotations.
        /// </summary>
        private void imageViewer_GotFocus(object sender, EventArgs e)
        {
            UpdateInteractionButtonIcons();
        }

        #endregion

        #endregion

    }
}
