using System;
using System.Collections;
using System.Drawing;
using CourseProject.Tools;

namespace CourseProject
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowGrid = new CourseProject.MyButton();
            this.btnEnableGrid = new CourseProject.MyButton();
            this.pnlTools = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPointer = new System.Windows.Forms.Button();
            this.btnPan = new System.Windows.Forms.Button();
            this.btnSelection = new CourseProject.MyButton();
            this.btnScribble = new System.Windows.Forms.Button();
            this.btnBucket = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.btnImageTool = new System.Windows.Forms.Button();
            this.btnMagnifier = new System.Windows.Forms.Button();
            this.canvasView1 = new CourseProject.CanvasView();
            this.splitUI_East = new System.Windows.Forms.SplitContainer();
            this.splitEast = new System.Windows.Forms.SplitContainer();
            this.splitEast_Top = new System.Windows.Forms.SplitContainer();
            this.grBoxMisc = new System.Windows.Forms.GroupBox();
            this.pnlMisc = new System.Windows.Forms.Panel();
            this.button2 = new CourseProject.MyButton();
            this.updownFillOpacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updownOutlineWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOutlineColor = new CourseProject.MyButton();
            this.btnFillColor = new CourseProject.MyButton();
            this.grBoxShapes = new System.Windows.Forms.GroupBox();
            this.pnlShapes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOval = new CourseProject.MyButton();
            this.btnTriangle = new CourseProject.MyButton();
            this.btnRectangle = new CourseProject.MyButton();
            this.btnParallelogram = new CourseProject.MyButton();
            this.btnPentagon = new CourseProject.MyButton();
            this.btnHexagon = new CourseProject.MyButton();
            this.btnHeptagon = new CourseProject.MyButton();
            this.btnOctagon = new CourseProject.MyButton();
            this.splitEast_Bot = new System.Windows.Forms.SplitContainer();
            this.grBoxLayers = new System.Windows.Forms.GroupBox();
            this.btnRenameLayer = new CourseProject.MyButton();
            this.btnAddLayer = new CourseProject.MyButton();
            this.btnRemoveLayer = new CourseProject.MyButton();
            this.layerManager = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.DownColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.VisionColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.LockColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.RearColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grBoxProperties = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnMisc = new CourseProject.MyButton();
            this.btnShapes = new CourseProject.MyButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnLayers = new CourseProject.MyButton();
            this.btnProperties = new CourseProject.MyButton();
            this.clrDialogOutline = new System.Windows.Forms.ColorDialog();
            this.clrDialogFill = new System.Windows.Forms.ColorDialog();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnTools = new CourseProject.MyButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitUI_East)).BeginInit();
            this.splitUI_East.Panel1.SuspendLayout();
            this.splitUI_East.Panel2.SuspendLayout();
            this.splitUI_East.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEast)).BeginInit();
            this.splitEast.Panel1.SuspendLayout();
            this.splitEast.Panel2.SuspendLayout();
            this.splitEast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEast_Top)).BeginInit();
            this.splitEast_Top.Panel1.SuspendLayout();
            this.splitEast_Top.Panel2.SuspendLayout();
            this.splitEast_Top.SuspendLayout();
            this.grBoxMisc.SuspendLayout();
            this.pnlMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownFillOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownOutlineWidth)).BeginInit();
            this.grBoxShapes.SuspendLayout();
            this.pnlShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitEast_Bot)).BeginInit();
            this.splitEast_Bot.Panel1.SuspendLayout();
            this.splitEast_Bot.Panel2.SuspendLayout();
            this.splitEast_Bot.SuspendLayout();
            this.grBoxLayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layerManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.grBoxProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(946, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.saveAsToolStripMenuItem.Text = "Save As ...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBoxToolStripMenuItem,
            this.propertyGridToolStripMenuItem,
            this.shapesToolStripMenuItem,
            this.miscToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // toolBoxToolStripMenuItem
            // 
            this.toolBoxToolStripMenuItem.Name = "toolBoxToolStripMenuItem";
            this.toolBoxToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.toolBoxToolStripMenuItem.Text = "Tools";
            // 
            // propertyGridToolStripMenuItem
            // 
            this.propertyGridToolStripMenuItem.Name = "propertyGridToolStripMenuItem";
            this.propertyGridToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertyGridToolStripMenuItem.Text = "Properties";
            // 
            // shapesToolStripMenuItem
            // 
            this.shapesToolStripMenuItem.Name = "shapesToolStripMenuItem";
            this.shapesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.shapesToolStripMenuItem.Text = "Shapes";
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(18, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitUI_East);
            this.splitContainer1.Size = new System.Drawing.Size(928, 549);
            this.splitContainer1.SplitterDistance = 495;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 14;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.IsSplitterFixed = true;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.canvasView1);
            this.splitContainer4.Size = new System.Drawing.Size(495, 549);
            this.splitContainer4.SplitterDistance = 63;
            this.splitContainer4.SplitterWidth = 3;
            this.splitContainer4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowGrid);
            this.groupBox1.Controls.Add(this.btnEnableGrid);
            this.groupBox1.Controls.Add(this.pnlTools);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(63, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // btnShowGrid
            // 
            this.btnShowGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowGrid.BackgroundImage = global::CourseProject.Properties.Resources.grid_hide;
            this.btnShowGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowGrid.FlatAppearance.BorderSize = 0;
            this.btnShowGrid.Location = new System.Drawing.Point(4, 504);
            this.btnShowGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShowGrid.Name = "btnShowGrid";
            this.btnShowGrid.Size = new System.Drawing.Size(54, 41);
            this.btnShowGrid.TabIndex = 13;
            this.btnShowGrid.UseVisualStyleBackColor = true;
            this.btnShowGrid.Click += new System.EventHandler(this.btnShowGrid_Click_1);
            // 
            // btnEnableGrid
            // 
            this.btnEnableGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnableGrid.BackgroundImage = global::CourseProject.Properties.Resources.grid_enable;
            this.btnEnableGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnableGrid.FlatAppearance.BorderSize = 0;
            this.btnEnableGrid.Location = new System.Drawing.Point(4, 458);
            this.btnEnableGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnableGrid.Name = "btnEnableGrid";
            this.btnEnableGrid.Size = new System.Drawing.Size(54, 41);
            this.btnEnableGrid.TabIndex = 12;
            this.btnEnableGrid.UseVisualStyleBackColor = true;
            this.btnEnableGrid.Click += new System.EventHandler(this.btnEnableGrid_Click);
            // 
            // pnlTools
            // 
            this.pnlTools.AutoSize = true;
            this.pnlTools.Controls.Add(this.btnPointer);
            this.pnlTools.Controls.Add(this.btnPan);
            this.pnlTools.Controls.Add(this.btnSelection);
            this.pnlTools.Controls.Add(this.btnScribble);
            this.pnlTools.Controls.Add(this.btnBucket);
            this.pnlTools.Controls.Add(this.btnEraser);
            this.pnlTools.Controls.Add(this.btnText);
            this.pnlTools.Controls.Add(this.btnImageTool);
            this.pnlTools.Controls.Add(this.btnMagnifier);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTools.Location = new System.Drawing.Point(2, 15);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(59, 405);
            this.pnlTools.TabIndex = 15;
            // 
            // btnPointer
            // 
            this.btnPointer.BackgroundImage = global::CourseProject.Properties.Resources.tool_pointer;
            this.btnPointer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPointer.FlatAppearance.BorderSize = 0;
            this.btnPointer.Location = new System.Drawing.Point(2, 2);
            this.btnPointer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPointer.Name = "btnPointer";
            this.btnPointer.Size = new System.Drawing.Size(38, 41);
            this.btnPointer.TabIndex = 1;
            this.btnPointer.UseVisualStyleBackColor = true;
            this.btnPointer.Click += new System.EventHandler(this.btnPointer_Click);
            // 
            // btnPan
            // 
            this.btnPan.BackgroundImage = global::CourseProject.Properties.Resources.tool_roam;
            this.btnPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPan.FlatAppearance.BorderSize = 0;
            this.btnPan.Location = new System.Drawing.Point(2, 47);
            this.btnPan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPan.Name = "btnPan";
            this.btnPan.Size = new System.Drawing.Size(38, 41);
            this.btnPan.TabIndex = 11;
            this.btnPan.UseVisualStyleBackColor = true;
            this.btnPan.Click += new System.EventHandler(this.btnPan_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.BackgroundImage = global::CourseProject.Properties.Resources.tool_selection1;
            this.btnSelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelection.FlatAppearance.BorderSize = 0;
            this.btnSelection.Location = new System.Drawing.Point(2, 92);
            this.btnSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(38, 41);
            this.btnSelection.TabIndex = 3;
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnScribble
            // 
            this.btnScribble.BackgroundImage = global::CourseProject.Properties.Resources.tool_scribble;
            this.btnScribble.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnScribble.FlatAppearance.BorderSize = 0;
            this.btnScribble.Location = new System.Drawing.Point(2, 137);
            this.btnScribble.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnScribble.Name = "btnScribble";
            this.btnScribble.Size = new System.Drawing.Size(38, 41);
            this.btnScribble.TabIndex = 2;
            this.btnScribble.UseVisualStyleBackColor = true;
            this.btnScribble.Click += new System.EventHandler(this.btnScribble_Click);
            // 
            // btnBucket
            // 
            this.btnBucket.BackgroundImage = global::CourseProject.Properties.Resources.tool_bucket;
            this.btnBucket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBucket.FlatAppearance.BorderSize = 0;
            this.btnBucket.Location = new System.Drawing.Point(2, 182);
            this.btnBucket.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBucket.Name = "btnBucket";
            this.btnBucket.Size = new System.Drawing.Size(38, 41);
            this.btnBucket.TabIndex = 4;
            this.btnBucket.UseVisualStyleBackColor = true;
            this.btnBucket.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBucket_MouseDown);
            // 
            // btnEraser
            // 
            this.btnEraser.BackgroundImage = global::CourseProject.Properties.Resources.tool_eraser;
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEraser.FlatAppearance.BorderSize = 0;
            this.btnEraser.Location = new System.Drawing.Point(2, 227);
            this.btnEraser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(38, 41);
            this.btnEraser.TabIndex = 8;
            this.btnEraser.UseVisualStyleBackColor = true;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnText
            // 
            this.btnText.BackgroundImage = global::CourseProject.Properties.Resources.tool_text;
            this.btnText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnText.FlatAppearance.BorderSize = 0;
            this.btnText.Location = new System.Drawing.Point(2, 272);
            this.btnText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(38, 41);
            this.btnText.TabIndex = 10;
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnImageTool
            // 
            this.btnImageTool.BackgroundImage = global::CourseProject.Properties.Resources.tool_picture;
            this.btnImageTool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImageTool.FlatAppearance.BorderSize = 0;
            this.btnImageTool.Location = new System.Drawing.Point(2, 317);
            this.btnImageTool.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImageTool.Name = "btnImageTool";
            this.btnImageTool.Size = new System.Drawing.Size(38, 41);
            this.btnImageTool.TabIndex = 9;
            this.btnImageTool.UseVisualStyleBackColor = true;
            this.btnImageTool.Click += new System.EventHandler(this.btnImageTool_Click);
            // 
            // btnMagnifier
            // 
            this.btnMagnifier.BackgroundImage = global::CourseProject.Properties.Resources.tool_magnifier;
            this.btnMagnifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMagnifier.FlatAppearance.BorderSize = 0;
            this.btnMagnifier.Location = new System.Drawing.Point(2, 362);
            this.btnMagnifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMagnifier.Name = "btnMagnifier";
            this.btnMagnifier.Size = new System.Drawing.Size(38, 41);
            this.btnMagnifier.TabIndex = 7;
            this.btnMagnifier.UseVisualStyleBackColor = true;
            this.btnMagnifier.Click += new System.EventHandler(this.btnMagnifier_Click);
            // 
            // canvasView1
            // 
            this.canvasView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvasView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvasView1.Location = new System.Drawing.Point(0, 0);
            this.canvasView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.canvasView1.Name = "canvasView1";
            this.canvasView1.Size = new System.Drawing.Size(429, 549);
            this.canvasView1.TabIndex = 0;
            // 
            // splitUI_East
            // 
            this.splitUI_East.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitUI_East.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitUI_East.IsSplitterFixed = true;
            this.splitUI_East.Location = new System.Drawing.Point(0, 0);
            this.splitUI_East.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitUI_East.Name = "splitUI_East";
            // 
            // splitUI_East.Panel1
            // 
            this.splitUI_East.Panel1.Controls.Add(this.splitEast);
            // 
            // splitUI_East.Panel2
            // 
            this.splitUI_East.Panel2.Controls.Add(this.splitContainer2);
            this.splitUI_East.Size = new System.Drawing.Size(427, 549);
            this.splitUI_East.SplitterDistance = 396;
            this.splitUI_East.SplitterWidth = 3;
            this.splitUI_East.TabIndex = 0;
            // 
            // splitEast
            // 
            this.splitEast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEast.Location = new System.Drawing.Point(0, 0);
            this.splitEast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitEast.Name = "splitEast";
            this.splitEast.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitEast.Panel1
            // 
            this.splitEast.Panel1.Controls.Add(this.splitEast_Top);
            // 
            // splitEast.Panel2
            // 
            this.splitEast.Panel2.Controls.Add(this.splitEast_Bot);
            this.splitEast.Size = new System.Drawing.Size(396, 549);
            this.splitEast.SplitterDistance = 196;
            this.splitEast.SplitterWidth = 3;
            this.splitEast.TabIndex = 0;
            // 
            // splitEast_Top
            // 
            this.splitEast_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEast_Top.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitEast_Top.Location = new System.Drawing.Point(0, 0);
            this.splitEast_Top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitEast_Top.Name = "splitEast_Top";
            this.splitEast_Top.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitEast_Top.Panel1
            // 
            this.splitEast_Top.Panel1.Controls.Add(this.grBoxMisc);
            // 
            // splitEast_Top.Panel2
            // 
            this.splitEast_Top.Panel2.Controls.Add(this.grBoxShapes);
            this.splitEast_Top.Size = new System.Drawing.Size(396, 196);
            this.splitEast_Top.SplitterDistance = 105;
            this.splitEast_Top.SplitterWidth = 3;
            this.splitEast_Top.TabIndex = 0;
            // 
            // grBoxMisc
            // 
            this.grBoxMisc.Controls.Add(this.pnlMisc);
            this.grBoxMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxMisc.Location = new System.Drawing.Point(0, 0);
            this.grBoxMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxMisc.Name = "grBoxMisc";
            this.grBoxMisc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxMisc.Size = new System.Drawing.Size(396, 105);
            this.grBoxMisc.TabIndex = 7;
            this.grBoxMisc.TabStop = false;
            this.grBoxMisc.Text = "Misc";
            // 
            // pnlMisc
            // 
            this.pnlMisc.Controls.Add(this.button2);
            this.pnlMisc.Controls.Add(this.updownFillOpacity);
            this.pnlMisc.Controls.Add(this.label2);
            this.pnlMisc.Controls.Add(this.updownOutlineWidth);
            this.pnlMisc.Controls.Add(this.label1);
            this.pnlMisc.Controls.Add(this.btnOutlineColor);
            this.pnlMisc.Controls.Add(this.btnFillColor);
            this.pnlMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMisc.Location = new System.Drawing.Point(2, 15);
            this.pnlMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlMisc.Name = "pnlMisc";
            this.pnlMisc.Size = new System.Drawing.Size(392, 88);
            this.pnlMisc.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CourseProject.Properties.Resources._switch;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(250, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 16);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSwitchColors_Click);
            // 
            // updownFillOpacity
            // 
            this.updownFillOpacity.Location = new System.Drawing.Point(91, 42);
            this.updownFillOpacity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updownFillOpacity.Name = "updownFillOpacity";
            this.updownFillOpacity.Size = new System.Drawing.Size(90, 20);
            this.updownFillOpacity.TabIndex = 5;
            this.updownFillOpacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownFillOpacity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.updownFillOpacity.ValueChanged += new System.EventHandler(this.updownFillOpacity_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fill Opacity:";
            // 
            // updownOutlineWidth
            // 
            this.updownOutlineWidth.Location = new System.Drawing.Point(91, 13);
            this.updownOutlineWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updownOutlineWidth.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updownOutlineWidth.Name = "updownOutlineWidth";
            this.updownOutlineWidth.Size = new System.Drawing.Size(90, 20);
            this.updownOutlineWidth.TabIndex = 3;
            this.updownOutlineWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.updownOutlineWidth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updownOutlineWidth.ValueChanged += new System.EventHandler(this.updownOutlineWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Outline Width:";
            // 
            // btnOutlineColor
            // 
            this.btnOutlineColor.BackColor = System.Drawing.Color.Black;
            this.btnOutlineColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutlineColor.Location = new System.Drawing.Point(208, 4);
            this.btnOutlineColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOutlineColor.Name = "btnOutlineColor";
            this.btnOutlineColor.Size = new System.Drawing.Size(38, 41);
            this.btnOutlineColor.TabIndex = 1;
            this.btnOutlineColor.UseVisualStyleBackColor = false;
            this.btnOutlineColor.Click += new System.EventHandler(this.btnOutlineColor_Click);
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.White;
            this.btnFillColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillColor.Location = new System.Drawing.Point(236, 25);
            this.btnFillColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(38, 41);
            this.btnFillColor.TabIndex = 0;
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.Click += new System.EventHandler(this.btnFillColor_Click);
            // 
            // grBoxShapes
            // 
            this.grBoxShapes.Controls.Add(this.pnlShapes);
            this.grBoxShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxShapes.Location = new System.Drawing.Point(0, 0);
            this.grBoxShapes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxShapes.Name = "grBoxShapes";
            this.grBoxShapes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxShapes.Size = new System.Drawing.Size(396, 88);
            this.grBoxShapes.TabIndex = 7;
            this.grBoxShapes.TabStop = false;
            this.grBoxShapes.Text = "Shapes";
            // 
            // pnlShapes
            // 
            this.pnlShapes.AutoScroll = true;
            this.pnlShapes.Controls.Add(this.btnOval);
            this.pnlShapes.Controls.Add(this.btnTriangle);
            this.pnlShapes.Controls.Add(this.btnRectangle);
            this.pnlShapes.Controls.Add(this.btnParallelogram);
            this.pnlShapes.Controls.Add(this.btnPentagon);
            this.pnlShapes.Controls.Add(this.btnHexagon);
            this.pnlShapes.Controls.Add(this.btnHeptagon);
            this.pnlShapes.Controls.Add(this.btnOctagon);
            this.pnlShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlShapes.Location = new System.Drawing.Point(2, 15);
            this.pnlShapes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlShapes.Name = "pnlShapes";
            this.pnlShapes.Size = new System.Drawing.Size(392, 71);
            this.pnlShapes.TabIndex = 6;
            // 
            // btnOval
            // 
            this.btnOval.BackgroundImage = global::CourseProject.Properties.Resources.oval;
            this.btnOval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOval.Location = new System.Drawing.Point(2, 2);
            this.btnOval.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOval.Name = "btnOval";
            this.btnOval.Size = new System.Drawing.Size(38, 41);
            this.btnOval.TabIndex = 0;
            this.btnOval.UseVisualStyleBackColor = true;
            this.btnOval.Click += new System.EventHandler(this.btnOval_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.BackgroundImage = global::CourseProject.Properties.Resources.triangle;
            this.btnTriangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTriangle.Location = new System.Drawing.Point(44, 2);
            this.btnTriangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(38, 41);
            this.btnTriangle.TabIndex = 1;
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::CourseProject.Properties.Resources.rectangle;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRectangle.Location = new System.Drawing.Point(86, 2);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(38, 41);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnParallelogram
            // 
            this.btnParallelogram.BackgroundImage = global::CourseProject.Properties.Resources.parallelogram;
            this.btnParallelogram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnParallelogram.Location = new System.Drawing.Point(128, 2);
            this.btnParallelogram.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnParallelogram.Name = "btnParallelogram";
            this.btnParallelogram.Size = new System.Drawing.Size(38, 41);
            this.btnParallelogram.TabIndex = 3;
            this.btnParallelogram.UseVisualStyleBackColor = true;
            this.btnParallelogram.Click += new System.EventHandler(this.btnParallelogram_Click);
            // 
            // btnPentagon
            // 
            this.btnPentagon.BackgroundImage = global::CourseProject.Properties.Resources.pentagon;
            this.btnPentagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPentagon.Location = new System.Drawing.Point(170, 2);
            this.btnPentagon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(38, 41);
            this.btnPentagon.TabIndex = 4;
            this.btnPentagon.UseVisualStyleBackColor = true;
            this.btnPentagon.Click += new System.EventHandler(this.btnPentagon_Click);
            // 
            // btnHexagon
            // 
            this.btnHexagon.BackgroundImage = global::CourseProject.Properties.Resources.hexagon1;
            this.btnHexagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHexagon.Location = new System.Drawing.Point(212, 2);
            this.btnHexagon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(38, 41);
            this.btnHexagon.TabIndex = 5;
            this.btnHexagon.UseVisualStyleBackColor = true;
            this.btnHexagon.Click += new System.EventHandler(this.btnHexagon_Click);
            // 
            // btnHeptagon
            // 
            this.btnHeptagon.BackgroundImage = global::CourseProject.Properties.Resources.heptagon;
            this.btnHeptagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHeptagon.Location = new System.Drawing.Point(254, 2);
            this.btnHeptagon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHeptagon.Name = "btnHeptagon";
            this.btnHeptagon.Size = new System.Drawing.Size(38, 41);
            this.btnHeptagon.TabIndex = 6;
            this.btnHeptagon.UseVisualStyleBackColor = true;
            this.btnHeptagon.Click += new System.EventHandler(this.btnHeptagon_Click);
            // 
            // btnOctagon
            // 
            this.btnOctagon.BackgroundImage = global::CourseProject.Properties.Resources.octagon;
            this.btnOctagon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOctagon.Location = new System.Drawing.Point(296, 2);
            this.btnOctagon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOctagon.Name = "btnOctagon";
            this.btnOctagon.Size = new System.Drawing.Size(38, 41);
            this.btnOctagon.TabIndex = 7;
            this.btnOctagon.UseVisualStyleBackColor = true;
            this.btnOctagon.Click += new System.EventHandler(this.btnOctagon_Click);
            // 
            // splitEast_Bot
            // 
            this.splitEast_Bot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitEast_Bot.Location = new System.Drawing.Point(0, 0);
            this.splitEast_Bot.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitEast_Bot.Name = "splitEast_Bot";
            this.splitEast_Bot.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitEast_Bot.Panel1
            // 
            this.splitEast_Bot.Panel1.Controls.Add(this.grBoxLayers);
            // 
            // splitEast_Bot.Panel2
            // 
            this.splitEast_Bot.Panel2.Controls.Add(this.grBoxProperties);
            this.splitEast_Bot.Size = new System.Drawing.Size(396, 350);
            this.splitEast_Bot.SplitterDistance = 140;
            this.splitEast_Bot.SplitterWidth = 3;
            this.splitEast_Bot.TabIndex = 0;
            // 
            // grBoxLayers
            // 
            this.grBoxLayers.Controls.Add(this.btnRenameLayer);
            this.grBoxLayers.Controls.Add(this.btnAddLayer);
            this.grBoxLayers.Controls.Add(this.btnRemoveLayer);
            this.grBoxLayers.Controls.Add(this.layerManager);
            this.grBoxLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxLayers.Location = new System.Drawing.Point(0, 0);
            this.grBoxLayers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxLayers.Name = "grBoxLayers";
            this.grBoxLayers.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxLayers.Size = new System.Drawing.Size(396, 140);
            this.grBoxLayers.TabIndex = 2;
            this.grBoxLayers.TabStop = false;
            this.grBoxLayers.Text = "Layers";
            // 
            // btnRenameLayer
            // 
            this.btnRenameLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenameLayer.BackgroundImage = global::CourseProject.Properties.Resources.add;
            this.btnRenameLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRenameLayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRenameLayer.Location = new System.Drawing.Point(108, 109);
            this.btnRenameLayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRenameLayer.Name = "btnRenameLayer";
            this.btnRenameLayer.Size = new System.Drawing.Size(109, 26);
            this.btnRenameLayer.TabIndex = 4;
            this.btnRenameLayer.Text = "Rename Selected";
            this.btnRenameLayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRenameLayer.UseVisualStyleBackColor = true;
            this.btnRenameLayer.Click += new System.EventHandler(this.btnRenameLayer_Click);
            // 
            // btnAddLayer
            // 
            this.btnAddLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLayer.BackgroundImage = global::CourseProject.Properties.Resources.add;
            this.btnAddLayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddLayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLayer.Location = new System.Drawing.Point(279, 111);
            this.btnAddLayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddLayer.Name = "btnAddLayer";
            this.btnAddLayer.Size = new System.Drawing.Size(56, 26);
            this.btnAddLayer.TabIndex = 3;
            this.btnAddLayer.Text = "Add";
            this.btnAddLayer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddLayer.UseVisualStyleBackColor = true;
            this.btnAddLayer.Click += new System.EventHandler(this.btnAddLayer_Click);
            // 
            // btnRemoveLayer
            // 
            this.btnRemoveLayer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveLayer.Location = new System.Drawing.Point(338, 111);
            this.btnRemoveLayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveLayer.Name = "btnRemoveLayer";
            this.btnRemoveLayer.Size = new System.Drawing.Size(56, 26);
            this.btnRemoveLayer.TabIndex = 2;
            this.btnRemoveLayer.Text = "Remove";
            this.btnRemoveLayer.UseVisualStyleBackColor = true;
            this.btnRemoveLayer.Click += new System.EventHandler(this.btnRemoveLayer_Click);
            // 
            // layerManager
            // 
            this.layerManager.AllowUserToAddRows = false;
            this.layerManager.AllowUserToDeleteRows = false;
            this.layerManager.AllowUserToResizeColumns = false;
            this.layerManager.AllowUserToResizeRows = false;
            this.layerManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layerManager.AutoGenerateColumns = false;
            this.layerManager.BackgroundColor = System.Drawing.SystemColors.Control;
            this.layerManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.layerManager.ColumnHeadersVisible = false;
            this.layerManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.UpColumn,
            this.DownColumn,
            this.VisionColumn1,
            this.LockColumn1,
            this.RearColumn});
            this.layerManager.DataSource = this.bindingSource1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.139131F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.layerManager.DefaultCellStyle = dataGridViewCellStyle1;
            this.layerManager.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.layerManager.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.layerManager.Location = new System.Drawing.Point(2, 15);
            this.layerManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.layerManager.Name = "layerManager";
            this.layerManager.ReadOnly = true;
            this.layerManager.RowHeadersVisible = false;
            this.layerManager.RowHeadersWidth = 25;
            this.layerManager.RowTemplate.Height = 24;
            this.layerManager.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.layerManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.layerManager.Size = new System.Drawing.Size(394, 92);
            this.layerManager.TabIndex = 1;
            this.layerManager.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.layerManager_CellClick);
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 6;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameColumn.Width = 150;
            // 
            // UpColumn
            // 
            this.UpColumn.Frozen = true;
            this.UpColumn.HeaderText = "Up";
            this.UpColumn.Image = global::CourseProject.Properties.Resources.arrow_up;
            this.UpColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.UpColumn.MinimumWidth = 6;
            this.UpColumn.Name = "UpColumn";
            this.UpColumn.ReadOnly = true;
            this.UpColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UpColumn.Width = 50;
            // 
            // DownColumn
            // 
            this.DownColumn.Frozen = true;
            this.DownColumn.HeaderText = "Down";
            this.DownColumn.Image = global::CourseProject.Properties.Resources.arrow_down;
            this.DownColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.DownColumn.MinimumWidth = 6;
            this.DownColumn.Name = "DownColumn";
            this.DownColumn.ReadOnly = true;
            this.DownColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DownColumn.Width = 50;
            // 
            // VisionColumn1
            // 
            this.VisionColumn1.Frozen = true;
            this.VisionColumn1.HeaderText = "Vision";
            this.VisionColumn1.Image = global::CourseProject.Properties.Resources.invisible;
            this.VisionColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.VisionColumn1.MinimumWidth = 6;
            this.VisionColumn1.Name = "VisionColumn1";
            this.VisionColumn1.ReadOnly = true;
            this.VisionColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.VisionColumn1.Width = 50;
            // 
            // LockColumn1
            // 
            this.LockColumn1.Frozen = true;
            this.LockColumn1.HeaderText = "Lock";
            this.LockColumn1.Image = global::CourseProject.Properties.Resources.locked;
            this.LockColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.LockColumn1.MinimumWidth = 6;
            this.LockColumn1.Name = "LockColumn1";
            this.LockColumn1.ReadOnly = true;
            this.LockColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LockColumn1.Width = 50;
            // 
            // RearColumn
            // 
            this.RearColumn.Frozen = true;
            this.RearColumn.HeaderText = "Rear";
            this.RearColumn.MinimumWidth = 6;
            this.RearColumn.Name = "RearColumn";
            this.RearColumn.ReadOnly = true;
            this.RearColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RearColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.RearColumn.Width = 120;
            // 
            // grBoxProperties
            // 
            this.grBoxProperties.Controls.Add(this.propertyGrid1);
            this.grBoxProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBoxProperties.Location = new System.Drawing.Point(0, 0);
            this.grBoxProperties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxProperties.Name = "grBoxProperties";
            this.grBoxProperties.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grBoxProperties.Size = new System.Drawing.Size(396, 207);
            this.grBoxProperties.TabIndex = 4;
            this.grBoxProperties.TabStop = false;
            this.grBoxProperties.Text = "Properties";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.propertyGrid1.CategorySplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.propertyGrid1.CommandsBackColor = System.Drawing.SystemColors.ControlDark;
            this.propertyGrid1.Location = new System.Drawing.Point(4, 17);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(386, 185);
            this.propertyGrid1.TabIndex = 2;
            this.propertyGrid1.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid1_PropertyValueChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(28, 549);
            this.splitContainer2.SplitterDistance = 196;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.btnMisc);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.btnShapes);
            this.splitContainer5.Size = new System.Drawing.Size(28, 196);
            this.splitContainer5.SplitterDistance = 85;
            this.splitContainer5.SplitterWidth = 3;
            this.splitContainer5.TabIndex = 0;
            // 
            // btnMisc
            // 
            this.btnMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMisc.Location = new System.Drawing.Point(0, 0);
            this.btnMisc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMisc.Name = "btnMisc";
            this.btnMisc.Size = new System.Drawing.Size(28, 85);
            this.btnMisc.TabIndex = 0;
            this.btnMisc.Text = "M\r\ni\r\ns\r\nc\r\n";
            this.btnMisc.UseVisualStyleBackColor = true;
            this.btnMisc.Click += new System.EventHandler(this.btnMisc_Click);
            // 
            // btnShapes
            // 
            this.btnShapes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShapes.Location = new System.Drawing.Point(0, 0);
            this.btnShapes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnShapes.Name = "btnShapes";
            this.btnShapes.Size = new System.Drawing.Size(28, 108);
            this.btnShapes.TabIndex = 1;
            this.btnShapes.Text = "S\r\nh\r\na\r\np\r\ne\r\ns\r\n";
            this.btnShapes.UseVisualStyleBackColor = true;
            this.btnShapes.Click += new System.EventHandler(this.btnShapes_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.btnLayers);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnProperties);
            this.splitContainer3.Size = new System.Drawing.Size(28, 350);
            this.splitContainer3.SplitterDistance = 142;
            this.splitContainer3.SplitterWidth = 3;
            this.splitContainer3.TabIndex = 0;
            // 
            // btnLayers
            // 
            this.btnLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLayers.Location = new System.Drawing.Point(0, 0);
            this.btnLayers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLayers.Name = "btnLayers";
            this.btnLayers.Size = new System.Drawing.Size(28, 142);
            this.btnLayers.TabIndex = 2;
            this.btnLayers.Text = "L\r\na\r\ny\r\ne\r\nr\r\ns\r\n";
            this.btnLayers.UseVisualStyleBackColor = true;
            this.btnLayers.Click += new System.EventHandler(this.btnLayers_Click);
            // 
            // btnProperties
            // 
            this.btnProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProperties.Location = new System.Drawing.Point(0, 0);
            this.btnProperties.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(28, 205);
            this.btnProperties.TabIndex = 3;
            this.btnProperties.Text = "P\r\nr\r\no\r\np\r\ne\r\nr\r\nt\r\ni\r\ne\r\ns\r\n";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Up";
            this.dataGridViewImageColumn1.Image = global::CourseProject.Properties.Resources.arrow_up;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Down";
            this.dataGridViewImageColumn2.Image = global::CourseProject.Properties.Resources.arrow_down;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "Vision";
            this.dataGridViewImageColumn3.Image = global::CourseProject.Properties.Resources.invisible;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 50;
            // 
            // dataGridViewImageColumn4
            // 
            this.dataGridViewImageColumn4.HeaderText = "Lock";
            this.dataGridViewImageColumn4.Image = global::CourseProject.Properties.Resources.locked;
            this.dataGridViewImageColumn4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn4.MinimumWidth = 6;
            this.dataGridViewImageColumn4.Name = "dataGridViewImageColumn4";
            this.dataGridViewImageColumn4.ReadOnly = true;
            this.dataGridViewImageColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn4.Width = 50;
            // 
            // btnTools
            // 
            this.btnTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTools.Location = new System.Drawing.Point(0, 28);
            this.btnTools.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(19, 549);
            this.btnTools.TabIndex = 0;
            this.btnTools.Text = "T\r\no\r\no\r\nl\r\ns";
            this.btnTools.UseVisualStyleBackColor = true;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 587);
            this.Controls.Add(this.btnTools);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graphic Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_OnKeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlTools.ResumeLayout(false);
            this.splitUI_East.Panel1.ResumeLayout(false);
            this.splitUI_East.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitUI_East)).EndInit();
            this.splitUI_East.ResumeLayout(false);
            this.splitEast.Panel1.ResumeLayout(false);
            this.splitEast.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEast)).EndInit();
            this.splitEast.ResumeLayout(false);
            this.splitEast_Top.Panel1.ResumeLayout(false);
            this.splitEast_Top.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEast_Top)).EndInit();
            this.splitEast_Top.ResumeLayout(false);
            this.grBoxMisc.ResumeLayout(false);
            this.pnlMisc.ResumeLayout(false);
            this.pnlMisc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownFillOpacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownOutlineWidth)).EndInit();
            this.grBoxShapes.ResumeLayout(false);
            this.pnlShapes.ResumeLayout(false);
            this.splitEast_Bot.Panel1.ResumeLayout(false);
            this.splitEast_Bot.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitEast_Bot)).EndInit();
            this.splitEast_Bot.ResumeLayout(false);
            this.grBoxLayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layerManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.grBoxProperties.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MyButton btnFillColor;
        private MyButton btnOutlineColor;
        private System.Windows.Forms.ColorDialog clrDialogOutline;
        private System.Windows.Forms.ColorDialog clrDialogFill;
        private System.Windows.Forms.GroupBox grBoxProperties;
        private System.Windows.Forms.Panel pnlMisc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel pnlTools;
        private System.Windows.Forms.Button btnPointer;
        private System.Windows.Forms.Button btnScribble;
        private MyButton btnSelection;
        private System.Windows.Forms.Button btnBucket;
        private System.Windows.Forms.FlowLayoutPanel pnlShapes;
        private System.Windows.Forms.Button btnMagnifier;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.SplitContainer splitUI_East;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStripMenuItem toolBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertyGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.DataGridView layerManager;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox grBoxLayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.SplitContainer splitEast;
        private System.Windows.Forms.SplitContainer splitEast_Top;
        private System.Windows.Forms.GroupBox grBoxShapes;
        private System.Windows.Forms.SplitContainer splitEast_Bot;
        private System.Windows.Forms.GroupBox grBoxMisc;
        private MyButton button2;
        private System.Windows.Forms.NumericUpDown updownFillOpacity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown updownOutlineWidth;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private MyButton btnMisc;
        private MyButton btnShapes;
        private MyButton btnLayers;
        private MyButton btnProperties;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn4;
        private CanvasView canvasView1;
        private MyButton btnAddLayer;
        private MyButton btnRemoveLayer;
        private System.Windows.Forms.Button btnImageTool;
        private System.Windows.Forms.Button btnText;
        private MyButton btnTools;
        private MyButton btnShowGrid;
        private MyButton btnEnableGrid;
        private System.Windows.Forms.Button btnPan;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewImageColumn UpColumn;
        private System.Windows.Forms.DataGridViewImageColumn DownColumn;
        private System.Windows.Forms.DataGridViewImageColumn VisionColumn1;
        private System.Windows.Forms.DataGridViewImageColumn LockColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RearColumn;
        private MyButton btnOval;
        private MyButton btnTriangle;
        private MyButton btnRectangle;
        private MyButton btnParallelogram;
        private MyButton btnPentagon;
        private MyButton btnHexagon;
        private MyButton btnHeptagon;
        private MyButton btnOctagon;
        private MyButton btnRenameLayer;
    }
}

