namespace DicomMprViewerDemo
{
    partial class DicomOverlaySettingEditorForm
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
            this.components = new System.ComponentModel.Container();
            this.supportedItemsListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.selectedItemsListBox = new System.Windows.Forms.ListBox();
            this.selectedTextOverlayPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.moveUpButton = new System.Windows.Forms.Button();
            this.moveDownButton = new System.Windows.Forms.Button();
            this.buttonToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupButton = new System.Windows.Forms.Button();
            this.ungroupButton = new System.Windows.Forms.Button();
            this.anchorTypeLabel = new System.Windows.Forms.Label();
            this.anchorTypeEditor = new DemosCommonCode.CustomControls.AnchorTypeEditorControl();
            this.SuspendLayout();
            // 
            // supportedItemsListBox
            // 
            this.supportedItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.supportedItemsListBox.FormattingEnabled = true;
            this.supportedItemsListBox.Location = new System.Drawing.Point(12, 13);
            this.supportedItemsListBox.Name = "supportedItemsListBox";
            this.supportedItemsListBox.Size = new System.Drawing.Size(275, 446);
            this.supportedItemsListBox.TabIndex = 1;
            this.supportedItemsListBox.SelectedIndexChanged += new System.EventHandler(this.supportedItemsListBox_SelectedIndexChanged);
            this.supportedItemsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.supportedItemsListBox_MouseDoubleClick);
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addButton.Location = new System.Drawing.Point(12, 461);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(275, 30);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Add";
            this.buttonToolTip.SetToolTip(this.addButton, "Add Element");
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.removeButton.Location = new System.Drawing.Point(293, 222);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(73, 30);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.buttonToolTip.SetToolTip(this.removeButton, "Remove Element");
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // selectedItemsListBox
            // 
            this.selectedItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedItemsListBox.FormattingEnabled = true;
            this.selectedItemsListBox.Location = new System.Drawing.Point(293, 82);
            this.selectedItemsListBox.Name = "selectedItemsListBox";
            this.selectedItemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.selectedItemsListBox.Size = new System.Drawing.Size(389, 134);
            this.selectedItemsListBox.TabIndex = 4;
            this.selectedItemsListBox.SelectedIndexChanged += new System.EventHandler(this.selectedItemsListBox_SelectedIndexChanged);
            // 
            // selectedTextOverlayPropertyGrid
            // 
            this.selectedTextOverlayPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectedTextOverlayPropertyGrid.Location = new System.Drawing.Point(293, 258);
            this.selectedTextOverlayPropertyGrid.Name = "selectedTextOverlayPropertyGrid";
            this.selectedTextOverlayPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            this.selectedTextOverlayPropertyGrid.Size = new System.Drawing.Size(389, 233);
            this.selectedTextOverlayPropertyGrid.TabIndex = 5;
            this.selectedTextOverlayPropertyGrid.ToolbarVisible = false;
            this.selectedTextOverlayPropertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.selectedTextOverlayPropertyGrid_PropertyValueChanged);
            // 
            // moveUpButton
            // 
            this.moveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moveUpButton.Location = new System.Drawing.Point(372, 222);
            this.moveUpButton.Name = "moveUpButton";
            this.moveUpButton.Size = new System.Drawing.Size(73, 30);
            this.moveUpButton.TabIndex = 9;
            this.moveUpButton.Text = "Move Up";
            this.buttonToolTip.SetToolTip(this.moveUpButton, "Move Up Element");
            this.moveUpButton.UseVisualStyleBackColor = true;
            this.moveUpButton.Click += new System.EventHandler(this.moveUpButton_Click);
            // 
            // moveDownButton
            // 
            this.moveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moveDownButton.Location = new System.Drawing.Point(451, 222);
            this.moveDownButton.Name = "moveDownButton";
            this.moveDownButton.Size = new System.Drawing.Size(73, 30);
            this.moveDownButton.TabIndex = 10;
            this.moveDownButton.Text = "Move Down";
            this.buttonToolTip.SetToolTip(this.moveDownButton, "Move Down Element");
            this.moveDownButton.UseVisualStyleBackColor = true;
            this.moveDownButton.Click += new System.EventHandler(this.moveDownButton_Click);
            // 
            // groupButton
            // 
            this.groupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupButton.Location = new System.Drawing.Point(530, 222);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(73, 30);
            this.groupButton.TabIndex = 11;
            this.groupButton.Text = "Group";
            this.buttonToolTip.SetToolTip(this.groupButton, "Group Selected Elements In Single String");
            this.groupButton.UseVisualStyleBackColor = true;
            this.groupButton.Click += new System.EventHandler(this.groupButton_Click);
            // 
            // ungroupButton
            // 
            this.ungroupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ungroupButton.Location = new System.Drawing.Point(609, 222);
            this.ungroupButton.Name = "ungroupButton";
            this.ungroupButton.Size = new System.Drawing.Size(73, 30);
            this.ungroupButton.TabIndex = 12;
            this.ungroupButton.Text = "Ungroup";
            this.buttonToolTip.SetToolTip(this.ungroupButton, "Ungroup Selected Element");
            this.ungroupButton.UseVisualStyleBackColor = true;
            this.ungroupButton.Click += new System.EventHandler(this.ungroupButton_Click);
            // 
            // anchorTypeLabel
            // 
            this.anchorTypeLabel.AutoSize = true;
            this.anchorTypeLabel.Location = new System.Drawing.Point(294, 13);
            this.anchorTypeLabel.Name = "anchorTypeLabel";
            this.anchorTypeLabel.Size = new System.Drawing.Size(41, 13);
            this.anchorTypeLabel.TabIndex = 14;
            this.anchorTypeLabel.Text = "Anchor";
            // 
            // anchorTypeEditor
            // 
            this.anchorTypeEditor.Location = new System.Drawing.Point(344, 10);
            this.anchorTypeEditor.Name = "anchorTypeEditor";
            this.anchorTypeEditor.SelectedAnchorType = Vintasoft.Imaging.AnchorType.None;
            this.anchorTypeEditor.Size = new System.Drawing.Size(63, 63);
            this.anchorTypeEditor.TabIndex = 13;
            this.anchorTypeEditor.SelectedAnchorTypeChanged += new System.EventHandler(this.anchorTypeEditor_SelectedAnchorTypeChanged);
            // 
            // DicomOverlaySettingEditorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 506);
            this.Controls.Add(this.anchorTypeLabel);
            this.Controls.Add(this.anchorTypeEditor);
            this.Controls.Add(this.ungroupButton);
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.moveDownButton);
            this.Controls.Add(this.moveUpButton);
            this.Controls.Add(this.selectedTextOverlayPropertyGrid);
            this.Controls.Add(this.selectedItemsListBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.supportedItemsListBox);
            this.MinimumSize = new System.Drawing.Size(705, 545);
            this.Name = "DicomOverlaySettingEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Overlay Setting Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DicomOverlaySettingEditorForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox supportedItemsListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox selectedItemsListBox;
        private System.Windows.Forms.PropertyGrid selectedTextOverlayPropertyGrid;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button moveUpButton;
        private System.Windows.Forms.Button moveDownButton;
        private System.Windows.Forms.ToolTip buttonToolTip;
        private System.Windows.Forms.Button groupButton;
        private System.Windows.Forms.Button ungroupButton;
        private DemosCommonCode.CustomControls.AnchorTypeEditorControl anchorTypeEditor;
        private System.Windows.Forms.Label anchorTypeLabel;
    }
}
