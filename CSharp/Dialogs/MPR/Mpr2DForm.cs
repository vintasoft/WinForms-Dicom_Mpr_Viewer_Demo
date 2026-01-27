using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Dicom;
using Vintasoft.Imaging.Dicom.Mpr;
using Vintasoft.Imaging.Dicom.Mpr.UI;
using Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools;
using Vintasoft.Imaging.Dicom.UI.VisualTools;
using Vintasoft.Imaging.ImageProcessing;
using Vintasoft.Imaging.UI.VisualTools;
using Vintasoft.Imaging.ImageProcessing.Color;
using Vintasoft.Imaging.ImageProcessing.Filters;

using DemosCommonCode.Imaging;
using DemosCommonCode.Imaging.Codecs;


namespace DicomMprViewerDemo
{
    /// <summary>
    /// A form that allows to view 2D MPR (multiplanar reconstruction): the sagittal, coronal or axial slices.
    /// </summary>
    public partial class Mpr2DForm : Form
    {

        #region Constants

        /// <summary>
        /// The text overlay collection owner name.
        /// </summary>
        const string OVERLAY_OWNER_NAME = "2D MPR";

        #endregion



        #region Fields

        /// <summary>
        /// The visualization controller.
        /// </summary>
        MprVisualizationController _visualizationController;

        /// <summary>
        /// The current slice.
        /// </summary>
        MprPlanarSlice _currentSlice;

        /// <summary>
        /// The DicomMprTool.
        /// </summary>
        DicomMprTool _dicomMprTool;

        /// <summary>
        /// Determines that form is initialized.
        /// </summary>
        bool _isInitialized = false;

        /// <summary>
        /// The default value VOI LUT of slice.
        /// </summary>
        DicomImageVoiLookupTable _defaultVoiLut;

        /// <summary>
        /// The default location of slice.
        /// </summary>
        VintasoftPoint3D _defaultLocation;

        /// <summary>
        /// The previous window state value.
        /// </summary>
        FormWindowState _previousWindowState;

        /// <summary>
        /// The MPR settings manager.
        /// </summary>
        MprImageToolAppearanceSettings _mprSettingsManager;

        /// <summary>
        /// The slice type.
        /// </summary>
        SliceType _sliceType;

        /// <summary>
        /// The processing commands, which can be applied to an image region of DICOM MPR viewer.
        /// </summary>
        ProcessingCommandBase[] _processingCommands = new ProcessingCommandBase[]
        {
            null,
            new InvertCommand(),
            new BlurCommand(7),
            new SharpenCommand(),
            new Vintasoft.Imaging.ImageProcessing.Fft.Filters.ImageSharpeningCommand()
        };

        #region Animation

        /// <summary>
        /// A value indicating whether the animation is cycled.
        /// </summary>
        bool _isAnimationCycled = true;

        /// <summary>
        /// Animation delay in milliseconds.
        /// </summary>
        int _animationDelay = 100;

        /// <summary>
        /// Animation thread.
        /// </summary>
        Thread _animationThread = null;

        /// <summary>
        /// Index of current animated frame.
        /// </summary>
        int _currentAnimatedFrameIndex = 0;

        /// <summary>
        /// A value indicating whether the focused index is changing.
        /// </summary>
        bool _isPageChanging = false;

        /// <summary>
        /// A value indicating whether the form is closing.
        /// </summary>
        bool _isFormClosed = false;

        #endregion

