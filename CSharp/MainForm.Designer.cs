namespace DicomMprViewerDemo
{
    partial class MainForm
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
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard4 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            Vintasoft.Imaging.Codecs.Decoders.RenderingSettings renderingSettings4 = new Vintasoft.Imaging.Codecs.Decoders.RenderingSettings();
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard5 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            Vintasoft.Imaging.Codecs.Decoders.RenderingSettings renderingSettings5 = new Vintasoft.Imaging.Codecs.Decoders.RenderingSettings();
            Vintasoft.Imaging.Utils.WinFormsSystemClipboard winFormsSystemClipboard6 = new Vintasoft.Imaging.Utils.WinFormsSystemClipboard();
            Vintasoft.Imaging.Codecs.Decoders.RenderingSettings renderingSettings6 = new Vintasoft.Imaging.Codecs.Decoders.RenderingSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.actionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.imageInfoToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.viewersPanel = new System.Windows.Forms.Panel();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.dicomSeriesManagerControl1 = new Vintasoft.Imaging.Dicom.UI.DicomSeriesManagerControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.imageViewer1 = new Vintasoft.Imaging.UI.ImageViewer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.imageViewer2 = new Vintasoft.Imaging.UI.ImageViewer();
            this.imageViewer3 = new Vintasoft.Imaging.UI.ImageViewer();
            this.topPanel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDICOMFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDICOMFilesFromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllImagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyImageToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllImagesSlicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyImageSliceToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.closeDICOMSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.synchronizeWindowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativeImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToDefaultWindowLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.useInterpolationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.showAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.show3DAxisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMPRParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topPanelAlwaysVisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.textOverlaySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTextOverlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mPRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sagittalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coronalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.curvilinearSliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvilinearSliceOnSagittalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvilinearSliceOnCoronalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curvilinearSliceOnAxialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.mprImagePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.imageViewerToolStrip1 = new DemosCommonCode.Imaging.ImageViewerToolStrip();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.dicomMprToolInteractionModeToolStrip1 = new DicomMprViewerDemo.DicomMprToolInteractionModeToolStrip();
            this.openDicomFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mainPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.viewersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStripPanel.SuspendLayout();
            this.imageViewerToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.statusStrip1);
            this.mainPanel.Controls.Add(this.viewersPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1011, 622);
            this.mainPanel.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.actionLabel,
            this.toolStripStatusLabel1,
            this.imageInfoToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1011, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(197, 16);
            this.progressBar1.Visible = false;
            // 
            // actionLabel
            // 
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(73, 17);
            this.actionLabel.Text = "Action Label";
            this.actionLabel.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(693, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // imageInfoToolStripStatusLabel
            // 
            this.imageInfoToolStripStatusLabel.Name = "imageInfoToolStripStatusLabel";
            this.imageInfoToolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // viewersPanel
            // 
            this.viewersPanel.Controls.Add(this.mainSplitContainer);
            this.viewersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewersPanel.Location = new System.Drawing.Point(0, 52);
            this.viewersPanel.Name = "viewersPanel";
            this.viewersPanel.Size = new System.Drawing.Size(1011, 570);
            this.viewersPanel.TabIndex = 4;
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.dicomSeriesManagerControl1);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.splitContainer1);
            this.mainSplitContainer.Size = new System.Drawing.Size(1011, 570);
            this.mainSplitContainer.SplitterDistance = 200;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // dicomSeriesManagerControl1
            // 
            this.dicomSeriesManagerControl1.BackColor = System.Drawing.Color.Black;
            this.dicomSeriesManagerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dicomSeriesManagerControl1.FocusedSeriesIdentifier = null;
            this.dicomSeriesManagerControl1.IsKeyboardNavigationEnabled = true;
            this.dicomSeriesManagerControl1.Location = new System.Drawing.Point(0, 0);
            this.dicomSeriesManagerControl1.Name = "dicomSeriesManagerControl1";
            this.dicomSeriesManagerControl1.PanelTextPadding = new System.Windows.Forms.Padding(1);
            this.dicomSeriesManagerControl1.PatientPanelFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dicomSeriesManagerControl1.PatientPanelPadding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.dicomSeriesManagerControl1.SelectedSeriesPanelFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dicomSeriesManagerControl1.SeriesImageCountFont = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.dicomSeriesManagerControl1.SeriesImageCountPadding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.dicomSeriesManagerControl1.SeriesImageCountTextColor = System.Drawing.Color.White;
            this.dicomSeriesManagerControl1.SeriesPanelFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.dicomSeriesManagerControl1.SeriesPanelPadding = new System.Windows.Forms.Padding(0);
            this.dicomSeriesManagerControl1.Size = new System.Drawing.Size(200, 570);
            this.dicomSeriesManagerControl1.StudyPanelFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.dicomSeriesManagerControl1.StudyPanelPadding = new System.Windows.Forms.Padding(0);
            this.dicomSeriesManagerControl1.TabIndex = 0;
            this.dicomSeriesManagerControl1.Text = "dicomSeriesManagerControl1";
            this.dicomSeriesManagerControl1.TextBlockFontDefaultValue = new System.Drawing.Font("Consolas", 10F);
            this.dicomSeriesManagerControl1.TextBlockTextColorDefaultValue = System.Drawing.Color.White;
            this.dicomSeriesManagerControl1.ThumbnailImageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dicomSeriesManagerControl1.ThumbnailImageBorderWidth = 1;
            this.dicomSeriesManagerControl1.ThumbnailImagePadding = new System.Windows.Forms.Padding(6, 0, 6, 6);
            this.dicomSeriesManagerControl1.ThumbnailImageSize = new System.Drawing.Size(150, 150);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.imageViewer1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(807, 570);
            this.splitContainer1.SplitterDistance = 407;
            this.splitContainer1.TabIndex = 1;
            // 
            // imageViewer1
            // 
            this.imageViewer1.BackColor = System.Drawing.Color.Transparent;
            this.imageViewer1.CenterImage = true;
            this.imageViewer1.Clipboard = winFormsSystemClipboard4;
            this.imageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer1.FastScrollingCursor = System.Windows.Forms.Cursors.SizeAll;
            this.imageViewer1.FastScrollingInterval = 10;
            this.imageViewer1.FastScrollingMinDistance = 5F;
            this.imageViewer1.FastScrollingMouseButton = System.Windows.Forms.MouseButtons.Middle;
            this.imageViewer1.FastScrollingScale = 0.5F;
            this.imageViewer1.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.imageViewer1.ImageRenderingSettings = renderingSettings4;
            this.imageViewer1.ImageRotationAngle = 0;
            this.imageViewer1.Location = new System.Drawing.Point(0, 0);
            this.imageViewer1.Name = "imageViewer1";
            this.imageViewer1.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer1.Size = new System.Drawing.Size(407, 570);
            this.imageViewer1.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.imageViewer1.TabIndex = 0;
            this.imageViewer1.Text = "imageViewer1";
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
            this.splitContainer2.Panel1.Controls.Add(this.imageViewer2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.imageViewer3);
            this.splitContainer2.Size = new System.Drawing.Size(396, 570);
            this.splitContainer2.SplitterDistance = 274;
            this.splitContainer2.TabIndex = 0;
            // 
            // imageViewer2
            // 
            this.imageViewer2.BackColor = System.Drawing.Color.Transparent;
            this.imageViewer2.CenterImage = true;
            this.imageViewer2.Clipboard = winFormsSystemClipboard5;
            this.imageViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer2.FastScrollingCursor = System.Windows.Forms.Cursors.SizeAll;
            this.imageViewer2.FastScrollingInterval = 10;
            this.imageViewer2.FastScrollingMinDistance = 5F;
            this.imageViewer2.FastScrollingMouseButton = System.Windows.Forms.MouseButtons.Middle;
            this.imageViewer2.FastScrollingScale = 0.5F;
            this.imageViewer2.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.imageViewer2.ImageRenderingSettings = renderingSettings5;
            this.imageViewer2.ImageRotationAngle = 0;
            this.imageViewer2.Location = new System.Drawing.Point(0, 0);
            this.imageViewer2.Name = "imageViewer2";
            this.imageViewer2.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer2.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer2.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer2.Size = new System.Drawing.Size(396, 274);
            this.imageViewer2.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.imageViewer2.TabIndex = 0;
            this.imageViewer2.Text = "imageViewer2";
            // 
            // imageViewer3
            // 
            this.imageViewer3.BackColor = System.Drawing.Color.Transparent;
            this.imageViewer3.CenterImage = true;
            this.imageViewer3.Clipboard = winFormsSystemClipboard6;
            this.imageViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageViewer3.FastScrollingCursor = System.Windows.Forms.Cursors.SizeAll;
            this.imageViewer3.FastScrollingInterval = 10;
            this.imageViewer3.FastScrollingMinDistance = 5F;
            this.imageViewer3.FastScrollingMouseButton = System.Windows.Forms.MouseButtons.Middle;
            this.imageViewer3.FastScrollingScale = 0.5F;
            this.imageViewer3.FocusPointAnchor = Vintasoft.Imaging.AnchorType.None;
            this.imageViewer3.ImageRenderingSettings = renderingSettings6;
            this.imageViewer3.ImageRotationAngle = 0;
            this.imageViewer3.Location = new System.Drawing.Point(0, 0);
            this.imageViewer3.Name = "imageViewer3";
            this.imageViewer3.ShortcutDelete = System.Windows.Forms.Shortcut.None;
            this.imageViewer3.ShortcutInsert = System.Windows.Forms.Shortcut.None;
            this.imageViewer3.ShortcutSelectAll = System.Windows.Forms.Shortcut.None;
            this.imageViewer3.Size = new System.Drawing.Size(396, 292);
            this.imageViewer3.SizeMode = Vintasoft.Imaging.UI.ImageSizeMode.BestFit;
            this.imageViewer3.TabIndex = 0;
            this.imageViewer3.Text = "imageViewer3";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.menuStrip1);
            this.topPanel.Controls.Add(this.toolStripPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1011, 52);
            this.topPanel.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.mPRToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDICOMFilesToolStripMenuItem,
            this.openDICOMFilesFromFolderToolStripMenuItem,
            this.toolStripSeparator11,
            this.saveImageToolStripMenuItem,
            this.saveAllImagesToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyImageToClipboardToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveImageSliceToolStripMenuItem,
            this.saveAllImagesSlicesToolStripMenuItem,
            this.toolStripSeparator3,
            this.copyImageSliceToClipboardToolStripMenuItem,
            this.toolStripSeparator10,
            this.closeDICOMSeriesToolStripMenuItem,
            this.toolStripSeparator13,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openDICOMFilesToolStripMenuItem
            // 
            this.openDICOMFilesToolStripMenuItem.Name = "openDICOMFilesToolStripMenuItem";
            this.openDICOMFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openDICOMFilesToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.openDICOMFilesToolStripMenuItem.Text = "Open DICOM File(s) ...";
            this.openDICOMFilesToolStripMenuItem.Click += new System.EventHandler(this.openDICOMFilesToolStripMenuItem_Click);
            // 
            // openDICOMFilesFromFolderToolStripMenuItem
            // 
            this.openDICOMFilesFromFolderToolStripMenuItem.Name = "openDICOMFilesFromFolderToolStripMenuItem";
            this.openDICOMFilesFromFolderToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.openDICOMFilesFromFolderToolStripMenuItem.Text = "Open DICOM Files From Folder...";
            this.openDICOMFilesFromFolderToolStripMenuItem.Click += new System.EventHandler(this.openDICOMFilesFromFolderToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(306, 6);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.saveImageToolStripMenuItem.Text = "Save Viewer Screenshot...";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // saveAllImagesToolStripMenuItem
            // 
            this.saveAllImagesToolStripMenuItem.Name = "saveAllImagesToolStripMenuItem";
            this.saveAllImagesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllImagesToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.saveAllImagesToolStripMenuItem.Text = "Save All Viewers Screenshots...";
            this.saveAllImagesToolStripMenuItem.Click += new System.EventHandler(this.saveAllImagesToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(306, 6);
            // 
            // copyImageToClipboardToolStripMenuItem
            // 
            this.copyImageToClipboardToolStripMenuItem.Name = "copyImageToClipboardToolStripMenuItem";
            this.copyImageToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.copyImageToClipboardToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.copyImageToClipboardToolStripMenuItem.Text = "Copy Viewer Screenshot To Clipboard";
            this.copyImageToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyImageToClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(306, 6);
            // 
            // saveImageSliceToolStripMenuItem
            // 
            this.saveImageSliceToolStripMenuItem.Name = "saveImageSliceToolStripMenuItem";
            this.saveImageSliceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImageSliceToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.saveImageSliceToolStripMenuItem.Text = "Save Image Slice...";
            this.saveImageSliceToolStripMenuItem.Click += new System.EventHandler(this.saveImageSliceToolStripMenuItem_Click);
            // 
            // saveAllImagesSlicesToolStripMenuItem
            // 
            this.saveAllImagesSlicesToolStripMenuItem.Name = "saveAllImagesSlicesToolStripMenuItem";
            this.saveAllImagesSlicesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAllImagesSlicesToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.saveAllImagesSlicesToolStripMenuItem.Text = "Save All Images Slices...";
            this.saveAllImagesSlicesToolStripMenuItem.Click += new System.EventHandler(this.saveAllImagesSlicesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(306, 6);
            // 
            // copyImageSliceToClipboardToolStripMenuItem
            // 
            this.copyImageSliceToClipboardToolStripMenuItem.Name = "copyImageSliceToClipboardToolStripMenuItem";
            this.copyImageSliceToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyImageSliceToClipboardToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.copyImageSliceToClipboardToolStripMenuItem.Text = "Copy Image Slice To Clipboard";
            this.copyImageSliceToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyImageSliceToClipboardToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(306, 6);
            // 
            // closeDICOMSeriesToolStripMenuItem
            // 
            this.closeDICOMSeriesToolStripMenuItem.Name = "closeDICOMSeriesToolStripMenuItem";
            this.closeDICOMSeriesToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.closeDICOMSeriesToolStripMenuItem.Text = "Close DICOM Series";
            this.closeDICOMSeriesToolStripMenuItem.Click += new System.EventHandler(this.closeDICOMSeriesToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(306, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetSceneToolStripMenuItem,
            this.fitSceneToolStripMenuItem,
            this.toolStripSeparator7,
            this.synchronizeWindowLevelToolStripMenuItem,
            this.negativeImageToolStripMenuItem,
            this.resetToDefaultWindowLevelToolStripMenuItem,
            this.toolStripSeparator8,
            this.useInterpolationToolStripMenuItem,
            this.toolStripSeparator2,
            this.showAxisToolStripMenuItem,
            this.show3DAxisToolStripMenuItem,
            this.showMPRParametersToolStripMenuItem,
            this.toolStripSeparator6,
            this.fullScreenToolStripMenuItem,
            this.topPanelAlwaysVisibleToolStripMenuItem,
            this.toolStripSeparator5,
            this.textOverlaySettingsToolStripMenuItem,
            this.showTextOverlayToolStripMenuItem,
            this.toolStripSeparator9,
            this.settingsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // resetSceneToolStripMenuItem
            // 
            this.resetSceneToolStripMenuItem.Name = "resetSceneToolStripMenuItem";
            this.resetSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetSceneToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.resetSceneToolStripMenuItem.Text = "Reset Scene";
            this.resetSceneToolStripMenuItem.Click += new System.EventHandler(this.resetSceneToolStripMenuItem_Click);
            // 
            // fitSceneToolStripMenuItem
            // 
            this.fitSceneToolStripMenuItem.Name = "fitSceneToolStripMenuItem";
            this.fitSceneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fitSceneToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.fitSceneToolStripMenuItem.Text = "Fit Scene";
            this.fitSceneToolStripMenuItem.Click += new System.EventHandler(this.fitSceneToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(277, 6);
            // 
            // synchronizeWindowLevelToolStripMenuItem
            // 
            this.synchronizeWindowLevelToolStripMenuItem.Checked = true;
            this.synchronizeWindowLevelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.synchronizeWindowLevelToolStripMenuItem.Name = "synchronizeWindowLevelToolStripMenuItem";
            this.synchronizeWindowLevelToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.synchronizeWindowLevelToolStripMenuItem.Text = "Synchronize Window Level";
            this.synchronizeWindowLevelToolStripMenuItem.Click += new System.EventHandler(this.synchronizeWindowLevelToolStripMenuItem_Click);
            // 
            // negativeImageToolStripMenuItem
            // 
            this.negativeImageToolStripMenuItem.Name = "negativeImageToolStripMenuItem";
            this.negativeImageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.negativeImageToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.negativeImageToolStripMenuItem.Text = "Is Negative";
            this.negativeImageToolStripMenuItem.Click += new System.EventHandler(this.negativeImageToolStripMenuItem_Click);
            // 
            // resetToDefaultWindowLevelToolStripMenuItem
            // 
            this.resetToDefaultWindowLevelToolStripMenuItem.Name = "resetToDefaultWindowLevelToolStripMenuItem";
            this.resetToDefaultWindowLevelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.resetToDefaultWindowLevelToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.resetToDefaultWindowLevelToolStripMenuItem.Text = "Reset To Default Window Level";
            this.resetToDefaultWindowLevelToolStripMenuItem.Click += new System.EventHandler(this.resetToDefaultWindowLevelToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(277, 6);
            // 
            // useInterpolationToolStripMenuItem
            // 
            this.useInterpolationToolStripMenuItem.Checked = true;
            this.useInterpolationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useInterpolationToolStripMenuItem.Name = "useInterpolationToolStripMenuItem";
            this.useInterpolationToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.useInterpolationToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.useInterpolationToolStripMenuItem.Text = "Use Interpolation";
            this.useInterpolationToolStripMenuItem.Click += new System.EventHandler(this.useInterpolationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(277, 6);
            // 
            // showAxisToolStripMenuItem
            // 
            this.showAxisToolStripMenuItem.Checked = true;
            this.showAxisToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAxisToolStripMenuItem.Name = "showAxisToolStripMenuItem";
            this.showAxisToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.showAxisToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.showAxisToolStripMenuItem.Text = "Show Axis";
            this.showAxisToolStripMenuItem.Click += new System.EventHandler(this.showAxisToolStripMenuItem_Click);
            // 
            // show3DAxisToolStripMenuItem
            // 
            this.show3DAxisToolStripMenuItem.Name = "show3DAxisToolStripMenuItem";
            this.show3DAxisToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.show3DAxisToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.show3DAxisToolStripMenuItem.Text = "Show 3D Axis";
            this.show3DAxisToolStripMenuItem.Click += new System.EventHandler(this.show3DAxisToolStripMenuItem_Click);
            // 
            // showMPRParametersToolStripMenuItem
            // 
            this.showMPRParametersToolStripMenuItem.Name = "showMPRParametersToolStripMenuItem";
            this.showMPRParametersToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.showMPRParametersToolStripMenuItem.Text = "Show MPR Parameters";
            this.showMPRParametersToolStripMenuItem.Click += new System.EventHandler(this.showMPRParametersToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(277, 6);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.CheckOnClick = true;
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.fullScreenToolStripMenuItem_CheckedChanged);
            // 
            // topPanelAlwaysVisibleToolStripMenuItem
            // 
            this.topPanelAlwaysVisibleToolStripMenuItem.CheckOnClick = true;
            this.topPanelAlwaysVisibleToolStripMenuItem.Name = "topPanelAlwaysVisibleToolStripMenuItem";
            this.topPanelAlwaysVisibleToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.topPanelAlwaysVisibleToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.topPanelAlwaysVisibleToolStripMenuItem.Text = "Top Panel Always Visible";
            this.topPanelAlwaysVisibleToolStripMenuItem.CheckedChanged += new System.EventHandler(this.topPanelAlwaysVisibleToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(277, 6);
            // 
            // textOverlaySettingsToolStripMenuItem
            // 
            this.textOverlaySettingsToolStripMenuItem.Name = "textOverlaySettingsToolStripMenuItem";
            this.textOverlaySettingsToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.textOverlaySettingsToolStripMenuItem.Text = "Text Overlay Settings...";
            this.textOverlaySettingsToolStripMenuItem.Click += new System.EventHandler(this.textOverlaySettingsToolStripMenuItem_Click);
            // 
            // showTextOverlayToolStripMenuItem
            // 
            this.showTextOverlayToolStripMenuItem.Checked = true;
            this.showTextOverlayToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showTextOverlayToolStripMenuItem.Name = "showTextOverlayToolStripMenuItem";
            this.showTextOverlayToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.showTextOverlayToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.showTextOverlayToolStripMenuItem.Text = "Show Text Overlay";
            this.showTextOverlayToolStripMenuItem.Click += new System.EventHandler(this.showTextOverlayToolStripMenuItem_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(277, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(280, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // mPRToolStripMenuItem
            // 
            this.mPRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sagittalToolStripMenuItem,
            this.coronalToolStripMenuItem,
            this.axialToolStripMenuItem,
            this.toolStripSeparator14,
            this.curvilinearSliceToolStripMenuItem,
            this.toolStripSeparator15,
            this.mprImagePropertiesToolStripMenuItem});
            this.mPRToolStripMenuItem.Name = "mPRToolStripMenuItem";
            this.mPRToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.mPRToolStripMenuItem.Text = "MPR";
            // 
            // sagittalToolStripMenuItem
            // 
            this.sagittalToolStripMenuItem.Name = "sagittalToolStripMenuItem";
            this.sagittalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.sagittalToolStripMenuItem.Text = "Sagittal...";
            this.sagittalToolStripMenuItem.Click += new System.EventHandler(this.sagittalToolStripMenuItem_Click);
            // 
            // coronalToolStripMenuItem
            // 
            this.coronalToolStripMenuItem.Name = "coronalToolStripMenuItem";
            this.coronalToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.coronalToolStripMenuItem.Text = "Coronal...";
            this.coronalToolStripMenuItem.Click += new System.EventHandler(this.coronalToolStripMenuItem_Click);
            // 
            // axialToolStripMenuItem
            // 
            this.axialToolStripMenuItem.Name = "axialToolStripMenuItem";
            this.axialToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.axialToolStripMenuItem.Text = "Axial...";
            this.axialToolStripMenuItem.Click += new System.EventHandler(this.axialToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(197, 6);
            // 
            // curvilinearSliceToolStripMenuItem
            // 
            this.curvilinearSliceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.curvilinearSliceOnSagittalToolStripMenuItem,
            this.curvilinearSliceOnCoronalToolStripMenuItem,
            this.curvilinearSliceOnAxialToolStripMenuItem});
            this.curvilinearSliceToolStripMenuItem.Name = "curvilinearSliceToolStripMenuItem";
            this.curvilinearSliceToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.curvilinearSliceToolStripMenuItem.Text = "Curved MPR";
            // 
            // curvilinearSliceOnSagittalToolStripMenuItem
            // 
            this.curvilinearSliceOnSagittalToolStripMenuItem.Name = "curvilinearSliceOnSagittalToolStripMenuItem";
            this.curvilinearSliceOnSagittalToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.curvilinearSliceOnSagittalToolStripMenuItem.Text = "On Sagittal...";
            this.curvilinearSliceOnSagittalToolStripMenuItem.Click += new System.EventHandler(this.curvilinearSliceOnSagittalToolStripMenuItem_Click);
            // 
            // curvilinearSliceOnCoronalToolStripMenuItem
            // 
            this.curvilinearSliceOnCoronalToolStripMenuItem.Name = "curvilinearSliceOnCoronalToolStripMenuItem";
            this.curvilinearSliceOnCoronalToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.curvilinearSliceOnCoronalToolStripMenuItem.Text = "On Coronal...";
            this.curvilinearSliceOnCoronalToolStripMenuItem.Click += new System.EventHandler(this.curvilinearSliceOnCoronalToolStripMenuItem_Click);
            // 
            // curvilinearSliceOnAxialToolStripMenuItem
            // 
            this.curvilinearSliceOnAxialToolStripMenuItem.Name = "curvilinearSliceOnAxialToolStripMenuItem";
            this.curvilinearSliceOnAxialToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.curvilinearSliceOnAxialToolStripMenuItem.Text = "On Axial...";
            this.curvilinearSliceOnAxialToolStripMenuItem.Click += new System.EventHandler(this.curvilinearSliceOnAxialToolStripMenuItem_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(197, 6);
            // 
            // mprImagePropertiesToolStripMenuItem
            // 
            this.mprImagePropertiesToolStripMenuItem.Name = "mprImagePropertiesToolStripMenuItem";
            this.mprImagePropertiesToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.mprImagePropertiesToolStripMenuItem.Text = "MPR Image Properties...";
            this.mprImagePropertiesToolStripMenuItem.Click += new System.EventHandler(this.mprImagePropertiesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripPanel
            // 
            this.toolStripPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripPanel.Controls.Add(this.imageViewerToolStrip1);
            this.toolStripPanel.Controls.Add(this.dicomMprToolInteractionModeToolStrip1);
            this.toolStripPanel.Location = new System.Drawing.Point(0, 24);
            this.toolStripPanel.Name = "toolStripPanel";
            this.toolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel.Size = new System.Drawing.Size(1011, 28);
            // 
            // imageViewerToolStrip1
            // 
            this.imageViewerToolStrip1.AssociatedZoomTrackBar = null;
            this.imageViewerToolStrip1.CanNavigate = false;
            this.imageViewerToolStrip1.CanPrint = false;
            this.imageViewerToolStrip1.CanSaveFile = false;
            this.imageViewerToolStrip1.CaptureFromCameraButtonEnabled = true;
            this.imageViewerToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.imageViewerToolStrip1.ImageViewer = this.imageViewer1;
            this.imageViewerToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator12});
            this.imageViewerToolStrip1.Location = new System.Drawing.Point(3, 0);
            this.imageViewerToolStrip1.Name = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.PageCount = 0;
            this.imageViewerToolStrip1.PrintButtonEnabled = true;
            this.imageViewerToolStrip1.ScanButtonEnabled = true;
            this.imageViewerToolStrip1.Size = new System.Drawing.Size(151, 25);
            this.imageViewerToolStrip1.TabIndex = 3;
            this.imageViewerToolStrip1.Text = "imageViewerToolStrip1";
            this.imageViewerToolStrip1.UseImageViewerImages = true;
            this.imageViewerToolStrip1.OpenFile += new System.EventHandler(this.imageViewerToolStrip1_OpenFile);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // dicomMprToolInteractionModeToolStrip1
            // 
            this.dicomMprToolInteractionModeToolStrip1.DicomMprTools = null;
            this.dicomMprToolInteractionModeToolStrip1.DisabledInteractionModes = null;
            this.dicomMprToolInteractionModeToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.dicomMprToolInteractionModeToolStrip1.Location = new System.Drawing.Point(154, 0);
            this.dicomMprToolInteractionModeToolStrip1.Name = "dicomMprToolInteractionModeToolStrip1";
            this.dicomMprToolInteractionModeToolStrip1.Size = new System.Drawing.Size(218, 25);
            this.dicomMprToolInteractionModeToolStrip1.SupportedInteractionModes = new Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode[] {
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Browse,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Pan,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Roll,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Rotate3D,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Zoom,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.WindowLevel,
        Vintasoft.Imaging.Dicom.Mpr.UI.VisualTools.DicomMprToolInteractionMode.Measure};
            this.dicomMprToolInteractionModeToolStrip1.TabIndex = 4;
            // 
            // openDicomFileDialog
            // 
            this.openDicomFileDialog.Filter = "DICOM files|*.dcm;*.dic;*.acr|All files|*.*";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 622);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DicomMprViewerDemo";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.viewersPanel.ResumeLayout(false);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripPanel.ResumeLayout(false);
            this.toolStripPanel.PerformLayout();
            this.imageViewerToolStrip1.ResumeLayout(false);
            this.imageViewerToolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel viewersPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer2;
        private Vintasoft.Imaging.UI.ImageViewer imageViewer3;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllImagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem copyImageToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveImageSliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAllImagesSlicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyImageSliceToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem synchronizeWindowLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativeImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToDefaultWindowLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem useInterpolationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem showAxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem show3DAxisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMPRParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topPanelAlwaysVisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem textOverlaySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTextOverlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDICOMFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem openDICOMFilesFromFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDICOMSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator13;
        private System.Windows.Forms.OpenFileDialog openDicomFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel actionLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel imageInfoToolStripStatusLabel;
        private System.Windows.Forms.ToolStripPanel toolStripPanel;
        private DemosCommonCode.Imaging.ImageViewerToolStrip imageViewerToolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private DicomMprToolInteractionModeToolStrip dicomMprToolInteractionModeToolStrip1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem mPRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sagittalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coronalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem axialToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator14;
        private System.Windows.Forms.ToolStripMenuItem curvilinearSliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator15;
        private System.Windows.Forms.ToolStripMenuItem mprImagePropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvilinearSliceOnSagittalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvilinearSliceOnCoronalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curvilinearSliceOnAxialToolStripMenuItem;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private Vintasoft.Imaging.Dicom.UI.DicomSeriesManagerControl dicomSeriesManagerControl1;
    }
}