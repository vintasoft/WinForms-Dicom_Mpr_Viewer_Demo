namespace DicomMprViewerDemo
{
    partial class MprCurvilinearSliceForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.viewersPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.planarSliceImageViewer = new Vintasoft.Imaging.UI.ImageViewer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.curvilinearSliceImageViewer = new Vintasoft.Imaging.UI.ImageViewer();
            this.perpendicularMultiSliceImageViewer = new Vintasoft.Imaging.UI.ImageViewer();
            this.topPanel = new System.Windows.Forms.Panel();
            this.toolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.imageViewerToolStrip1 = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.dicomMprToolInteractionModeToolStrip1 = new DicomMprViewerDemo.DicomMprToolInteractionModeToolStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_saveAllImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.file_copyImageToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.file_saveImageSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_saveAllImagesSlicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.savePerpendicularMultiSliceImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePerpendicularMultiSliceImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.file_copyImageSliceToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_resetSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_fitSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.view_synchronizeWindowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_negativeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_resetWindowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_resetToDefaultWindowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.view_showWindowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_showAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_showPatientDirectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_showMPRParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_showSlicePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.view_useInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.view_fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.view_topPanelAlwaysVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.view_textOverlaySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.view_settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slice_buildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slice_build_byPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slice_build_freehandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.slice_createPerpendicularMultiSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perpendicularMultiSlicePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHidePerpendicularMultiSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainPanel.SuspendLayout();
            this.viewersPanel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.toolStripPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.viewersPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(884, 662);
            this.mainPanel.TabIndex = 0;
            // 
            // viewersPanel
            // 
            this.viewersPanel.Controls.Add(this.splitContainer1);
            this.viewersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewersPanel.Location = new System.Drawing.Point(0, 52);
            this.viewersPanel.Name = "viewersPanel";
            this.viewersPanel.Size = new System.Drawing.Size(884, 610);
            this.viewersPanel.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.planarSliceImageViewer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 610);
            this.splitContainer1.SplitterDistance = 401;
            this.splitContainer1.TabIndex = 0;
            // 
            // planarSliceImageViewer
            // 
            this.planarSliceImageViewer.BackColor = System.Drawing.Color.Black;
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
            this.planarSliceImageViewer.Size = new System.Drawing.Size(401, 610);
            this.planarSliceImageViewer.TabIndex = 0;
            this.planarSliceImageViewer.Text = "imageViewer1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.curvilinearSliceImageViewer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.perpendicularMultiSliceImageViewer);
            this.splitContainer2.Panel2Collapsed = true;
            this.splitContainer2.Size = new System.Drawing.Size(479, 610);
            this.splitContainer2.SplitterDistance = 305;
            this.splitContainer2.TabIndex = 1;
            // 
            // curvilinearSliceImageViewer
            // 
            this.curvilinearSliceImageViewer.BackColor = System.Drawing.Color.Black;
            this.curvilinearSliceImageViewer.CenterImage = true;
            this.curvilinearSliceImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curvilinearSliceImageViewer.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.curvilinearSliceImageViewer.Location = new System.Drawing.Point(0, 0);
            this.curvilinearSliceImageViewer.Name = "curvilinearSliceImageViewer";
            this.curvilinearSliceImageViewer.ShortcutCopy = System.Windows.Forms.Shortcut.None;
            this.curvilinearSliceImageViewer.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.curvilinearSliceImageViewer.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.curvilinearSliceImageViewer.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.curvilinearSliceImageViewer.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.curvilinearSliceImageViewer.Size = new System.Drawing.Size(479, 610);
            this.curvilinearSliceImageViewer.TabIndex = 0;
            this.curvilinearSliceImageViewer.Text = "imageViewer2";
            // 
            // perpendicularMultiSliceImageViewer
            // 
            this.perpendicularMultiSliceImageViewer.BackColor = System.Drawing.Color.Black;
            this.perpendicularMultiSliceImageViewer.CenterImage = true;
            this.perpendicularMultiSliceImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perpendicularMultiSliceImageViewer.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.perpendicularMultiSliceImageViewer.Location = new System.Drawing.Point(0, 0);
            this.perpendicularMultiSliceImageViewer.Name = "perpendicularMultiSliceImageViewer";
            this.perpendicularMultiSliceImageViewer.ShortcutCopy = System.Windows.Forms.Shortcut.None;
            this.perpendicularMultiSliceImageViewer.ShortcutCut = System.Windows.Forms.Shortcut.None;
            this.perpendicularMultiSliceImageViewer.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.perpendicularMultiSliceImageViewer.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.perpendicularMultiSliceImageViewer.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.perpendicularMultiSliceImageViewer.Size = new System.Drawing.Size(150, 46);
            this.perpendicularMultiSliceImageViewer.TabIndex = 1;
            this.perpendicularMultiSliceImageViewer.Text = "imageViewer2";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.toolStripPanel);
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(884, 52);
            this.topPanel.TabIndex = 0;
            // 
            // toolStripPanel
            // 
            this.toolStripPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripPanel.Controls.Add(this.imageViewerToolStrip1);
            this.toolStripPanel.Controls.Add(this.dicomMprToolInteractionModeToolStrip1);
            this.toolStripPanel.Location = new System.Drawing.Point(0, 22);
            this.toolStripPanel.Name = "toolStripPanel";
            this.toolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel.Size = new System.Drawing.Size(884, 27);
            // 
            // imageViewerToolStrip1
            // 
            this.imageViewerToolStrip1.AssociatedZoomTrackBar = null;
            this.imageViewerToolStrip1.CanChangeSizeMode = false;
            this.imageViewerToolStrip1.CanNavigate = false;
            this.imageViewerToolStrip1.CanOpenFile = false;
            this.imageViewerToolStrip1.CanPrint = false;
            this.imageViewerToolStrip1.CaptureFromCameraButtonEnabled = true;
            this.imageViewerToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.imageViewerToolStrip1.ImageViewer = null;
            this.imageViewerToolStrip1.Location = new System.Drawing.Point(3, 0);
            this.imageViewerToolStrip1.Name = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.PrintButtonEnabled = true;
            this.imageViewerToolStrip1.ScanButtonEnabled = true;
            this.imageViewerToolStrip1.Size = new System.Drawing.Size(145, 25);
            this.imageViewerToolStrip1.TabIndex = 3;
            this.imageViewerToolStrip1.Text = "imageViewerToolStrip1";
            // 
            // dicomMprToolInteractionModeToolStrip1
            // 
            this.dicomMprToolInteractionModeToolStrip1.DicomMprTools = null;
            this.dicomMprToolInteractionModeToolStrip1.DisabledInteractionModes = null;
            this.dicomMprToolInteractionModeToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.dicomMprToolInteractionModeToolStrip1.Location = new System.Drawing.Point(152, 0);
            this.dicomMprToolInteractionModeToolStrip1.Name = "dicomMprToolInteractionModeToolStrip1";
            this.dicomMprToolInteractionModeToolStrip1.Size = new System.Drawing.Size(218, 25);
            this.dicomMprToolInteractionModeToolStrip1.SupportedInteractionModes = new Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode[] {
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Browse,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Pan,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Roll,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.WindowLevel,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Zoom,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Measure,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.ViewProcessing};
            this.dicomMprToolInteractionModeToolStrip1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.sliceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_saveImageToolStripMenuItem,
            this.file_saveAllImagesToolStripMenuItem,
            this.toolStripSeparator5,
            this.file_copyImageToClipboardToolStripMenuItem,
            this.toolStripSeparator6,
            this.file_saveImageSliceToolStripMenuItem,
            this.file_saveAllImagesSlicesToolStripMenuItem,
            this.toolStripSeparator10,
            this.savePerpendicularMultiSliceImageToolStripMenuItem,
            this.savePerpendicularMultiSliceImagesToolStripMenuItem,
            this.toolStripSeparator7,
            this.file_copyImageSliceToClipboardToolStripMenuItem,
            this.toolStripSeparator9,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // file_saveImageToolStripMenuItem
            // 
            this.file_saveImageToolStripMenuItem.Name = "file_saveImageToolStripMenuItem";
            this.file_saveImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.file_saveImageToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.file_saveImageToolStripMenuItem.Text = "Save Image...";
            this.file_saveImageToolStripMenuItem.Click += new System.EventHandler(this.file_saveImageToolStripMenuItem_Click);
            // 
            // file_saveAllImagesToolStripMenuItem
            // 
            this.file_saveAllImagesToolStripMenuItem.Name = "file_saveAllImagesToolStripMenuItem";
            this.file_saveAllImagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.file_saveAllImagesToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.file_saveAllImagesToolStripMenuItem.Text = "Save All Images...";
            this.file_saveAllImagesToolStripMenuItem.Click += new System.EventHandler(this.file_saveAllImagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(279, 6);
            // 
            // file_copyImageToClipboardToolStripMenuItem
            // 
            this.file_copyImageToClipboardToolStripMenuItem.Name = "file_copyImageToClipboardToolStripMenuItem";
            this.file_copyImageToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.file_copyImageToClipboardToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.file_copyImageToClipboardToolStripMenuItem.Text = "Copy Image To Clipboard";
            this.file_copyImageToClipboardToolStripMenuItem.Click += new System.EventHandler(this.file_copyImageToClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(279, 6);
            // 
            // file_saveImageSliceToolStripMenuItem
            // 
            this.file_saveImageSliceToolStripMenuItem.Name = "file_saveImageSliceToolStripMenuItem";
            this.file_saveImageSliceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.file_saveImageSliceToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.file_saveImageSliceToolStripMenuItem.Text = "Save Image Slice...";
            this.file_saveImageSliceToolStripMenuItem.Click += new System.EventHandler(this.file_saveImageSliceToolStripMenuItem_Click);
            // 
            // file_saveAllImagesSlicesToolStripMenuItem
            // 
            this.file_saveAllImagesSlicesToolStripMenuItem.Name = "file_saveAllImagesSlicesToolStripMenuItem";
            this.file_saveAllImagesSlicesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.file_saveAllImagesSlicesToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.file_saveAllImagesSlicesToolStripMenuItem.Text = "Save All Images Slices...";
            this.file_saveAllImagesSlicesToolStripMenuItem.Click += new System.EventHandler(this.file_saveAllImagesSlicesToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(279, 6);
            // 
            // savePerpendicularMultiSliceImageToolStripMenuItem
            // 
            this.savePerpendicularMultiSliceImageToolStripMenuItem.Name = "savePerpendicularMultiSliceImageToolStripMenuItem";
            this.savePerpendicularMultiSliceImageToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.savePerpendicularMultiSliceImageToolStripMenuItem.Text = "Save Perpendicular Multi Slice Image...";
            this.savePerpendicularMultiSliceImageToolStripMenuItem.Click += new System.EventHandler(this.savePerpendicularMultiSliceImageToolStripMenuItem_Click);
            // 
            // savePerpendicularMultiSliceImagesToolStripMenuItem
            // 
            this.savePerpendicularMultiSliceImagesToolStripMenuItem.Name = "savePerpendicularMultiSliceImagesToolStripMenuItem";
            this.savePerpendicularMultiSliceImagesToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.savePerpendicularMultiSliceImagesToolStripMenuItem.Text = "Save Perpendicular Multi Slice Images...";
            this.savePerpendicularMultiSliceImagesToolStripMenuItem.Click += new System.EventHandler(this.savePerpendicularMultiSliceImagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(279, 6);
            // 
            // file_copyImageSliceToClipboardToolStripMenuItem
            // 
            this.file_copyImageSliceToClipboardToolStripMenuItem.Name = "file_copyImageSliceToClipboardToolStripMenuItem";
            this.file_copyImageSliceToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.file_copyImageSliceToClipboardToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.file_copyImageSliceToClipboardToolStripMenuItem.Text = "Copy Image Slice To Clipboard";
            this.file_copyImageSliceToClipboardToolStripMenuItem.Click += new System.EventHandler(this.file_copyImageSliceToClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(279, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(282, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.file_exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.view_resetSceneToolStripMenuItem,
            this.view_fitSceneToolStripMenuItem,
            this.toolStripSeparator1,
            this.view_synchronizeWindowLevelToolStripMenuItem,
            this.view_negativeImageToolStripMenuItem,
            this.view_resetWindowLevelToolStripMenuItem,
            this.view_resetToDefaultWindowLevelToolStripMenuItem,
            this.toolStripSeparator2,
            this.view_showWindowLevelToolStripMenuItem,
            this.view_showAxisToolStripMenuItem,
            this.view_showPatientDirectionToolStripMenuItem,
            this.view_showMPRParametersToolStripMenuItem,
            this.view_showSlicePropertiesToolStripMenuItem,
            this.toolStripSeparator3,
            this.view_useInterpolationToolStripMenuItem,
            this.view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem,
            this.toolStripSeparator4,
            this.view_fullScreenToolStripMenuItem,
            this.view_topPanelAlwaysVisibleToolStripMenuItem,
            this.toolStripSeparator8,
            this.view_textOverlaySettingsToolStripMenuItem,
            this.toolStripSeparator12,
            this.processingToolStripMenuItem,
            this.toolStripSeparator13,
            this.view_settingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownOpened += new System.EventHandler(this.viewToolStripMenuItem_DropDownOpening);
            // 
            // view_resetSceneToolStripMenuItem
            // 
            this.view_resetSceneToolStripMenuItem.Name = "view_resetSceneToolStripMenuItem";
            this.view_resetSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.view_resetSceneToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_resetSceneToolStripMenuItem.Text = "Reset Scene";
            this.view_resetSceneToolStripMenuItem.Click += new System.EventHandler(this.view_resetSceneToolStripMenuItem_Click);
            // 
            // view_fitSceneToolStripMenuItem
            // 
            this.view_fitSceneToolStripMenuItem.Name = "view_fitSceneToolStripMenuItem";
            this.view_fitSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.view_fitSceneToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_fitSceneToolStripMenuItem.Text = "Fit Scene";
            this.view_fitSceneToolStripMenuItem.Click += new System.EventHandler(this.view_fitSceneToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(332, 6);
            // 
            // view_synchronizeWindowLevelToolStripMenuItem
            // 
            this.view_synchronizeWindowLevelToolStripMenuItem.Checked = true;
            this.view_synchronizeWindowLevelToolStripMenuItem.CheckOnClick = true;
            this.view_synchronizeWindowLevelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view_synchronizeWindowLevelToolStripMenuItem.Name = "view_synchronizeWindowLevelToolStripMenuItem";
            this.view_synchronizeWindowLevelToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_synchronizeWindowLevelToolStripMenuItem.Text = "Synchronize Window Level";
            this.view_synchronizeWindowLevelToolStripMenuItem.Click += new System.EventHandler(this.view_synchronizeWindowLevelToolStripMenuItem_Click);
            // 
            // view_negativeImageToolStripMenuItem
            // 
            this.view_negativeImageToolStripMenuItem.Name = "view_negativeImageToolStripMenuItem";
            this.view_negativeImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.view_negativeImageToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_negativeImageToolStripMenuItem.Text = "Is Negative";
            this.view_negativeImageToolStripMenuItem.Click += new System.EventHandler(this.view_negativeImageToolStripMenuItem_Click);
            // 
            // view_resetWindowLevelToolStripMenuItem
            // 
            this.view_resetWindowLevelToolStripMenuItem.Name = "view_resetWindowLevelToolStripMenuItem";
            this.view_resetWindowLevelToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_resetWindowLevelToolStripMenuItem.Text = "Reset Window Level";
            this.view_resetWindowLevelToolStripMenuItem.Click += new System.EventHandler(this.view_resetWindowLevelToolStripMenuItem_Click);
            // 
            // view_resetToDefaultWindowLevelToolStripMenuItem
            // 
            this.view_resetToDefaultWindowLevelToolStripMenuItem.Name = "view_resetToDefaultWindowLevelToolStripMenuItem";
            this.view_resetToDefaultWindowLevelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.view_resetToDefaultWindowLevelToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_resetToDefaultWindowLevelToolStripMenuItem.Text = "Reset To Default Window Level";
            this.view_resetToDefaultWindowLevelToolStripMenuItem.Click += new System.EventHandler(this.view_resetToDefaultWindowLevelToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(332, 6);
            // 
            // view_showWindowLevelToolStripMenuItem
            // 
            this.view_showWindowLevelToolStripMenuItem.Checked = true;
            this.view_showWindowLevelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view_showWindowLevelToolStripMenuItem.Name = "view_showWindowLevelToolStripMenuItem";
            this.view_showWindowLevelToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_showWindowLevelToolStripMenuItem.Text = "Show Window Level";
            this.view_showWindowLevelToolStripMenuItem.Click += new System.EventHandler(this.view_showWindowLevelToolStripMenuItem_Click);
            // 
            // view_showAxisToolStripMenuItem
            // 
            this.view_showAxisToolStripMenuItem.Checked = true;
            this.view_showAxisToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view_showAxisToolStripMenuItem.Name = "view_showAxisToolStripMenuItem";
            this.view_showAxisToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_showAxisToolStripMenuItem.Text = "Show Axis";
            this.view_showAxisToolStripMenuItem.Click += new System.EventHandler(this.view_showAxisToolStripMenuItem_Click);
            // 
            // view_showPatientDirectionToolStripMenuItem
            // 
            this.view_showPatientDirectionToolStripMenuItem.Checked = true;
            this.view_showPatientDirectionToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view_showPatientDirectionToolStripMenuItem.Name = "view_showPatientDirectionToolStripMenuItem";
            this.view_showPatientDirectionToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_showPatientDirectionToolStripMenuItem.Text = "Show Patient Direction";
            this.view_showPatientDirectionToolStripMenuItem.Click += new System.EventHandler(this.view_showPatientDirectionToolStripMenuItem_Click);
            // 
            // view_showMPRParametersToolStripMenuItem
            // 
            this.view_showMPRParametersToolStripMenuItem.Name = "view_showMPRParametersToolStripMenuItem";
            this.view_showMPRParametersToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_showMPRParametersToolStripMenuItem.Text = "Show MPR Parameters...";
            this.view_showMPRParametersToolStripMenuItem.Click += new System.EventHandler(this.view_showMPRParametersToolStripMenuItem_Click);
            // 
            // view_showSlicePropertiesToolStripMenuItem
            // 
            this.view_showSlicePropertiesToolStripMenuItem.Name = "view_showSlicePropertiesToolStripMenuItem";
            this.view_showSlicePropertiesToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_showSlicePropertiesToolStripMenuItem.Text = "Show Slice Properties...";
            this.view_showSlicePropertiesToolStripMenuItem.Click += new System.EventHandler(this.view_showSlicePropertiesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(332, 6);
            // 
            // view_useInterpolationToolStripMenuItem
            // 
            this.view_useInterpolationToolStripMenuItem.Checked = true;
            this.view_useInterpolationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view_useInterpolationToolStripMenuItem.Name = "view_useInterpolationToolStripMenuItem";
            this.view_useInterpolationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.view_useInterpolationToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_useInterpolationToolStripMenuItem.Text = "Use Interpolation";
            this.view_useInterpolationToolStripMenuItem.Click += new System.EventHandler(this.view_useInterpolationToolStripMenuItem_Click);
            // 
            // view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem
            // 
            this.view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem.Checked = true;
            this.view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem.CheckOnClick = true;
            this.view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem.Name = "view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem";
            this.view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem.Text = "Automatically Change Zoom When Slice Building";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(332, 6);
            // 
            // view_fullScreenToolStripMenuItem
            // 
            this.view_fullScreenToolStripMenuItem.CheckOnClick = true;
            this.view_fullScreenToolStripMenuItem.Name = "view_fullScreenToolStripMenuItem";
            this.view_fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.view_fullScreenToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_fullScreenToolStripMenuItem.Text = "Full Screen";
            this.view_fullScreenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.view_fullScreenToolStripMenuItem_CheckedChanged);
            // 
            // view_topPanelAlwaysVisibleToolStripMenuItem
            // 
            this.view_topPanelAlwaysVisibleToolStripMenuItem.CheckOnClick = true;
            this.view_topPanelAlwaysVisibleToolStripMenuItem.Name = "view_topPanelAlwaysVisibleToolStripMenuItem";
            this.view_topPanelAlwaysVisibleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.view_topPanelAlwaysVisibleToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_topPanelAlwaysVisibleToolStripMenuItem.Text = "Top Panel Always Visible";
            this.view_topPanelAlwaysVisibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.view_topPanelAlwaysVisibleToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(332, 6);
            // 
            // view_textOverlaySettingsToolStripMenuItem
            // 
            this.view_textOverlaySettingsToolStripMenuItem.Name = "view_textOverlaySettingsToolStripMenuItem";
            this.view_textOverlaySettingsToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_textOverlaySettingsToolStripMenuItem.Text = "Text Overlay Settings...";
            this.view_textOverlaySettingsToolStripMenuItem.Click += new System.EventHandler(this.view_textOverlaySettingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(332, 6);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processingToolStripComboBox});
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.processingToolStripMenuItem.Text = "Processing";
            // 
            // processingToolStripComboBox
            // 
            this.processingToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processingToolStripComboBox.Name = "processingToolStripComboBox";
            this.processingToolStripComboBox.Size = new System.Drawing.Size(121, 23);
            this.processingToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.processingToolStripComboBox_SelectedIndexChanged);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(332, 6);
            // 
            // view_settingsToolStripMenuItem
            // 
            this.view_settingsToolStripMenuItem.Name = "view_settingsToolStripMenuItem";
            this.view_settingsToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.view_settingsToolStripMenuItem.Text = "Settings...";
            this.view_settingsToolStripMenuItem.Click += new System.EventHandler(this.view_settingsToolStripMenuItem_Click);
            // 
            // sliceToolStripMenuItem
            // 
            this.sliceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slice_buildToolStripMenuItem,
            this.toolStripSeparator11,
            this.slice_createPerpendicularMultiSliceToolStripMenuItem,
            this.perpendicularMultiSlicePropertiesToolStripMenuItem,
            this.showHidePerpendicularMultiSliceToolStripMenuItem});
            this.sliceToolStripMenuItem.Name = "sliceToolStripMenuItem";
            this.sliceToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sliceToolStripMenuItem.Text = "Slice";
            // 
            // slice_buildToolStripMenuItem
            // 
            this.slice_buildToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slice_build_byPointsToolStripMenuItem,
            this.slice_build_freehandToolStripMenuItem});
            this.slice_buildToolStripMenuItem.Name = "slice_buildToolStripMenuItem";
            this.slice_buildToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.slice_buildToolStripMenuItem.Text = "Build Curvlinear";
            // 
            // slice_build_byPointsToolStripMenuItem
            // 
            this.slice_build_byPointsToolStripMenuItem.Name = "slice_build_byPointsToolStripMenuItem";
            this.slice_build_byPointsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.slice_build_byPointsToolStripMenuItem.Text = "By Points";
            this.slice_build_byPointsToolStripMenuItem.Click += new System.EventHandler(this.slice_build_byPointsToolStripMenuItem_Click);
            // 
            // slice_build_freehandToolStripMenuItem
            // 
            this.slice_build_freehandToolStripMenuItem.Name = "slice_build_freehandToolStripMenuItem";
            this.slice_build_freehandToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.slice_build_freehandToolStripMenuItem.Text = "Freehand";
            this.slice_build_freehandToolStripMenuItem.Click += new System.EventHandler(this.slice_build_freehandToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(267, 6);
            // 
            // slice_createPerpendicularMultiSliceToolStripMenuItem
            // 
            this.slice_createPerpendicularMultiSliceToolStripMenuItem.Name = "slice_createPerpendicularMultiSliceToolStripMenuItem";
            this.slice_createPerpendicularMultiSliceToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.slice_createPerpendicularMultiSliceToolStripMenuItem.Text = "Create Perpendicular Multi Slice";
            this.slice_createPerpendicularMultiSliceToolStripMenuItem.Click += new System.EventHandler(this.slice_createPerpendicularMultiSliceToolStripMenuItem_Click);
            // 
            // perpendicularMultiSlicePropertiesToolStripMenuItem
            // 
            this.perpendicularMultiSlicePropertiesToolStripMenuItem.Enabled = false;
            this.perpendicularMultiSlicePropertiesToolStripMenuItem.Name = "perpendicularMultiSlicePropertiesToolStripMenuItem";
            this.perpendicularMultiSlicePropertiesToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.perpendicularMultiSlicePropertiesToolStripMenuItem.Text = "Perpendicular Multi Slice Properties...";
            this.perpendicularMultiSlicePropertiesToolStripMenuItem.Click += new System.EventHandler(this.perpendicularMultiSlicePropertiesToolStripMenuItem_Click);
            // 
            // showHidePerpendicularMultiSliceToolStripMenuItem
            // 
            this.showHidePerpendicularMultiSliceToolStripMenuItem.Checked = true;
            this.showHidePerpendicularMultiSliceToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showHidePerpendicularMultiSliceToolStripMenuItem.Name = "showHidePerpendicularMultiSliceToolStripMenuItem";
            this.showHidePerpendicularMultiSliceToolStripMenuItem.Size = new System.Drawing.Size(270, 22);
            this.showHidePerpendicularMultiSliceToolStripMenuItem.Text = "Show/Hide Perpendicular Multi Slice";
            this.showHidePerpendicularMultiSliceToolStripMenuItem.Click += new System.EventHandler(this.showHidePerpendicularMultiSliceToolStripMenuItem_Click);
            // 
            // MprCurvilinearSliceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 662);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MprCurvilinearSliceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MPR Curvilinear Slice";
            this.mainPanel.ResumeLayout(false);
            this.viewersPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.toolStripPanel.ResumeLayout(false);
            this.toolStripPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel viewersPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Vintasoft.Imaging.UI.ImageViewer planarSliceImageViewer;
        private Vintasoft.Imaging.UI.ImageViewer curvilinearSliceImageViewer;
        private System.Windows.Forms.ToolStripPanel toolStripPanel;
        private DemosCommonCode.Imaging.ImageViewerToolStrip imageViewerToolStrip1;
        private DicomMprToolInteractionModeToolStrip dicomMprToolInteractionModeToolStrip1;
        private System.Windows.Forms.ToolStripMenuItem view_resetSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_fitSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem view_negativeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_resetWindowLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_resetToDefaultWindowLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem view_showWindowLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_showPatientDirectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem view_useInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem view_fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_topPanelAlwaysVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_synchronizeWindowLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_showAxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_showMPRParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_saveAllImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem file_copyImageToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem file_saveImageSliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem file_saveAllImagesSlicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem file_copyImageSliceToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slice_buildToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem view_settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_automaticallyChangeZoomWhenSliceBuildingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_textOverlaySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem view_showSlicePropertiesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Vintasoft.Imaging.UI.ImageViewer perpendicularMultiSliceImageViewer;
        private System.Windows.Forms.ToolStripMenuItem slice_createPerpendicularMultiSliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perpendicularMultiSlicePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem savePerpendicularMultiSliceImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePerpendicularMultiSliceImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem showHidePerpendicularMultiSliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slice_build_byPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slice_build_freehandToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.ToolStripComboBox processingToolStripComboBox;
    }
}