using System;
using System.ComponentModel;
using System.Windows.Forms;

using Vintasoft.Imaging.Dicom.Mpr;

namespace DicomMprViewerDemo
{
    /// <summary>
    /// A control that allows to change the slice appearance settings.
    /// </summary>
    public partial class VisualMprSliceAppearanceEditorControl : UserControl
    {

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VisualMprSliceAppearanceEditorControl"/> class.
        /// </summary>
        public VisualMprSliceAppearanceEditorControl()
        {
            InitializeComponent();

            Init();
        }

        #endregion



        #region Properties

        VisualMprSliceAppearanceSettings _sliceSettings;
        /// <summary>
        /// Gets or sets the slice settings.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public VisualMprSliceAppearanceSettings SliceSettings
        {
            get
            {
                return _sliceSettings;
            }
            set
            {
                _sliceSettings = value;
                UpdateUI();
            }
        }

        bool _showCurvilinearSliceSettings = false;
        /// <summary>
        /// Gets or set a value indicating whether the control should show settings for curvilinear slice.
        /// </summary>
        /// <value>
        /// <b>True</b> - the control should show settings for curvilinear slice;
        /// <b>false</b> - the control should NOT show settings for curvilinear slice.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowCurvilinearSliceSettings
        {
            get
            {
                return _showCurvilinearSliceSettings;
            }
            set
            {
                _showCurvilinearSliceSettings = value;
                UpdateUI();
            }
        }

        bool _showPerpendicularMultiSliceSettings = false;
        /// <summary>
        /// Gets or set a value indicating whether the control should show settings for perpendicular multi slice.
        /// </summary>
        /// <value>
        /// <b>True</b> - the control should show settings for perpendicular multi slice;
        /// <b>false</b> - the control should NOT show settings for perpendicular multi slice.
        /// </value>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool ShowPerpendicularMultiSliceSettings
        {
            get
            {
                return _showPerpendicularMultiSliceSettings;
            }
            set
            {
                _showPerpendicularMultiSliceSettings = value;
                UpdateUI();
            }
        }

        #endregion



        #region Mehtods

        /// <summary>
        /// Initializes the control.
        /// </summary>
        private void Init()
        {
            // init rendering mode combo box values
            foreach (MprSliceRenderingMode renderingMode in Enum.GetValues(typeof(MprSliceRenderingMode)))
                renderingModeComboBox.Items.Add(renderingMode);
            renderingModeComboBox.SelectedIndex = 0;

            UpdateUI();
        }

        /// <summary>
        /// Updates the user interface.
        /// </summary>
        private void UpdateUI()
        {
            if (SliceSettings != null)
            {
                sliceColorPanelControl.Color = SliceSettings.SliceColor;
                sliceLineWidthNumericUpDown.Value = (decimal)SliceSettings.SliceLineWidth;
                focusedSliceColorPanelControl.Color = SliceSettings.FocusedSliceColor;
                focusedSliceLineWidthNumericUpDown.Value = (decimal)SliceSettings.FocusedSliceLineWidth;
                markerPointDiameterNumericUpDown.Value = (decimal)SliceSettings.MarkerPointDiameter;
                thicknessNumericUpDown.Value = (decimal)SliceSettings.Thickness;
                renderingModeComboBox.SelectedItem = SliceSettings.RenderingMode;
                curveTensionNumericUpDown.Value = (decimal)SliceSettings.CurveTension;
                sliceCountNumericUpDown.Value = (decimal)SliceSettings.SliceCount;
            }

            if ((MprSliceRenderingMode)renderingModeComboBox.SelectedItem == MprSliceRenderingMode.MPR)
            {
                thicknessNumericUpDown.Enabled = false;
            }
            else
            {
                thicknessNumericUpDown.Enabled = true;
            }

            if (ShowCurvilinearSliceSettings)
            {
                curveTensionLabel.Enabled = true;
                curveTensionNumericUpDown.Enabled = true;
            }
            else
            {
                curveTensionNumericUpDown.Enabled = false;
                curveTensionLabel.Enabled = false;
            }

            if (ShowPerpendicularMultiSliceSettings)
            {
                sliceCountLabel.Enabled = true;
                sliceCountNumericUpDown.Enabled = true;
                focusedSliceColorPanelControl.Enabled = true;
                focusedSliceLineWidthNumericUpDown.Enabled = true;
            }
            else
            {
                sliceCountLabel.Enabled = false;
                sliceCountNumericUpDown.Enabled = false;
                focusedSliceColorPanelControl.Enabled = false;
                focusedSliceLineWidthNumericUpDown.Enabled = false;
            }

            propertiesGroupBox.Refresh();
        }

        /// <summary>
        /// Slice color is changed.
        /// </summary>
        private void sliceColorPanelControl_ColorChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
                SliceSettings.SliceColor = sliceColorPanelControl.Color;
        }

        /// <summary>
        /// Slice line width is changed.
        /// </summary>
        private void sliceLineWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
                SliceSettings.SliceLineWidth = (float)sliceLineWidthNumericUpDown.Value;
        }

        /// <summary>
        /// Handles the ColorChanged event of focusedSliceColorPanelControl object.
        /// </summary>
        private void focusedSliceColorPanelControl_ColorChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
                SliceSettings.FocusedSliceColor = focusedSliceColorPanelControl.Color;
        }

        /// <summary>
        /// Handles the ValueChanged event of focusedSliceLineWidthNumericUpDown object.
        /// </summary>
        private void focusedSliceLineWidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
                SliceSettings.FocusedSliceLineWidth = (float)focusedSliceLineWidthNumericUpDown.Value;
        }

        /// <summary>
        /// Marker point diameter is changed.
        /// </summary>
        private void markerPointDiameterNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
                SliceSettings.MarkerPointDiameter = (float)markerPointDiameterNumericUpDown.Value;
        }

        /// <summary>
        /// Slice thickness is changed.
        /// </summary>
        private void thicknessNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
                SliceSettings.Thickness = (float)thicknessNumericUpDown.Value;
        }

        /// <summary>
        /// MPR image slice rendering mode is changed.
        /// </summary>
        private void renderingModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
            {
                SliceSettings.RenderingMode = (MprSliceRenderingMode)renderingModeComboBox.SelectedItem;

                if (SliceSettings.RenderingMode == MprSliceRenderingMode.MPR)
                    thicknessNumericUpDown.Enabled = false;
                else
                    thicknessNumericUpDown.Enabled = true;
            }
        }

        /// <summary>
        /// Curve tension is changed.
        /// </summary>
        private void curveTensionNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
            {
                SliceSettings.CurveTension = (double)curveTensionNumericUpDown.Value;
            }
        }

        /// <summary>
        /// Handles the ValueChanged event of sliceCountNumericUpDown object.
        /// </summary>
        private void sliceCountNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (SliceSettings != null)
            {
                SliceSettings.SliceCount = (int)sliceCountNumericUpDown.Value;
            }
        }

        #endregion
    }
}