        #endregion



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Mpr2DForm"/> class.
        /// </summary>
        /// <param name="mprImage">The MPR cube.</param>
        /// <param name="currentSlice">The current slice.</param>
        /// <param name="voiLut">The current VOI LUT of slice.</param>
        /// <param name="isNegativeImage">Indicates that the image must be inverted.</param>
        /// <param name="settingsManager">The settings manager.</param>
        public Mpr2DForm(
            MprImage mprImage,
            MprPlanarSlice currentSlice,
            DicomImageVoiLookupTable voiLut,
            bool isNegativeImage,
            MprImageToolAppearanceSettings settingsManager)
        {
            InitializeComponent();

            _mprSettingsManager = settingsManager;

            // create visualization controller
            _visualizationController = new MprVisualizationController(mprImage, imageViewer1);

            settingsManager.SetMprVisualizationControllerSettings(_visualizationController);

            // save current slice
            _currentSlice = currentSlice;

            _sliceType = GetSliceType(currentSlice);

            // save current location
            _defaultLocation = currentSlice.Location;
            // save current VOI LUT
            _defaultVoiLut = voiLut;

            // create DicomMprTool
            _dicomMprTool = _visualizationController.GetDicomMprToolAssociatedWithImageViewer(imageViewer1);
            dicomMprToolInteractionModeToolStrip1.DicomMprTools = new DicomMprTool[] { _dicomMprTool };
            _dicomMprTool.MprImageTool.AllowRotate3D = false;
            _dicomMprTool.DicomViewerTool.DicomImageVoiLut = _defaultVoiLut;
            _dicomMprTool.DicomViewerTool.IsImageNegative = isNegativeImage;
            view_negativeImageToolStripMenuItem.Checked = isNegativeImage;

            // init the text overlays on image viewer
            InitTextOverlaysOnViewer();

            // set appearance to DicomMprTool
            settingsManager.SetMprToolSettings(_dicomMprTool.MprImageTool);
            // hide the color mark
            _dicomMprTool.MprImageTool.IsFocusedSliceColorMarkVisible = false;

            // add slice to the visualization controller
            MprSliceVisualizer visualMprSlice = _visualizationController.AddSliceVisualization(currentSlice, Color.Transparent);

            settingsManager.SetSliceSettings(_sliceType, visualMprSlice);

            // set scroll bar and tool strip settings

            imageViewerToolStrip1.UseImageViewerImages = false;
            imageViewerToolStrip1.PageCount = GetPerpendicularAxisLengthInPixels(currentSlice);
            imageViewerToolStrip1.SelectedPageIndex = GetPerpendicularAxisPositionPixels(currentSlice);

            currentSlice.PropertyChanged += new EventHandler<ObjectPropertyChangedEventArgs>(currentSlice_PropertyChanged);

            foreach (ProcessingCommandBase processingCommand in _processingCommands)
            {
                string processingCommandName = "None";

                if (processingCommand != null)
                    processingCommandName = processingCommand.Name;

                viewProcessingToolStripComboBox.Items.Add(processingCommandName);
                viewerProcessingToolStripComboBox.Items.Add(processingCommandName);
            }
            viewProcessingToolStripComboBox.SelectedIndex = 0;
            viewerProcessingToolStripComboBox.SelectedIndex = 0;

            _isInitialized = true;
        }

        #endregion



        #region Properties

        bool _isAnimationStarted = false;
        /// <summary>
        /// Gets or sets a value indicating whether the animation is started.
        /// </summary>
        bool IsAnimationStarted
        {
            get
            {
                return _isAnimationStarted;
            }
            set
            {
                if (IsAnimationStarted == value)
                    return;

                if (value)
                    StartAnimation();
                else
                    StopAnimation();

                imageViewerToolStrip1.IsNavigateEnabled = !value;
            }
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Raises the <see cref="Control.OnKeyDown"/> event.
        /// </summary>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && view_fullScreenToolStripMenuItem.Checked)
                view_fullScreenToolStripMenuItem.Checked = false;

            base.OnKeyDown(e);
        }

        /// <summary>
        /// The form is shown.
        /// </summary>
        protected override void OnShown(EventArgs e)
        {
            // show slice in viewer
            _visualizationController.ShowSliceInViewer(imageViewer1, _currentSlice);

            base.OnShown(e);
        }

        /// <summary>
        /// The form is closed.
        /// </summary>
        protected override void OnClosed(EventArgs e)
        {
            _currentSlice.PropertyChanged -=
                new EventHandler<ObjectPropertyChangedEventArgs>(currentSlice_PropertyChanged);

            _visualizationController.Dispose();

            _isFormClosed = true;

            base.OnClosed(e);
        }

        #endregion


        #region PRIVATE

        #region Init

