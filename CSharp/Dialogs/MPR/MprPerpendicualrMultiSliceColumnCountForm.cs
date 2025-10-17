using System.ComponentModel;
using System.Windows.Forms;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// A form that allows to change the count of perpendicular multi slice columns.
    /// </summary>
    public partial class MprPerpendicualrMultiSliceColumnCountForm : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MprPerpendicualrMultiSliceColumnCountForm"/> class.
        /// </summary>
        public MprPerpendicualrMultiSliceColumnCountForm()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Gets or sets the column count.
        /// </summary>
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int ColumnCount
        {
            get
            {
                return (int)columnCountNumericUpDown.Value;
            }
            set
            {
                columnCountNumericUpDown.Value = value;
            }
        }

    }
}
