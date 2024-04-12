using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Gif;

namespace DemosCommonCode.Imaging.Codecs.Dialogs
{
    /// <summary>
    /// A form that allows to view and edit the GIF encoder settings.
    /// </summary>
    public partial class GifEncoderSettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="GifEncoderSettingsForm"/> class.
        /// </summary>
        public GifEncoderSettingsForm()
        {
            InitializeComponent();

            createPageMethodComboBox.Items.Add(CreatePageMethod.UseGlobalOrLocalPalette);
            createPageMethodComboBox.Items.Add(CreatePageMethod.UseOnlyGlobalPalette);
        }

        #endregion



        #region Properties

        #region PUBLIC

        GifEncoderSettings _encoderSettings;
        /// <summary>
        /// Gets or sets a GIF encoder settings.
        /// </summary>
        public GifEncoderSettings EncoderSettings
        {
            get
            {
                return _encoderSettings;
            }
            set
            {
                if (value == null)
                    throw new ArgumentOutOfRangeException();
                if (_encoderSettings != value)
                {
                    _encoderSettings = value;
                    UpdateUI();
                }
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether encoder can add images to the existing GIF file.
        /// </summary>
        /// <value>
        /// <b>True</b> - encoder can add images to the existing GIF file;
        /// <b>false</b> - encoder can NOT add images to the existing GIF file.
        /// </value>
        public bool CanAddImagesToExistingFile
        {
            get
            {
                return addImagesToExistingFileCheckBox.Enabled;
            }
            set
            {
                addImagesToExistingFileCheckBox.Enabled = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether encoder must add images to the existing GIF file.
        /// </summary>
        /// <value>
        /// <b>True</b> - encoder must add images to the existing GIF file;
        /// <b>false</b> - encoder must delete the existing GIF file if necessary, create new GIF file and add images to the new GIF file.
        /// </value>
        public bool AddImagesToExistingFile
        {
            get
            {
                return addImagesToExistingFileCheckBox.Checked;
            }
            set
            {
                addImagesToExistingFileCheckBox.Checked = value;
            }
        }

        #endregion


        #region PRIVATE

        /// <summary>
        /// Gets or sets the align modes for GIF pages.
        /// </summary>
        private PageAlignMode ImagesAlign
        {
            get
            {
                if (centerPositionRadioButton.Checked)
                    return PageAlignMode.Center;
                if (leftTopPositionRadioButton.Checked)
                    return PageAlignMode.LeftTop;
                if (topPositionRadioButton.Checked)
                    return PageAlignMode.Top;
                if (rightTopPositionRadioButton.Checked)
                    return PageAlignMode.RightTop;
                if (rightPositionRadioButton.Checked)
                    return PageAlignMode.Right;
                if (rightBottomPositionRadioButton.Checked)
                    return PageAlignMode.RightButtom;
                if (bottomPositionRadioButton.Checked)
                    return PageAlignMode.Bottom;
                if (letfBottomPositionRadioButton.Checked)
                    return PageAlignMode.LeftBottom;
                if (leftPositionRadioButton.Checked)
                    return PageAlignMode.Left;
                return PageAlignMode.LeftTop;
            }
            set
            {
                switch (value)
                {
                    case PageAlignMode.Center:
                        centerPositionRadioButton.Checked = true;
                        break;
                    case PageAlignMode.LeftTop:
                        leftTopPositionRadioButton.Checked = true;
                        break;
                    case PageAlignMode.Top:
                        topPositionRadioButton.Checked = true;
                        break;
                    case PageAlignMode.RightTop:
                        rightTopPositionRadioButton.Checked = true;
                        break;
                    case PageAlignMode.Right:
                        rightPositionRadioButton.Checked = true;
                        break;
                    case PageAlignMode.RightButtom:
                        rightBottomPositionRadioButton.Checked = true;
                        break;
                    case PageAlignMode.Bottom:
                        bottomPositionRadioButton.Checked = true;
                        break;
                    case PageAlignMode.LeftBottom:
                        letfBottomPositionRadioButton.Checked = true;
                        break;
                    case PageAlignMode.Left:
                        leftPositionRadioButton.Checked = true;
                        break;
                }
            }
        }

        #endregion

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Creates the encoder settings.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (EncoderSettings == null)
                EncoderSettings = new GifEncoderSettings();
        }

        #endregion


        #region PRIVATE

        #region UI

        /// <summary>
        /// Handles the CheckedChanged event of autoSizeCheckBox object.
        /// </summary>
        private void autoSizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // if logical screen must be disabled
            if (autoSizeCheckBox.Checked)
            {
                logicalScreenWidthNumericUpDown.Enabled = false;
                logicalScreenHeightNumericUpDown.Enabled = false;
                logicalScreenWidthNumericUpDown.Value = 0;
                logicalScreenHeightNumericUpDown.Value = 0;
            }
            else
            {
                logicalScreenWidthNumericUpDown.Enabled = true;
                logicalScreenHeightNumericUpDown.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of infiniteAnimationCheckBox object.
        /// </summary>
        private void infiniteAnimationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // if animation must be infinity
            if (infiniteAnimationCheckBox.Checked)
            {
                animationCyclesNumericUpDown.Enabled = false;
                animationCyclesNumericUpDown.Value = 0;
            }
            else
            {
                animationCyclesNumericUpDown.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the Click event of buttonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            // update encoder settings
            SetEncoderSettings();
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of buttonCancel object.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        #endregion


        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            createPageMethodComboBox.SelectedItem = _encoderSettings.CreatePageMethod;

            infiniteAnimationCheckBox.Checked = _encoderSettings.InfiniteAnimation;
            animationCyclesNumericUpDown.Value = _encoderSettings.NumberOfAnimationCycles;

            animationDelayNumericUpDown.Value = _encoderSettings.AnimationDelay;

            autoSizeCheckBox.Checked = _encoderSettings.LogicalScreenWidth == 0 && _encoderSettings.LogicalScreenHeight == 0;
            logicalScreenWidthNumericUpDown.Value = _encoderSettings.LogicalScreenWidth;
            logicalScreenHeightNumericUpDown.Value = _encoderSettings.LogicalScreenHeight;

            ImagesAlign = _encoderSettings.PageAlign;
        }

        /// <summary>
        /// Updates the encoder settings.
        /// </summary>
        private void SetEncoderSettings()
        {
            _encoderSettings.CreatePageMethod = (CreatePageMethod)createPageMethodComboBox.SelectedItem;

            _encoderSettings.NumberOfAnimationCycles = (int)animationCyclesNumericUpDown.Value;
            _encoderSettings.InfiniteAnimation = infiniteAnimationCheckBox.Checked;

            _encoderSettings.AnimationDelay = (int)animationDelayNumericUpDown.Value;

            _encoderSettings.LogicalScreenWidth = (int)logicalScreenWidthNumericUpDown.Value;
            _encoderSettings.LogicalScreenHeight = (int)logicalScreenHeightNumericUpDown.Value;

            _encoderSettings.PageAlign = ImagesAlign;
        }

        #endregion

        #endregion

    }
}
