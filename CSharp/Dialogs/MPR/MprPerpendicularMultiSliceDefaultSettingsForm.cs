using System;
using System.Windows.Forms;

using Vintasoft.Imaging;
using Vintasoft.Imaging.Dicom.Mpr;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// A form that allows to change the default settings of <see cref="MprPerpendicularMultiSlice"/>.
    /// </summary>
    public partial class MprPerpendicularMultiSliceDefaultSettingsForm : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MprPerpendicularMultiSliceDefaultSettingsForm"/> class.
        /// </summary>
        public MprPerpendicularMultiSliceDefaultSettingsForm()
        {
            InitializeComponent();

            sliceCountNumericUpDown.Value = MprPerpendicularMultiSlice.DefaultSliceCount;
            planarSliceMarginPaddingFEditorControl.PaddingValue =
                VintasoftDrawingConverter.Convert(MprPerpendicularMultiSlice.DefaultPlanarSliceMargin);
        }



        /// <summary>
        /// Handles the Click event of okButton object.
        /// </summary>
        private void okButton_Click(object sender, EventArgs e)
        {
            MprPerpendicularMultiSlice.DefaultSliceCount = (int)sliceCountNumericUpDown.Value;
            MprPerpendicularMultiSlice.DefaultPlanarSliceMargin =
                VintasoftDrawingConverter.Convert(planarSliceMarginPaddingFEditorControl.PaddingValue);
        }

    }
}
