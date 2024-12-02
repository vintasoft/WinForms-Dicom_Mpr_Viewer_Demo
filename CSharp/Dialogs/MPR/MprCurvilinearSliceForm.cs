using System;
using System.Drawing;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.ImageFiles.Dicom;
using Vintasoft.Imaging.Dicom.Mpr;
using Vintasoft.Imaging.Dicom.Mpr.UI;
using Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools;
using Vintasoft.Imaging.Dicom.UI.VisualTools;
using Vintasoft.Imaging.ImageProcessing;
using Vintasoft.Imaging.UI;
using Vintasoft.Imaging.UI.VisualTools;
using Vintasoft.Imaging.UI.VisualTools.UserInteraction;

using DemosCommonCode;
using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;


namespace DicomMprViewerDemo
{
    /// <summary>
    /// A form that allows to view a curvilinear slice, which is constructed from the sagittal, coronal or axial slice.
    /// </summary>
    public partial class MprCurvilinearSliceForm : Form
    {

        #region Constants

        /// <summary>
        /// The form title format.
        /// </summary>
        const string TITLE_DEFAULT_FORMAT = "Curvlinear Slice From {0}";

        /// <summary>
        /// The text overlay collection owner name.
        /// </summary>
        const string OVERLAY_OWNER_NAME = "Curvlinear Slice From";

        #endregion



        #region Fields

        /// <summary>
        /// The visualization controller for image viewers, which show planar slice and curvilinear slice.
        /// </summary>
        MprVisualizationController _visualizationController;

        /// <summary>
        /// The slice type.
        /// </summary>
        SliceType _sliceType;


        #region Planar slice

        /// <summary>
        /// The DicomMprTool for planar slice.
        /// </summary>
        DicomMprTool _planarSliceDicomMprTool;

        /// <summary>
        /// The current planar slice.
        /// </summary>
        MprPlanarSlice _currentPlanarSlice;

        /// <summary>
        /// The default state of planar slice.
        /// </summary>
        MprSlice _defaultPlanarSlice;

        #endregion


        #region Curvilinear slice

        /// <summary>
        /// The DicomMprTool for curvilinear slice.
        /// </summary>
        DicomMprTool _curvilinearSliceDicomMprTool;

        /// <summary>
        /// The current curvilinear slice.
        /// </summary>
        MprPolylineSlice _currentCurvilinearSlice;

        /// <summary>
        /// The default state of curvilinear slice.
        /// </summary>
        MprSlice _defaultCurvilinearSlice;

        #endregion


        /// <summary>
        /// The default VOI LUT for planar and curvilinear slices.
        /// </summary>
        DicomImageVoiLookupTable _defaultVoiLut;


        /// <summary>
        /// The MPR image tool appearance settings.
        /// </summary>
        MprImageToolAppearanceSettings _imageToolAppearanceSettings;


        /// <summary>
        /// A form with MPR parameters information.
        /// </summary>
        MprParametersViewerForm _mprParametersForm;