        /// <summary>
        /// Initializes the text overlays on image viewer.
        /// </summary>
        private void InitTextOverlaysOnViewer()
        {
            // add a text overlay, which shows the loading progress of slices, at the left-top corner of image viewer

            DicomMprFillDataProgressTextOverlay loadingProgressOverlay = new DicomMprFillDataProgressTextOverlay();
            _dicomMprTool.TextOverlay.Add(loadingProgressOverlay);


            // add a text overlay, which shows slice thickness and location, at the left-bottom corner of image viewer

            TextOverlayGroup sliceInfoGroup = new TextOverlayGroup(
                  AnchorType.Bottom | AnchorType.Left,
                  new MprPlanarSliceThicknessTextOverlay(),
                  new MprPlanarSliceLocationTextOverlay());
            sliceInfoGroup.TextColor = sliceInfoGroup.Items[0].TextColor;
            sliceInfoGroup.TextFont = sliceInfoGroup.Items[0].TextFont;
            _dicomMprTool.TextOverlay.Add(sliceInfoGroup);


            // add a text overlay, which shows content date and time, at the right-bottom corner of image viewer

            TextOverlayGroup contetntInfoGroup = new TextOverlayGroup(
                AnchorType.Bottom | AnchorType.Right,
                new StandardDicomDataElementTextOverlay(DicomDataElementId.ContentDate),
                new StandardDicomDataElementTextOverlay(DicomDataElementId.ContentTime));
            contetntInfoGroup.TextColor = contetntInfoGroup.Items[0].TextColor;
            contetntInfoGroup.TextFont = contetntInfoGroup.Items[0].TextFont;
            _dicomMprTool.TextOverlay.Add(contetntInfoGroup);
        }

        #endregion


        #region 'File' menu

        /// <summary>
        /// Saves the screenshot of image viewer.
        /// </summary>
        private void file_saveViewerScreenshotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get image of focused image viewer
            using (VintasoftImage image = imageViewer1.RenderViewerImage())
            {
                // save image to a file
                SaveImageFileForm.SaveImageToFile(image, ImagingEncoderFactory.Default);
            }
        }

