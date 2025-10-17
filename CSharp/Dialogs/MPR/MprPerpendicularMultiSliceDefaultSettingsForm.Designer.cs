namespace DicomMprViewerDemo
{
    partial class MprPerpendicularMultiSliceDefaultSettingsForm
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
            this.sliceCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.planarSliceMarginPaddingFEditorControl = new DemosCommonCode.CustomControls.PaddingFEditorControl();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sliceCountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sliceCountNumericUpDown
            // 
            this.sliceCountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sliceCountNumericUpDown.Location = new System.Drawing.Point(115, 12);
            this.sliceCountNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.sliceCountNumericUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sliceCountNumericUpDown.Name = "sliceCountNumericUpDown";
            this.sliceCountNumericUpDown.Size = new System.Drawing.Size(156, 20);
            this.sliceCountNumericUpDown.TabIndex = 0;
            this.sliceCountNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Slice Count";
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(115, 139);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 2;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(196, 139);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // planarSliceMarginPaddingFEditorControl
            // 
            this.planarSliceMarginPaddingFEditorControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.planarSliceMarginPaddingFEditorControl.Location = new System.Drawing.Point(115, 38);
            this.planarSliceMarginPaddingFEditorControl.MaximumSize = new System.Drawing.Size(180, 75);
            this.planarSliceMarginPaddingFEditorControl.MinimumSize = new System.Drawing.Size(128, 75);
            this.planarSliceMarginPaddingFEditorControl.Name = "planarSliceMarginPaddingFEditorControl";
            this.planarSliceMarginPaddingFEditorControl.PaddingValue = new Vintasoft.Imaging.PaddingF(0F, 0F, 0F, 0F);
            this.planarSliceMarginPaddingFEditorControl.Size = new System.Drawing.Size(156, 75);
            this.planarSliceMarginPaddingFEditorControl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Planar Slice Margin";
            // 
            // MprPerpendicularMultiSliceDefaultSettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(283, 174);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.planarSliceMarginPaddingFEditorControl);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sliceCountNumericUpDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MprPerpendicularMultiSliceDefaultSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Perpendicular Multislice Default Settings";
            ((System.ComponentModel.ISupportInitialize)(this.sliceCountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sliceCountNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button buttonCancel;
        private DemosCommonCode.CustomControls.PaddingFEditorControl planarSliceMarginPaddingFEditorControl;
        private System.Windows.Forms.Label label2;
    }
}