        /// <summary>
        /// A form state, which was used in non full screen mode.
        /// </summary>
        FormWindowState _nonFullScreenWindowState;

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MprCurvilinearSliceForm"/> class.
        /// </summary>
        /// <param name="mprImage">The MPR image.</param>
        /// <param name="currentPlanarSlice">The current planar slice.</param>
        /// <param name="voiLut">The default VOI LUT.</param>
        /// <param name="isNegativeImage">Indicates whether the image must be inverted.</param>
        /// <param name="imageToolAppearanceSettings">The MPR image tool appearance settings.</param>
        public MprCurvilinearSliceForm(
            MprImage mprImage,
            MprPlanarSlice currentPlanarSlice,
            DicomImageVoiLookupTable voiLut,
            bool isNegativeImage,
            MprImageToolAppearanceSettings imageToolAppearanceSettings)
        {
            InitializeComponent();

            _imageToolAppearanceSettings = imageToolAppearanceSettings;

            // create visualization controller
            _visualizationController = new MprVisualizationController(
                mprImage, planarSliceImageViewer, curvilinearSliceImageViewer);

            _imageToolAppearanceSettings.SetMprVisualizationControllerSettings(_visualizationController);

            // save current planar slice
            _currentPlanarSlice = currentPlanarSlice;
            _defaultPlanarSlice = currentPlanarSlice.CreateCopy();

            // save current VOI LUT
            _defaultVoiLut = voiLut;

            // create DicomMprTool
            CreatePlanarSliceDicomMprTool(isNegativeImage);
            CreateCurvilinearSliceDicomMprTool(isNegativeImage);

            dicomMprToolInteractionModeToolStrip1.DicomMprTools = new DicomMprTool[] {
                _planarSliceDicomMprTool, _curvilinearSliceDicomMprTool };
            view_negativeImageToolStripMenuItem.Checked = isNegativeImage;
            _planarSliceDicomMprTool.MprImageTool.AllowRotate3D = false;
            _planarSliceDicomMprTool.MprImageTool.ScrollProperties.Anchor = AnchorType.Left;

            // set appearance to DicomMprTool
            imageToolAppearanceSettings.SetMprToolSettings(_planarSliceDicomMprTool.MprImageTool);

            // add slice to the visualization controller
            MprSliceVisualizer visualMprPlanarSlice = _visualizationController.AddSliceVisualization(
                currentPlanarSlice, Color.Transparent);

            string sliceName = "Unknown";
            // if slice is sagittal
            if (MprPlanarSlice.IsSagittalSlice(currentPlanarSlice))
            {
                sliceName = "Sagittal";
                imageToolAppearanceSettings.SagittalSliceAppearance.SetSettings(visualMprPlanarSlice);
                _sliceType = SliceType.Sagittal;
            }
            // if slice is coronal
            else if (MprPlanarSlice.IsCoronalSlice(currentPlanarSlice))
            {
                sliceName = "Coronal";
                imageToolAppearanceSettings.CoronalSliceAppearance.SetSettings(visualMprPlanarSlice);
                _sliceType = SliceType.Coronal;
            }
            // if slice is axial
            else if (MprPlanarSlice.IsAxialSlice(currentPlanarSlice))
            {
                sliceName = "Axial";
                imageToolAppearanceSettings.AxialSliceAppearance.SetSettings(visualMprPlanarSlice);
                _sliceType = SliceType.Axial;
            }

            // update title of form
            Text = string.Format(TITLE_DEFAULT_FORMAT, sliceName);

            planarSliceImageViewer.GotFocus += new EventHandler(ImageViewer_GotFocus);
            curvilinearSliceImageViewer.GotFocus += new EventHandler(ImageViewer_GotFocus);
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets the focused viewer.
        /// </summary>
        /// <value>
        /// The focused viewer.
        /// </value>
        private ImageViewer FocusedViewer
        {
            get
            {
                if (planarSliceImageViewer.Focused)
                    return planarSliceImageViewer;

                if (curvilinearSliceImageViewer.Focused)
                    return curvilinearSliceImageViewer;

                return null;
            }
        }

        #endregion



        #region Methods

        #region 'File' menu

        /// <summary>
        /// Saves the image of focused image viewer.
        /// </summary>
        private void file_saveImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get image of focused image viewer
            using (VintasoftImage image = FocusedViewer.RenderViewerImage())
            {
                // save image to a file
                SaveImageFileForm.SaveImageToFile(image, ImagingEncoderFactory.Default);
            }
        }

        /// <summary>
        /// Saves the images of all image viewers.
        /// </summary>
        private void file_saveAllImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a temporary image collection
            using (ImageCollection images = new ImageCollection())
            {
                // get image of the first viewer to the temporary image collection
                images.Add(planarSliceImageViewer.RenderViewerImage());
                // get image of the second viewer to the temporary image collection
                images.Add(curvilinearSliceImageViewer.RenderViewerImage());

                // save images to a file
                SaveImageFileForm.SaveImagesToFile(images,
                    ImagingEncoderFactory.Default);

                // clear and dispose images in the temporary image collection
                images.ClearAndDisposeItems();
            }
        }