        /// <summary>
        /// Saves the image of MPR slice.
        /// </summary>
        private void file_saveImageSliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (VintasoftImage image = _dicomMprTool.DicomViewerTool.GetDisplayedImage())
            {
                SaveImageFileForm.SaveImageToFile(image, ImagingEncoderFactory.Default);
            }
        }

        /// <summary>
        /// Saves the image slices to a TIFF file.
        /// </summary>
        private void file_saveSlicesToMultipageTIFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create image slices encoding dialog
            using (MprImageSlicesEncodingPropertiesForm encodingPropertiesForm =
                new MprImageSlicesEncodingPropertiesForm())
            {
                if (encodingPropertiesForm.ShowDialog() == DialogResult.OK)
                {
                    // create a file save dialog
                    using (SaveFileDialog fileSaveDialog = new SaveFileDialog())
                    {
                        fileSaveDialog.Filter = "TIFF files|*.tiff;*.tif";

                        if (fileSaveDialog.ShowDialog() == DialogResult.OK)
                        {
                            // create images
                            ImageCollection images = CreateMprImageSlices(
                                encodingPropertiesForm.UseGray16MprImages,
                                encodingPropertiesForm.ApplyVoiLutToMprImageSlices);
                            try
                            {
                                // create TIFF encoder
                                using (TiffEncoder tiffEncoder = new TiffEncoder(true))
                                {
                                    // subscribe to the image collection saving events
                                    images.ImageCollectionSavingProgress +=
                                        new EventHandler<ProgressEventArgs>(images_ImageCollectionSavingProgress);
                                    images.ImageCollectionSaved += new EventHandler(images_ImageCollectionSaved);

                                    // initialize progress bar and description label
                                    toolStripProgressBar1.Value = 0;
                                    toolStripProgressBar1.Visible = true;
                                    toolStripStatusLabel1.Text = string.Format("Save to '{0}'...",
                                        System.IO.Path.GetFileName(fileSaveDialog.FileName));
                                    toolStripStatusLabel1.Visible = true;

                                    // set TIFF encoder settings
                                    tiffEncoder.Settings = encodingPropertiesForm.TiffEncoderSettings;

                                    // save images to specified file
                                    images.SaveSync(fileSaveDialog.FileName, tiffEncoder);
                                }
                            }
                            finally
                            {
                                images.ClearAndDisposeItems();
                            }
                        }
                    }
                }
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

            if (_dicomMprTool.MprImageTool.RenderingInterpolationMode == MprInterpolationMode.NearestNeighbor)
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
            FitScene();

            _currentSlice.Location = _defaultLocation;
        }

        /// <summary>
        /// Fits the slice on viewer.
        /// </summary>
        private void view_fitSceneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FitScene();
        }

        /// <summary>
        /// Resets the VOI LUT of slice.
        /// </summary>
        private void view_resetWindowLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dicomMprTool.DicomViewerTool.DicomImageVoiLut = _defaultVoiLut;
        }

        /// <summary>
        /// Inverts the image in viewer.
        /// </summary>
        private void view_negativeImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_negativeImageToolStripMenuItem.Checked ^= true;
            _dicomMprTool.DicomViewerTool.IsImageNegative = view_negativeImageToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Resets to the default VOI LUT of slice.
        /// </summary>
        private void view_resetToDefaultWindowLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dicomMprTool.DicomViewerTool.DicomImageVoiLut = _dicomMprTool.DicomViewerTool.DefaultDicomImageVoiLut;
        }

        /// <summary>
        /// Shows the text overlay on viewer.
        /// </summary>
        private void view_showTextOverlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            view_showTextOverlayToolStripMenuItem.Checked ^= true;
            bool value = view_showTextOverlayToolStripMenuItem.Checked;

            _dicomMprTool.IsTextOverlayVisible = value;
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
                _dicomMprTool.MprImageTool.RenderingInterpolationMode = MprInterpolationMode.NearestNeighbor;
            }
            // if interpolation is disabled
            else
            {
                // enable interpolation
                _dicomMprTool.MprImageTool.RenderingInterpolationMode = MprInterpolationMode.Linear;
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
                _previousWindowState = WindowState;
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
                if (WindowState != _previousWindowState)
                    WindowState = _previousWindowState;
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
        /// Shows the dialog that allows to change the text overlay, which must be shown on image viewer.
        /// </summary>
        private void view_textOverlaySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (DicomOverlaySettingEditorForm dlg = new DicomOverlaySettingEditorForm(OVERLAY_OWNER_NAME, _dicomMprTool))
            {
                dlg.StartPosition = FormStartPosition.CenterParent;
                // show dialog
                dlg.ShowDialog(this);

                DicomOverlaySettingEditorForm.SetTextOverlay(OVERLAY_OWNER_NAME, _dicomMprTool);
            }
        }

        /// <summary>
        /// Opens an MPR settings form.
        /// </summary>
        private void view_settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (MprImageToolAppearanceSettingsForm dlg = new MprImageToolAppearanceSettingsForm(_mprSettingsManager, _sliceType))
            {
                dlg.CanChangeColorMarkSettings = false;
                dlg.CanChangeSliceType = false;

                dlg.Owner = this;
                dlg.ShowDialog();
            }

            UpdateMprSettings();

            // hide the color mark
            _dicomMprTool.MprImageTool.IsFocusedSliceColorMarkVisible = false;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of viewProcessingToolStripComboBox object.
        /// </summary>
        private void viewProcessingToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessingCommandBase command = _processingCommands[viewProcessingToolStripComboBox.SelectedIndex];

            if (_dicomMprTool.ViewProcessingCommand == command)
                return;

            if (_dicomMprTool.GetMouseButtonsForInteractionMode(DicomMprToolInteractionMode.ViewProcessing) == MouseButtons.None)
                _dicomMprTool.SetInteractionMode(MouseButtons.Left, DicomMprToolInteractionMode.ViewProcessing);

            _dicomMprTool.ViewProcessingCommand = command;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of viewerProcessingToolStripComboBox object.
        /// </summary>
        private void viewerProcessingToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProcessingCommandBase command = _processingCommands[viewerProcessingToolStripComboBox.SelectedIndex];

            if (_dicomMprTool.DicomViewerTool.DisplayedImageProcessing == command)
                return;

            _dicomMprTool.DicomViewerTool.DisplayedImageProcessing = command;
        }

        #endregion


        #region Animation

        #region 'Animation' menu

        /// <summary>
        /// Handles the Click event of showAnimationToolStripMenuItem object.
        /// </summary>
        private void showAnimationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsAnimationStarted = showAnimationToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the Click event of animationRepeatToolStripMenuItem object.
        /// </summary>
        private void animationRepeatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isAnimationCycled = animationRepeatToolStripMenuItem.Checked;
        }

        /// <summary>
        /// Handles the TextChanged event of animationDelayToolStripComboBox object.
        /// </summary>
        private void animationDelayToolStripComboBox_TextChanged(object sender, EventArgs e)
        {
            int delay;
            if (int.TryParse(animationDelay_valueToolStripComboBox.Text, out delay))
                _animationDelay = Math.Max(1, delay);
            else
                animationDelay_valueToolStripComboBox.Text = _animationDelay.ToString();
        }

        #endregion


        #region Frame animation

        /// <summary>
        /// Starts animation.
        /// </summary>
        private void StartAnimation()
        {
            StopAnimation();

            _animationThread = new Thread(AnimationMethod);
            _animationThread.IsBackground = false;

            // disable visual tool
            _dicomMprTool.Enabled = false;
            // disable tool strip
            imageViewerToolStrip1.Enabled = false;
            dicomMprToolInteractionModeToolStrip1.Enabled = false;

            _animationThread.Start();
            _isAnimationStarted = true;
        }

        /// <summary>
        /// Stops animation.
        /// </summary>
        private void StopAnimation()
        {
            _isAnimationStarted = false;

            if (_animationThread == null)
                return;

            showAnimationToolStripMenuItem.Checked = false;

            _animationThread = null;

            _isPageChanging = false;

            // if the focused index in thumbnail viewer was NOT changed during animation
            if (!_isPageChanging)
            {
                if (imageViewerToolStrip1.SelectedPageIndex != _currentAnimatedFrameIndex)
                {
                    imageViewerToolStrip1.SelectedPageIndex = _currentAnimatedFrameIndex;
                }
            }

            // enable tool strip
            imageViewerToolStrip1.Enabled = true;
            dicomMprToolInteractionModeToolStrip1.Enabled = true;
            // enable visual tool
            _dicomMprTool.Enabled = true;
        }

        /// <summary>
        /// Animation thread.
        /// </summary>
        private void AnimationMethod()
        {
            Thread currentThread = Thread.CurrentThread;
            _currentAnimatedFrameIndex = imageViewerToolStrip1.SelectedPageIndex;
            int count = imageViewerToolStrip1.PageCount;

            for (; _currentAnimatedFrameIndex < count || _isAnimationCycled;)
            {
                if (_animationThread != currentThread)
                    break;

                _isPageChanging = true;

                if (!_isFormClosed)
                    BeginInvoke(new ChangePageDelegate(ChangePage));

                _isPageChanging = false;
                Thread.Sleep(_animationDelay);

                if (_isFormClosed)
                {
                    _isFormClosed = false;
                    break;
                }

                _currentAnimatedFrameIndex++;
                if (_isAnimationCycled && _currentAnimatedFrameIndex >= count)
                    _currentAnimatedFrameIndex = 0;
            }

            _currentAnimatedFrameIndex--;
            BeginInvoke(new ThreadStart(StopAnimation));
        }

        /// <summary>
        /// Changes page in viewer.
        /// </summary>
        private void ChangePage()
        {
            imageViewerToolStrip1.SelectedPageIndex = _currentAnimatedFrameIndex + 1;
        }

        #endregion

        #endregion


        #region Image viewer toolstrip

        /// <summary>
        /// Moves the slice.
        /// </summary>
        private void imageViewerToolStrip1_PageIndexChanged(object sender, PageIndexChangedEventArgs e)
        {
            // if form is not initialized
            if (!_isInitialized)
                return;

            // get the new perpendicular axis position of slice
            // because the page index contains information about perpendicular axis position
            int newPerpendicularAxisPosition = e.SelectedPageIndex;
            // get the current perpendicular axis position of slice
            int currentPerpendicularAxisPosition = GetPerpendicularAxisPositionPixels(_currentSlice);

            // if perpendicular axis position is changed
            if (newPerpendicularAxisPosition != currentPerpendicularAxisPosition)
            {
                // update perpendicular axis position
                SetPerpendicularAxisPositionPixels(_currentSlice, newPerpendicularAxisPosition);
            }
        }

        #endregion


        #region Image saving

        /// <summary>
        /// Image collection is saved successfully.
        /// </summary>
        private void images_ImageCollectionSaved(object sender, EventArgs e)
        {
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel1.Visible = false;
        }

        /// <summary>
        /// Image collection saving process is in progress.
        /// </summary>
        private void images_ImageCollectionSavingProgress(object sender, ProgressEventArgs e)
        {
            toolStripProgressBar1.Value = e.Progress;
            viewerAndScrollPanel.Update();
        }

        #endregion


        #region Perpendicular axis of slice

        /// <summary>
        /// Returns the perpendicular axis position, in pixels.
        /// </summary>
        /// <param name="slice">The slice.</param>
        /// <returns>
        /// The perpendicular axis position.
        /// </returns>
        private int GetPerpendicularAxisPositionPixels(MprPlanarSlice slice)
        {
            int xAxisPx = _visualizationController.MprImage.XDataLength - 1;
            int yAxisPx = _visualizationController.MprImage.YDataLength - 1;
            int zAxisPx = _visualizationController.MprImage.ZDataLength - 1;
            double xAxisMm = _visualizationController.MprImage.XLength;
            double yAxisMm = _visualizationController.MprImage.YLength;
            double zAxisMm = _visualizationController.MprImage.ZLength;


            double value = 0;

            if (MprPlanarSlice.IsSagittalSlice(slice))
            {
                value = slice.Location.X * xAxisPx / xAxisMm;
            }
            else if (MprPlanarSlice.IsCoronalSlice(slice))
            {
                value = slice.Location.Y * yAxisPx / yAxisMm;
            }
            else if (MprPlanarSlice.IsAxialSlice(slice))
            {
                value = slice.Location.Z * zAxisPx / zAxisMm;
            }

            return (int)Math.Round(value, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Returns the perpendicular axis length, in pixels.
        /// </summary>
        /// <param name="slice">The slice.</param>
        /// <returns>
        /// The perpendicular axis length.
        /// </returns>
        private int GetPerpendicularAxisLengthInPixels(MprPlanarSlice slice)
        {
            int xAxisPx = _visualizationController.MprImage.XDataLength;
            int yAxisPx = _visualizationController.MprImage.YDataLength;
            int zAxisPx = _visualizationController.MprImage.ZDataLength;
            if (MprPlanarSlice.IsSagittalSlice(slice))
                return xAxisPx;

            if (MprPlanarSlice.IsCoronalSlice(slice))
                return yAxisPx;

            if (MprPlanarSlice.IsAxialSlice(slice))
                return zAxisPx;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the perpendicular axis position.
        /// </summary>
        /// <param name="slice">The slice.</param>
        /// <param name="location">The location, in pixels.</param>
        private void SetPerpendicularAxisPositionPixels(MprPlanarSlice slice, int location)
        {
            VintasoftPoint3D newLocation = slice.Location;

            int xAxisPx = _visualizationController.MprImage.XDataLength - 1;
            int yAxisPx = _visualizationController.MprImage.YDataLength - 1;
            int zAxisPx = _visualizationController.MprImage.ZDataLength - 1;
            double xAxisMm = _visualizationController.MprImage.XLength;
            double yAxisMm = _visualizationController.MprImage.YLength;
            double zAxisMm = _visualizationController.MprImage.ZLength;

            if (MprPlanarSlice.IsSagittalSlice(slice))
            {
                newLocation.X = location * (xAxisMm / xAxisPx);
            }
            else if (MprPlanarSlice.IsCoronalSlice(slice))
            {
                newLocation.Y = location * (yAxisMm / yAxisPx);
            }
            else if (MprPlanarSlice.IsAxialSlice(slice))
            {
                newLocation.Z = location * (zAxisMm / zAxisPx);
            }
            else
            {
                throw new NotImplementedException();
            }

            slice.Location = newLocation;
        }

        #endregion


        /// <summary>
        /// Scales the slice proportion to the viewer.
        /// </summary>
        private void FitScene()
        {
            _dicomMprTool.MprImageTool.FitScene();
        }

        /// <summary>
        /// Updates the tool strip and scroll bar.
        /// </summary>
        private void currentSlice_PropertyChanged(object sender, ObjectPropertyChangedEventArgs e)
        {
            // if form is not initialized
            if (!_isInitialized)
                return;

            // get slice perpendicular axis position
            int perpendicularAxisPosition = GetPerpendicularAxisPositionPixels(_currentSlice);
            // get slice perpendicular axis length
            int perpendicularAxisLength = GetPerpendicularAxisLengthInPixels(_currentSlice);
            perpendicularAxisPosition = Math.Max(0, Math.Min(perpendicularAxisPosition, perpendicularAxisLength));

            // if value must be changed in tool strip
            if (imageViewerToolStrip1.SelectedPageIndex != perpendicularAxisPosition)
                imageViewerToolStrip1.SelectedPageIndex = perpendicularAxisPosition;
        }

        /// <summary>
        /// Creates the MPR slice images.
        /// </summary>
        /// <param name="useGray16Images">Indicates whether the MPR slice image must be Gray16.</param>
        /// <param name="applyVoiLutCommand">
        /// Indicates whether the <see cref="ApplyDicomImageVoiLutCommand"/> must be applied to MPR slice image.
        /// </param>
        /// <returns>
        /// The MPR slices image.
        /// </returns>
        private ImageCollection CreateMprImageSlices(bool useGray16Images, bool applyVoiLutCommand)
        {
            MprImage mprImage = _dicomMprTool.MprImageTool.MprImage;

            // create MPR slice offset
            VintasoftPoint3D sliceLocationOffset = new VintasoftPoint3D(0, 0, 0);
            // slice of MPR image
            MprSlice slice;
            // count slices
            int countImageSlices;

            if (MprPlanarSlice.IsSagittalSlice(_currentSlice))
            {
                sliceLocationOffset.X = mprImage.XLength / mprImage.XDataLength;
                countImageSlices = mprImage.XDataLength;
                slice = mprImage.CreateSagittalSlice(0);
            }
            else if (MprPlanarSlice.IsCoronalSlice(_currentSlice))
            {
                sliceLocationOffset.Y = mprImage.YLength / mprImage.YDataLength;
                countImageSlices = mprImage.YDataLength;
                slice = mprImage.CreateCoronalSlice(0);
            }
            else if (MprPlanarSlice.IsAxialSlice(_currentSlice))
            {
                sliceLocationOffset.Z = mprImage.ZLength / mprImage.ZDataLength;
                countImageSlices = mprImage.ZDataLength;
                slice = mprImage.CreateAxialSlice(0);
            }
            else
            {
                throw new NotImplementedException();
            }

            // create processing command for MPR image slices
            ProcessingCommandBase command = GetMprImageSliceProcessing(useGray16Images, applyVoiLutCommand);

            // create result collection
            ImageCollection images = new ImageCollection();

            // initialize progress bar and description label
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = countImageSlices;
            toolStripProgressBar1.Visible = true;
            toolStripStatusLabel1.Text = "Create MPR Image Slices...";
            toolStripStatusLabel1.Visible = true;

            for (int i = 0; i < countImageSlices; i++)
            {
                // update progress bar
                toolStripProgressBar1.Value = i;
                viewerAndScrollPanel.Update();

                // render the MPR slice image
                MprImageSlice mprImageSlice = mprImage.RenderSlice(slice);

                // move slice
                slice.Location += sliceLocationOffset;

                // get image of MPR slice
                VintasoftImage image = mprImageSlice.GetImageAndDispose();
                // process image
                command.ExecuteInPlace(image);
                // save image
                images.Add(image);
            }

            toolStripProgressBar1.Maximum = 100;
            toolStripProgressBar1.Visible = false;
            toolStripStatusLabel1.Text = string.Empty;
            toolStripStatusLabel1.Visible = false;

            return images;
        }

        /// <summary>
        /// Returns the processing command that should be applied to the MPR slice image.
        /// </summary>
        /// <param name="useGray16Images">Indicates whether the MPR slice image must be Gray16.</param>
        /// <param name="applyVoiLutCommand">
        /// Indicates whether the <see cref="ApplyDicomImageVoiLutCommand"/> must be applied to MPR slice image.
        /// </param>
        /// <returns>
        /// The processing command for apply to MPR slice image.
        /// </returns>
        private ProcessingCommandBase GetMprImageSliceProcessing(bool useGray16Images, bool applyVoiLutCommand)
        {
            ProcessingCommandBase command = null;

            // if VOI LUT must be applied
            if (applyVoiLutCommand)
            {
                // create command
                ApplyDicomImageVoiLutCommand voiLutCommand = _dicomMprTool.DicomViewerTool.CreateApplyDicomImageVoiLutCommand();

                // if result image must be Gray16
                if (useGray16Images)
                    voiLutCommand.OutputPixelFormat = DicomImagePixelFormat.Gray16;
                else
                    voiLutCommand.OutputPixelFormat = DicomImagePixelFormat.Gray8;

                command = voiLutCommand;
            }
            else
            {
                // create command
                ChangePixelFormatCommand changePixelFormat = new ChangePixelFormatCommand();

                // if result image must be Gray16
                if (useGray16Images)
                    changePixelFormat.PixelFormat = PixelFormat.Gray16;
                else
                    changePixelFormat.PixelFormat = PixelFormat.Gray8;

                command = changePixelFormat;
            }
            return command;
        }

        /// <summary>
        /// Returns the MPR slice type.
        /// </summary>
        /// <param name="slice">The MPR planar slice.</param>
        /// <returns>
        /// The MPR slice type.
        /// </returns>
        private SliceType GetSliceType(MprPlanarSlice slice)
        {
            // if slice is sagittal
            if (MprPlanarSlice.IsSagittalSlice(slice))
                return SliceType.Sagittal;

            // if slice is coronal
            if (MprPlanarSlice.IsCoronalSlice(slice))
                return SliceType.Coronal;

            // if slice is axial
            if (MprPlanarSlice.IsAxialSlice(slice))
                return SliceType.Axial;

            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates MPR settings.
        /// </summary>
        private void UpdateMprSettings()
        {
            // update MPR Image
            _mprSettingsManager.SetMprImageSettings(_visualizationController.MprImage);
            // update controller
            _mprSettingsManager.SetMprVisualizationControllerSettings(_visualizationController);

            // update slice

            MprSliceVisualizer visualMprSlice = _visualizationController.GetVisualMprSliceAssociatedWithMprSlice(_currentSlice);
            // if slice is sagittal
            if (MprPlanarSlice.IsSagittalSlice(_currentSlice))
                _mprSettingsManager.SagittalSliceAppearance.SetSettings(visualMprSlice);
            // if slice is coronal
            else if (MprPlanarSlice.IsCoronalSlice(_currentSlice))
                _mprSettingsManager.CoronalSliceAppearance.SetSettings(visualMprSlice);
            // if slice is axial
            else if (MprPlanarSlice.IsAxialSlice(_currentSlice))
                _mprSettingsManager.AxialSliceAppearance.SetSettings(visualMprSlice);

            // update MPR tool
            _mprSettingsManager.SetMprToolSettings(_dicomMprTool.MprImageTool);
        }

        #endregion

        #endregion



        #region Delegates

        delegate void ChangePageDelegate();

        #endregion

    }
}
