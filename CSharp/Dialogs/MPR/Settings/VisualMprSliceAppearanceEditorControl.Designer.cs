namespace DicomMprViewerDemo
{
    partial class VisualMprSliceAppearanceEditorControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.sliceLineWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.markerPointDiameterNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sliceColorPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.appearanceGroupBox = new System.Windows.Forms.GroupBox();
            this.propertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.curveTensionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.curveTensionLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.thicknessNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.renderingModeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliceLineWidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markerPointDiameterNumericUpDown)).BeginInit();
            this.appearanceGroupBox.SuspendLayout();
            this.propertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curveTensionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slice Color";
            // 
            // sliceLineWidthNumericUpDown
            // 
            this.sliceLineWidthNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliceLineWidthNumericUpDown.Location = new System.Drawing.Point(130, 51);
            this.sliceLineWidthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sliceLineWidthNumericUpDown.Name = "sliceLineWidthNumericUpDown";
            this.sliceLineWidthNumericUpDown.Size = new System.Drawing.Size(145, 20);
            this.sliceLineWidthNumericUpDown.TabIndex = 2;
            this.sliceLineWidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sliceLineWidthNumericUpDown.ValueChanged += new System.EventHandler(this.sliceLineWidthNumericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Slice Line Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marker Point Diameter";
            // 
            // markerPointDiameterNumericUpDown
            // 
            this.markerPointDiameterNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.markerPointDiameterNumericUpDown.Location = new System.Drawing.Point(130, 79);
            this.markerPointDiameterNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.markerPointDiameterNumericUpDown.Name = "markerPointDiameterNumericUpDown";
            this.markerPointDiameterNumericUpDown.Size = new System.Drawing.Size(145, 20);
            this.markerPointDiameterNumericUpDown.TabIndex = 5;
            this.markerPointDiameterNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.markerPointDiameterNumericUpDown.ValueChanged += new System.EventHandler(this.markerPointDiameterNumericUpDown_ValueChanged);
            // 
            // sliceColorPanelControl
            // 
            this.sliceColorPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliceColorPanelControl.CanEditAlphaChannel = false;
            this.sliceColorPanelControl.Color = System.Drawing.Color.Transparent;
            this.sliceColorPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.sliceColorPanelControl.Location = new System.Drawing.Point(130, 21);
            this.sliceColorPanelControl.Name = "sliceColorPanelControl";
            this.sliceColorPanelControl.Size = new System.Drawing.Size(145, 22);
            this.sliceColorPanelControl.TabIndex = 0;
            this.sliceColorPanelControl.ColorChanged += new System.EventHandler(this.sliceColorPanelControl_ColorChanged);
            // 
            // appearanceGroupBox
            // 
            this.appearanceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appearanceGroupBox.Controls.Add(this.label2);
            this.appearanceGroupBox.Controls.Add(this.sliceColorPanelControl);
            this.appearanceGroupBox.Controls.Add(this.label1);
            this.appearanceGroupBox.Controls.Add(this.markerPointDiameterNumericUpDown);
            this.appearanceGroupBox.Controls.Add(this.sliceLineWidthNumericUpDown);
            this.appearanceGroupBox.Controls.Add(this.label3);
            this.appearanceGroupBox.Location = new System.Drawing.Point(1, 3);
            this.appearanceGroupBox.Name = "appearanceGroupBox";
            this.appearanceGroupBox.Size = new System.Drawing.Size(281, 107);
            this.appearanceGroupBox.TabIndex = 8;
            this.appearanceGroupBox.TabStop = false;
            this.appearanceGroupBox.Text = "Appearance";
            // 
            // propertiesGroupBox
            // 
            this.propertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.propertiesGroupBox.Controls.Add(this.curveTensionNumericUpDown);
            this.propertiesGroupBox.Controls.Add(this.curveTensionLabel);
            this.propertiesGroupBox.Controls.Add(this.label7);
            this.propertiesGroupBox.Controls.Add(this.thicknessNumericUpDown);
            this.propertiesGroupBox.Controls.Add(this.renderingModeComboBox);
            this.propertiesGroupBox.Controls.Add(this.label6);
            this.propertiesGroupBox.Controls.Add(this.label5);
            this.propertiesGroupBox.Location = new System.Drawing.Point(1, 116);
            this.propertiesGroupBox.Name = "propertiesGroupBox";
            this.propertiesGroupBox.Size = new System.Drawing.Size(281, 104);
            this.propertiesGroupBox.TabIndex = 9;
            this.propertiesGroupBox.TabStop = false;
            this.propertiesGroupBox.Text = "Properties";
            // 
            // curveTensionNumericUpDown
            // 
            this.curveTensionNumericUpDown.DecimalPlaces = 2;
            this.curveTensionNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.curveTensionNumericUpDown.Location = new System.Drawing.Point(130, 20);
            this.curveTensionNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.curveTensionNumericUpDown.Name = "curveTensionNumericUpDown";
            this.curveTensionNumericUpDown.Size = new System.Drawing.Size(145, 20);
            this.curveTensionNumericUpDown.TabIndex = 14;
            this.curveTensionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.curveTensionNumericUpDown.ValueChanged += new System.EventHandler(this.curveTensionNumericUpDown_ValueChanged);
            // 
            // curveTensionLabel
            // 
            this.curveTensionLabel.AutoSize = true;
            this.curveTensionLabel.Location = new System.Drawing.Point(6, 24);
            this.curveTensionLabel.Name = "curveTensionLabel";
            this.curveTensionLabel.Size = new System.Drawing.Size(76, 13);
            this.curveTensionLabel.TabIndex = 13;
            this.curveTensionLabel.Text = "Curve Tension";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "mm";
            // 
            // thicknessNumericUpDown
            // 
            this.thicknessNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thicknessNumericUpDown.Location = new System.Drawing.Point(130, 77);
            this.thicknessNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.thicknessNumericUpDown.Name = "thicknessNumericUpDown";
            this.thicknessNumericUpDown.Size = new System.Drawing.Size(116, 20);
            this.thicknessNumericUpDown.TabIndex = 11;
            this.thicknessNumericUpDown.ValueChanged += new System.EventHandler(this.thicknessNumericUpDown_ValueChanged);
            // 
            // renderingModeComboBox
            // 
            this.renderingModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.renderingModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.renderingModeComboBox.FormattingEnabled = true;
            this.renderingModeComboBox.Location = new System.Drawing.Point(130, 48);
            this.renderingModeComboBox.Name = "renderingModeComboBox";
            this.renderingModeComboBox.Size = new System.Drawing.Size(145, 21);
            this.renderingModeComboBox.TabIndex = 10;
            this.renderingModeComboBox.SelectedIndexChanged += new System.EventHandler(this.renderingModeComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rendering Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thickness";
            // 
            // VisualMprSliceAppearanceEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.propertiesGroupBox);
            this.Controls.Add(this.appearanceGroupBox);
            this.Name = "VisualMprSliceAppearanceEditorControl";
            this.Size = new System.Drawing.Size(285, 223);
            ((System.ComponentModel.ISupportInitialize)(this.sliceLineWidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markerPointDiameterNumericUpDown)).EndInit();
            this.appearanceGroupBox.ResumeLayout(false);
            this.appearanceGroupBox.PerformLayout();
            this.propertiesGroupBox.ResumeLayout(false);
            this.propertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.curveTensionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thicknessNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DemosCommonCode.CustomControls.ColorPanelControl sliceColorPanelControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sliceLineWidthNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown markerPointDiameterNumericUpDown;
        private System.Windows.Forms.GroupBox appearanceGroupBox;
        private System.Windows.Forms.GroupBox propertiesGroupBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown thicknessNumericUpDown;
        private System.Windows.Forms.ComboBox renderingModeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown curveTensionNumericUpDown;
        private System.Windows.Forms.Label curveTensionLabel;
    }
}