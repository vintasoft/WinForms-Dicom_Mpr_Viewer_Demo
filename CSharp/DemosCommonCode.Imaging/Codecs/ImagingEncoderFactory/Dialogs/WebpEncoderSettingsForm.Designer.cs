
namespace DemosCommonCode.Imaging.Codecs.Dialogs
{
    partial class WebpEncoderSettingsForm
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
            this.encodingComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.qualityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.losslessRadioButton = new System.Windows.Forms.RadioButton();
            this.lossyRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.losslessGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nearLosslessQualityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nearLosslessCheckBox = new System.Windows.Forms.CheckBox();
            this.transparentComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lossyGroupBox = new System.Windows.Forms.GroupBox();
            this.entropyPassesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.spatialNoiseShapingNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.filtersStrengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qualityNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.losslessGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nearLosslessQualityNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.lossyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entropyPassesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spatialNoiseShapingNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersStrengthNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // encodingComboBox
            // 
            this.encodingComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encodingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encodingComboBox.FormattingEnabled = true;
            this.encodingComboBox.Location = new System.Drawing.Point(69, 29);
            this.encodingComboBox.Name = "encodingComboBox";
            this.encodingComboBox.Size = new System.Drawing.Size(120, 23);
            this.encodingComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encoding";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quality";
            // 
            // qualityNumericUpDown
            // 
            this.qualityNumericUpDown.Location = new System.Drawing.Point(69, 58);
            this.qualityNumericUpDown.Name = "qualityNumericUpDown";
            this.qualityNumericUpDown.Size = new System.Drawing.Size(65, 23);
            this.qualityNumericUpDown.TabIndex = 6;
            this.qualityNumericUpDown.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // losslessRadioButton
            // 
            this.losslessRadioButton.AutoSize = true;
            this.losslessRadioButton.Checked = true;
            this.losslessRadioButton.Location = new System.Drawing.Point(6, 22);
            this.losslessRadioButton.Name = "losslessRadioButton";
            this.losslessRadioButton.Size = new System.Drawing.Size(67, 19);
            this.losslessRadioButton.TabIndex = 8;
            this.losslessRadioButton.TabStop = true;
            this.losslessRadioButton.Text = "Lossless";
            this.losslessRadioButton.UseVisualStyleBackColor = true;
            this.losslessRadioButton.CheckedChanged += new System.EventHandler(this.losslessRadioButton_CheckedChanged);
            // 
            // lossyRadioButton
            // 
            this.lossyRadioButton.AutoSize = true;
            this.lossyRadioButton.Location = new System.Drawing.Point(79, 22);
            this.lossyRadioButton.Name = "lossyRadioButton";
            this.lossyRadioButton.Size = new System.Drawing.Size(54, 19);
            this.lossyRadioButton.TabIndex = 9;
            this.lossyRadioButton.Text = "Lossy";
            this.lossyRadioButton.UseVisualStyleBackColor = true;
            this.lossyRadioButton.CheckedChanged += new System.EventHandler(this.lossyRadioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.losslessRadioButton);
            this.groupBox1.Controls.Add(this.lossyRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 54);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // losslessGroupBox
            // 
            this.losslessGroupBox.Controls.Add(this.groupBox4);
            this.losslessGroupBox.Controls.Add(this.transparentComboBox);
            this.losslessGroupBox.Controls.Add(this.label3);
            this.losslessGroupBox.Location = new System.Drawing.Point(12, 178);
            this.losslessGroupBox.Name = "losslessGroupBox";
            this.losslessGroupBox.Size = new System.Drawing.Size(219, 184);
            this.losslessGroupBox.TabIndex = 11;
            this.losslessGroupBox.TabStop = false;
            this.losslessGroupBox.Text = "Lossless";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nearLosslessQualityNumericUpDown);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nearLosslessCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(207, 102);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "NearLossless";
            // 
            // nearLosslessQualityNumericUpDown
            // 
            this.nearLosslessQualityNumericUpDown.Location = new System.Drawing.Point(125, 61);
            this.nearLosslessQualityNumericUpDown.Name = "nearLosslessQualityNumericUpDown";
            this.nearLosslessQualityNumericUpDown.Size = new System.Drawing.Size(65, 23);
            this.nearLosslessQualityNumericUpDown.TabIndex = 8;
            this.nearLosslessQualityNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "NearLossless quality";
            // 
            // nearLosslessCheckBox
            // 
            this.nearLosslessCheckBox.AutoSize = true;
            this.nearLosslessCheckBox.Location = new System.Drawing.Point(6, 32);
            this.nearLosslessCheckBox.Name = "nearLosslessCheckBox";
            this.nearLosslessCheckBox.Size = new System.Drawing.Size(115, 19);
            this.nearLosslessCheckBox.TabIndex = 0;
            this.nearLosslessCheckBox.Text = "Use NearLossless";
            this.nearLosslessCheckBox.UseVisualStyleBackColor = true;
            this.nearLosslessCheckBox.CheckedChanged += new System.EventHandler(this.nearLosslessCheckBox_CheckedChanged);
            // 
            // transparentComboBox
            // 
            this.transparentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transparentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transparentComboBox.FormattingEnabled = true;
            this.transparentComboBox.Location = new System.Drawing.Point(80, 34);
            this.transparentComboBox.Name = "transparentComboBox";
            this.transparentComboBox.Size = new System.Drawing.Size(133, 23);
            this.transparentComboBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Transparent";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.encodingComboBox);
            this.groupBox3.Controls.Add(this.qualityNumericUpDown);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 100);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Base";
            // 
            // lossyGroupBox
            // 
            this.lossyGroupBox.Controls.Add(this.entropyPassesNumericUpDown);
            this.lossyGroupBox.Controls.Add(this.label7);
            this.lossyGroupBox.Controls.Add(this.spatialNoiseShapingNumericUpDown);
            this.lossyGroupBox.Controls.Add(this.label6);
            this.lossyGroupBox.Controls.Add(this.filtersStrengthNumericUpDown);
            this.lossyGroupBox.Controls.Add(this.label5);
            this.lossyGroupBox.Location = new System.Drawing.Point(12, 178);
            this.lossyGroupBox.Name = "lossyGroupBox";
            this.lossyGroupBox.Size = new System.Drawing.Size(210, 127);
            this.lossyGroupBox.TabIndex = 13;
            this.lossyGroupBox.TabStop = false;
            this.lossyGroupBox.Text = "Lossy";
            // 
            // entropyPassesNumericUpDown
            // 
            this.entropyPassesNumericUpDown.Location = new System.Drawing.Point(139, 92);
            this.entropyPassesNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.entropyPassesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.entropyPassesNumericUpDown.Name = "entropyPassesNumericUpDown";
            this.entropyPassesNumericUpDown.Size = new System.Drawing.Size(65, 23);
            this.entropyPassesNumericUpDown.TabIndex = 14;
            this.entropyPassesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Entropy passes";
            // 
            // spatialNoiseShapingNumericUpDown
            // 
            this.spatialNoiseShapingNumericUpDown.Location = new System.Drawing.Point(139, 63);
            this.spatialNoiseShapingNumericUpDown.Name = "spatialNoiseShapingNumericUpDown";
            this.spatialNoiseShapingNumericUpDown.Size = new System.Drawing.Size(65, 23);
            this.spatialNoiseShapingNumericUpDown.TabIndex = 12;
            this.spatialNoiseShapingNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Spatial noise shaping";
            // 
            // filtersStrengthNumericUpDown
            // 
            this.filtersStrengthNumericUpDown.Location = new System.Drawing.Point(139, 34);
            this.filtersStrengthNumericUpDown.Name = "filtersStrengthNumericUpDown";
            this.filtersStrengthNumericUpDown.Size = new System.Drawing.Size(65, 23);
            this.filtersStrengthNumericUpDown.TabIndex = 10;
            this.filtersStrengthNumericUpDown.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filters strength";
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(156, 377);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(75, 377);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 14;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // WebpEncoderSettingsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(242, 413);
            this.Controls.Add(this.losslessGroupBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.lossyGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(258, 452);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(258, 452);
            this.Name = "WebpEncoderSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WEBP Encoder Settings";
            ((System.ComponentModel.ISupportInitialize)(this.qualityNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.losslessGroupBox.ResumeLayout(false);
            this.losslessGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nearLosslessQualityNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.lossyGroupBox.ResumeLayout(false);
            this.lossyGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entropyPassesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spatialNoiseShapingNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersStrengthNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox encodingComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown qualityNumericUpDown;
        private System.Windows.Forms.RadioButton losslessRadioButton;
        private System.Windows.Forms.RadioButton lossyRadioButton;
        private System.Windows.Forms.GroupBox losslessGroupBox;
        private System.Windows.Forms.ComboBox transparentComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox nearLosslessCheckBox;
        private System.Windows.Forms.NumericUpDown nearLosslessQualityNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox lossyGroupBox;
        private System.Windows.Forms.NumericUpDown filtersStrengthNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spatialNoiseShapingNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown entropyPassesNumericUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}