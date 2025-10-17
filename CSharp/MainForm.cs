using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs;
using Vintasoft.Imaging.Codecs.ImageFiles.Dicom;
using Vintasoft.Imaging.Dicom.Mpr;
using Vintasoft.Imaging.Dicom.Mpr.UI;
using Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools;
using Vintasoft.Imaging.Dicom.UI;
using Vintasoft.Imaging.Dicom.UI.VisualTools;
using Vintasoft.Imaging.ImageProcessing;
using Vintasoft.Imaging.Metadata;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.UI.VisualTools;
using Vintasoft.Imaging.UI.VisualTools.GraphicObjects;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// Main form of DICOM MPR viewer demo.
    /// </summary>
    public partial class MainForm : Form
    {

        #region Fields

        /// <summary>
        /// Controller of source data in MPR image.
        /// </summary>
        MprSourceDataController _mprSourceDataController;

        /// <summary>
        /// The MPR settings manager.
        /// </summary>
        MprImageToolAppearanceSettings _mprSettingsManager;

        /// <summary>
        /// The visualization controller that manages the visualization of MPR image in image viewers.
        /// </summary>
        MprVisualizationController _visualizationController;

        /// <summary>
        /// The visualized slices (the first item - sagittal slice, the second item - coronal slice, the third item - axial slice).
        /// </summary>
        MprSlice[] _slices;

        /// <summary>
        /// The default slices.
        /// </summary>
        MprSlice[] _defaultSlices;

        /// <summary>
        /// The <see cref="DicomMprTool"/> of viewers.
        /// </summary>
        DicomMprTool[] _dicomMprTools;

        /// <summary>
        /// A value indicating whether DICOM image VOI LUT is changing.
        /// </summary>
        bool _isImageVoiLutChanging = false;

        /// <summary>
        /// The previous window state value.
        /// </summary>
        FormWindowState _previousWindowState;

        /// <summary>
        /// The form with MPR parameters information.
        /// </summary>
        MprParametersViewerForm _mprParametersForm;

        /// <summary>
        /// A value indicating whether the application form is closing.
        /// </summary> 
        bool _isFormClosing = false;

        /// <summary>
        /// A value indicating whether the MPR cube is initialized.
        /// </summary> 
        bool _isMprCubeInitialized = false;

        /// <summary>
        /// Dictionary: the tool strip menu item => rulers units of measure.
        /// </summary>
        Dictionary<ToolStripMenuItem, UnitOfMeasure> _toolStripMenuItemToRulersUnitOfMeasure =
            new Dictionary<ToolStripMenuItem, UnitOfMeasure>();

        /// <summary>
        /// Current rulers unit menu item.
        /// </summary>
        ToolStripMenuItem _currentRulersUnitOfMeasureMenuItem = null;

        #endregion



        #region Constructors

        public MainForm()
        {
            // register the evaluation license for VintaSoft Imaging .NET SDK
            Vintasoft.Imaging.ImagingGlobalSettings.Register("REG_USER", "REG_EMAIL", "EXPIRATION_DATE", "REG_CODE");

            _mprSourceDataController = new MprSourceDataController();
            _mprSettingsManager = new MprImageToolAppearanceSettings();

            InitializeComponent();

            this.Text = "VintaSoft DICOM MPR Viewer Demo v" + ImagingGlobalSettings.ProductVersion;

            MoveDicomCodecToFirstPosition();

            Jpeg2000AssemblyLoader.Load();

            // subscribe to the image viewers events
            imageViewer1.GotFocus += new EventHandler(ImageViewer_GotFocus);
            imageViewer2.GotFocus += new EventHandler(ImageViewer_GotFocus);
            imageViewer3.GotFocus += new EventHandler(ImageViewer_GotFocus);

            dicomSeriesManagerControl1.AddedFileCountChanged += DicomSeriesManagerControl1_AddedFileCountChanged;
            dicomSeriesManagerControl1.FocusedSeriesIdentifierChanged += DicomSeriesManagerControl1_FocusedSeriesIdentifierChanged;

            UpdateUI();
        }

        #endregion



        #region Properties

        bool _isDicomSeriesOpening = false;
        /// <summary>
        /// Gets or sets a value indicating whether the DICOM series is opening.
        /// </summary>
        private bool IsDicomSeriesOpening
        {
            get
            {
                return _isDicomSeriesOpening;
            }
            set
            {
                _isDicomSeriesOpening = value;

                if (InvokeRequired)
                    InvokeUpdateUI();
                else
                    UpdateUI();
            }
        }

        /// <summary>
        /// Gets the focused image viewer.
        /// </summary>
        /// <value>
        /// The focused image viewer.
        /// </value>
        private ImageViewer FocusedViewer
        {
            get
            {
                return imageViewerToolStrip1.ImageViewer;
            }
        }

        /// <summary>
        /// Gets the DICOM MPR tool of focused image viewer.
        /// </summary>
        private DicomMprTool FocusedViewerDicomMprTool
        {
            get
            {
                return _visualizationController.GetDicomMprToolAssociatedWithImageViewer(FocusedViewer);
            }
        }

        #endregion



        #region Methods

        #region UI

        #region Main Form

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && fullScreenToolStripMenuItem.Checked)
                fullScreenToolStripMenuItem.Checked = false;

            base.OnKeyDown(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _isFormClosing = true;

            base.OnClosing(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            if (_visualizationController != null)
            {
                _visualizationController.Dispose();
                _visualizationController = null;
            }

            base.OnClosed(e);
        }

        #endregion


        #region 'File' menu

        /// <summary>
        /// Handles the Click event of openDICOMFilesFromFolderToolStripMenuItem object.
        /// </summary>
        private void openDICOMFilesFromFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                // get the folder path
                string folderPath = folderBrowserDialog1.SelectedPath;

                CloseDicomSeries();

                dicomSeriesManagerControl1.AddDirectory(folderPath, true);
            }
        }

        /// <summary>
        /// Handles the Click event of openDICOMFilesToolStripMenuItem object.
        /// </summary>
        private void openDICOMFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDicomFiles();
        }

        /// <summary>
        /// Handles the OpenFile event of imageViewerToolStrip1 object.
        /// </summary>
        private void imageViewerToolStrip1_OpenFile(object sender, EventArgs e)
        {
            OpenDicomFiles();
        }

        /// <summary>
        /// Handles the Click event of closeDICOMSeriesToolStripMenuItem object.
        /// </summary>
        private void closeDICOMSeriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // close the previously opened DICOM files
            CloseDicomSeries();
        }

        /// <summary>
        /// Handles the Click event of saveImageToolStripMenuItem object.
        /// </summary>
        private void saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get image of focused image viewer
            using (VintasoftImage image = FocusedViewer.RenderViewerImage())
            {
                // save image to a file
                SaveImageFileForm.SaveImageToFile(image, ImagingEncoderFactory.Default);
            }
        }

        /// <summary>
        /// Handles the Click event of saveAllImagesToolStripMenuItem object.
        /// </summary>
        private void saveAllImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a temporary image collection
            using (ImageCollection images = new ImageCollection())
            {
                // get image of the first viewer and add it to the temporary image collection
                images.Add(imageViewer1.RenderViewerImage());
                // get image of the second viewer and add it to the temporary image collection
                images.Add(imageViewer2.RenderViewerImage());
                // get image of the third viewer and add it to the temporary image collection
                images.Add(imageViewer3.RenderViewerImage());

                // save images to a file
                SaveImageFileForm.SaveImagesToFile(images, ImagingEncoderFactory.Default);

                // clear and dispose images in the temporary image collection
                images.ClearAndDisposeItems();
            }
        }

        /// <summary>
        /// Handles the Click event of copyImageToClipboardToolStripMenuItem object.
        /// </summary>
        private void copyImageToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get image of focused image viewer
            using (VintasoftImage image = FocusedViewer.RenderViewerImage())
            {
                // copy image to the clipboard
                CopyToClipboard(image);
            }
        }

        /// <summary>
        /// Handles the Click event of saveImageSliceToolStripMenuItem object.
        /// </summary>
        private void saveImageSliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the DICOM MPR tool, which is associated with focused image viewer
            DicomMprTool dicomMprTool =
                _visualizationController.GetDicomMprToolAssociatedWithImageViewer(FocusedViewer);

            // get the image slice from DICOM MPR tool
            using (VintasoftImage image = dicomMprTool.DicomViewerTool.GetDisplayedImage())
            {
                // save image to a file
                SaveImageFileForm.SaveImageToFile(image, ImagingEncoderFactory.Default);
            }
        }

        /// <summary>
        /// Handles the Click event of saveAllImagesSlicesToolStripMenuItem object.
        /// </summary>
        private void saveAllImagesSlicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a temporary image collection
            using (ImageCollection images = new ImageCollection())
            {
                // for each DICOM MPR tool
                foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                {
                    // get the slice image from DICOM MPR tool
                    VintasoftImage sliceImage = dicomMprTool.DicomViewerTool.GetDisplayedImage();
                    // add the slice image to the temporary image collection
                    images.Add(sliceImage);
                }

                // save images to a file
                SaveImageFileForm.SaveImagesToFile(images, ImagingEncoderFactory.Default);

                // clear and dispose images in the temporary image collection
                images.ClearAndDisposeItems();
            }
        }

        /// <summary>
        /// Handles the Click event of copyImageSliceToClipboardToolStripMenuItem object.
        /// </summary>
        private void copyImageSliceToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the DICOM MPR tool, which is associated with focused image viewer
            DicomMprTool dicomMprTool =
                _visualizationController.GetDicomMprToolAssociatedWithImageViewer(FocusedViewer);

            // get the image slice from DICOM MPR tool
            using (VintasoftImage image = dicomMprTool.DicomViewerTool.GetDisplayedImage())
            {
                // copy image to the clipboard
                CopyToClipboard(image);
            }
        }

        /// <summary>
        /// Handles the Click event of exitToolStripMenuItem object.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Handles the Click event of resetSceneToolStripMenuItem object.
        /// </summary>
        private void resetSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _slices.Length; i++)
                _defaultSlices[i].CopyTo(_slices[i]);

            FitScene();
        }

        /// <summary>
        /// Handles the Click event of fitSceneToolStripMenuItem object.
        /// </summary>
        private void fitSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FitScene();
        }

        /// <summary>
        /// Handles the Click event of synchronizeWindowLevelToolStripMenuItem object.
        /// </summary>
        private void synchronizeWindowLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synchronizeWindowLevelToolStripMenuItem.Checked ^= true;

            // if VOI LUT must be synchronized
            if (synchronizeWindowLevelToolStripMenuItem.Checked)
            {
                // get the current DicomMprTool
                DicomMprTool focusedViewerMprTool =
                    _visualizationController.GetDicomMprToolAssociatedWithImageViewer(FocusedViewer);
                // get the VOI LUT of focused DICOM image
                DicomImageVoiLookupTable focusedImageVoiLutTable = focusedViewerMprTool.DicomViewerTool.DicomImageVoiLut;

                foreach (DicomMprTool tool in _dicomMprTools)
                {
                    // if visual tool must be skipped
                    if (tool == focusedViewerMprTool)
                        continue;

                    tool.DicomViewerTool.DicomImageVoiLut = focusedImageVoiLutTable;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of negativeImageToolStripMenuItem object.
        /// </summary>
        private void negativeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            negativeImageToolStripMenuItem.Checked ^= true;

            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                dicomMprTool.DicomViewerTool.IsImageNegative = negativeImageToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the Click event of resetToDefaultWindowLevelToolStripMenuItem object.
        /// </summary>
        private void resetToDefaultWindowLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DicomImageVoiLookupTable defaultVoiLut = _dicomMprTools[0].DicomViewerTool.DefaultDicomImageVoiLut;

            UpdateDicomImageVoiLookupTable(defaultVoiLut);
        }

        /// <summary>
        /// Handles the Click event of useInterpolationToolStripMenuItem object.
        /// </summary>
        private void useInterpolationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get focused viewer DICOM tool
            DicomMprTool focusedViewerMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(FocusedViewer);
            // indicates whether interpolation is enabled
            bool isInterpolationEnabled = useInterpolationToolStripMenuItem.Checked;

            // if interpolation is enabled
            if (isInterpolationEnabled)
            {
                // disable interpolation
                focusedViewerMprTool.MprImageTool.RenderingInterpolationMode = MprInterpolationMode.NearestNeighbor;
            }
            // if interpolation is disabled
            else
            {
                // enable interpolation
                focusedViewerMprTool.MprImageTool.RenderingInterpolationMode = MprInterpolationMode.Linear;
            }

            useInterpolationToolStripMenuItem.Checked = !isInterpolationEnabled;
        }

        /// <summary>
        /// Handles the Click event of showAxisToolStripMenuItem object.
        /// </summary>
        private void showAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showAxisToolStripMenuItem.Checked ^= true;
            bool value = showAxisToolStripMenuItem.Checked;

            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                dicomMprTool.MprImageTool.AreAxesVisible = value;
        }

        /// <summary>
        /// Handles the Click event of show3DAxisToolStripMenuItem object.
        /// </summary>
        private void show3DAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            show3DAxisToolStripMenuItem.Checked ^= true;

            Set3DAxisVisibility(show3DAxisToolStripMenuItem.Checked);
        }

        /// <summary>
        /// Handles the Click event of showRulersInViewerToolStripMenuItem object.
        /// </summary>
        private void showRulersInViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showRulersInViewerToolStripMenuItem.Checked ^= true;

            SetRulersVisibility(showRulersInViewerToolStripMenuItem.Checked);
        }

        /// <summary>
        /// Handles the Click event of rulersColorToolStripMenuItem object.
        /// </summary>
        private void rulersColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // init dialog

            Color? color = null;
            foreach (DicomMprTool mprTool in _dicomMprTools)
            {
                foreach (GraphicObject graphicalOverlay in mprTool.DicomViewerTool.GraphicalOverlay)
                {
                    if (graphicalOverlay is ImageRulerGraphicObject)
                    {
                        ImageRulerGraphicObject ruler = (ImageRulerGraphicObject)graphicalOverlay;

                        color = ruler.RulerPen.Color;
                        break;
                    }
                }

                if (color != null)
                    break;
            }
            colorDialog1.Color = color.Value;


            // show dialog
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // update rulers

                foreach (DicomMprTool mprTool in _dicomMprTools)
                {
                    foreach (GraphicObject graphicalOverlay in mprTool.DicomViewerTool.GraphicalOverlay)
                    {
                        if (graphicalOverlay is ImageRulerGraphicObject)
                        {
                            ImageRulerGraphicObject ruler = (ImageRulerGraphicObject)graphicalOverlay;

                            ruler.RulerPen.Color = colorDialog1.Color;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Handles the Click event of showMPRParametersToolStripMenuItem object.
        /// </summary>
        private void showMPRParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!showMPRParametersToolStripMenuItem.Checked)
            {
                // if MPR parameters form is not created
                if (_mprParametersForm == null)
                    CreateDicomMprParametersViewerForm();
                // show form
                _mprParametersForm.Show();
                showMPRParametersToolStripMenuItem.Checked = true;

                // disable all MPR image tools
                foreach (DicomMprTool tool in _dicomMprTools)
                    tool.MprImageTool.Enabled = false;
            }
            else
            {
                // if MPR parameters form is created
                if (_mprParametersForm != null)
                {
                    // close the MPR parameters form
                    _mprParametersForm.Close();
                }
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of fullScreenToolStripMenuItem object.
        /// </summary>
        private void fullScreenToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFormFullScreenMode(fullScreenToolStripMenuItem.Checked);
        }

        /// <summary>
        /// Handles the CheckedChanged event of topPanelAlwaysVisibleToolStripMenuItem object.
        /// </summary>
        private void topPanelAlwaysVisibleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (fullScreenToolStripMenuItem.Checked)
            {
                if (topPanelAlwaysVisibleToolStripMenuItem.Checked)
                {
                    topPanel.Visible = true;
                }
                else
                {
                    topPanel.Visible = false;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of textOverlaySettingsToolStripMenuItem object.
        /// </summary>
        private void textOverlaySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DicomOverlaySettingEditorForm dialog = new DicomOverlaySettingEditorForm(Text, _dicomMprTools[0]))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                // show dialog
                dialog.ShowDialog(this);

                DicomOverlaySettingEditorForm.SetTextOverlay(Text, _dicomMprTools[0]);
                DicomOverlaySettingEditorForm.SetTextOverlay(Text, _dicomMprTools[1]);
                DicomOverlaySettingEditorForm.SetTextOverlay(Text, _dicomMprTools[2]);
            }
        }

        /// <summary>
        /// Handles the Click event of showTextOverlayToolStripMenuItem object.
        /// </summary>
        private void showTextOverlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showTextOverlayToolStripMenuItem.Checked ^= true;
            bool value = showTextOverlayToolStripMenuItem.Checked;

            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                dicomMprTool.IsTextOverlayVisible = value;
        }

        /// <summary>
        /// Handles the Click event of settingsToolStripMenuItem object.
        /// </summary>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SliceType selectedSliceType;

            if (imageViewer1.Focused)
                selectedSliceType = SliceType.Sagittal;
            else if (imageViewer2.Focused)
                selectedSliceType = SliceType.Coronal;
            else
                selectedSliceType = SliceType.Axial;

            using (MprImageToolAppearanceSettingsForm dialog = new MprImageToolAppearanceSettingsForm(
                _mprSettingsManager, selectedSliceType,
                SliceType.Sagittal, SliceType.Coronal, SliceType.Axial))
            {
                dialog.Owner = this;
                dialog.ShowDialog();
            }
            UpdateDicomMprSettings();
        }

        #endregion


        #region 'MPR' menu

        /// <summary>
        /// Handles the Click event of sagittalToolStripMenuItem object.
        /// </summary>
        private void sagittalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateSagittalSlice(mprImage.XLength / 2.0);

            // show the slice
            ShowMprForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of coronalToolStripMenuItem object.
        /// </summary>
        private void coronalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateCoronalSlice(mprImage.YLength / 2.0);

            // show the slice
            ShowMprForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of axialToolStripMenuItem object.
        /// </summary>
        private void axialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateAxialSlice(mprImage.ZLength / 2.0);

            // show the slice
            ShowMprForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of multiSliceOnSagittalToolStripMenuItem object.
        /// </summary>
        private void multiSliceOnSagittalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateSagittalSlice(mprImage.XLength / 2.0);

            // show the slice
            ShowMprMultiSliceForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of multiSliceOnCoronalToolStripMenuItem object.
        /// </summary>
        private void multiSliceOnCoronalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateCoronalSlice(mprImage.YLength / 2.0);

            // show the slice
            ShowMprMultiSliceForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of multiSliceOnAxialToolStripMenuItem object.
        /// </summary>
        private void multiSliceOnAxialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateAxialSlice(mprImage.ZLength / 2.0);

            // show the slice
            ShowMprMultiSliceForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of curvilinearSliceOnSagittalToolStripMenuItem object.
        /// </summary>
        private void curvilinearSliceOnSagittalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateSagittalSlice(mprImage.XLength / 2.0);

            // show the slice
            ShowMprCurvilinearSliceForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of curvilinearSliceOnCoronalToolStripMenuItem object.
        /// </summary>
        private void curvilinearSliceOnCoronalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateCoronalSlice(mprImage.YLength / 2.0);

            // show the slice
            ShowMprCurvilinearSliceForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of curvilinearSliceOnAxialToolStripMenuItem object.
        /// </summary>
        private void curvilinearSliceOnAxialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MprImage mprImage = _mprSourceDataController.MprImage;
            // create the planar slice
            MprPlanarSlice planarSlice = mprImage.CreateAxialSlice(mprImage.ZLength / 2.0);

            // show the slice
            ShowMprCurvilinearSliceForm(planarSlice);
        }

        /// <summary>
        /// Handles the Click event of mprImagePropertiesToolStripMenuItem object.
        /// </summary>
        private void mprImagePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (PropertyGridForm dlg = new PropertyGridForm(_mprSourceDataController.MprImage, "MPR Image"))
            {
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Click event of perpendicularMultiSliceDefaultSettingsToolStripMenuItem object.
        /// </summary>
        private void perpendicularMultiSliceDefaultSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MprPerpendicularMultiSliceDefaultSettingsForm dlg =
                new MprPerpendicularMultiSliceDefaultSettingsForm())
            {
                dlg.Owner = this;
                dlg.ShowDialog();

                _mprSettingsManager.PerpendicularMultiSliceAppearance.SliceCount = MprPerpendicularMultiSlice.DefaultSliceCount;
            }
        }

        /// <summary>
        /// Handles the FormClosing event of DicomMprParametersForm object.
        /// </summary>
        private void DicomMprParametersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mprParametersForm.FormClosing -= DicomMprParametersForm_FormClosing;
            _mprParametersForm = null;
            showMPRParametersToolStripMenuItem.Checked = false;

            foreach (DicomMprTool tool in _dicomMprTools)
                tool.MprImageTool.Enabled = true;
        }

        /// <summary>
        /// Handles the DicomImageVoiLutChanged event of DicomViewerTool object.
        /// </summary>
        private void DicomViewerTool_DicomImageVoiLutChanged(object sender, VoiLutChangedEventArgs e)
        {
            // if VOI LUT can not be synchronized
            if (!synchronizeWindowLevelToolStripMenuItem.Checked)
                return;

            // if VOI LUT is changing
            if (_isImageVoiLutChanging)
                return;

            _isImageVoiLutChanging = true;
            foreach (DicomMprTool mprTool in _dicomMprTools)
            {
                if (sender != mprTool)
                {
                    // update VOI LUT
                    mprTool.DicomViewerTool.DicomImageVoiLut =
                        new DicomImageVoiLookupTable(e.WindowCenter, e.WindowWidth);
                }
            }
            _isImageVoiLutChanging = false;
        }

        /// <summary>
        /// Handles the MouseDown event of dicomMprTool object.
        /// </summary>
        private void dicomMprTool_MouseDown(object sender, VisualToolMouseEventArgs e)
        {
            ImageViewer viewer = ((VisualTool)sender).ImageViewer;
            // if image viewer is focused AND
            // mouse left button is clicked AND
            // MPR parameters form is not null
            if (viewer.Focused && e.Button == MouseButtons.Left && _mprParametersForm != null)
            {
                UpdateDicomMprParametersForm(viewer, e.X, e.Y);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the MouseMove event of dicomMprTool object.
        /// </summary>
        private void dicomMprTool_MouseMove(object sender, VisualToolMouseEventArgs e)
        {
            ImageViewer viewer = ((VisualTool)sender).ImageViewer;
            // if image viewer is focused AND
            // mouse left button is clicked AND
            // MPR parameters form is not null
            if (viewer.Focused && e.Button == MouseButtons.Left && _mprParametersForm != null)
            {
                UpdateDicomMprParametersForm(viewer, e.X, e.Y);
                e.Handled = true;
            }
        }

        #endregion


        #region 'Help' menu

        /// <summary>
        /// Handles the Click event of aboutToolStripMenuItem object.
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (AboutBoxForm dlg = new AboutBoxForm())
            {
                dlg.ShowDialog();
            }
        }

        #endregion


        /// <summary>
        /// Handles the GotFocus event of ImageViewer object.
        /// </summary>
        private void ImageViewer_GotFocus(object sender, EventArgs e)
        {
            ImageViewer viewer = (ImageViewer)sender;

            if (viewer != imageViewerToolStrip1.ImageViewer)
                imageViewerToolStrip1.ImageViewer = (ImageViewer)sender;
        }

        /// <summary>
        /// Handles the AddedFileCountChanged event of DicomSeriesManagerControl1 object.
        /// </summary>
        private void DicomSeriesManagerControl1_AddedFileCountChanged(object sender, EventArgs e)
        {
            DicomSeriesManagerControl control = (DicomSeriesManagerControl)sender;

            // if DICOM files loaded
            if (control.AddedFileCount == control.AddingFileCount)
            {
                // hide action label and progress bar
                progressBar1.Visible = false;
                progressBar1.Maximum = 0;

                if (!_isFormClosing)
                {
                    // update the UI
                    IsDicomSeriesOpening = false;

                    if (control.FocusedSeriesIdentifier == null)
                    {
                        IList<string> seriesIdentifiers = control.SeriesManager.GetAllSeriesIdentifiers();
                        if (seriesIdentifiers.Count > 0)
                            control.FocusedSeriesIdentifier = seriesIdentifiers[0];
                    }

                    InitializeMprCube(control.FocusedSeriesIdentifier);
                }
            }
            else
            {
                // if DICOM files loading started
                if (control.AddingFileCount != progressBar1.Maximum)
                {
                    progressBar1.Visible = true;
                    progressBar1.Maximum = control.AddingFileCount;
                    // update the UI
                    IsDicomSeriesOpening = true;
                }

                progressBar1.Value = control.AddedFileCount;
            }
        }

        /// <summary>
        /// Handles the FocusedSeriesIdentifierChanged event of DicomSeriesManagerControl1 object.
        /// </summary>
        private void DicomSeriesManagerControl1_FocusedSeriesIdentifierChanged(object sender, EventArgs e)
        {
            DicomSeriesManagerControl control = (DicomSeriesManagerControl)sender;

            // if DICOM files loaded
            if (control.AddedFileCount == control.AddingFileCount)
                InitializeMprCube(control.FocusedSeriesIdentifier);
        }

        #endregion


        #region UI state

        /// <summary>
        /// Updates UI safely.
        /// </summary>
        private void InvokeUpdateUI()
        {
            if (InvokeRequired)
                Invoke(new UpdateUIDelegate(UpdateUI));
            else
                UpdateUI();
        }

        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            // if application is closing
            if (_isFormClosing)
                // exit
                return;

            bool isDicomSeriesLoaded = dicomSeriesManagerControl1.Images.Count > 0;
            bool isDicomSeriesOpening = _isDicomSeriesOpening;

            bool isMprCubeInitialized = _isMprCubeInitialized && _visualizationController != null;

            // 'File' menu
            //
            openDICOMFilesToolStripMenuItem.Enabled = !isDicomSeriesOpening;
            openDICOMFilesFromFolderToolStripMenuItem.Enabled = !isDicomSeriesOpening;
            saveImageToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            saveAllImagesToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            copyImageToClipboardToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            saveImageSliceToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            saveAllImagesSlicesToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            copyImageSliceToClipboardToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            closeDICOMSeriesToolStripMenuItem.Enabled = isDicomSeriesLoaded;

            // 'View' menu
            //
            resetSceneToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            fitSceneToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            synchronizeWindowLevelToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            negativeImageToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            resetToDefaultWindowLevelToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            useInterpolationToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            showAxisToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            show3DAxisToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            showRulersInViewerToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            rulersColorToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            rulersUnitOfMeasureToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            showMPRParametersToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            fullScreenToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            topPanelAlwaysVisibleToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            textOverlaySettingsToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            showTextOverlayToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            settingsToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            // 'MPR' menu
            //
            sagittalToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            coronalToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            axialToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            multiSliceOnSagittalToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            multiSliceOnCoronalToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            multiSliceOnAxialToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            curvilinearSliceOnSagittalToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            curvilinearSliceOnCoronalToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
            curvilinearSliceOnAxialToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            mprImagePropertiesToolStripMenuItem.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;

            dicomMprToolInteractionModeToolStrip1.Enabled = isMprCubeInitialized && !isDicomSeriesOpening;
        }

        #endregion


        #region 'File' menu

        /// <summary>
        /// Opens the DICOM files.
        /// </summary>
        private void OpenDicomFiles()
        {
            openDicomFileDialog.Multiselect = true;
            if (openDicomFileDialog.ShowDialog() == DialogResult.OK)
            {
                // close the previously opened DICOM files
                CloseDicomSeries();

                // add DICOM files to the DICOM series
                dicomSeriesManagerControl1.AddFiles(openDicomFileDialog.FileNames);
            }
        }

        /// <summary>
        /// Closes series of DICOM frames.
        /// </summary>
        private void CloseDicomSeries()
        {
            CloseMprCube();

            dicomSeriesManagerControl1.CloseAllSeries();

            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Initializes the MPR cube.
        /// </summary>
        /// <param name="seriesIdentifier">The series identifier.</param>
        private void InitializeMprCube(string seriesIdentifier)
        {
            CloseMprCube();

            if (string.IsNullOrEmpty(seriesIdentifier))
                return;

            VintasoftImage[] images = dicomSeriesManagerControl1.SeriesManager.GetSeriesImages(seriesIdentifier);
            // get DICOM files, which represent DICOM frames for MPR cube
            DicomFile[] dicomFiles = DicomFile.GetFilesAssociatedWithImages(images);

            if (dicomFiles.Length > 0)
            {
                // update source data of MPR image
                _mprSourceDataController.SetSourceMprData(dicomFiles);

                if (InitializeVisualizationController(images))
                {
                    _isMprCubeInitialized = true;

                    // update the UI
                    UpdateUI();
                }
                else
                {
                    CloseMprCube();
                }
            }
        }

        /// <summary>
        /// Closes the MPR cube.
        /// </summary>
        private void CloseMprCube()
        {
            _isMprCubeInitialized = false;

            lock (_mprSourceDataController)
            {
                dicomMprToolInteractionModeToolStrip1.DicomMprTools = null;

                if (_visualizationController != null)
                    _visualizationController.Dispose();

                _mprSourceDataController.ClearSourceMprData();
            }

            // update the UI
            UpdateUI();
        }

        /// <summary>
        /// Initializes the visualization controller.
        /// </summary>
        /// <param name="images">The images.</param>
        private bool InitializeVisualizationController(VintasoftImage[] images)
        {
            lock (_mprSourceDataController)
            {
                DicomFrame dicomFrame = DicomFrame.GetFrameAssociatedWithImage(images[0]);

                // create the MPR image
                if (!_mprSourceDataController.SetMprData(dicomFrame, true))
                    return false;

                MprVisualizationController oldVisualizationController = _visualizationController;
                // create visualization controller
                _visualizationController = new MprVisualizationController(
                    _mprSourceDataController.MprImage,
                    imageViewer1, imageViewer2, imageViewer3);

                _mprSettingsManager.SetMprVisualizationControllerSettings(_visualizationController);

                // get DICOM MPR tools of image viewers
                _dicomMprTools = new DicomMprTool[] {
                _visualizationController.GetDicomMprToolAssociatedWithImageViewer(imageViewer1),
                _visualizationController.GetDicomMprToolAssociatedWithImageViewer(imageViewer2),
                _visualizationController.GetDicomMprToolAssociatedWithImageViewer(imageViewer3)
                };
                // set main DICOM MPR tool
                dicomMprToolInteractionModeToolStrip1.DicomMprTools = _dicomMprTools;

                // create slices
                _slices = _visualizationController.AddThreeSlicesVisualization(
                    _mprSourceDataController.MprImage.XLength / 2.0, _mprSettingsManager.SagittalSliceAppearance.SliceColor,
                    _mprSourceDataController.MprImage.YLength / 2.0, _mprSettingsManager.CoronalSliceAppearance.SliceColor,
                    _mprSourceDataController.MprImage.ZLength / 2.0, _mprSettingsManager.AxialSliceAppearance.SliceColor);

                // apply the appearance settings to the slices
                _mprSettingsManager.SetSliceSettings(
                    _visualizationController.GetVisualMprSliceAssociatedWithMprSlice(_slices[0]),
                    _visualizationController.GetVisualMprSliceAssociatedWithMprSlice(_slices[1]),
                    _visualizationController.GetVisualMprSliceAssociatedWithMprSlice(_slices[2]));

                // save the default values of slices
                _defaultSlices = new MprSlice[_slices.Length];
                for (int i = 0; i < _slices.Length; i++)
                    _defaultSlices[i] = _slices[i].CreateCopy();

                // apply appearance settings to the visual tools
                _mprSettingsManager.SetMprToolSettings(_dicomMprTools[0].MprImageTool);
                _mprSettingsManager.SetMprToolSettings(_dicomMprTools[1].MprImageTool);
                _mprSettingsManager.SetMprToolSettings(_dicomMprTools[2].MprImageTool);

                // for each DICOM MPR tool
                foreach (DicomMprTool mprTool in _dicomMprTools)
                {
                    mprTool.DicomViewerTool.DicomImageVoiLutChanged += new EventHandler<VoiLutChangedEventArgs>(DicomViewerTool_DicomImageVoiLutChanged);
                    mprTool.MouseMove += new VisualToolMouseEventHandler(dicomMprTool_MouseMove);
                    mprTool.MouseDown += new VisualToolMouseEventHandler(dicomMprTool_MouseDown);

                    DicomMprFillDataProgressTextOverlay loadingProgressOverlay = new DicomMprFillDataProgressTextOverlay();
                    mprTool.TextOverlay.Add(loadingProgressOverlay);
                }

                // shows the slices on viewers
                _visualizationController.ShowSliceInViewer(imageViewer1, _slices[0]);
                _visualizationController.ShowSliceInViewer(imageViewer2, _slices[1]);
                _visualizationController.ShowSliceInViewer(imageViewer3, _slices[2]);

                if (oldVisualizationController != null)
                {
                    useInterpolationToolStripMenuItem.Checked = true;

                    oldVisualizationController.SetProperties(_visualizationController);

                    foreach (DicomMprTool mprTool in _dicomMprTools)
                    {
                        mprTool.DicomViewerTool.IsGraphicalOverlayVisible = true;

                        foreach (GraphicObject overlay in mprTool.DicomViewerTool.GraphicalOverlay)
                        {
                            if (overlay is ImageRulerGraphicObject)
                            {
                                ImageRulerGraphicObject ruler = (ImageRulerGraphicObject)overlay;
                                ruler.Padding = 20;
                            }
                        }

                        mprTool.DicomViewerTool.GraphicalOverlay.Add(new MprImage3DAxisGraphicObject(_visualizationController));
                        mprTool.TextOverlay.Insert(0, new MprImagePointLuminanceTextOverlay(AnchorType.BottomLeft));
                    }

                    InitUnitOfMeasuresForRulers();

                    Set3DAxisVisibility(show3DAxisToolStripMenuItem.Checked);
                    SetRulersVisibility(showRulersInViewerToolStripMenuItem.Checked);

                    oldVisualizationController.Dispose();
                }

                imageViewer1.Focus();

                return true;
            }
        }

        /// <summary>
        /// Updates values of <see cref="MprParametersViewerForm"/>.
        /// </summary>
        /// <param name="viewer">The focused image viewer.</param>
        /// <param name="mouseLocationX">The mouse X coordinate.</param>
        /// <param name="mouseLocationY">The mouse Y coordinate.</param>
        private void UpdateDicomMprParametersForm(ImageViewer viewer, int mouseLocationX, int mouseLocationY)
        {
            // get location on image
            int xCoordinate = mouseLocationX - viewer.Location.X;
            int yCoordinate = mouseLocationY - viewer.Location.Y;
            AffineMatrix transformFromControlToImage = FocusedViewer.GetTransformFromControlToImage();
            PointF locationOnImage = PointFAffineTransform.TransformPoint(transformFromControlToImage, new PointF(xCoordinate, yCoordinate));

            // get focused viewer visual tool
            DicomMprTool dicomMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(viewer);
            // get transform from image to slice
            PointFTransform transformFormImageToSlice = dicomMprTool.MprImageTool.FocusedSliceView.GetPointTransform(viewer, viewer.Image);
            transformFormImageToSlice = transformFormImageToSlice.GetInverseTransform();

            // update values
            _mprParametersForm.LocationOnImage = new Point((int)locationOnImage.X, (int)locationOnImage.Y);
            _mprParametersForm.TransformFromImageToSlice = transformFormImageToSlice;
            _mprParametersForm.DisplayedImage = dicomMprTool.DicomViewerTool.DisplayedImage;
            _mprParametersForm.MprImage = dicomMprTool.MprImageTool.MprImage;
            _mprParametersForm.Slice = dicomMprTool.MprImageTool.FocusedSlice;
            _mprParametersForm.UpdateValues();
        }

        /// <summary>
        /// Copies the specified image to the clipboard.
        /// </summary>
        /// <param name="image">The image.</param>
        private void CopyToClipboard(VintasoftImage image)
        {
            try
            {
                // if image is Gray16 image
                if (image.PixelFormat == PixelFormat.Gray16)
                {
                    // convert image to Gray8 image

                    ChangePixelFormatToGrayscaleCommand command =
                        new ChangePixelFormatToGrayscaleCommand(PixelFormat.Gray8);
                    image = command.Execute(image);
                }

                // copy image to the clipboard
                Clipboard.SetImage(image.GetAsBitmap());
            }
            catch (Exception ex)
            {
                DemosTools.ShowErrorMessage(ex);
            }
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// Changes the visibility of 3D axis.
        /// </summary>
        /// <param name="visibility">The visibility of 3D axis.</param>
        private void Set3DAxisVisibility(bool visibility)
        {
            foreach (DicomMprTool mprTool in _dicomMprTools)
            {
                foreach (GraphicObject graphicalOverlay in mprTool.DicomViewerTool.GraphicalOverlay)
                {
                    if (graphicalOverlay is MprImage3DAxisGraphicObject)
                        graphicalOverlay.IsVisible = visibility;
                }
            }
        }

        /// <summary>
        /// Changes the visibility of rulers.
        /// </summary>
        /// <param name="visibility">The visibility of rulers.</param>
        private void SetRulersVisibility(bool visibility)
        {
            foreach (DicomMprTool mprTool in _dicomMprTools)
            {
                foreach (Vintasoft.Imaging.UI.VisualTools.GraphicObjects.GraphicObject graphicalOverlay in mprTool.DicomViewerTool.GraphicalOverlay)
                {
                    if (graphicalOverlay is ImageRulerGraphicObject)
                        graphicalOverlay.IsVisible = visibility;
                }
            }
        }

        /// <summary>
        /// Scales the slices proportion to the viewer.
        /// </summary>
        private void FitScene()
        {
            foreach (DicomMprTool mprTool in _dicomMprTools)
                mprTool.MprImageTool.FitScene();
        }

        /// <summary>
        /// Updates the VOI LUT in DicomViewerTools.
        /// </summary>
        /// <param name="voiLut">The VOI LUT.</param>
        private void UpdateDicomImageVoiLookupTable(DicomImageVoiLookupTable voiLut)
        {
            _isImageVoiLutChanging = true;
            foreach (DicomMprTool dicomMprTool in _dicomMprTools)
                dicomMprTool.DicomViewerTool.DicomImageVoiLut = voiLut;
            _isImageVoiLutChanging = false;
        }

        /// <summary>
        /// Creates the form for viewing parameters of DICOM 3D MPR (multiplanar reconstruction).
        /// </summary>
        private void CreateDicomMprParametersViewerForm()
        {
            DicomMprTool dicomMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(FocusedViewer);
            // get transform from image to slice
            PointFTransform transformFormImageToSlice = dicomMprTool.MprImageTool.FocusedSliceView.GetPointTransform(FocusedViewer, FocusedViewer.Image);
            transformFormImageToSlice = transformFormImageToSlice.GetInverseTransform();

            // create form
            _mprParametersForm = new MprParametersViewerForm(
                new Point(0, 0),
                transformFormImageToSlice,
                dicomMprTool.DicomViewerTool.DisplayedImage,
                dicomMprTool.MprImageTool.MprImage,
                dicomMprTool.MprImageTool.FocusedSlice);
            _mprParametersForm.Owner = this;
            _mprParametersForm.FormClosing += new FormClosingEventHandler(DicomMprParametersForm_FormClosing);
        }

        /// <summary>
        /// Changes the window full screen mode.
        /// </summary>
        /// <param name="fullScreenMode">Determines whether full screen mode is on.</param>
        private void ChangeFormFullScreenMode(bool fullScreenMode)
        {
            if (fullScreenMode)
            {
                // if the top panel must be hidden
                if (!topPanelAlwaysVisibleToolStripMenuItem.Checked)
                {
                    topPanel.Visible = false;
                }

                // update the form settings
                TopMost = true;
                _previousWindowState = WindowState;
                FormBorderStyle = FormBorderStyle.None;
                if (WindowState == FormWindowState.Maximized)
                    WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
                statusStrip1.Visible = false;
            }
            else
            {
                // show the top panel
                topPanel.Visible = true;

                // update the form settings
                TopMost = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                if (WindowState != _previousWindowState)
                    WindowState = _previousWindowState;
                statusStrip1.Visible = true;
            }
        }

        /// <summary>
        /// Updates DICOM MPR settings.
        /// </summary>
        private void UpdateDicomMprSettings()
        {
            // update MPR Image
            _mprSettingsManager.SetMprImageSettings(_visualizationController.MprImage);
            // update controller
            _mprSettingsManager.SetMprVisualizationControllerSettings(_visualizationController);
            // update slices
            _mprSettingsManager.SetSliceSettings(
                _visualizationController.GetVisualMprSliceAssociatedWithMprSlice(_slices[0]),
                _visualizationController.GetVisualMprSliceAssociatedWithMprSlice(_slices[1]),
                _visualizationController.GetVisualMprSliceAssociatedWithMprSlice(_slices[2]));
            // update default slices
            _defaultSlices[0].Thickness = _slices[0].Thickness;
            _defaultSlices[1].Thickness = _slices[1].Thickness;
            _defaultSlices[2].Thickness = _slices[2].Thickness;
            _defaultSlices[0].RenderingMode = _slices[0].RenderingMode;
            _defaultSlices[1].RenderingMode = _slices[1].RenderingMode;
            _defaultSlices[2].RenderingMode = _slices[2].RenderingMode;
            // update MPR tools
            _mprSettingsManager.SetMprToolSettings(_dicomMprTools[0].MprImageTool);
            _mprSettingsManager.SetMprToolSettings(_dicomMprTools[1].MprImageTool);
            _mprSettingsManager.SetMprToolSettings(_dicomMprTools[2].MprImageTool);
        }

        #endregion


        #region 'MPR' menu

        /// <summary>
        /// Shows the MPR planar slice.
        /// </summary>
        /// <param name="planarSlice">The planar slice.</param>
        private void ShowMprForm(MprPlanarSlice planarSlice)
        {
            // get VOI LUT of current frame
            DicomImageVoiLookupTable voiLut = FocusedViewerDicomMprTool.DicomViewerTool.DicomImageVoiLut;
            bool isNegative = FocusedViewerDicomMprTool.DicomViewerTool.IsImageNegative;

            // create dialog
            using (Mpr2DForm dlg = new Mpr2DForm(
                _mprSourceDataController.MprImage,
                planarSlice,
                voiLut,
                isNegative,
                _mprSettingsManager))
            {
                // set start position on dialog
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.Owner = this;

                // show dialog
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// Shows the MPR multi slice.
        /// </summary>
        /// <param name="planarSlice">The planar slice.</param>
        private void ShowMprMultiSliceForm(MprPlanarSlice planarSlice)
        {
            // get VOI LUT of current frame
            DicomImageVoiLookupTable voiLut = FocusedViewerDicomMprTool.DicomViewerTool.DicomImageVoiLut;
            bool isNegative = FocusedViewerDicomMprTool.DicomViewerTool.IsImageNegative;

            // create dialog
            using (MprPerpendicularMultiSliceForm dlg = new MprPerpendicularMultiSliceForm(
                _mprSourceDataController.MprImage,
                planarSlice,
                voiLut,
                isNegative,
                _mprSettingsManager))
            {
                // set start position on dialog
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.Owner = this;

                // show dialog
                dlg.ShowDialog();
            }
        }

        /// <summary>
        /// Shows the MPR curvilinear slice.
        /// </summary>
        /// <param name="planarSlice">The planar slice.</param>
        private void ShowMprCurvilinearSliceForm(MprPlanarSlice planarSlice)
        {
            // get VOI LUT of current frame
            DicomImageVoiLookupTable voiLut = FocusedViewerDicomMprTool.DicomViewerTool.DicomImageVoiLut;
            bool isNegative = FocusedViewerDicomMprTool.DicomViewerTool.IsImageNegative;

            // create dialog
            using (MprCurvilinearSliceForm dlg = new MprCurvilinearSliceForm(
                _mprSourceDataController.MprImage,
                planarSlice,
                voiLut,
                isNegative,
                _mprSettingsManager))
            {
                dlg.Owner = this;

                dlg.ShowDialog();
            }
        }

        #endregion


        /// <summary>
        /// Moves the DICOM codec to the first position in <see cref="AvailableCodecs"/>.
        /// </summary>
        private static void MoveDicomCodecToFirstPosition()
        {
            ReadOnlyCollection<Codec> codecs = AvailableCodecs.Codecs;

            for (int i = codecs.Count - 1; i >= 0; i--)
            {
                Codec codec = codecs[i];

                if (codec.Name.Equals("DICOM", StringComparison.InvariantCultureIgnoreCase))
                {
                    AvailableCodecs.RemoveCodec(codec);
                    AvailableCodecs.InsertCodec(0, codec);
                    break;
                }
            }
        }

        /// <summary>
        /// Initializes the unit of measures for rulers.
        /// </summary>
        private void InitUnitOfMeasuresForRulers()
        {
            UnitOfMeasure[] unitsOfMeasure = new UnitOfMeasure[] {
                UnitOfMeasure.Centimeters,
                UnitOfMeasure.Inches,
                UnitOfMeasure.Millimeters,
                UnitOfMeasure.Pixels
            };

            rulersUnitOfMeasureToolStripMenuItem.DropDownItems.Clear();
            _toolStripMenuItemToRulersUnitOfMeasure.Clear();

            UnitOfMeasure? currentUnit = null;

            foreach (DicomMprTool mprTool in _dicomMprTools)
            {
                foreach (GraphicObject graphicalOverlay in mprTool.DicomViewerTool.GraphicalOverlay)
                {
                    if (graphicalOverlay is ImageRulerGraphicObject)
                    {
                        ImageRulerGraphicObject ruler = (ImageRulerGraphicObject)graphicalOverlay;

                        currentUnit = ruler.UnitOfMeasure;
                        break;
                    }
                }

                if (currentUnit != null)
                    break;
            }


            foreach (UnitOfMeasure unit in unitsOfMeasure)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(unit.ToString());
                _toolStripMenuItemToRulersUnitOfMeasure.Add(menuItem, unit);
                menuItem.Click += new EventHandler(rulersUnitOfMeasureToolStripMenuItem_Click);
                if (unit == currentUnit)
                {
                    menuItem.Checked = true;
                    _currentRulersUnitOfMeasureMenuItem = menuItem;
                }
                rulersUnitOfMeasureToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }

        /// <summary>
        /// Handles the Click event of rulersUnitOfMeasureToolStripMenuItem object.
        /// </summary>
        private void rulersUnitOfMeasureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _currentRulersUnitOfMeasureMenuItem.Checked = false;
            _currentRulersUnitOfMeasureMenuItem = (ToolStripMenuItem)sender;

            foreach (DicomMprTool mprTool in _dicomMprTools)
            {
                foreach (GraphicObject graphicalOverlay in mprTool.DicomViewerTool.GraphicalOverlay)
                {
                    if (graphicalOverlay is ImageRulerGraphicObject)
                    {
                        ImageRulerGraphicObject ruler = (ImageRulerGraphicObject)graphicalOverlay;

                        ruler.UnitOfMeasure = _toolStripMenuItemToRulersUnitOfMeasure[_currentRulersUnitOfMeasureMenuItem];
                    }
                }
            }

            _currentRulersUnitOfMeasureMenuItem.Checked = true;
        }

        #endregion



        #region Delegates

        /// <summary>
        /// Represents the <see cref="UpdateUI"/> method.
        /// </summary>
        delegate void UpdateUIDelegate();

        #endregion

    }
}
