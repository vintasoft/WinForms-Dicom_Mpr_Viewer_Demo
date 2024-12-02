using System;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Tga;

namespace DemosCommonCode.Imaging.Codecs.Dialogs
{
    /// <summary>
    /// A form that allows to view and edit the TGA encoder settings.
    /// </summary>
    public partial class TgaEncoderSettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TgaEncoderSettingsForm"/> class.
        /// </summary>
        public TgaEncoderSettingsForm()
        {
            InitializeComponent();

            foreach (TgaCompression compression in Enum.GetValues(typeof(TgaCompression)))
            {
                compressionComboBox.Items.Add(compression);
            }
            foreach (TgaImageOrigin origin in Enum.GetValues(typeof(TgaImageOrigin)))
            {
                originComboBox.Items.Add(origin);
            }

            EncoderSettings = new TgaEncoderSettings();
        }

        #endregion



        #region Properties

        TgaEncoderSettings _encoderSettings = null;
        /// <summary>
        /// Gets or sets the settings of TGA encoder.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TgaEncoderSettings EncoderSettings
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
                    originComboBox.SelectedItem = _encoderSettings.ImageOrigin;
                }
            }
        } 

        #endregion



        #region Methods

        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            _encoderSettings = new TgaEncoderSettings(
                (TgaCompression)compressionComboBox.SelectedItem, 
                (TgaImageOrigin)originComboBox.SelectedItem);
        }

        #endregion

    }
}
