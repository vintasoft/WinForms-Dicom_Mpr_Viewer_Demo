using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Bmp;


namespace DemosCommonCode.Imaging.Codecs.Dialogs
{
    /// <summary>
    /// A form that allows to view and edit the BMP encoder settings.
    /// </summary>
    public partial class BmpEncoderSettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BmpEncoderSettingsForm"/> class.
        /// </summary>
        public BmpEncoderSettingsForm()
        {
            InitializeComponent();

            foreach (BmpCompression compression in Enum.GetValues(typeof(BmpCompression)))
            {
                if (compression == BmpCompression.Unsupported)
                    continue;

                compressionComboBox.Items.Add(compression);
            }

            EncoderSettings = new BmpEncoderSettings();
        }

        #endregion
        


        #region Properties

        BmpEncoderSettings _encoderSettings = null;
        /// <summary>
        /// Gets or sets the settings of BMP encoder.
        /// </summary>
        public BmpEncoderSettings EncoderSettings
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

                    compressionComboBox.SelectedItem = _encoderSettings.Compression;
                }
            }
        } 

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of OkButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            // update compression
            _encoderSettings.Compression = (BmpCompression)compressionComboBox.SelectedItem;
        }

        #endregion

    }
}