        /// <summary>
        /// Copies to the clipboard the image of focused image viewer.
        /// </summary>
        private void file_copyImageToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get image of focused image viewer
            using (VintasoftImage image = FocusedViewer.RenderViewerImage())
            {
                // copy image to the clipboard
                CopyToClipboard(image);
            }
        }

        /// <summary>
        /// Saves the image of the focused MPR slice.
        /// </summary>
        private void file_saveImageSliceToolStripMenuItem_Click(object sender, EventArgs e)
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
        /// Saves the images of all MPR slices.
        /// </summary>
        private void file_saveAllImagesSlicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create a temporary image collection
            using (ImageCollection images = new ImageCollection())
            {
                // get the slice image from DICOM MPR tool
                VintasoftImage planarSliceImage = _planarSliceDicomMprTool.DicomViewerTool.GetDisplayedImage();
                if (planarSliceImageViewer != null)
                    // add the slice image to the temporary image collection
                    images.Add(planarSliceImage);

                // get the slice image from DICOM MPR tool
                VintasoftImage curvilinearSliceImage = _curvilinearSliceDicomMprTool.DicomViewerTool.GetDisplayedImage();
                if (curvilinearSliceImage != null)
                    // add the slice image to the temporary image collection
                    images.Add(curvilinearSliceImage);

                // save images to a file
                SaveImageFileForm.SaveImagesToFile(images, ImagingEncoderFactory.Default);

                // clear and dispose images in the temporary image collection
                images.ClearAndDisposeItems();
            }
        }

        /// <summary>
        /// Copies to the clipboard the image of the focused MPR slice.
        /// </summary>
        private void file_copyImageSliceToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get the DICOM MPR tool, which is associated with focused image viewer
            DicomMprTool dicomMprTool =
                _visualizationController.GetDicomMprToolAssociatedWithImageViewer(FocusedViewer);

            if (dicomMprTool.MprImageTool.FocusedSlice == null)
                return;

            // get the image slice from DICOM MPR tool
            using (VintasoftImage image = dicomMprTool.DicomViewerTool.GetDisplayedImage())
            {
                // copy image to the clipboard
                CopyToClipboard(image);
            }
        }

        /// <summary>
        /// Closes the form.
        /// </summary>
        private void file_exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion


        #region 'View' menu

        /// <summary>
        /// "View" menu is opening.
        /// </summary>
        private void viewToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            // indicates whether interpolation is enabled
            bool isInterpolationEnabled = true;

            if (_planarSliceDicomMprTool.MprImageTool.RenderingInterpolationMode == MprInterpolationMode.NearestNeighbor)
                isInterpolationEnabled = false;
            else
                isInterpolationEnabled = true;

            view_useInterpolationToolStripMenuItem.Checked = isInterpolationEnabled;
        }


        /// <summary>
        /// Resets the slice location.
        /// </summary>
        private void view_resetSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_defaultPlanarSlice != null)
                _defaultPlanarSlice.CopyTo(_currentPlanarSlice);

            if (_defaultCurvilinearSlice != null)
                _defaultCurvilinearSlice.CopyTo(_currentCurvilinearSlice);

            FitScene();
        }

        /// <summary>
        /// Fits the slice on viewer.
        /// </summary>
        private void view_fitSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FitScene();
        }


        /// <summary>
        /// Synchronizes the VOI LUT of slice.
        /// </summary>
        private void view_synchronizeWindowLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (view_synchronizeWindowLevelToolStripMenuItem.Checked)
            {
                if (planarSliceImageViewer.Focused)
                {
                    _curvilinearSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut =
                        _planarSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut;
                }
                else
                {
                    _planarSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut =
                        _curvilinearSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut;
                }
            }
        }

        /// <summary>
        /// Inverts the image in viewer.
        /// </summary>
        private void view_negativeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_negativeImageToolStripMenuItem.Checked ^= true;

            _planarSliceDicomMprTool.DicomViewerTool.IsImageNegative =
                view_negativeImageToolStripMenuItem.Checked;
            _curvilinearSliceDicomMprTool.DicomViewerTool.IsImageNegative =
                view_negativeImageToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Resets the VOI LUT of slice.
        /// </summary>
        private void view_resetWindowLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _planarSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut = _defaultVoiLut;
            _curvilinearSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut = _defaultVoiLut;
        }

        /// <summary>
        /// Resets to the default VOI LUT of slice.
        /// </summary>
        private void view_resetToDefaultWindowLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _planarSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut =
                _planarSliceDicomMprTool.DicomViewerTool.DefaultDicomImageVoiLut;
            _curvilinearSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut =
                _curvilinearSliceDicomMprTool.DicomViewerTool.DefaultDicomImageVoiLut;
        }


        /// <summary>
        /// Shows the window level.
        /// </summary>
        private void view_showWindowLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_showWindowLevelToolStripMenuItem.Checked ^= true;
            bool value = view_showWindowLevelToolStripMenuItem.Checked;


            DicomImageVoiLutTextOverlay planarSliceVoiLutTextOverlay =
                _planarSliceDicomMprTool.TextOverlay.Find<DicomImageVoiLutTextOverlay>();
            if (planarSliceVoiLutTextOverlay != null)
                planarSliceVoiLutTextOverlay.IsVisible = value;

            DicomImageVoiLutTextOverlay curvilinearSliceVoiLutTextOverlay =
                _curvilinearSliceDicomMprTool.TextOverlay.Find<DicomImageVoiLutTextOverlay>();
            if (curvilinearSliceVoiLutTextOverlay != null)
                curvilinearSliceVoiLutTextOverlay.IsVisible = value;
        }

        /// <summary>
        /// Shows the axis of the slice.
        /// </summary>
        private void view_showAxisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_showAxisToolStripMenuItem.Checked ^= true;

            _planarSliceDicomMprTool.MprImageTool.AreAxesVisible =
                view_showAxisToolStripMenuItem.Checked;
            _curvilinearSliceDicomMprTool.MprImageTool.AreAxesVisible =
                view_showAxisToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Shows the patient direction.
        /// </summary>
        private void view_showPatientDirectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_showPatientDirectionToolStripMenuItem.Checked ^= true;

            foreach (TextOverlay textOverlay in _planarSliceDicomMprTool.TextOverlay)
            {
                if (textOverlay is MprSliceOrientationTextOverlay)
                    textOverlay.IsVisible = view_showPatientDirectionToolStripMenuItem.Checked;
            }

            foreach (TextOverlay textOverlay in _curvilinearSliceDicomMprTool.TextOverlay)
            {
                if (textOverlay is MprSliceOrientationTextOverlay)
                    textOverlay.IsVisible = view_showPatientDirectionToolStripMenuItem.Checked;
            }
        }

        /// <summary>
        /// Shows a form with MPR parameters information.
        /// </summary>
        private void view_showMPRParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!view_showMPRParametersToolStripMenuItem.Checked)
            {
                // if MPR parameters form is not created
                if (_mprParametersForm == null)
                    CreateMprParametersViewerForm();
                // show form
                _mprParametersForm.Show();
                view_showMPRParametersToolStripMenuItem.Checked = true;

                // disable all MPR image tools
                _planarSliceDicomMprTool.MprImageTool.Enabled = false;
                _curvilinearSliceDicomMprTool.MprImageTool.Enabled = false;
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
        /// Enables or disables interpolation in slice rendering.
        /// </summary>
        private void view_useInterpolationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // indicates whether interpolation is enabled
            bool isInterpolationEnabled = view_useInterpolationToolStripMenuItem.Checked;

            // if interpolation is enabled
            if (isInterpolationEnabled)
            {
                // disable interpolation
                _planarSliceDicomMprTool.MprImageTool.RenderingInterpolationMode = MprInterpolationMode.NearestNeighbor;
                _curvilinearSliceDicomMprTool.MprImageTool.RenderingInterpolationMode = MprInterpolationMode.NearestNeighbor;
            }
            // if interpolation is disabled
            else
            {
                // enable interpolation
                _planarSliceDicomMprTool.MprImageTool.RenderingInterpolationMode = MprInterpolationMode.Linear;
                _curvilinearSliceDicomMprTool.MprImageTool.RenderingInterpolationMode = MprInterpolationMode.Linear;
            }

            view_useInterpolationToolStripMenuItem.Checked = !isInterpolationEnabled;
        }


        /// <summary>
        /// Enables or disables the full screen mode of form.
        /// </summary>
        private void view_fullScreenToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            // if form must be shown in 'Full Screen' mode
            if (view_fullScreenToolStripMenuItem.Checked)
            {
                // if the top panel must be hidden
                if (!view_topPanelAlwaysVisibleToolStripMenuItem.Checked)
                {
                    topPanel.Visible = false;
                }

                // update the form settings
                TopMost = true;
                _nonFullScreenWindowState = WindowState;
                FormBorderStyle = FormBorderStyle.None;
                if (WindowState == FormWindowState.Maximized)
                    WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                // show the top panel
                topPanel.Visible = true;

                // update the form settings
                TopMost = false;
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                if (WindowState != _nonFullScreenWindowState)
                    WindowState = _nonFullScreenWindowState;
            }
        }

        /// <summary>
        /// Shows or hides the top panel.
        /// </summary>
        private void view_topPanelAlwaysVisibleToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (view_fullScreenToolStripMenuItem.Checked)
            {
                if (view_topPanelAlwaysVisibleToolStripMenuItem.Checked)
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
        /// Shows a dialog that allows to change the text overlay, which must be shown on image viewer.
        /// </summary>
        private void view_textOverlaySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DicomOverlaySettingEditorForm dialog = new DicomOverlaySettingEditorForm(OVERLAY_OWNER_NAME, _planarSliceDicomMprTool))
            {
                dialog.StartPosition = FormStartPosition.CenterParent;
                // show dialog
                dialog.ShowDialog(this);

                DicomOverlaySettingEditorForm.SetTextOverlay(OVERLAY_OWNER_NAME, _planarSliceDicomMprTool);
                DicomOverlaySettingEditorForm.SetTextOverlay(OVERLAY_OWNER_NAME, _curvilinearSliceDicomMprTool);
            }
        }

        /// <summary>
        /// Opens an MPR settings form.
        /// </summary>
        private void view_settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SliceType selectedSliceType = _sliceType;

            if (curvilinearSliceImageViewer.Focused)
                selectedSliceType = SliceType.Curvilinear;

            using (MprImageToolAppearanceSettingsForm dialog = new MprImageToolAppearanceSettingsForm(
                _imageToolAppearanceSettings, selectedSliceType,
                _sliceType, SliceType.Curvilinear))
            {
                dialog.Owner = this;
                dialog.ShowDialog();
            }

            UpdateMprSettings();
        }

        #endregion


        #region 'Slice' menu

        /// <summary>
        /// Starts the building of curvilinear slice.
        /// </summary>
        private void slice_buildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartBuildCurvilinearSlice();
        }

        #endregion


        #region MPR settings

        /// <summary>
        /// Updates MPR settings.
        /// </summary>
        private void UpdateMprSettings()
        {
            // update MPR image
            _imageToolAppearanceSettings.SetMprImageSettings(_visualizationController.MprImage);
            // update controller
            _imageToolAppearanceSettings.SetMprVisualizationControllerSettings(_visualizationController);

            // update slices

            MprSliceVisualizer visualMprSlice = _visualizationController.GetVisualMprSliceAssociatedWithMprSlice(
                _currentPlanarSlice);
            _imageToolAppearanceSettings.SetSliceSettings(_sliceType, visualMprSlice);
            // if curvilinear slice is created
            if (_currentCurvilinearSlice != null)
                _imageToolAppearanceSettings.SetCurvilinearSliceSettings(_visualizationController.GetVisualMprSliceAssociatedWithMprSlice(_currentCurvilinearSlice));

            // update default slices
            _defaultPlanarSlice.Thickness = _currentPlanarSlice.Thickness;
            _defaultPlanarSlice.RenderingMode = _currentPlanarSlice.RenderingMode;
            if (_currentCurvilinearSlice != null && _defaultCurvilinearSlice != null)
            {
                _defaultCurvilinearSlice.Thickness = _currentCurvilinearSlice.Thickness;
                _defaultCurvilinearSlice.RenderingMode = _currentCurvilinearSlice.RenderingMode;
            }

            // update MPR tools
            _imageToolAppearanceSettings.SetMprToolSettings(_planarSliceDicomMprTool.MprImageTool);
            _imageToolAppearanceSettings.SetMprToolSettings(_curvilinearSliceDicomMprTool.MprImageTool);
        }

        #endregion


        #region DicomViewerTool

        /// <summary>
        /// Updates the VOI LUT in DICOM viewer tool.
        /// </summary>
        private void DicomViewerTool_DicomImageVoiLutChanged(object sender, VoiLutChangedEventArgs e)
        {
            if (view_synchronizeWindowLevelToolStripMenuItem.Checked)
            {
                DicomImageVoiLookupTable newVoiLut = new DicomImageVoiLookupTable(e.WindowCenter, e.WindowWidth);

                if (sender == _curvilinearSliceDicomMprTool)
                {
                    _planarSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut = newVoiLut;
                }
                else
                {
                    _curvilinearSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut = newVoiLut;
                }
            }
        }

        #endregion


        #region MprImageTool

        /// <summary>
        /// The slice building is started.
        /// </summary>
        private void MprImageTool_SliceBuildingStarted(object sender, MprSliceViewEventArgs e)
        {
            // remove information about current curvilinear slice
            _currentCurvilinearSlice = null;
            _defaultCurvilinearSlice = null;
        }

        /// <summary>
        /// The slice building is finished.
        /// </summary>
        private void MprImageTool_SliceBuildingFinished(object sender, MprSliceViewEventArgs e)
        {
            // update information about current curvilinear slice

            MprPolylineSlice curvlinearSlice = e.SliceView.MprSliceVisualizer.Slice as MprPolylineSlice;

            if (curvlinearSlice == null)
                throw new ArgumentNullException();

            _currentCurvilinearSlice = curvlinearSlice;
            _defaultCurvilinearSlice = curvlinearSlice.CreateCopy();
        }

        /// <summary>
        /// Mouse is down.
        /// </summary>
        private void MprImageTool_MouseDown(object sender, VisualToolMouseEventArgs e)
        {
            ImageViewer viewer = ((VisualTool)sender).ImageViewer;
            // if image viewer is focused AND
            // mouse left button is clicked AND
            // MPR parameters form is shown
            if (viewer.Focused && e.Button == MouseButtons.Left && _mprParametersForm != null)
            {
                // update values in MPR parameters viewer form
                UpdateMprParametersForm(viewer, e.X, e.Y);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Mouse is moved.
        /// </summary>
        private void MprImageTool_MouseMove(object sender, VisualToolMouseEventArgs e)
        {
            ImageViewer viewer = ((VisualTool)sender).ImageViewer;
            // if image viewer is focused AND
            // mouse left button is clicked AND
            // MPR parameters form is shown
            if (viewer.Focused && e.Button == MouseButtons.Left && _mprParametersForm != null)
            {
                // update values in MPR parameters viewer form
                UpdateMprParametersForm(viewer, e.X, e.Y);
                e.Handled = true;
            }
        }

        #endregion


        #region MPR slice building

        /// <summary>
        /// Starts the building of curvilinear slice.
        /// </summary>
        private void StartBuildCurvilinearSlice()
        {
            // if previous curvlinear slice must be removed
            if (_curvilinearSliceDicomMprTool.MprImageTool.FocusedSlice != null)
            {
                // remove previous curvlinear slice
                _visualizationController.RemoveSliceVisualization(
                    _curvilinearSliceDicomMprTool.MprImageTool.FocusedSlice);
            }

            // create curvilinear slice
            MprCurvilinearSlice curvilinearSlice =
                _visualizationController.MprImage.CreateCurvilinearSlice(_currentPlanarSlice, null);
            // create visualizer for curvilinear slice
            MprSliceVisualizer curvilinearSliceVisualizer = new MprSliceVisualizer(curvilinearSlice, Color.White);
            // set the visual settings of curvilinear slice
            _imageToolAppearanceSettings.SetCurvilinearSliceSettings(curvilinearSliceVisualizer);

            // start the building of curvilinear slice
            MprSliceView curvilinearSliceView = _planarSliceDicomMprTool.MprImageTool.AddAndBuildSlice(curvilinearSliceVisualizer);

            // show slice in the right viewer
            _visualizationController.ShowSliceInViewer(curvilinearSliceImageViewer, curvilinearSlice);

            // if image viewer zoom must be changed automatically when slice is building
            if (view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem.Checked)
            {
                // subscribe to the interaction events of slice builder

                curvilinearSliceView.Builder.Interaction +=
                    new EventHandler<Vintasoft.Imaging.UI.VisualTools.UserInteraction.InteractionEventArgs>(CurvilinearSlice_Builder_Interaction);
                curvilinearSliceView.Builder.InteractionFinished +=
                    new EventHandler<Vintasoft.Imaging.UI.VisualTools.UserInteraction.InteractionEventArgs>(CurvilinearSlice_Builder_InteractionFinished);
            }
        }

        /// <summary>
        /// User is interacted with the curvilinear slice.
        /// </summary>
        private void CurvilinearSlice_Builder_Interaction(object sender, InteractionEventArgs e)
        {
            // calculate the image viewer zoom for viewing
            double viewerZoom = MprVisualizationController.CalculateZoomForViewSliceOnBestFit(
                _curvilinearSliceDicomMprTool.MprImageTool.MprImage,
                _curvilinearSliceDicomMprTool.MprImageTool.FocusedSlice,
                curvilinearSliceImageViewer);

            // change the zoom in image viewer

            curvilinearSliceImageViewer.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.Zoom;
            curvilinearSliceImageViewer.ZoomExtended = (float)viewerZoom;
        }

        /// <summary>
        /// User is finished interacting with the curvilinear slice.
        /// </summary>
        private void CurvilinearSlice_Builder_InteractionFinished(object sender, InteractionEventArgs e)
        {
            // unsubscribe from the slice builder events

            IInteractionController builder = (IInteractionController)sender;
            builder.Interaction -= CurvilinearSlice_Builder_Interaction;
            builder.InteractionFinished -= CurvilinearSlice_Builder_InteractionFinished;
        }

        #endregion


        #region ToolStrip

        /// <summary>
        /// Updates the current image viewer in tool strip.
        /// </summary>
        private void ImageViewer_GotFocus(object sender, EventArgs e)
        {
            // if focused viewer is changed
            if (imageViewerToolStrip1.ImageViewer != sender)
            {
                imageViewerToolStrip1.ImageViewer = (ImageViewer)sender;

                DicomMprToolInteractionMode[] disabledInteractionModes = null;

                // is curvilinear viewer is focused
                if (curvilinearSliceImageViewer.Focused)
                    // disable the Roll interaction mode
                    disabledInteractionModes = new DicomMprToolInteractionMode[] { DicomMprToolInteractionMode.Roll };

                // update disabled interaction modes
                dicomMprToolInteractionModeToolStrip1.DisabledInteractionModes = disabledInteractionModes;
            }
        }

        #endregion


        #region MPR parameters form

        /// <summary>
        /// Creates a form for viewing parameters of 3D MPR (multiplanar reconstruction).
        /// </summary>
        private void CreateMprParametersViewerForm()
        {
            // get DICOM MPR tool, which is associated with focused image viewer
            DicomMprTool dicomMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(FocusedViewer);
            // get transform from the image space to the slice space
            PointFTransform transformFromImageToSlice = dicomMprTool.MprImageTool.FocusedSliceView.GetPointTransform(FocusedViewer, FocusedViewer.Image);
            // inverse the transform, i.e. get transform from the slice space to the image space
            transformFromImageToSlice = transformFromImageToSlice.GetInverseTransform();

            // create a form
            _mprParametersForm = new MprParametersViewerForm(
                new Point(0, 0),
                transformFromImageToSlice,
                dicomMprTool.DicomViewerTool.DisplayedImage,
                dicomMprTool.MprImageTool.MprImage,
                dicomMprTool.MprImageTool.FocusedSlice);
            _mprParametersForm.Owner = this;
            _mprParametersForm.FormClosing += new FormClosingEventHandler(MprParametersForm_FormClosing);
        }

        /// <summary>
        /// Updates values of <see cref="MprParametersViewerForm"/>.
        /// </summary>
        /// <param name="viewer">The focused image viewer.</param>
        /// <param name="mouseLocationX">The mouse X coordinate.</param>
        /// <param name="mouseLocationY">The mouse Y coordinate.</param>
        private void UpdateMprParametersForm(ImageViewer viewer, int mouseLocationX, int mouseLocationY)
        {
            // get mouse location on image
            int xCoordinate = mouseLocationX - viewer.Location.X;
            int yCoordinate = mouseLocationY - viewer.Location.Y;
            AffineMatrix transformFromControlToImage = FocusedViewer.GetTransformFromControlToImage();
            PointF locationOnImage = PointFAffineTransform.TransformPoint(transformFromControlToImage, new PointF(xCoordinate, yCoordinate));

            // get visual tool of focused viewer
            DicomMprTool dicomMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(viewer);
            // get transform from an image to the slice
            PointFTransform transformFromImageToSlice = dicomMprTool.MprImageTool.FocusedSliceView.GetPointTransform(viewer, viewer.Image);
            transformFromImageToSlice = transformFromImageToSlice.GetInverseTransform();

            // update values
            _mprParametersForm.LocationOnImage = new Point((int)locationOnImage.X, (int)locationOnImage.Y);
            _mprParametersForm.TransformFromImageToSlice = transformFromImageToSlice;
            _mprParametersForm.DisplayedImage = dicomMprTool.DicomViewerTool.DisplayedImage;
            _mprParametersForm.MprImage = dicomMprTool.MprImageTool.MprImage;
            _mprParametersForm.Slice = dicomMprTool.MprImageTool.FocusedSlice;
            _mprParametersForm.UpdateValues();
        }

        /// <summary>
        /// The form with 3D MPR parameters information is closing.
        /// </summary>
        private void MprParametersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _mprParametersForm.FormClosing -= MprParametersForm_FormClosing;
            _mprParametersForm = null;
            view_showMPRParametersToolStripMenuItem.Checked = false;

            _planarSliceDicomMprTool.MprImageTool.Enabled = true;
            _curvilinearSliceDicomMprTool.MprImageTool.Enabled = true;
        }

        #endregion


        #region Common

        /// <summary>
        /// Scales the slice proportion to the viewer.
        /// </summary>
        private void FitScene()
        {
            _planarSliceDicomMprTool.MprImageTool.FitScene();
            _curvilinearSliceDicomMprTool.MprImageTool.FitScene();
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

        /// <summary>
        /// Creates the <see cref="DicomMprTool"/> for the planar slice.
        /// </summary>
        /// <param name="isNegativeImage">The value indicating whether the image must be inverted.</param>
        private void CreatePlanarSliceDicomMprTool(bool isNegativeImage)
        {
            _planarSliceDicomMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(
                planarSliceImageViewer);
            _planarSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut = _defaultVoiLut;
            _planarSliceDicomMprTool.DicomViewerTool.IsImageNegative = isNegativeImage;
            _planarSliceDicomMprTool.DicomViewerTool.DicomImageVoiLutChanged +=
                new EventHandler<VoiLutChangedEventArgs>(DicomViewerTool_DicomImageVoiLutChanged);
            _planarSliceDicomMprTool.MouseMove += new VisualToolMouseEventHandler(MprImageTool_MouseMove);
            _planarSliceDicomMprTool.MouseDown += new VisualToolMouseEventHandler(MprImageTool_MouseDown);
            _planarSliceDicomMprTool.MprImageTool.SliceBuildingStarted +=
                new EventHandler<MprSliceViewEventArgs>(MprImageTool_SliceBuildingStarted);
            _planarSliceDicomMprTool.MprImageTool.SliceBuildingFinished +=
                new EventHandler<MprSliceViewEventArgs>(MprImageTool_SliceBuildingFinished);

            _planarSliceDicomMprTool.TextOverlay.Add(new DicomMprFillDataProgressTextOverlay());
        }

        /// <summary>
        /// Creates the <see cref="DicomMprTool"/> for the curvilinear slice.
        /// </summary>
        /// <param name="isNegativeImage">The value indicating whether the image must be inverted.</param>
        private void CreateCurvilinearSliceDicomMprTool(bool isNegativeImage)
        {
            _curvilinearSliceDicomMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(
                curvilinearSliceImageViewer);
            _curvilinearSliceDicomMprTool.DicomViewerTool.DicomImageVoiLut = _defaultVoiLut;
            _curvilinearSliceDicomMprTool.DicomViewerTool.IsImageNegative = isNegativeImage;
            _curvilinearSliceDicomMprTool.DicomViewerTool.DicomImageVoiLutChanged +=
                new EventHandler<VoiLutChangedEventArgs>(DicomViewerTool_DicomImageVoiLutChanged);
            _curvilinearSliceDicomMprTool.MouseMove += new VisualToolMouseEventHandler(MprImageTool_MouseMove);
            _curvilinearSliceDicomMprTool.MouseDown += new VisualToolMouseEventHandler(MprImageTool_MouseDown);
            _curvilinearSliceDicomMprTool.TextOverlay.Add(new DicomMprFillDataProgressTextOverlay());
        }

        /// <summary>
        /// Raises the <see cref="Control.OnKeyDown"/> event.
        /// </summary>
        /// <param name="e">A <see cref="KeyEventArgs"/> that contains the event data.</param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (_planarSliceDicomMprTool.MprImageTool.IsSliceBuilding)
                {
                    _planarSliceDicomMprTool.MprImageTool.CancelSliceBuilding();
                }
                else if (view_fullScreenToolStripMenuItem.Checked)
                {
                    view_fullScreenToolStripMenuItem.Checked = false;
                }
            }

            base.OnKeyDown(e);
        }

        /// <summary>
        /// The form is shown.
        /// </summary>
        protected override void OnShown(EventArgs e)
        {
            // show slice in viewer
            _visualizationController.ShowSliceInViewer(planarSliceImageViewer, _currentPlanarSlice);

            base.OnShown(e);

            StartBuildCurvilinearSlice();
        }

        /// <summary>
        /// The form is closed.
        /// </summary>
        protected override void OnClosed(EventArgs e)
        {
            _visualizationController.Dispose();

            base.OnClosed(e);
        }

        #endregion

    }
}
