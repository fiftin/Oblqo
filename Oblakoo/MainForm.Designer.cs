﻿namespace Oblakoo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.fileListView = new System.Windows.Forms.ListView();
            this.fileNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileDateColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileSizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.fileInfoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filePropertiesPanel = new System.Windows.Forms.Panel();
            this.filePropertiesTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.widthAndHeightLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tasksTabPage = new System.Windows.Forms.TabPage();
            this.taskListView = new System.Windows.Forms.ListView();
            this.taskColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskTypeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PercentColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.taskMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cancelTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.driveRootLabel = new System.Windows.Forms.Label();
            this.driveTypeLabel = new System.Windows.Forms.Label();
            this.imageMaxSizeLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.vaultRegionLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vaultNameLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.logTabPage = new System.Windows.Forms.TabPage();
            this.logListView = new System.Windows.Forms.ListView();
            this.logDataTimeColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.logMessageColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.accountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.mainTool = new System.Windows.Forms.ToolStrip();
            this.uploadToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.uploadFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.refreshFilesToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.accountMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.changeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.newFolderToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFolderToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFilesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.downloadFromDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.loadingFileListProgressBar = new System.Windows.Forms.ProgressBar();
            this.loadingImageProgressBar = new System.Windows.Forms.ProgressBar();
            this.fileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadFileFromDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFileFromStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.downloadFolderFromDriveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadFolderFromStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFolderToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFilesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadingFoldersTimer = new System.Windows.Forms.Timer(this.components);
            this.logMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indicateErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.fileListMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFolderToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.synchronizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.fileInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.filePropertiesPanel.SuspendLayout();
            this.filePropertiesTable.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tasksTabPage.SuspendLayout();
            this.taskMenu.SuspendLayout();
            this.propertiesTabPage.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.logTabPage.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.mainTool.SuspendLayout();
            this.accountMenu.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.folderMenu.SuspendLayout();
            this.logMenu.SuspendLayout();
            this.fileListMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(2, 0, 0, 1);
            this.splitContainer1.Size = new System.Drawing.Size(948, 503);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.splitContainer2.Panel1MinSize = 250;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.fileListView);
            this.splitContainer2.Panel2.Controls.Add(this.splitter1);
            this.splitContainer2.Panel2.Controls.Add(this.fileInfoPanel);
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.splitContainer2.Size = new System.Drawing.Size(948, 270);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.SplitterWidth = 8;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.smallImageList;
            this.treeView1.ItemHeight = 20;
            this.treeView1.Location = new System.Drawing.Point(2, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(248, 270);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "folder");
            this.smallImageList.Images.SetKeyName(1, "file_old");
            this.smallImageList.Images.SetKeyName(2, "download");
            this.smallImageList.Images.SetKeyName(3, "upload");
            this.smallImageList.Images.SetKeyName(4, "cloud_download");
            this.smallImageList.Images.SetKeyName(5, "cloud_upload");
            this.smallImageList.Images.SetKeyName(6, "file_text");
            this.smallImageList.Images.SetKeyName(7, "account");
            this.smallImageList.Images.SetKeyName(8, "account_disconnected");
            this.smallImageList.Images.SetKeyName(9, "delete");
            this.smallImageList.Images.SetKeyName(10, "process");
            this.smallImageList.Images.SetKeyName(11, "process90");
            this.smallImageList.Images.SetKeyName(12, "process180");
            this.smallImageList.Images.SetKeyName(13, "process270");
            this.smallImageList.Images.SetKeyName(14, "error");
            this.smallImageList.Images.SetKeyName(15, "info");
            this.smallImageList.Images.SetKeyName(16, "file_image_gif");
            this.smallImageList.Images.SetKeyName(17, "file_image_jpeg");
            this.smallImageList.Images.SetKeyName(18, "file_image_png");
            this.smallImageList.Images.SetKeyName(19, "file");
            this.smallImageList.Images.SetKeyName(20, "file_image");
            this.smallImageList.Images.SetKeyName(21, "file_text");
            this.smallImageList.Images.SetKeyName(22, "error_red");
            this.smallImageList.Images.SetKeyName(23, "ok");
            this.smallImageList.Images.SetKeyName(24, "run");
            this.smallImageList.Images.SetKeyName(25, "pause");
            this.smallImageList.Images.SetKeyName(26, "cancel");
            // 
            // fileListView
            // 
            this.fileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileNameColumnHeader,
            this.fileDateColumnHeader,
            this.fileSizeColumnHeader});
            this.fileListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileListView.FullRowSelect = true;
            this.fileListView.Location = new System.Drawing.Point(0, 0);
            this.fileListView.Name = "fileListView";
            this.fileListView.Size = new System.Drawing.Size(447, 270);
            this.fileListView.SmallImageList = this.smallImageList;
            this.fileListView.TabIndex = 1;
            this.fileListView.UseCompatibleStateImageBehavior = false;
            this.fileListView.View = System.Windows.Forms.View.Details;
            this.fileListView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.fileListView_DrawItem);
            this.fileListView.SelectedIndexChanged += new System.EventHandler(this.fileListView_SelectedIndexChanged);
            this.fileListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fileListView_MouseUp);
            this.fileListView.Move += new System.EventHandler(this.listView1_Move);
            this.fileListView.Resize += new System.EventHandler(this.listView1_Resize);
            // 
            // fileNameColumnHeader
            // 
            this.fileNameColumnHeader.Text = "Name";
            this.fileNameColumnHeader.Width = 250;
            // 
            // fileDateColumnHeader
            // 
            this.fileDateColumnHeader.Text = "Date";
            this.fileDateColumnHeader.Width = 100;
            // 
            // fileSizeColumnHeader
            // 
            this.fileSizeColumnHeader.Text = "Size";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(447, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 270);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // fileInfoPanel
            // 
            this.fileInfoPanel.Controls.Add(this.pictureBox1);
            this.fileInfoPanel.Controls.Add(this.filePropertiesPanel);
            this.fileInfoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.fileInfoPanel.Location = new System.Drawing.Point(455, 0);
            this.fileInfoPanel.MinimumSize = new System.Drawing.Size(233, 0);
            this.fileInfoPanel.Name = "fileInfoPanel";
            this.fileInfoPanel.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.fileInfoPanel.Size = new System.Drawing.Size(233, 270);
            this.fileInfoPanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(231, 135);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // filePropertiesPanel
            // 
            this.filePropertiesPanel.Controls.Add(this.filePropertiesTable);
            this.filePropertiesPanel.Controls.Add(this.fileNameLabel);
            this.filePropertiesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.filePropertiesPanel.Location = new System.Drawing.Point(0, 135);
            this.filePropertiesPanel.Name = "filePropertiesPanel";
            this.filePropertiesPanel.Size = new System.Drawing.Size(231, 135);
            this.filePropertiesPanel.TabIndex = 3;
            // 
            // filePropertiesTable
            // 
            this.filePropertiesTable.ColumnCount = 2;
            this.filePropertiesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.filePropertiesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.filePropertiesTable.Controls.Add(this.label1, 0, 0);
            this.filePropertiesTable.Controls.Add(this.fileSizeLabel, 1, 0);
            this.filePropertiesTable.Controls.Add(this.label3, 0, 1);
            this.filePropertiesTable.Controls.Add(this.widthAndHeightLabel, 1, 1);
            this.filePropertiesTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePropertiesTable.Location = new System.Drawing.Point(0, 31);
            this.filePropertiesTable.Name = "filePropertiesTable";
            this.filePropertiesTable.RowCount = 2;
            this.filePropertiesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filePropertiesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.filePropertiesTable.Size = new System.Drawing.Size(231, 40);
            this.filePropertiesTable.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "File size:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSizeLabel.Location = new System.Drawing.Point(108, 0);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(120, 20);
            this.fileSizeLabel.TabIndex = 1;
            this.fileSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Image size:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // widthAndHeightLabel
            // 
            this.widthAndHeightLabel.AutoSize = true;
            this.widthAndHeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.widthAndHeightLabel.Location = new System.Drawing.Point(108, 20);
            this.widthAndHeightLabel.Name = "widthAndHeightLabel";
            this.widthAndHeightLabel.Size = new System.Drawing.Size(120, 20);
            this.widthAndHeightLabel.TabIndex = 3;
            this.widthAndHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fileNameLabel.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(231, 31);
            this.fileNameLabel.TabIndex = 1;
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tasksTabPage);
            this.tabControl1.Controls.Add(this.propertiesTabPage);
            this.tabControl1.Controls.Add(this.logTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.smallImageList;
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(946, 224);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Deselecting);
            // 
            // tasksTabPage
            // 
            this.tasksTabPage.Controls.Add(this.taskListView);
            this.tasksTabPage.Location = new System.Drawing.Point(4, 23);
            this.tasksTabPage.Name = "tasksTabPage";
            this.tasksTabPage.Padding = new System.Windows.Forms.Padding(0, 2, 2, 1);
            this.tasksTabPage.Size = new System.Drawing.Size(938, 197);
            this.tasksTabPage.TabIndex = 0;
            this.tasksTabPage.Text = "Tasks";
            this.tasksTabPage.UseVisualStyleBackColor = true;
            // 
            // taskListView
            // 
            this.taskListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.taskColumnHeader,
            this.taskTypeColumnHeader,
            this.sizeColumnHeader,
            this.PercentColumnHeader});
            this.taskListView.ContextMenuStrip = this.taskMenu;
            this.taskListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taskListView.FullRowSelect = true;
            this.taskListView.HideSelection = false;
            this.taskListView.Location = new System.Drawing.Point(0, 2);
            this.taskListView.Name = "taskListView";
            this.taskListView.Size = new System.Drawing.Size(936, 194);
            this.taskListView.SmallImageList = this.smallImageList;
            this.taskListView.TabIndex = 0;
            this.taskListView.UseCompatibleStateImageBehavior = false;
            this.taskListView.View = System.Windows.Forms.View.Details;
            // 
            // taskColumnHeader
            // 
            this.taskColumnHeader.Text = "File/Folder";
            this.taskColumnHeader.Width = 180;
            // 
            // taskTypeColumnHeader
            // 
            this.taskTypeColumnHeader.Text = "Task";
            this.taskTypeColumnHeader.Width = 120;
            // 
            // sizeColumnHeader
            // 
            this.sizeColumnHeader.Text = "Size";
            // 
            // PercentColumnHeader
            // 
            this.PercentColumnHeader.Text = "%";
            // 
            // taskMenu
            // 
            this.taskMenu.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.taskMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelTaskToolStripMenuItem});
            this.taskMenu.Name = "taskMenu";
            this.taskMenu.Size = new System.Drawing.Size(117, 26);
            // 
            // cancelTaskToolStripMenuItem
            // 
            this.cancelTaskToolStripMenuItem.Name = "cancelTaskToolStripMenuItem";
            this.cancelTaskToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.cancelTaskToolStripMenuItem.Text = "Cancel";
            this.cancelTaskToolStripMenuItem.Click += new System.EventHandler(this.cancelTaskToolStripMenuItem_Click);
            // 
            // propertiesTabPage
            // 
            this.propertiesTabPage.Controls.Add(this.tableLayoutPanel2);
            this.propertiesTabPage.Controls.Add(this.tableLayoutPanel1);
            this.propertiesTabPage.Location = new System.Drawing.Point(4, 23);
            this.propertiesTabPage.Name = "propertiesTabPage";
            this.propertiesTabPage.Padding = new System.Windows.Forms.Padding(0, 2, 2, 1);
            this.propertiesTabPage.Size = new System.Drawing.Size(938, 197);
            this.propertiesTabPage.TabIndex = 1;
            this.propertiesTabPage.Text = "Properties";
            this.propertiesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.90354F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.09647F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.driveRootLabel, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.driveTypeLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.imageMaxSizeLabel, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(269, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 194);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(3, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Root path:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(3, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Image size:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driveRootLabel
            // 
            this.driveRootLabel.AutoSize = true;
            this.driveRootLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveRootLabel.Location = new System.Drawing.Point(95, 55);
            this.driveRootLabel.Name = "driveRootLabel";
            this.driveRootLabel.Size = new System.Drawing.Size(213, 22);
            this.driveRootLabel.TabIndex = 3;
            this.driveRootLabel.Text = "driveRootLabel";
            this.driveRootLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // driveTypeLabel
            // 
            this.driveTypeLabel.AutoSize = true;
            this.driveTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.driveTypeLabel.Location = new System.Drawing.Point(95, 33);
            this.driveTypeLabel.Name = "driveTypeLabel";
            this.driveTypeLabel.Size = new System.Drawing.Size(213, 22);
            this.driveTypeLabel.TabIndex = 4;
            this.driveTypeLabel.Text = "driveTypeLabel";
            this.driveTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imageMaxSizeLabel
            // 
            this.imageMaxSizeLabel.AutoSize = true;
            this.imageMaxSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageMaxSizeLabel.Location = new System.Drawing.Point(95, 77);
            this.imageMaxSizeLabel.Name = "imageMaxSizeLabel";
            this.imageMaxSizeLabel.Size = new System.Drawing.Size(213, 22);
            this.imageMaxSizeLabel.TabIndex = 5;
            this.imageMaxSizeLabel.Text = "imageMaxSizeLabel";
            this.imageMaxSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label9, 2);
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(3, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(305, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "Drive";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.24242F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.75758F));
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.vaultRegionLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.vaultNameLabel, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(269, 194);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(68, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(198, 22);
            this.label11.TabIndex = 8;
            this.label11.Text = "Amazon Glacier";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(3, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "Type:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // vaultRegionLabel
            // 
            this.vaultRegionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vaultRegionLabel.Location = new System.Drawing.Point(68, 55);
            this.vaultRegionLabel.Name = "vaultRegionLabel";
            this.vaultRegionLabel.Size = new System.Drawing.Size(198, 22);
            this.vaultRegionLabel.TabIndex = 3;
            this.vaultRegionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Region:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vault:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vaultNameLabel
            // 
            this.vaultNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.vaultNameLabel.Location = new System.Drawing.Point(68, 77);
            this.vaultNameLabel.Name = "vaultNameLabel";
            this.vaultNameLabel.Size = new System.Drawing.Size(198, 22);
            this.vaultNameLabel.TabIndex = 4;
            this.vaultNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label8, 2);
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(263, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "Archive";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logTabPage
            // 
            this.logTabPage.Controls.Add(this.logListView);
            this.logTabPage.Location = new System.Drawing.Point(4, 23);
            this.logTabPage.Name = "logTabPage";
            this.logTabPage.Padding = new System.Windows.Forms.Padding(0, 2, 2, 1);
            this.logTabPage.Size = new System.Drawing.Size(938, 197);
            this.logTabPage.TabIndex = 2;
            this.logTabPage.Text = "Log";
            this.logTabPage.UseVisualStyleBackColor = true;
            // 
            // logListView
            // 
            this.logListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.logDataTimeColumnHeader,
            this.logMessageColumnHeader});
            this.logListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logListView.FullRowSelect = true;
            this.logListView.Location = new System.Drawing.Point(0, 2);
            this.logListView.MultiSelect = false;
            this.logListView.Name = "logListView";
            this.logListView.Size = new System.Drawing.Size(936, 194);
            this.logListView.SmallImageList = this.smallImageList;
            this.logListView.TabIndex = 2;
            this.logListView.UseCompatibleStateImageBehavior = false;
            this.logListView.View = System.Windows.Forms.View.Details;
            this.logListView.SelectedIndexChanged += new System.EventHandler(this.logListView_SelectedIndexChanged);
            this.logListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logListView_MouseDown);
            // 
            // logDataTimeColumnHeader
            // 
            this.logDataTimeColumnHeader.Text = "Time";
            this.logDataTimeColumnHeader.Width = 140;
            // 
            // logMessageColumnHeader
            // 
            this.logMessageColumnHeader.Text = "Message";
            this.logMessageColumnHeader.Width = 600;
            // 
            // accountsToolStripMenuItem
            // 
            this.accountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewAccountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            this.accountsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.accountsToolStripMenuItem.Text = "&Accounts";
            // 
            // addNewAccountToolStripMenuItem
            // 
            this.addNewAccountToolStripMenuItem.Name = "addNewAccountToolStripMenuItem";
            this.addNewAccountToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.addNewAccountToolStripMenuItem.Text = "A&dd new account";
            this.addNewAccountToolStripMenuItem.Click += new System.EventHandler(this.addNewAccountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(948, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // mainTool
            // 
            this.mainTool.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainTool.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadToolStripDropDownButton,
            this.newFolderToolStripButton,
            this.refreshFilesToolStripButton});
            this.mainTool.Location = new System.Drawing.Point(0, 24);
            this.mainTool.Name = "mainTool";
            this.mainTool.Size = new System.Drawing.Size(948, 25);
            this.mainTool.TabIndex = 2;
            this.mainTool.Text = "toolStrip2";
            // 
            // uploadToolStripDropDownButton
            // 
            this.uploadToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uploadFolderToolStripMenuItem,
            this.uploadFileToolStripMenuItem});
            this.uploadToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("uploadToolStripDropDownButton.Image")));
            this.uploadToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uploadToolStripDropDownButton.Name = "uploadToolStripDropDownButton";
            this.uploadToolStripDropDownButton.Size = new System.Drawing.Size(78, 22);
            this.uploadToolStripDropDownButton.Text = "Upload";
            // 
            // uploadFolderToolStripMenuItem
            // 
            this.uploadFolderToolStripMenuItem.Name = "uploadFolderToolStripMenuItem";
            this.uploadFolderToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.uploadFolderToolStripMenuItem.Text = "Upload folder";
            this.uploadFolderToolStripMenuItem.Click += new System.EventHandler(this.uploadFolderToolStripMenuItem_Click);
            // 
            // uploadFileToolStripMenuItem
            // 
            this.uploadFileToolStripMenuItem.Name = "uploadFileToolStripMenuItem";
            this.uploadFileToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.uploadFileToolStripMenuItem.Text = "Upload files";
            this.uploadFileToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // newFolderToolStripButton
            // 
            this.newFolderToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newFolderToolStripButton.Image")));
            this.newFolderToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newFolderToolStripButton.Name = "newFolderToolStripButton";
            this.newFolderToolStripButton.Size = new System.Drawing.Size(97, 22);
            this.newFolderToolStripButton.Text = "New folder";
            this.newFolderToolStripButton.Click += new System.EventHandler(this.newFolderToolStripButton_Click);
            // 
            // refreshFilesToolStripButton
            // 
            this.refreshFilesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshFilesToolStripButton.Image")));
            this.refreshFilesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshFilesToolStripButton.Name = "refreshFilesToolStripButton";
            this.refreshFilesToolStripButton.Size = new System.Drawing.Size(76, 22);
            this.refreshFilesToolStripButton.Text = "Refresh";
            this.refreshFilesToolStripButton.Click += new System.EventHandler(this.refreshFilesToolStripButton_Click);
            // 
            // accountMenu
            // 
            this.accountMenu.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.accountMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator2,
            this.changeAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem,
            this.toolStripSeparator5,
            this.newFolderToolStripMenuItem2,
            this.uploadFolderToolStripMenuItem3,
            this.uploadFilesToolStripMenuItem2,
            this.toolStripSeparator6,
            this.downloadFromDriveToolStripMenuItem});
            this.accountMenu.Name = "accountContextMenuStrip";
            this.accountMenu.Size = new System.Drawing.Size(208, 198);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
            // 
            // changeAccountToolStripMenuItem
            // 
            this.changeAccountToolStripMenuItem.Name = "changeAccountToolStripMenuItem";
            this.changeAccountToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.changeAccountToolStripMenuItem.Text = "Change account";
            this.changeAccountToolStripMenuItem.Click += new System.EventHandler(this.changeAccountToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete account";
            this.deleteAccountToolStripMenuItem.Click += new System.EventHandler(this.deleteAccountToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(204, 6);
            // 
            // newFolderToolStripMenuItem2
            // 
            this.newFolderToolStripMenuItem2.Name = "newFolderToolStripMenuItem2";
            this.newFolderToolStripMenuItem2.Size = new System.Drawing.Size(207, 22);
            this.newFolderToolStripMenuItem2.Text = "New folder";
            this.newFolderToolStripMenuItem2.Click += new System.EventHandler(this.newFolderToolStripButton_Click);
            // 
            // uploadFolderToolStripMenuItem3
            // 
            this.uploadFolderToolStripMenuItem3.Name = "uploadFolderToolStripMenuItem3";
            this.uploadFolderToolStripMenuItem3.Size = new System.Drawing.Size(207, 22);
            this.uploadFolderToolStripMenuItem3.Text = "Upload folder";
            this.uploadFolderToolStripMenuItem3.Click += new System.EventHandler(this.uploadFolderToolStripMenuItem_Click);
            // 
            // uploadFilesToolStripMenuItem2
            // 
            this.uploadFilesToolStripMenuItem2.Name = "uploadFilesToolStripMenuItem2";
            this.uploadFilesToolStripMenuItem2.Size = new System.Drawing.Size(207, 22);
            this.uploadFilesToolStripMenuItem2.Text = "Upload files";
            this.uploadFilesToolStripMenuItem2.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(204, 6);
            // 
            // downloadFromDriveToolStripMenuItem
            // 
            this.downloadFromDriveToolStripMenuItem.Name = "downloadFromDriveToolStripMenuItem";
            this.downloadFromDriveToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.downloadFromDriveToolStripMenuItem.Text = "Download from drive";
            this.downloadFromDriveToolStripMenuItem.Click += new System.EventHandler(this.downloadFromDriveToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // loadingFileListProgressBar
            // 
            this.loadingFileListProgressBar.Location = new System.Drawing.Point(297, 348);
            this.loadingFileListProgressBar.Name = "loadingFileListProgressBar";
            this.loadingFileListProgressBar.Size = new System.Drawing.Size(399, 19);
            this.loadingFileListProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingFileListProgressBar.TabIndex = 1;
            this.loadingFileListProgressBar.Value = 10;
            this.loadingFileListProgressBar.Visible = false;
            // 
            // loadingImageProgressBar
            // 
            this.loadingImageProgressBar.Location = new System.Drawing.Point(702, 348);
            this.loadingImageProgressBar.Name = "loadingImageProgressBar";
            this.loadingImageProgressBar.Size = new System.Drawing.Size(232, 19);
            this.loadingImageProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loadingImageProgressBar.TabIndex = 3;
            this.loadingImageProgressBar.Value = 10;
            this.loadingImageProgressBar.Visible = false;
            // 
            // fileMenu
            // 
            this.fileMenu.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadFileFromDriveToolStripMenuItem,
            this.downloadFileFromStorageToolStripMenuItem,
            this.synchronizeToolStripMenuItem,
            this.toolStripSeparator1,
            this.deleteFileToolStripMenuItem});
            this.fileMenu.Name = "fileContextMenuStrip";
            this.fileMenu.Size = new System.Drawing.Size(222, 98);
            // 
            // downloadFileFromDriveToolStripMenuItem
            // 
            this.downloadFileFromDriveToolStripMenuItem.Name = "downloadFileFromDriveToolStripMenuItem";
            this.downloadFileFromDriveToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.downloadFileFromDriveToolStripMenuItem.Text = "Download from drive";
            this.downloadFileFromDriveToolStripMenuItem.Click += new System.EventHandler(this.downloadFileFromDriveToolStripMenuItem_Click);
            // 
            // downloadFileFromStorageToolStripMenuItem
            // 
            this.downloadFileFromStorageToolStripMenuItem.Name = "downloadFileFromStorageToolStripMenuItem";
            this.downloadFileFromStorageToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.downloadFileFromStorageToolStripMenuItem.Text = "Download from archive";
            this.downloadFileFromStorageToolStripMenuItem.Click += new System.EventHandler(this.downloadFileFromStorageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(218, 6);
            // 
            // deleteFileToolStripMenuItem
            // 
            this.deleteFileToolStripMenuItem.Name = "deleteFileToolStripMenuItem";
            this.deleteFileToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deleteFileToolStripMenuItem.Text = "Delete";
            this.deleteFileToolStripMenuItem.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // folderMenu
            // 
            this.folderMenu.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.folderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadFolderFromDriveToolStripMenuItem,
            this.downloadFolderFromStorageToolStripMenuItem,
            this.toolStripSeparator3,
            this.newFolderToolStripMenuItem,
            this.uploadFolderToolStripMenuItem2,
            this.uploadFilesToolStripMenuItem1,
            this.toolStripSeparator4,
            this.deleteFolderToolStripMenuItem});
            this.folderMenu.Name = "folderContextMenuStrip";
            this.folderMenu.Size = new System.Drawing.Size(222, 148);
            // 
            // downloadFolderFromDriveToolStripMenuItem
            // 
            this.downloadFolderFromDriveToolStripMenuItem.Name = "downloadFolderFromDriveToolStripMenuItem";
            this.downloadFolderFromDriveToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.downloadFolderFromDriveToolStripMenuItem.Text = "Download from drive";
            this.downloadFolderFromDriveToolStripMenuItem.Click += new System.EventHandler(this.downloadFolderFromDriveToolStripMenuItem_Click);
            // 
            // downloadFolderFromStorageToolStripMenuItem
            // 
            this.downloadFolderFromStorageToolStripMenuItem.Name = "downloadFolderFromStorageToolStripMenuItem";
            this.downloadFolderFromStorageToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.downloadFolderFromStorageToolStripMenuItem.Text = "Download from archive";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(218, 6);
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.newFolderToolStripMenuItem.Text = "New folder";
            this.newFolderToolStripMenuItem.Click += new System.EventHandler(this.newFolderToolStripButton_Click);
            // 
            // uploadFolderToolStripMenuItem2
            // 
            this.uploadFolderToolStripMenuItem2.Name = "uploadFolderToolStripMenuItem2";
            this.uploadFolderToolStripMenuItem2.Size = new System.Drawing.Size(221, 22);
            this.uploadFolderToolStripMenuItem2.Text = "Upload folder";
            this.uploadFolderToolStripMenuItem2.Click += new System.EventHandler(this.uploadFolderToolStripMenuItem_Click);
            // 
            // uploadFilesToolStripMenuItem1
            // 
            this.uploadFilesToolStripMenuItem1.Name = "uploadFilesToolStripMenuItem1";
            this.uploadFilesToolStripMenuItem1.Size = new System.Drawing.Size(221, 22);
            this.uploadFilesToolStripMenuItem1.Text = "Upload files";
            this.uploadFilesToolStripMenuItem1.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(218, 6);
            // 
            // deleteFolderToolStripMenuItem
            // 
            this.deleteFolderToolStripMenuItem.Name = "deleteFolderToolStripMenuItem";
            this.deleteFolderToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.deleteFolderToolStripMenuItem.Text = "Delete";
            this.deleteFolderToolStripMenuItem.Click += new System.EventHandler(this.deleteFolderToolStripMenuItem_Click);
            // 
            // loadingFoldersTimer
            // 
            this.loadingFoldersTimer.Enabled = true;
            this.loadingFoldersTimer.Interval = 150;
            this.loadingFoldersTimer.Tick += new System.EventHandler(this.loadingFoldersTimer_Tick);
            // 
            // logMenu
            // 
            this.logMenu.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.logMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDescriptionToolStripMenuItem});
            this.logMenu.Name = "logMenu";
            this.logMenu.Size = new System.Drawing.Size(124, 26);
            // 
            // showDescriptionToolStripMenuItem
            // 
            this.showDescriptionToolStripMenuItem.Name = "showDescriptionToolStripMenuItem";
            this.showDescriptionToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.showDescriptionToolStripMenuItem.Text = "Details";
            this.showDescriptionToolStripMenuItem.Click += new System.EventHandler(this.showDescriptionToolStripMenuItem_Click);
            // 
            // indicateErrorTimer
            // 
            this.indicateErrorTimer.Interval = 150;
            this.indicateErrorTimer.Tick += new System.EventHandler(this.indicateErrorTimer_Tick);
            // 
            // fileListMenu
            // 
            this.fileListMenu.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileListMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem1,
            this.uploadFolderToolStripMenuItem1,
            this.uploadFilesToolStripMenuItem});
            this.fileListMenu.Name = "fileListMenu";
            this.fileListMenu.Size = new System.Drawing.Size(166, 70);
            // 
            // newFolderToolStripMenuItem1
            // 
            this.newFolderToolStripMenuItem1.Name = "newFolderToolStripMenuItem1";
            this.newFolderToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.newFolderToolStripMenuItem1.Text = "New folder";
            this.newFolderToolStripMenuItem1.Click += new System.EventHandler(this.newFolderToolStripButton_Click);
            // 
            // uploadFolderToolStripMenuItem1
            // 
            this.uploadFolderToolStripMenuItem1.Name = "uploadFolderToolStripMenuItem1";
            this.uploadFolderToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.uploadFolderToolStripMenuItem1.Text = "Upload folder";
            this.uploadFolderToolStripMenuItem1.Click += new System.EventHandler(this.uploadFolderToolStripMenuItem_Click);
            // 
            // uploadFilesToolStripMenuItem
            // 
            this.uploadFilesToolStripMenuItem.Name = "uploadFilesToolStripMenuItem";
            this.uploadFilesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.uploadFilesToolStripMenuItem.Text = "Upload files";
            this.uploadFilesToolStripMenuItem.Click += new System.EventHandler(this.uploadFileToolStripMenuItem_Click);
            // 
            // synchronizeToolStripMenuItem
            // 
            this.synchronizeToolStripMenuItem.Name = "synchronizeToolStripMenuItem";
            this.synchronizeToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.synchronizeToolStripMenuItem.Text = "Synchronize";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 552);
            this.Controls.Add(this.loadingImageProgressBar);
            this.Controls.Add(this.loadingFileListProgressBar);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainTool);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Oblakoo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.fileInfoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.filePropertiesPanel.ResumeLayout(false);
            this.filePropertiesTable.ResumeLayout(false);
            this.filePropertiesTable.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tasksTabPage.ResumeLayout(false);
            this.taskMenu.ResumeLayout(false);
            this.propertiesTabPage.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.logTabPage.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.mainTool.ResumeLayout(false);
            this.mainTool.PerformLayout();
            this.accountMenu.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
            this.folderMenu.ResumeLayout(false);
            this.logMenu.ResumeLayout(false);
            this.fileListMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView fileListView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tasksTabPage;
        private System.Windows.Forms.TabPage propertiesTabPage;
        private System.Windows.Forms.ListView taskListView;
        private System.Windows.Forms.ColumnHeader taskColumnHeader;
        private System.Windows.Forms.ColumnHeader sizeColumnHeader;
        private System.Windows.Forms.ColumnHeader PercentColumnHeader;
        private System.Windows.Forms.ToolStripMenuItem accountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStrip mainTool;
        private System.Windows.Forms.ToolStripButton newFolderToolStripButton;
        private System.Windows.Forms.ToolStripButton refreshFilesToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton uploadToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem uploadFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadFolderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip accountMenu;
        private System.Windows.Forms.ToolStripMenuItem changeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ImageList smallImageList;
        private System.Windows.Forms.ColumnHeader fileNameColumnHeader;
        private System.Windows.Forms.ColumnHeader fileDateColumnHeader;
        private System.Windows.Forms.ColumnHeader fileSizeColumnHeader;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel fileInfoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar loadingFileListProgressBar;
        private System.Windows.Forms.ProgressBar loadingImageProgressBar;
        private System.Windows.Forms.TableLayoutPanel filePropertiesTable;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label widthAndHeightLabel;
        private System.Windows.Forms.Panel filePropertiesPanel;
        private System.Windows.Forms.ContextMenuStrip fileMenu;
        private System.Windows.Forms.ContextMenuStrip folderMenu;
        private System.Windows.Forms.ToolStripMenuItem downloadFileFromDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFolderFromDriveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteFolderToolStripMenuItem;
        private System.Windows.Forms.TabPage logTabPage;
        private System.Windows.Forms.ListView logListView;
        private System.Windows.Forms.ToolStripMenuItem downloadFileFromStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downloadFolderFromStorageToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader logDataTimeColumnHeader;
        private System.Windows.Forms.ColumnHeader logMessageColumnHeader;
        private System.Windows.Forms.Timer loadingFoldersTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label vaultRegionLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label vaultNameLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripMenuItem downloadFromDriveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip taskMenu;
        private System.Windows.Forms.ToolStripMenuItem cancelTaskToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip logMenu;
        private System.Windows.Forms.ToolStripMenuItem showDescriptionToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label driveRootLabel;
        private System.Windows.Forms.Label driveTypeLabel;
        private System.Windows.Forms.Label imageMaxSizeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer indicateErrorTimer;
        private System.Windows.Forms.ColumnHeader taskTypeColumnHeader;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem uploadFolderToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uploadFilesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip fileListMenu;
        private System.Windows.Forms.ToolStripMenuItem uploadFolderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uploadFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem uploadFolderToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem uploadFilesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem synchronizeToolStripMenuItem;
    }
}

