namespace DicomMprViewerDemo
{
    partial class MprImageSlicesEncodingPropertiesForm
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
            this.imageFormatComboBox = new System.Windows.Forms.ComboBox();
            this.applyVoiLutToImageSlicesCheckBox = new System.Windows.Forms.CheckBox();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tiffEncoderSettingsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Format";
            // 
            // imageFormatComboBox
            // 
            this.imageFormatComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.imageFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.imageFormatComboBox.FormattingEnabled = true;
            this.imageFormatComboBox.Items.AddRange(new object[] {
            "Gray 8",
            "Gray 16"});
            this.imageFormatComboBox.Location = new System.Drawing.Point(89, 12);
            this.imageFormatComboBox.Name = "imageFormatComboBox";
            this.imageFormatComboBox.Size = new System.Drawing.Size(293, 21);
            this.imageFormatComboBox.TabIndex = 1;
            // 
            // applyVoiLutToImageSlicesCheckBox
            // 
            this.applyVoiLutToImageSlicesCheckBox.AutoSize = true;
            this.applyVoiLutToImageSlicesCheckBox.Checked = true;
            this.applyVoiLutToImageSlicesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.applyVoiLutToImageSlicesCheckBox.Location = new System.Drawing.Point(15, 43);
            this.applyVoiLutToImageSlicesCheckBox.Name = "applyVoiLutToImageSlicesCheckBox";
            this.applyVoiLutToImageSlicesCheckBox.Size = new System.Drawing.Size(176, 17);
            this.applyVoiLutToImageSlicesCheckBox.TabIndex = 2;
            this.applyVoiLutToImageSlicesCheckBox.Text = "Apply VOI LUT To Image Slices";
            this.applyVoiLutToImageSlicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(226, 72);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(307, 72);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tiffEncoderSettingsButton
            // 
            this.tiffEncoderSettingsButton.Location = new System.Drawing.Point(226, 39);
            this.tiffEncoderSettingsButton.Name = "tiffEncoderSettingsButton";
            this.tiffEncoderSettingsButton.Size = new System.Drawing.Size(156, 23);
            this.tiffEncoderSettingsButton.TabIndex = 5;
            this.tiffEncoderSettingsButton.Text = "Tiff Encoder Settings...";
            this.tiffEncoderSettingsButton.UseVisualStyleBackColor = true;
            this.tiffEncoderSettingsButton.Click += new System.EventHandler(this.tiffEncoderSettingsButton_Click);
            // 
            // MprImageSlicesEncodingPropertiesForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(388, 107);
            this.Controls.Add(this.tiffEncoderSettingsButton);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.applyVoiLutToImageSlicesCheckBox);
            this.Controls.Add(this.imageFormatComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MprImageSlicesEncodingPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mpr Image Slices Encoding Properties";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox imageFormatComboBox;
        private System.Windows.Forms.CheckBox applyVoiLutToImageSlicesCheckBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button tiffEncoderSettingsButton;
    }
}
