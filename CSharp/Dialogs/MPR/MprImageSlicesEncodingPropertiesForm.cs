using System;
using System.Windows.Forms;

using Vintasoft.Imaging.Codecs.Encoders;

using DemosCommonCode.Imaging.Codecs.Dialogs;


namespace DicomMprViewerDemo
{
    /// <summary>
    /// A form that allows to view and edit the MPR slice image encoding settings.
    /// </summary>
    public partial class MprImageSlicesEncodingPropertiesForm : Form
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MprImageSlicesEncodingPropertiesForm"/> class.
        /// </summary>
        public MprImageSlicesEncodingPropertiesForm()
        {
            InitializeComponent();

            imageFormatComboBox.SelectedIndex = 1;
        }

        #endregion



        #region Properties

        /// <summary>
        /// Gets a value indicating whether the VOI LUT must be applied to MPR slice image.
        /// </summary>
        /// <value>
        /// <b>true</b> if the VOI LUT is applied to MPR slice image; otherwise, <b>false</b>.
        /// </value>
        public bool ApplyVoiLutToMprImageSlices
        {
            get
            {
                return applyVoiLutToImageSlicesCheckBox.Checked;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the MPR slice image pixel format must be Gray16.
        /// </summary>
        /// <value>
        /// <b>true</b> if the MPR slice image pixel format is Gray16; otherwise, <b>false</b>.
        /// </value>
        public bool UseGray16MprImages
        {
            get
            {
                return imageFormatComboBox.SelectedIndex == 1;
            }
        }

        TiffEncoderSettings _tiffEncoderSettings = new TiffEncoderSettings();
        /// <summary>
        /// Gets the TIFF encoder settings.
        /// </summary>
        public TiffEncoderSettings TiffEncoderSettings
        {
            get
            {
                return _tiffEncoderSettings;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Shows the TIFF encoder settings dialog.
        /// </summary>
        private void tiffEncoderSettingsButton_Click(object sender, EventArgs e)
        {
            using (TiffEncoderSettingsForm dlg = new TiffEncoderSettingsForm())
            {
                dlg.StartPosition = FormStartPosition.CenterParent;
                dlg.Owner = this;
                dlg.EncoderSettings = _tiffEncoderSettings;
                dlg.EditAnnotationSettings = false;
                dlg.CanAddImagesToExistingFile = false;

                dlg.ShowDialog();
            }
        }

        #endregion

    }
}
