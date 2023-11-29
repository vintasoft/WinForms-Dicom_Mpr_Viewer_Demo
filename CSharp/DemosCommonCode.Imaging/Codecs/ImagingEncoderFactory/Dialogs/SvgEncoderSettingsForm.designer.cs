namespace DemosCommonCode.Imaging.Codecs.Dialogs
{
    partial class SvgEncoderSettingsForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.encoderNameComboBox = new System.Windows.Forms.ComboBox();
            this.pngEncoderSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pngSettingsComboBox = new System.Windows.Forms.ComboBox();
            this.jpegEncoderSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.jpegGrayscaleCheckBox = new System.Windows.Forms.CheckBox();
            this.jpegQualityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.allowExternalFontsCheckBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pngEncoderSettingsGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.jpegEncoderSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jpegQualityNumericUpDown)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(117, 160);
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
            this.buttonCancel.Location = new System.Drawing.Point(198, 160);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Embedded images encoder";
            // 
            // encoderNameComboBox
            // 
            this.encoderNameComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.encoderNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.encoderNameComboBox.FormattingEnabled = true;
            this.encoderNameComboBox.Location = new System.Drawing.Point(15, 31);
            this.encoderNameComboBox.Name = "encoderNameComboBox";
            this.encoderNameComboBox.Size = new System.Drawing.Size(105, 21);
            this.encoderNameComboBox.TabIndex = 3;
            this.encoderNameComboBox.SelectedIndexChanged += new System.EventHandler(this.encoderNameComboBox_SelectedIndexChanged);
            // 
            // pngEncoderSettingsGroupBox
            // 
            this.pngEncoderSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pngEncoderSettingsGroupBox.AutoSize = true;
            this.pngEncoderSettingsGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.pngEncoderSettingsGroupBox.Location = new System.Drawing.Point(15, 58);
            this.pngEncoderSettingsGroupBox.Name = "pngEncoderSettingsGroupBox";
            this.pngEncoderSettingsGroupBox.Size = new System.Drawing.Size(259, 68);
            this.pngEncoderSettingsGroupBox.TabIndex = 4;
            this.pngEncoderSettingsGroupBox.TabStop = false;
            this.pngEncoderSettingsGroupBox.Text = "PNG settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pngSettingsComboBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 49);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Compression settings";
            // 
            // pngSettingsComboBox
            // 
            this.pngSettingsComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pngSettingsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pngSettingsComboBox.FormattingEnabled = true;
            this.pngSettingsComboBox.Location = new System.Drawing.Point(115, 14);
            this.pngSettingsComboBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.pngSettingsComboBox.Name = "pngSettingsComboBox";
            this.pngSettingsComboBox.Size = new System.Drawing.Size(135, 21);
            this.pngSettingsComboBox.TabIndex = 5;
            // 
            // jpegEncoderSettingsGroupBox
            // 
            this.jpegEncoderSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.jpegEncoderSettingsGroupBox.AutoSize = true;
            this.jpegEncoderSettingsGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.jpegEncoderSettingsGroupBox.Location = new System.Drawing.Point(15, 58);
            this.jpegEncoderSettingsGroupBox.Name = "jpegEncoderSettingsGroupBox";
            this.jpegEncoderSettingsGroupBox.Size = new System.Drawing.Size(258, 68);
            this.jpegEncoderSettingsGroupBox.TabIndex = 5;
            this.jpegEncoderSettingsGroupBox.TabStop = false;
            this.jpegEncoderSettingsGroupBox.Text = "JPEG settings";
            // 
            // jpegGrayscaleCheckBox
            // 
            this.jpegGrayscaleCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.jpegGrayscaleCheckBox.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.jpegGrayscaleCheckBox, 2);
            this.jpegGrayscaleCheckBox.Location = new System.Drawing.Point(3, 29);
            this.jpegGrayscaleCheckBox.Name = "jpegGrayscaleCheckBox";
            this.jpegGrayscaleCheckBox.Size = new System.Drawing.Size(109, 17);
            this.jpegGrayscaleCheckBox.TabIndex = 13;
            this.jpegGrayscaleCheckBox.Text = "Grayscale (8 bpp)";
            this.jpegGrayscaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // jpegQualityNumericUpDown
            // 
            this.jpegQualityNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.jpegQualityNumericUpDown.Location = new System.Drawing.Point(48, 3);
            this.jpegQualityNumericUpDown.Name = "jpegQualityNumericUpDown";
            this.jpegQualityNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.jpegQualityNumericUpDown.TabIndex = 7;
            this.jpegQualityNumericUpDown.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quality";
            // 
            // allowExternalFontsCheckBox
            // 
            this.allowExternalFontsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allowExternalFontsCheckBox.AutoSize = true;
            this.allowExternalFontsCheckBox.Location = new System.Drawing.Point(15, 132);
            this.allowExternalFontsCheckBox.Name = "allowExternalFontsCheckBox";
            this.allowExternalFontsCheckBox.Size = new System.Drawing.Size(121, 17);
            this.allowExternalFontsCheckBox.TabIndex = 6;
            this.allowExternalFontsCheckBox.Text = "Allow External Fonts";
            this.allowExternalFontsCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.jpegGrayscaleCheckBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.jpegQualityNumericUpDown, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 49);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // SvgEncoderSettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(285, 196);
            this.Controls.Add(this.allowExternalFontsCheckBox);
            this.Controls.Add(this.encoderNameComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.pngEncoderSettingsGroupBox);
            this.Controls.Add(this.jpegEncoderSettingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(270, 105);
            this.Name = "SvgEncoderSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SVG Encoder Settings";
            this.pngEncoderSettingsGroupBox.ResumeLayout(false);
            this.pngEncoderSettingsGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.jpegEncoderSettingsGroupBox.ResumeLayout(false);
            this.jpegEncoderSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jpegQualityNumericUpDown)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox encoderNameComboBox;
        private System.Windows.Forms.GroupBox pngEncoderSettingsGroupBox;
        private System.Windows.Forms.ComboBox pngSettingsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox jpegEncoderSettingsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown jpegQualityNumericUpDown;
        private System.Windows.Forms.CheckBox jpegGrayscaleCheckBox;
        private System.Windows.Forms.CheckBox allowExternalFontsCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}