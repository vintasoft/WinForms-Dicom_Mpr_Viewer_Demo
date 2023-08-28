using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Encoders;
#if NETCOREAPP
using Vintasoft.Imaging.Codecs.Webp;
#endif

namespace DemosCommonCode.Imaging.Codecs.Dialogs
{
    /// <summary>
    /// A form that allows to view and edit the WEBP encoder settings.
    /// </summary>
    public partial class WebpEncoderSettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="WebpEncoderSettingsForm"/> class.
        /// </summary>
        public WebpEncoderSettingsForm()
        {
            InitializeComponent();

#if NETCOREAPP
            for (int i = 0; i < 7; i++)
            {
                WebpEncodingMethod encoding = (WebpEncodingMethod)i;
                encodingComboBox.Items.Add(encoding);
            }

            foreach (WebpTransparentColorMode transparent in Enum.GetValues(typeof(WebpTransparentColorMode)))
            {
                transparentComboBox.Items.Add(transparent);
            }

            EncoderSettings = new WebpEncoderSettings();

            nearLosslessQualityNumericUpDown.Enabled = false;
            lossyGroupBox.Enabled = false;
            lossyGroupBox.Visible = false;
#endif
        }

        #endregion



        #region Properties

#if NETCOREAPP
        WebpEncoderSettings _encoderSettings = null;
        /// <summary>
        /// Gets or sets the settings of WEBP encoder.
        /// </summary>
        public WebpEncoderSettings EncoderSettings
        {
            get
            {
                return _encoderSettings;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                if (!object.Equals(_encoderSettings, value))
                {
                    _encoderSettings = value;

                    encodingComboBox.SelectedItem = _encoderSettings.Method;
                    transparentComboBox.SelectedItem = _encoderSettings.TransparentColorMode;
                }
            }
        }
#endif

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of ButtonOk object.
        /// </summary>
        private void buttonOk_Click(object sender, EventArgs e)
        {
#if NETCOREAPP
            _encoderSettings.Method = (WebpEncodingMethod)encodingComboBox.SelectedItem;
            _encoderSettings.TransparentColorMode = (WebpTransparentColorMode)transparentComboBox.SelectedItem;
            _encoderSettings.Quality = (int)qualityNumericUpDown.Value;
            _encoderSettings.NearLosslessQuality = (int)nearLosslessQualityNumericUpDown.Value;
            _encoderSettings.FilterStrength = (int)filtersStrengthNumericUpDown.Value;
            _encoderSettings.SpatialNoiseShaping = (int)spatialNoiseShapingNumericUpDown.Value;
            _encoderSettings.EntropyPasses = (int)entropyPassesNumericUpDown.Value;
            _encoderSettings.NearLossless = nearLosslessCheckBox.Checked;

            if (losslessRadioButton.Checked)
            {
                _encoderSettings.FileType = WebpFileFormatType.Lossless;
            }
            else
            {
                _encoderSettings.FileType = WebpFileFormatType.Lossy;
            }
#endif

            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Handles the Click event of ButtonCancel object.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        #region Format

        /// <summary>
        /// Handles the CheckedChanged event of LosslessRadioButton object.
        /// </summary>
        private void losslessRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (losslessRadioButton.Checked)
            {
                losslessGroupBox.Enabled = true;
                losslessGroupBox.Visible = true;
                lossyGroupBox.Enabled = false;
                lossyGroupBox.Visible = false;
                lossyRadioButton.Checked = false;
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of LossyRadioButton object.
        /// </summary>
        private void lossyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (lossyRadioButton.Checked)
            {
                lossyGroupBox.Enabled = true;
                lossyGroupBox.Visible = true;
                losslessGroupBox.Enabled = false;
                losslessGroupBox.Visible = false;
                losslessRadioButton.Checked = false;
            }
        }

        #endregion


        #region Lossless

        /// <summary>
        /// Handles the CheckedChanged event of NearLosslessCheckBox object.
        /// </summary>
        private void nearLosslessCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nearLosslessQualityNumericUpDown.Enabled = nearLosslessCheckBox.Checked;
        }

        #endregion

        #endregion

    }
}
