using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Encoders;
using Vintasoft.Imaging.Codecs.ImageFiles.Pbm;

namespace DemosCommonCode.Imaging.Codecs.Dialogs
{
    /// <summary>
    /// A form that allows to view and edit the PBM encoder settings.
    /// </summary>
    public partial class PbmEncoderSettingsForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PbmEncoderSettingsForm"/> class.
        /// </summary>
        public PbmEncoderSettingsForm()
        {
            InitializeComponent();

            foreach (PbmEncoding encoding in Enum.GetValues(typeof(PbmEncoding)))
            {
                encodingComboBox.Items.Add(encoding);
            }

            EncoderSettings = new PbmEncoderSettings();
        }

        #endregion
        


        #region Properties

        PbmEncoderSettings _encoderSettings = null;
        /// <summary>
        /// Gets or sets the settings of PBM encoder.
        /// </summary>
        public PbmEncoderSettings EncoderSettings
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

                    encodingComboBox.SelectedItem = _encoderSettings.Encoding;
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
            // update encoding
            _encoderSettings = new PbmEncoderSettings((PbmEncoding)encodingComboBox.SelectedItem);
        }

        #endregion

    }
}
