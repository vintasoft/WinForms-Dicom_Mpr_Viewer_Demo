using System;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Encoders;


namespace DemosCommonCode.Imaging.Codecs.Dialogs
{
    /// <summary>
    /// A form that allows to view and edit the SVG encoder settings.
    /// </summary>
    public partial class SvgEncoderSettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SvgEncoderSettingsForm"/> class.
        /// </summary>
        public SvgEncoderSettingsForm()
        {
            InitializeComponent();

            pngEncoderSettingsGroupBox.Visible = false;
            jpegEncoderSettingsGroupBox.Visible = false;

            encoderNameComboBox.Items.Add("PNG");
            encoderNameComboBox.Items.Add("JPEG");

            pngSettingsComboBox.Items.Add("Fast");
            pngSettingsComboBox.Items.Add("Best Speed");
            pngSettingsComboBox.Items.Add("Normal");
            pngSettingsComboBox.Items.Add("Best Compression");
        }

        #endregion



        #region Properties

        SvgEncoderSettings _encoderSettings = null;
        /// <summary>
        /// Gets or sets the settings of SVG encoder.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SvgEncoderSettings EncoderSettings
        {
            get
            {
                return _encoderSettings;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("value");

                if (_encoderSettings != value)
                {
                    _encoderSettings = value;

                    UpdateUI();
                }
            }
        }

        #endregion



        #region Methods

        #region PROTECTED

        /// <summary>
        /// Form is loaded.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (EncoderSettings == null)
                EncoderSettings = new SvgEncoderSettings();
        }

        #endregion


        #region PRIVATE

        #region UI

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            // update encoder
            string selectedEncoder = encoderNameComboBox.SelectedItem.ToString();
            switch (selectedEncoder)
            {
                case "PNG":
                    PngEncoder pngEncoder = new PngEncoder();

                    // set encoder settings
                    PngEncoderSettings pngSettings = GetPngEncoderSettings(pngSettingsComboBox.SelectedItem.ToString());                    
                    pngEncoder.Settings.FilterMethod = pngSettings.FilterMethod;
                    pngEncoder.Settings.CompressionLevel = pngSettings.CompressionLevel;

                    EncoderSettings.EmbeddedImageEncoder = pngEncoder;
                    break;

                case "JPEG":
                    // set encoder settings
                    JpegEncoderSettings jpegSettings = new JpegEncoderSettings();
                    jpegSettings.Quality = (int)jpegQualityNumericUpDown.Value;
                    jpegSettings.SaveAsGrayscale = jpegGrayscaleCheckBox.Checked;

                    JpegEncoder jpegEncoder = new JpegEncoder(jpegSettings);
                    EncoderSettings.EmbeddedImageEncoder = jpegEncoder;
                    break;
            }

            EncoderSettings.AllowExternalFonts = allowExternalFontsCheckBox.Checked;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of encoderNameComboBox object.
        /// </summary>
        private void encoderNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedEncoder = encoderNameComboBox.SelectedItem.ToString();
            if (selectedEncoder == "PNG")
            {
                pngEncoderSettingsGroupBox.Visible = true;
                jpegEncoderSettingsGroupBox.Visible = false;
                pngSettingsComboBox.SelectedItem = "Normal";
            }
            else if (selectedEncoder == "JPEG")
            {
                jpegEncoderSettingsGroupBox.Visible = true;
                pngEncoderSettingsGroupBox.Visible = false;
            }
        }

        #endregion


        /// <summary>
        /// Updates the user interface of this form.
        /// </summary>
        private void UpdateUI()
        {
            if (EncoderSettings.EmbeddedImageEncoder == null)
            {
                encoderNameComboBox.SelectedItem = "PNG";
            }
            else
            {
                encoderNameComboBox.SelectedItem = EncoderSettings.EmbeddedImageEncoder.Name.ToUpper();
            }

            allowExternalFontsCheckBox.Checked = EncoderSettings.AllowExternalFonts;
        }

        /// <summary>
        /// Returns an instance of <see cref="PngEncoderSettings"> 
        /// with the default settings, specified by settings name.
        /// </summary>
        /// <param name="settingsName">PNG encoder settings name.</param>
        /// <returns>
        /// An instance of <see cref="PngEncoderSettings"> with 
        /// the default settings, specified by settings name.
        /// </returns>
        private PngEncoderSettings GetPngEncoderSettings(string settingsName)
        {
            switch (settingsName)
            {
                case "Fast":
                    return PngEncoderSettings.Fast;
                case "Best Speed":
                    return PngEncoderSettings.BestSpeed;
                case "Normal":
                    return PngEncoderSettings.Normal;
                case "Best Compression":
                    return PngEncoderSettings.BestCompression;
            }

            encoderNameComboBox.SelectedItem = "Normal";
            return PngEncoderSettings.Normal;
        }

        #endregion

        #endregion

    }
}
