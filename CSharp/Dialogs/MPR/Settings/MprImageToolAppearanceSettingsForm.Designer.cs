namespace DicomMprViewerDemo
{
    partial class MprImageToolAppearanceSettingsForm
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
            this.sliceSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.sliceTypePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sliceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sliceAppearanceEditorControl = new DicomMprViewerDemo.VisualMprSliceAppearanceEditorControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorMarkVisibleCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.focusedImageViewerMarkSizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorMarkHeigthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorMarkWidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.colorMarkGroupBox = new System.Windows.Forms.GroupBox();
            this.colorMarkAnchorTypeEditor = new DemosCommonCode.CustomControls.AnchorTypeEditorControl();
            this.focusedImageViewerColorMarkPanelControl = new DemosCommonCode.CustomControls.ColorPanelControl();
            this.visualizationPerformanceGroupBox = new System.Windows.Forms.GroupBox();
            this.limitMaxFpsCheckBox = new System.Windows.Forms.CheckBox();
            this.complexityThresholdValueEditorControl = new DemosCommonCode.CustomControls.ValueEditorControl();
            this.stepCountValueEditorControl = new DemosCommonCode.CustomControls.ValueEditorControl();
            this.maxFpsValueEditorControl = new DemosCommonCode.CustomControls.ValueEditorControl();
            this.maxThreadValueEditorControl = new DemosCommonCode.CustomControls.ValueEditorControl();
            this.sliceSettingsGroupBox.SuspendLayout();
            this.sliceTypePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.focusedImageViewerMarkSizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMarkHeigthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMarkWidthNumericUpDown)).BeginInit();
            this.colorMarkGroupBox.SuspendLayout();
            this.visualizationPerformanceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliceSettingsGroupBox
            // 
            this.sliceSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliceSettingsGroupBox.Controls.Add(this.sliceTypePanel);
            this.sliceSettingsGroupBox.Controls.Add(this.sliceAppearanceEditorControl);
            this.sliceSettingsGroupBox.Location = new System.Drawing.Point(326, 12);
            this.sliceSettingsGroupBox.Name = "sliceSettingsGroupBox";
            this.sliceSettingsGroupBox.Size = new System.Drawing.Size(302, 302);
            this.sliceSettingsGroupBox.TabIndex = 0;
            this.sliceSettingsGroupBox.TabStop = false;
            this.sliceSettingsGroupBox.Text = "Slice Settings";
            // 
            // sliceTypePanel
            // 
            this.sliceTypePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliceTypePanel.Controls.Add(this.label1);
            this.sliceTypePanel.Controls.Add(this.sliceTypeComboBox);
            this.sliceTypePanel.Location = new System.Drawing.Point(6, 19);
            this.sliceTypePanel.Name = "sliceTypePanel";
            this.sliceTypePanel.Size = new System.Drawing.Size(284, 22);
            this.sliceTypePanel.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slice";
            // 
            // sliceTypeComboBox
            // 
            this.sliceTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliceTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sliceTypeComboBox.FormattingEnabled = true;
            this.sliceTypeComboBox.Location = new System.Drawing.Point(39, 1);
            this.sliceTypeComboBox.Name = "sliceTypeComboBox";
            this.sliceTypeComboBox.Size = new System.Drawing.Size(240, 21);
            this.sliceTypeComboBox.TabIndex = 0;
            this.sliceTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.sliceTypeComboBox_SelectedIndexChanged);
            // 
            // sliceAppearanceEditorControl
            // 
            this.sliceAppearanceEditorControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliceAppearanceEditorControl.Location = new System.Drawing.Point(6, 47);
            this.sliceAppearanceEditorControl.Name = "sliceAppearanceEditorControl";
            this.sliceAppearanceEditorControl.ShowCurvilinearSliceSettings = false;
            this.sliceAppearanceEditorControl.ShowPerpendicularMultiSliceSettings = false;
            this.sliceAppearanceEditorControl.Size = new System.Drawing.Size(288, 249);
            this.sliceAppearanceEditorControl.SliceSettings = null;
            this.sliceAppearanceEditorControl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Focused Image Viewer Color Mark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Focused Image Viewer Mark Size";
            // 
            // colorMarkVisibleCheckBox
            // 
            this.colorMarkVisibleCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorMarkVisibleCheckBox.AutoSize = true;
            this.colorMarkVisibleCheckBox.Location = new System.Drawing.Point(339, 320);
            this.colorMarkVisibleCheckBox.Name = "colorMarkVisibleCheckBox";
            this.colorMarkVisibleCheckBox.Size = new System.Drawing.Size(110, 17);
            this.colorMarkVisibleCheckBox.TabIndex = 3;
            this.colorMarkVisibleCheckBox.Text = "Color Mark Visible";
            this.colorMarkVisibleCheckBox.UseVisualStyleBackColor = true;
            this.colorMarkVisibleCheckBox.CheckedChanged += new System.EventHandler(this.colorMarkVisibleCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Color Mark Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Color Mark Anchor";
            // 
            // focusedImageViewerMarkSizeNumericUpDown
            // 
            this.focusedImageViewerMarkSizeNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.focusedImageViewerMarkSizeNumericUpDown.DecimalPlaces = 2;
            this.focusedImageViewerMarkSizeNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.focusedImageViewerMarkSizeNumericUpDown.Location = new System.Drawing.Point(184, 47);
            this.focusedImageViewerMarkSizeNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.focusedImageViewerMarkSizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.focusedImageViewerMarkSizeNumericUpDown.Name = "focusedImageViewerMarkSizeNumericUpDown";
            this.focusedImageViewerMarkSizeNumericUpDown.Size = new System.Drawing.Size(101, 20);
            this.focusedImageViewerMarkSizeNumericUpDown.TabIndex = 8;
            this.focusedImageViewerMarkSizeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // colorMarkHeigthNumericUpDown
            // 
            this.colorMarkHeigthNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorMarkHeigthNumericUpDown.Location = new System.Drawing.Point(248, 74);
            this.colorMarkHeigthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorMarkHeigthNumericUpDown.Name = "colorMarkHeigthNumericUpDown";
            this.colorMarkHeigthNumericUpDown.Size = new System.Drawing.Size(37, 20);
            this.colorMarkHeigthNumericUpDown.TabIndex = 9;
            this.colorMarkHeigthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // colorMarkWidthNumericUpDown
            // 
            this.colorMarkWidthNumericUpDown.Location = new System.Drawing.Point(184, 74);
            this.colorMarkWidthNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colorMarkWidthNumericUpDown.Name = "colorMarkWidthNumericUpDown";
            this.colorMarkWidthNumericUpDown.Size = new System.Drawing.Size(40, 20);
            this.colorMarkWidthNumericUpDown.TabIndex = 10;
            this.colorMarkWidthNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(472, 499);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(553, 499);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "x";
            // 
            // colorMarkGroupBox
            // 
            this.colorMarkGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.colorMarkGroupBox.Controls.Add(this.colorMarkAnchorTypeEditor);
            this.colorMarkGroupBox.Controls.Add(this.label6);
            this.colorMarkGroupBox.Controls.Add(this.label2);
            this.colorMarkGroupBox.Controls.Add(this.label3);
            this.colorMarkGroupBox.Controls.Add(this.label4);
            this.colorMarkGroupBox.Controls.Add(this.colorMarkWidthNumericUpDown);
            this.colorMarkGroupBox.Controls.Add(this.label5);
            this.colorMarkGroupBox.Controls.Add(this.colorMarkHeigthNumericUpDown);
            this.colorMarkGroupBox.Controls.Add(this.focusedImageViewerColorMarkPanelControl);
            this.colorMarkGroupBox.Controls.Add(this.focusedImageViewerMarkSizeNumericUpDown);
            this.colorMarkGroupBox.Location = new System.Drawing.Point(326, 322);
            this.colorMarkGroupBox.Name = "colorMarkGroupBox";
            this.colorMarkGroupBox.Size = new System.Drawing.Size(302, 168);
            this.colorMarkGroupBox.TabIndex = 14;
            this.colorMarkGroupBox.TabStop = false;
            // 
            // colorMarkAnchorTypeEditor
            // 
            this.colorMarkAnchorTypeEditor.Location = new System.Drawing.Point(177, 102);
            this.colorMarkAnchorTypeEditor.Name = "colorMarkAnchorTypeEditor";
            this.colorMarkAnchorTypeEditor.SelectedAnchorType = ((Vintasoft.Imaging.AnchorType)((((Vintasoft.Imaging.AnchorType.Top | Vintasoft.Imaging.AnchorType.Bottom) 
            | Vintasoft.Imaging.AnchorType.Left) 
            | Vintasoft.Imaging.AnchorType.Right)));
            this.colorMarkAnchorTypeEditor.Size = new System.Drawing.Size(63, 63);
            this.colorMarkAnchorTypeEditor.TabIndex = 14;
            // 
            // focusedImageViewerColorMarkPanelControl
            // 
            this.focusedImageViewerColorMarkPanelControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.focusedImageViewerColorMarkPanelControl.CanEditAlphaChannel = false;
            this.focusedImageViewerColorMarkPanelControl.Color = System.Drawing.Color.Transparent;
            this.focusedImageViewerColorMarkPanelControl.DefaultColor = System.Drawing.Color.Empty;
            this.focusedImageViewerColorMarkPanelControl.Location = new System.Drawing.Point(184, 19);
            this.focusedImageViewerColorMarkPanelControl.Name = "focusedImageViewerColorMarkPanelControl";
            this.focusedImageViewerColorMarkPanelControl.Size = new System.Drawing.Size(101, 22);
            this.focusedImageViewerColorMarkPanelControl.TabIndex = 6;
            // 
            // visualizationPerformanceGroupBox
            // 
            this.visualizationPerformanceGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.visualizationPerformanceGroupBox.Controls.Add(this.limitMaxFpsCheckBox);
            this.visualizationPerformanceGroupBox.Controls.Add(this.complexityThresholdValueEditorControl);
            this.visualizationPerformanceGroupBox.Controls.Add(this.stepCountValueEditorControl);
            this.visualizationPerformanceGroupBox.Controls.Add(this.maxFpsValueEditorControl);
            this.visualizationPerformanceGroupBox.Controls.Add(this.maxThreadValueEditorControl);
            this.visualizationPerformanceGroupBox.Location = new System.Drawing.Point(13, 12);
            this.visualizationPerformanceGroupBox.Name = "visualizationPerformanceGroupBox";
            this.visualizationPerformanceGroupBox.Size = new System.Drawing.Size(302, 478);
            this.visualizationPerformanceGroupBox.TabIndex = 15;
            this.visualizationPerformanceGroupBox.TabStop = false;
            this.visualizationPerformanceGroupBox.Text = "Visualization Performance";
            // 
            // limitMaxFpsCheckBox
            // 
            this.limitMaxFpsCheckBox.AutoSize = true;
            this.limitMaxFpsCheckBox.Checked = true;
            this.limitMaxFpsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.limitMaxFpsCheckBox.Location = new System.Drawing.Point(15, 133);
            this.limitMaxFpsCheckBox.Name = "limitMaxFpsCheckBox";
            this.limitMaxFpsCheckBox.Size = new System.Drawing.Size(93, 17);
            this.limitMaxFpsCheckBox.TabIndex = 16;
            this.limitMaxFpsCheckBox.Text = "Limit Max FPS";
            this.limitMaxFpsCheckBox.UseVisualStyleBackColor = true;
            this.limitMaxFpsCheckBox.CheckedChanged += new System.EventHandler(this.limitMaxFpsCheckBox_CheckedChanged);
            // 
            // complexityThresholdValueEditorControl
            // 
            this.complexityThresholdValueEditorControl.DefaultValue = 200F;
            this.complexityThresholdValueEditorControl.Location = new System.Drawing.Point(6, 355);
            this.complexityThresholdValueEditorControl.MaxValue = 1000F;
            this.complexityThresholdValueEditorControl.MinValue = 20F;
            this.complexityThresholdValueEditorControl.Name = "complexityThresholdValueEditorControl";
            this.complexityThresholdValueEditorControl.Size = new System.Drawing.Size(290, 76);
            this.complexityThresholdValueEditorControl.TabIndex = 15;
            this.complexityThresholdValueEditorControl.Value = 200F;
            this.complexityThresholdValueEditorControl.ValueName = "Adaptive Rendering Complexity Threshold";
            this.complexityThresholdValueEditorControl.ValueUnitOfMeasure = "";
            // 
            // stepCountValueEditorControl
            // 
            this.stepCountValueEditorControl.DefaultValue = 3F;
            this.stepCountValueEditorControl.Location = new System.Drawing.Point(6, 244);
            this.stepCountValueEditorControl.MaxValue = 5F;
            this.stepCountValueEditorControl.Name = "stepCountValueEditorControl";
            this.stepCountValueEditorControl.Size = new System.Drawing.Size(290, 76);
            this.stepCountValueEditorControl.TabIndex = 14;
            this.stepCountValueEditorControl.Value = 3F;
            this.stepCountValueEditorControl.ValueName = "Adaptive Rendering Quality Step Count";
            this.stepCountValueEditorControl.ValueUnitOfMeasure = "";
            this.stepCountValueEditorControl.ValueChanged += new System.EventHandler(this.stepCountValueEditorControl_ValueChanged);
            // 
            // maxFpsValueEditorControl
            // 
            this.maxFpsValueEditorControl.DefaultValue = 60F;
            this.maxFpsValueEditorControl.Location = new System.Drawing.Point(6, 133);
            this.maxFpsValueEditorControl.MaxValue = 150F;
            this.maxFpsValueEditorControl.MinValue = 5F;
            this.maxFpsValueEditorControl.Name = "maxFpsValueEditorControl";
            this.maxFpsValueEditorControl.Size = new System.Drawing.Size(290, 76);
            this.maxFpsValueEditorControl.TabIndex = 13;
            this.maxFpsValueEditorControl.Value = 60F;
            this.maxFpsValueEditorControl.ValueName = "";
            this.maxFpsValueEditorControl.ValueUnitOfMeasure = "";
            // 
            // maxThreadValueEditorControl
            // 
            this.maxThreadValueEditorControl.DefaultValue = 4F;
            this.maxThreadValueEditorControl.Location = new System.Drawing.Point(6, 22);
            this.maxThreadValueEditorControl.MaxValue = 8F;
            this.maxThreadValueEditorControl.MinValue = 1F;
            this.maxThreadValueEditorControl.Name = "maxThreadValueEditorControl";
            this.maxThreadValueEditorControl.Size = new System.Drawing.Size(290, 76);
            this.maxThreadValueEditorControl.TabIndex = 1;
            this.maxThreadValueEditorControl.Value = 4F;
            this.maxThreadValueEditorControl.ValueName = "Max Thread Count For Rendering";
            this.maxThreadValueEditorControl.ValueUnitOfMeasure = "";
            // 
            // MprImageToolAppearanceSettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(640, 532);
            this.Controls.Add(this.visualizationPerformanceGroupBox);
            this.Controls.Add(this.colorMarkVisibleCheckBox);
            this.Controls.Add(this.colorMarkGroupBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sliceSettingsGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MprImageToolAppearanceSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MPR Settings";
            this.sliceSettingsGroupBox.ResumeLayout(false);
            this.sliceTypePanel.ResumeLayout(false);
            this.sliceTypePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.focusedImageViewerMarkSizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMarkHeigthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorMarkWidthNumericUpDown)).EndInit();
            this.colorMarkGroupBox.ResumeLayout(false);
            this.colorMarkGroupBox.PerformLayout();
            this.visualizationPerformanceGroupBox.ResumeLayout(false);
            this.visualizationPerformanceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sliceSettingsGroupBox;
        private VisualMprSliceAppearanceEditorControl sliceAppearanceEditorControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sliceTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox colorMarkVisibleCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DemosCommonCode.CustomControls.ColorPanelControl focusedImageViewerColorMarkPanelControl;
        private System.Windows.Forms.NumericUpDown focusedImageViewerMarkSizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown colorMarkHeigthNumericUpDown;
        private System.Windows.Forms.NumericUpDown colorMarkWidthNumericUpDown;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox colorMarkGroupBox;
        private System.Windows.Forms.GroupBox visualizationPerformanceGroupBox;
        private DemosCommonCode.CustomControls.ValueEditorControl maxThreadValueEditorControl;
        private DemosCommonCode.CustomControls.ValueEditorControl complexityThresholdValueEditorControl;
        private DemosCommonCode.CustomControls.ValueEditorControl stepCountValueEditorControl;
        private DemosCommonCode.CustomControls.ValueEditorControl maxFpsValueEditorControl;
        private System.Windows.Forms.CheckBox limitMaxFpsCheckBox;
        private System.Windows.Forms.Panel sliceTypePanel;
        private DemosCommonCode.CustomControls.AnchorTypeEditorControl colorMarkAnchorTypeEditor;
    }
}