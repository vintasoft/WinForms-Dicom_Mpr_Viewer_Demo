namespace DicomMprViewerDemo
{
    partial class MprPerpendicularMultiSliceForm
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
            this.toolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.imageViewerToolStrip1 = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.planarSliceImageViewer = new Vintasoft.Imaging.UI.ImageViewer();
            this.dicomMprToolInteractionModeToolStrip1 = new DicomMprViewerDemo.DicomMprToolInteractionModeToolStrip();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.viewerPanel = new System.Windows.Forms.Panel();
            this.viewerAndScrollPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.multiSliceImageViewer = new Vintasoft.Imaging.UI.ImageViewer();
            this.topPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_saveViewerScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_saveImageSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.file_saveSlicesToMultipageTIFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_resetSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_fitSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.view_negativeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_resetWindowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_resetToDefaultWindowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.view_showTextOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_textOverlaySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.view_useInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.view_fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_topPanelAlwaysVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.view_settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.viewerPanel.SuspendLayout();
            this.viewerAndScrollPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripPanel
            // 
            this.toolStripPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripPanel.Controls.Add(this.imageViewerToolStrip1);
            this.toolStripPanel.Controls.Add(this.dicomMprToolInteractionModeToolStrip1);
            this.toolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.toolStripPanel.Name = "toolStripPanel";
            this.toolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel.Size = new System.Drawing.Size(887, 27);
            // 
            // imageViewerToolStrip1
            // 
            this.imageViewerToolStrip1.AssociatedZoomTrackBar = null;
            this.imageViewerToolStrip1.CanChangeSizeMode = false;
            this.imageViewerToolStrip1.CanOpenFile = false;
            this.imageViewerToolStrip1.CanPrint = false;
            this.imageViewerToolStrip1.CaptureFromCameraButtonEnabled = true;
            this.imageViewerToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.imageViewerToolStrip1.ImageViewer = this.planarSliceImageViewer;
            this.imageViewerToolStrip1.Location = new System.Drawing.Point(3, 0);
            this.imageViewerToolStrip1.Name = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.PrintButtonEnabled = true;
            this.imageViewerToolStrip1.ScanButtonEnabled = true;
            this.imageViewerToolStrip1.Size = new System.Drawing.Size(310, 25);
            this.imageViewerToolStrip1.TabIndex = 3;
            this.imageViewerToolStrip1.Text = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.SaveFile += new System.EventHandler(this.file_saveImageSliceToolStripMenuItem_Click);
            this.imageViewerToolStrip1.PageIndexChanged += new System.EventHandler<DemosCommonCode.Imaging.PageIndexChangedEventArgs>(this.imageViewerToolStrip1_PageIndexChanged);
            // 
            // planarSliceImageViewer
            // 
            this.planarSliceImageViewer.BackColor = System.Drawing.Color.Transparent;
            this.planarSliceImageViewer.CenterImage = true;
            this.planarSliceImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planarSliceImageViewer.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.planarSliceImageViewer.Location = new System.Drawing.Point(0, 0);
            this.planarSliceImageViewer.Name = "planarSliceImageViewer";
            this.planarSliceImageViewer.ShortcutCopy = System.Windows.Forms.Shortcut.None;
            this.planarSliceImageViewer.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.planarSliceImageViewer.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.planarSliceImageViewer.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.planarSliceImageViewer.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.planarSliceImageViewer.Size = new System.Drawing.Size(433, 505);
            this.planarSliceImageViewer.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.Zoom;
            this.planarSliceImageViewer.TabIndex = 0;
            this.planarSliceImageViewer.Text = "imageViewer1";
            // 
            // dicomMprToolInteractionModeToolStrip1
            // 
            this.dicomMprToolInteractionModeToolStrip1.DicomMprTools = null;
            this.dicomMprToolInteractionModeToolStrip1.DisabledInteractionModes = null;
            this.dicomMprToolInteractionModeToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.dicomMprToolInteractionModeToolStrip1.Location = new System.Drawing.Point(314, 0);
            this.dicomMprToolInteractionModeToolStrip1.Name = "dicomMprToolInteractionModeToolStrip1";
            this.dicomMprToolInteractionModeToolStrip1.Size = new System.Drawing.Size(172, 25);
            this.dicomMprToolInteractionModeToolStrip1.SupportedInteractionModes = new Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode[] {
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Browse,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Pan,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.WindowLevel,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Zoom,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Measure};
            this.dicomMprToolInteractionModeToolStrip1.TabIndex = 4;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.viewerPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(866, 579);
            this.mainPanel.TabIndex = 4;
            // 
            // viewerPanel
            // 
            this.viewerPanel.Controls.Add(this.viewerAndScrollPanel);
            this.viewerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerPanel.Location = new System.Drawing.Point(0, 53);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(866, 526);
            this.viewerPanel.TabIndex = 5;
            // 
            // viewerAndScrollPanel
            // 
            this.viewerAndScrollPanel.Controls.Add(this.statusStrip1);
            this.viewerAndScrollPanel.Controls.Add(this.splitContainer1);
            this.viewerAndScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewerAndScrollPanel.Location = new System.Drawing.Point(0, 0);
            this.viewerAndScrollPanel.Name = "viewerAndScrollPanel";
            this.viewerAndScrollPanel.Size = new System.Drawing.Size(866, 526);
            this.viewerAndScrollPanel.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 8, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.planarSliceImageViewer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.multiSliceImageViewer);
            this.splitContainer1.Size = new System.Drawing.Size(866, 505);
            this.splitContainer1.SplitterDistance = 433;
            this.splitContainer1.TabIndex = 7;
            // 
            // multiSliceImageViewer
            // 
            this.multiSliceImageViewer.BackColor = System.Drawing.Color.Transparent;
            this.multiSliceImageViewer.CenterImage = true;
            this.multiSliceImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiSliceImageViewer.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.multiSliceImageViewer.Location = new System.Drawing.Point(0, 0);
            this.multiSliceImageViewer.Name = "multiSliceImageViewer";
            this.multiSliceImageViewer.ShortcutCopy = System.Windows.Forms.Shortcut.None;
            this.multiSliceImageViewer.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.multiSliceImageViewer.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.multiSliceImageViewer.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.multiSliceImageViewer.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.multiSliceImageViewer.Size = new System.Drawing.Size(429, 505);
            this.multiSliceImageViewer.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.Zoom;
            this.multiSliceImageViewer.TabIndex = 1;
            this.multiSliceImageViewer.Text = "imageViewer2";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Controls.Add(this.toolStripPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(866, 53);
            this.topPanel.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_saveViewerScreenshotToolStripMenuItem,
            this.file_saveImageSliceToolStripMenuItem,
            this.toolStripSeparator6,
            this.file_saveSlicesToMultipageTIFFToolStripMenuItem,
            this.toolStripSeparator7,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // file_saveViewerScreenshotToolStripMenuItem
            // 
            this.file_saveViewerScreenshotToolStripMenuItem.Name = "file_saveViewerScreenshotToolStripMenuItem";
            this.file_saveViewerScreenshotToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.file_saveViewerScreenshotToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.file_saveViewerScreenshotToolStripMenuItem.Text = "Save Viewer Screenshot...";
            this.file_saveViewerScreenshotToolStripMenuItem.Click += new System.EventHandler(this.file_saveViewerScreenshotToolStripMenuItem_Click);
            // 
            // file_saveImageSliceToolStripMenuItem
            // 
            this.file_saveImageSliceToolStripMenuItem.Name = "file_saveImageSliceToolStripMenuItem";
            this.file_saveImageSliceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_saveImageSliceToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.file_saveImageSliceToolStripMenuItem.Text = "Save Image Slice...";
            this.file_saveImageSliceToolStripMenuItem.Click += new System.EventHandler(this.file_saveImageSliceToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(239, 6);
            // 
            // file_saveSlicesToMultipageTIFFToolStripMenuItem
            // 
            this.file_saveSlicesToMultipageTIFFToolStripMenuItem.Name = "file_saveSlicesToMultipageTIFFToolStripMenuItem";
            this.file_saveSlicesToMultipageTIFFToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.file_saveSlicesToMultipageTIFFToolStripMenuItem.Text = "Save Slices To Multipage TIFF...";
            this.file_saveSlicesToMultipageTIFFToolStripMenuItem.Click += new System.EventHandler(this.file_saveSlicesToMultipageTIFFToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(239, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.file_exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_resetSceneToolStripMenuItem,
            this.view_fitSceneToolStripMenuItem,
            this.toolStripSeparator4,
            this.view_negativeImageToolStripMenuItem,
            this.view_resetWindowLevelToolStripMenuItem,
            this.view_resetToDefaultWindowLevelToolStripMenuItem,
            this.toolStripSeparator1,
            this.view_showTextOverlayToolStripMenuItem,
            this.view_textOverlaySettingsToolStripMenuItem,
            this.toolStripSeparator5,
            this.view_useInterpolationToolStripMenuItem,
            this.toolStripSeparator3,
            this.view_fullScreenToolStripMenuItem,
            this.view_topPanelAlwaysVisibleToolStripMenuItem,
            this.toolStripSeparator2,
            this.view_settingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownOpening += new System.EventHandler(this.viewToolStripMenuItem_DropDownOpening);
            // 
            // view_resetSceneToolStripMenuItem
            // 
            this.view_resetSceneToolStripMenuItem.Name = "view_resetSceneToolStripMenuItem";
            this.view_resetSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.view_resetSceneToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_resetSceneToolStripMenuItem.Text = "Reset Scene";
            this.view_resetSceneToolStripMenuItem.Click += new System.EventHandler(this.view_resetSceneToolStripMenuItem_Click);
            // 
            // view_fitSceneToolStripMenuItem
            // 
            this.view_fitSceneToolStripMenuItem.Name = "view_fitSceneToolStripMenuItem";
            this.view_fitSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.view_fitSceneToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_fitSceneToolStripMenuItem.Text = "Fit Scene";
            this.view_fitSceneToolStripMenuItem.Click += new System.EventHandler(this.view_fitSceneToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(277, 6);
            // 
            // view_negativeImageToolStripMenuItem
            // 
            this.view_negativeImageToolStripMenuItem.Name = "view_negativeImageToolStripMenuItem";
            this.view_negativeImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.view_negativeImageToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_negativeImageToolStripMenuItem.Text = "Is Negative";
            this.view_negativeImageToolStripMenuItem.Click += new System.EventHandler(this.view_negativeImageToolStripMenuItem_Click);
            // 
            // view_resetWindowLevelToolStripMenuItem
            // 
            this.view_resetWindowLevelToolStripMenuItem.Name = "view_resetWindowLevelToolStripMenuItem";
            this.view_resetWindowLevelToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_resetWindowLevelToolStripMenuItem.Text = "Reset Window Level";
            this.view_resetWindowLevelToolStripMenuItem.Click += new System.EventHandler(this.view_resetWindowLevelToolStripMenuItem_Click);
            // 
            // view_resetToDefaultWindowLevelToolStripMenuItem
            // 
            this.view_resetToDefaultWindowLevelToolStripMenuItem.Name = "view_resetToDefaultWindowLevelToolStripMenuItem";
            this.view_resetToDefaultWindowLevelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.view_resetToDefaultWindowLevelToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_resetToDefaultWindowLevelToolStripMenuItem.Text = "Reset To Default Window Level";
            this.view_resetToDefaultWindowLevelToolStripMenuItem.Click += new System.EventHandler(this.view_resetToDefaultWindowLevelToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // view_showTextOverlayToolStripMenuItem
            // 
            this.view_showTextOverlayToolStripMenuItem.Checked = true;
            this.view_showTextOverlayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view_showTextOverlayToolStripMenuItem.Name = "view_showTextOverlayToolStripMenuItem";
            this.view_showTextOverlayToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.view_showTextOverlayToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_showTextOverlayToolStripMenuItem.Text = "Show Text Overlay";
            this.view_showTextOverlayToolStripMenuItem.Click += new System.EventHandler(this.view_showTextOverlayToolStripMenuItem_Click);
            // 
            // view_textOverlaySettingsToolStripMenuItem
            // 
            this.view_textOverlaySettingsToolStripMenuItem.Name = "view_textOverlaySettingsToolStripMenuItem";
            this.view_textOverlaySettingsToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_textOverlaySettingsToolStripMenuItem.Text = "Text Overlay Settings...";
            this.view_textOverlaySettingsToolStripMenuItem.Click += new System.EventHandler(this.view_textOverlaySettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(277, 6);
            // 
            // view_useInterpolationToolStripMenuItem
            // 
            this.view_useInterpolationToolStripMenuItem.Checked = true;
            this.view_useInterpolationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view_useInterpolationToolStripMenuItem.Name = "view_useInterpolationToolStripMenuItem";
            this.view_useInterpolationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.view_useInterpolationToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_useInterpolationToolStripMenuItem.Text = "Use Interpolation";
            this.view_useInterpolationToolStripMenuItem.Click += new System.EventHandler(this.view_useInterpolationToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(277, 6);
            // 
            // view_fullScreenToolStripMenuItem
            // 
            this.view_fullScreenToolStripMenuItem.CheckOnClick = true;
            this.view_fullScreenToolStripMenuItem.Name = "view_fullScreenToolStripMenuItem";
            this.view_fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.view_fullScreenToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_fullScreenToolStripMenuItem.Text = "Full Screen";
            this.view_fullScreenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.view_fullScreenToolStripMenuItem_CheckedChanged);
            // 
            // view_topPanelAlwaysVisibleToolStripMenuItem
            // 
            this.view_topPanelAlwaysVisibleToolStripMenuItem.CheckOnClick = true;
            this.view_topPanelAlwaysVisibleToolStripMenuItem.Name = "view_topPanelAlwaysVisibleToolStripMenuItem";
            this.view_topPanelAlwaysVisibleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.view_topPanelAlwaysVisibleToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_topPanelAlwaysVisibleToolStripMenuItem.Text = "Top Panel Always Visible";
            this.view_topPanelAlwaysVisibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.view_topPanelAlwaysVisibleToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // view_settingsToolStripMenuItem
            // 
            this.view_settingsToolStripMenuItem.Name = "view_settingsToolStripMenuItem";
            this.view_settingsToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.view_settingsToolStripMenuItem.Text = "Settings...";
            this.view_settingsToolStripMenuItem.Click += new System.EventHandler(this.view_settingsToolStripMenuItem_Click);
            // 
            // MprPerpendicularMultiSliceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 579);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Name = "MprPerpendicularMultiSliceForm";
            this.Text = "Multi Slice";
            this.toolStripPanel.ResumeLayout(false);
            this.toolStripPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.viewerPanel.ResumeLayout(false);
            this.viewerAndScrollPanel.ResumeLayout(false);
            this.viewerAndScrollPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Vintasoft.Imaging.UI.ImageViewer planarSliceImageViewer;
        private System.Windows.Forms.ToolStripPanel toolStripPanel;
        private DemosCommonCode.Imaging.ImageViewerToolStrip imageViewerToolStrip1;
        private DicomMprViewerDemo.DicomMprToolInteractionModeToolStrip dicomMprToolInteractionModeToolStrip1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_saveViewerScreenshotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_saveImageSliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_resetSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_resetWindowLevelToolStripMenuItem;
        private System.Windows.Forms.Panel viewerPanel;
        private System.Windows.Forms.Panel viewerAndScrollPanel;
        private System.Windows.Forms.ToolStripMenuItem view_fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem view_showTextOverlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem view_topPanelAlwaysVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_fitSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_resetToDefaultWindowLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem view_negativeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem view_useInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem view_settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_textOverlaySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_saveSlicesToMultipageTIFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Vintasoft.Imaging.UI.ImageViewer multiSliceImageViewer;
    }
}