namespace DicomMprViewerDemo
{
    partial class MprParametersViewerForm
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
            this.sliceGroupBox = new System.Windows.Forms.GroupBox();
            this.sliceHeightLabel = new System.Windows.Forms.Label();
            this.sliceWidthLabel = new System.Windows.Forms.Label();
            this.sliceYAxisLabel = new System.Windows.Forms.Label();
            this.sliceXAxisLabel = new System.Windows.Forms.Label();
            this.sliceLocationLabel = new System.Windows.Forms.Label();
            this.luminanceMeasureGroupBox = new System.Windows.Forms.GroupBox();
            this.luminanceInMprImageLinearLabel = new System.Windows.Forms.Label();
            this.luminanceWithLutLabel = new System.Windows.Forms.Label();
            this.luminanceLocationOnSliceLabel = new System.Windows.Forms.Label();
            this.luminanceInMprImageLabel = new System.Windows.Forms.Label();
            this.luminanceLocationOnImageLabel = new System.Windows.Forms.Label();
            this.luminanceLocationInMprImageLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.sliceGroupBox.SuspendLayout();
            this.luminanceMeasureGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sliceGroupBox
            // 
            this.sliceGroupBox.Controls.Add(this.sliceHeightLabel);
            this.sliceGroupBox.Controls.Add(this.sliceWidthLabel);
            this.sliceGroupBox.Controls.Add(this.sliceYAxisLabel);
            this.sliceGroupBox.Controls.Add(this.sliceXAxisLabel);
            this.sliceGroupBox.Controls.Add(this.sliceLocationLabel);
            this.sliceGroupBox.Location = new System.Drawing.Point(12, 7);
            this.sliceGroupBox.Name = "sliceGroupBox";
            this.sliceGroupBox.Size = new System.Drawing.Size(374, 137);
            this.sliceGroupBox.TabIndex = 1;
            this.sliceGroupBox.TabStop = false;
            this.sliceGroupBox.Text = "Slice";
            // 
            // sliceHeightLabel
            // 
            this.sliceHeightLabel.AutoSize = true;
            this.sliceHeightLabel.Location = new System.Drawing.Point(6, 108);
            this.sliceHeightLabel.Name = "sliceHeightLabel";
            this.sliceHeightLabel.Size = new System.Drawing.Size(120, 13);
            this.sliceHeightLabel.TabIndex = 4;
            this.sliceHeightLabel.Text = "Height (millimenters): {0}";
            // 
            // sliceWidthLabel
            // 
            this.sliceWidthLabel.AutoSize = true;
            this.sliceWidthLabel.Location = new System.Drawing.Point(6, 87);
            this.sliceWidthLabel.Name = "sliceWidthLabel";
            this.sliceWidthLabel.Size = new System.Drawing.Size(111, 13);
            this.sliceWidthLabel.TabIndex = 3;
            this.sliceWidthLabel.Text = "Width (miliimeters): {0}";
            // 
            // sliceYAxisLabel
            // 
            this.sliceYAxisLabel.AutoSize = true;
            this.sliceYAxisLabel.Location = new System.Drawing.Point(6, 66);
            this.sliceYAxisLabel.Name = "sliceYAxisLabel";
            this.sliceYAxisLabel.Size = new System.Drawing.Size(171, 13);
            this.sliceYAxisLabel.TabIndex = 2;
            this.sliceYAxisLabel.Text = "YAxis (vector): X={0}, Y={1}, Z={2}";
            // 
            // sliceXAxisLabel
            // 
            this.sliceXAxisLabel.AutoSize = true;
            this.sliceXAxisLabel.Location = new System.Drawing.Point(6, 45);
            this.sliceXAxisLabel.Name = "sliceXAxisLabel";
            this.sliceXAxisLabel.Size = new System.Drawing.Size(171, 13);
            this.sliceXAxisLabel.TabIndex = 1;
            this.sliceXAxisLabel.Text = "XAxis (vector): X={0}, Y={1}, Z={2}";
            // 
            // sliceLocationLabel
            // 
            this.sliceLocationLabel.AutoSize = true;
            this.sliceLocationLabel.Location = new System.Drawing.Point(6, 24);
            this.sliceLocationLabel.Name = "sliceLocationLabel";
            this.sliceLocationLabel.Size = new System.Drawing.Size(203, 13);
            this.sliceLocationLabel.TabIndex = 0;
            this.sliceLocationLabel.Text = "Location (millimeters): X={0}, Y={1}, Z={2}";
            // 
            // luminanceMeasureGroupBox
            // 
            this.luminanceMeasureGroupBox.Controls.Add(this.luminanceInMprImageLinearLabel);
            this.luminanceMeasureGroupBox.Controls.Add(this.luminanceWithLutLabel);
            this.luminanceMeasureGroupBox.Controls.Add(this.luminanceLocationOnSliceLabel);
            this.luminanceMeasureGroupBox.Controls.Add(this.luminanceInMprImageLabel);
            this.luminanceMeasureGroupBox.Controls.Add(this.luminanceLocationOnImageLabel);
            this.luminanceMeasureGroupBox.Controls.Add(this.luminanceLocationInMprImageLabel);
            this.luminanceMeasureGroupBox.Location = new System.Drawing.Point(12, 149);
            this.luminanceMeasureGroupBox.Name = "luminanceMeasureGroupBox";
            this.luminanceMeasureGroupBox.Size = new System.Drawing.Size(374, 175);
            this.luminanceMeasureGroupBox.TabIndex = 2;
            this.luminanceMeasureGroupBox.TabStop = false;
            this.luminanceMeasureGroupBox.Text = "Luminance Measure";
            // 
            // luminanceInMprImageLinearLabel
            // 
            this.luminanceInMprImageLinearLabel.AutoSize = true;
            this.luminanceInMprImageLinearLabel.Location = new System.Drawing.Point(6, 120);
            this.luminanceInMprImageLinearLabel.Name = "luminanceInMprImageLinearLabel";
            this.luminanceInMprImageLinearLabel.Size = new System.Drawing.Size(321, 13);
            this.luminanceInMprImageLinearLabel.TabIndex = 5;
            this.luminanceInMprImageLinearLabel.Text = "Luminance in MPR Image, linear interpolation (16-bit unsigned): {0}";
            // 
            // luminanceWithLutLabel
            // 
            this.luminanceWithLutLabel.AutoSize = true;
            this.luminanceWithLutLabel.Location = new System.Drawing.Point(6, 143);
            this.luminanceWithLutLabel.Name = "luminanceWithLutLabel";
            this.luminanceWithLutLabel.Size = new System.Drawing.Size(321, 13);
            this.luminanceWithLutLabel.TabIndex = 4;
            this.luminanceWithLutLabel.Text = "Luminance in Displayed Slice Image, with LUT (8-bit unsigned): {0}";
            // 
            // luminanceLocationOnSliceLabel
            // 
            this.luminanceLocationOnSliceLabel.AutoSize = true;
            this.luminanceLocationOnSliceLabel.Location = new System.Drawing.Point(6, 48);
            this.luminanceLocationOnSliceLabel.Name = "luminanceLocationOnSliceLabel";
            this.luminanceLocationOnSliceLabel.Size = new System.Drawing.Size(209, 13);
            this.luminanceLocationOnSliceLabel.TabIndex = 3;
            this.luminanceLocationOnSliceLabel.Text = "Location on slice (millimeters): X={0}, Y={1}";
            // 
            // luminanceInMprImageLabel
            // 
            this.luminanceInMprImageLabel.AutoSize = true;
            this.luminanceInMprImageLabel.Location = new System.Drawing.Point(6, 96);
            this.luminanceInMprImageLabel.Name = "luminanceInMprImageLabel";
            this.luminanceInMprImageLabel.Size = new System.Drawing.Size(230, 13);
            this.luminanceInMprImageLabel.TabIndex = 1;
            this.luminanceInMprImageLabel.Text = "Luminance in MPR Image (16-bit unsigned): {0}";
            // 
            // luminanceLocationOnImageLabel
            // 
            this.luminanceLocationOnImageLabel.AutoSize = true;
            this.luminanceLocationOnImageLabel.Location = new System.Drawing.Point(6, 24);
            this.luminanceLocationOnImageLabel.Name = "luminanceLocationOnImageLabel";
            this.luminanceLocationOnImageLabel.Size = new System.Drawing.Size(195, 13);
            this.luminanceLocationOnImageLabel.TabIndex = 2;
            this.luminanceLocationOnImageLabel.Text = "Location on image (pixels): X={0}, Y={1}";
            // 
            // luminanceLocationInMprImageLabel
            // 
            this.luminanceLocationInMprImageLabel.AutoSize = true;
            this.luminanceLocationInMprImageLabel.Location = new System.Drawing.Point(6, 72);
            this.luminanceLocationInMprImageLabel.Name = "luminanceLocationInMprImageLabel";
            this.luminanceLocationInMprImageLabel.Size = new System.Drawing.Size(272, 13);
            this.luminanceLocationInMprImageLabel.TabIndex = 0;
            this.luminanceLocationInMprImageLabel.Text = "Location in MPR image (millimeters): X={0}, Y={1}, Z={2}";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(312, 330);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MprParametersViewerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 364);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.luminanceMeasureGroupBox);
            this.Controls.Add(this.sliceGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MprParametersViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MPR Parameters Viewer";
            this.sliceGroupBox.ResumeLayout(false);
            this.sliceGroupBox.PerformLayout();
            this.luminanceMeasureGroupBox.ResumeLayout(false);
            this.luminanceMeasureGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sliceGroupBox;
        private System.Windows.Forms.GroupBox luminanceMeasureGroupBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label sliceLocationLabel;
        private System.Windows.Forms.Label sliceHeightLabel;
        private System.Windows.Forms.Label sliceWidthLabel;
        private System.Windows.Forms.Label sliceYAxisLabel;
        private System.Windows.Forms.Label sliceXAxisLabel;
        private System.Windows.Forms.Label luminanceWithLutLabel;
        private System.Windows.Forms.Label luminanceLocationOnSliceLabel;
        private System.Windows.Forms.Label luminanceLocationOnImageLabel;
        private System.Windows.Forms.Label luminanceInMprImageLabel;
        private System.Windows.Forms.Label luminanceLocationInMprImageLabel;
        private System.Windows.Forms.Label luminanceInMprImageLinearLabel;
    }
}
