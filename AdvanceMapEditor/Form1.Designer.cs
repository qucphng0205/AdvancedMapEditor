﻿namespace AdvanceMapEditor
{
    partial class Form1
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
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.txt_Size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Excute = new System.Windows.Forms.Button();
            this.cb_direction = new System.Windows.Forms.ComboBox();
            this.btnSaveQuadTree = new System.Windows.Forms.Button();
            this.check_deleteObject = new System.Windows.Forms.CheckBox();
            this.cb_typeObject = new System.Windows.Forms.ComboBox();
            this.location = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.worldSpace = new AdvanceMapEditor.ImageBox();
            this.btn_OpenImage = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gr_object = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txt_H = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_W = new System.Windows.Forms.TextBox();
            this.txt_Y = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_X = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gr_map = new System.Windows.Forms.GroupBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.imageListObjects = new System.Windows.Forms.ImageList(this.components);
            this.btnHide = new System.Windows.Forms.Button();
            this.subMenu_DeleteObject = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_OpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu_New = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.worldSpace.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gr_object.SuspendLayout();
            this.gr_map.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Refresh.Location = new System.Drawing.Point(191, 181);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 34);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // txt_Size
            // 
            this.txt_Size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Size.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Size.Location = new System.Drawing.Point(82, 37);
            this.txt_Size.Name = "txt_Size";
            this.txt_Size.Size = new System.Drawing.Size(162, 26);
            this.txt_Size.TabIndex = 0;
            this.txt_Size.Text = "32";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "pixel";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "pixel";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "pixel";
            // 
            // btn_Excute
            // 
            this.btn_Excute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Excute.Location = new System.Drawing.Point(69, 181);
            this.btn_Excute.Name = "btn_Excute";
            this.btn_Excute.Size = new System.Drawing.Size(75, 34);
            this.btn_Excute.TabIndex = 3;
            this.btn_Excute.Text = "Excute";
            this.btn_Excute.UseVisualStyleBackColor = true;
            this.btn_Excute.Click += new System.EventHandler(this.btn_Excute_Click);
            // 
            // cb_direction
            // 
            this.cb_direction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_direction.FormattingEnabled = true;
            this.cb_direction.Items.AddRange(new object[] {
            "Left to Right ->",
            "Right to Left <-",
            "None"});
            this.cb_direction.Location = new System.Drawing.Point(42, 272);
            this.cb_direction.Name = "cb_direction";
            this.cb_direction.Size = new System.Drawing.Size(219, 24);
            this.cb_direction.TabIndex = 8;
            // 
            // btnSaveQuadTree
            // 
            this.btnSaveQuadTree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveQuadTree.Location = new System.Drawing.Point(102, 334);
            this.btnSaveQuadTree.Name = "btnSaveQuadTree";
            this.btnSaveQuadTree.Size = new System.Drawing.Size(144, 34);
            this.btnSaveQuadTree.TabIndex = 7;
            this.btnSaveQuadTree.Text = "Save";
            this.btnSaveQuadTree.UseVisualStyleBackColor = true;
            this.btnSaveQuadTree.Click += new System.EventHandler(this.btnSaveQuadTree_Click);
            // 
            // check_deleteObject
            // 
            this.check_deleteObject.AutoSize = true;
            this.check_deleteObject.Location = new System.Drawing.Point(42, 302);
            this.check_deleteObject.Name = "check_deleteObject";
            this.check_deleteObject.Size = new System.Drawing.Size(116, 21);
            this.check_deleteObject.TabIndex = 6;
            this.check_deleteObject.Text = "Delete Object";
            this.check_deleteObject.UseVisualStyleBackColor = true;
            // 
            // cb_typeObject
            // 
            this.cb_typeObject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_typeObject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_typeObject.FormattingEnabled = true;
            this.cb_typeObject.Items.AddRange(new object[] {
            "GROUND",
            "SPARTA",
            "CAT",
            "THROWER",
            "EAGLE",
            "SOLDIER",
            "SPIRITPOINTS5",
            "SPIRITPOINTS10",
            "SCORES500",
            "SCORES1000",
            "TIMEFREEZE",
            "HEALTH",
            "THROWINGSTAR",
            "WINDMILLSTAR",
            "FLAMES",
            "GUNNER",
            "RUNNER",
            "LADDER",
            "THINSURFACE",
            "BASAQUER",
            "BAT"});
            this.cb_typeObject.Location = new System.Drawing.Point(42, 238);
            this.cb_typeObject.Name = "cb_typeObject";
            this.cb_typeObject.Size = new System.Drawing.Size(223, 28);
            this.cb_typeObject.TabIndex = 5;
            // 
            // location
            // 
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.worldSpace);
            this.splitContainer1.Panel1.Controls.Add(this.statusStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(1574, 678);
            this.splitContainer1.SplitterDistance = 1214;
            this.splitContainer1.TabIndex = 7;
            // 
            // worldSpace
            // 
            this.worldSpace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.worldSpace.Controls.Add(this.btn_OpenImage);
            this.worldSpace.HeightCell = 0;
            this.worldSpace.Image = null;
            this.worldSpace.Location = new System.Drawing.Point(3, 3);
            this.worldSpace.Name = "worldSpace";
            this.worldSpace.Size = new System.Drawing.Size(1208, 650);
            this.worldSpace.TabIndex = 5;
            this.worldSpace.WidthCell = 0;
            this.worldSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.worldSpace_MouseDown);
            this.worldSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.worldSpace_MouseMove);
            // 
            // btn_OpenImage
            // 
            this.btn_OpenImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_OpenImage.Location = new System.Drawing.Point(474, 251);
            this.btn_OpenImage.Name = "btn_OpenImage";
            this.btn_OpenImage.Size = new System.Drawing.Size(227, 105);
            this.btn_OpenImage.TabIndex = 3;
            this.btn_OpenImage.Text = "Open Images";
            this.btn_OpenImage.UseVisualStyleBackColor = true;
            this.btn_OpenImage.Click += new System.EventHandler(this.btn_OpenImage_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.location});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gr_object);
            this.panel1.Controls.Add(this.gr_map);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 678);
            this.panel1.TabIndex = 1;
            // 
            // gr_object
            // 
            this.gr_object.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gr_object.Controls.Add(this.label15);
            this.gr_object.Controls.Add(this.label14);
            this.gr_object.Controls.Add(this.txtRows);
            this.gr_object.Controls.Add(this.txtColumns);
            this.gr_object.Controls.Add(this.cb_direction);
            this.gr_object.Controls.Add(this.btnSaveQuadTree);
            this.gr_object.Controls.Add(this.check_deleteObject);
            this.gr_object.Controls.Add(this.cb_typeObject);
            this.gr_object.Controls.Add(this.txt_H);
            this.gr_object.Controls.Add(this.label13);
            this.gr_object.Controls.Add(this.label12);
            this.gr_object.Controls.Add(this.label11);
            this.gr_object.Controls.Add(this.label10);
            this.gr_object.Controls.Add(this.txt_W);
            this.gr_object.Controls.Add(this.txt_Y);
            this.gr_object.Controls.Add(this.label9);
            this.gr_object.Controls.Add(this.label8);
            this.gr_object.Controls.Add(this.label7);
            this.gr_object.Controls.Add(this.txt_X);
            this.gr_object.Controls.Add(this.label6);
            this.gr_object.Location = new System.Drawing.Point(15, 258);
            this.gr_object.Name = "gr_object";
            this.gr_object.Size = new System.Drawing.Size(328, 407);
            this.gr_object.TabIndex = 2;
            this.gr_object.TabStop = false;
            this.gr_object.Text = "Object";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 17);
            this.label15.TabIndex = 12;
            this.label15.Text = "Grid rows";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Grid columns";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(106, 198);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(118, 22);
            this.txtRows.TabIndex = 10;
            this.txtRows.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(106, 170);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(118, 22);
            this.txtColumns.TabIndex = 9;
            // 
            // txt_H
            // 
            this.txt_H.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_H.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_H.Location = new System.Drawing.Point(42, 128);
            this.txt_H.Name = "txt_H";
            this.txt_H.Size = new System.Drawing.Size(223, 26);
            this.txt_H.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(268, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Cell";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(268, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Cell";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(268, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cell";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Cell";
            // 
            // txt_W
            // 
            this.txt_W.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_W.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_W.Location = new System.Drawing.Point(42, 96);
            this.txt_W.Name = "txt_W";
            this.txt_W.Size = new System.Drawing.Size(223, 26);
            this.txt_W.TabIndex = 4;
            // 
            // txt_Y
            // 
            this.txt_Y.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Y.Location = new System.Drawing.Point(42, 64);
            this.txt_Y.Name = "txt_Y";
            this.txt_Y.Size = new System.Drawing.Size(223, 26);
            this.txt_Y.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "H";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "W";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Y";
            // 
            // txt_X
            // 
            this.txt_X.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_X.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_X.Location = new System.Drawing.Point(42, 32);
            this.txt_X.Name = "txt_X";
            this.txt_X.Size = new System.Drawing.Size(223, 26);
            this.txt_X.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "X";
            // 
            // gr_map
            // 
            this.gr_map.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gr_map.Controls.Add(this.btn_Refresh);
            this.gr_map.Controls.Add(this.txt_Size);
            this.gr_map.Controls.Add(this.label2);
            this.gr_map.Controls.Add(this.label5);
            this.gr_map.Controls.Add(this.label1);
            this.gr_map.Controls.Add(this.btn_Excute);
            this.gr_map.Controls.Add(this.txt_height);
            this.gr_map.Controls.Add(this.txt_width);
            this.gr_map.Controls.Add(this.label3);
            this.gr_map.Controls.Add(this.label4);
            this.gr_map.Controls.Add(this.label);
            this.gr_map.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_map.Location = new System.Drawing.Point(15, 28);
            this.gr_map.Name = "gr_map";
            this.gr_map.Size = new System.Drawing.Size(328, 223);
            this.gr_map.TabIndex = 0;
            this.gr_map.TabStop = false;
            this.gr_map.Text = "Map";
            // 
            // txt_height
            // 
            this.txt_height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_height.Location = new System.Drawing.Point(82, 139);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(162, 26);
            this.txt_height.TabIndex = 2;
            this.txt_height.Text = "32";
            // 
            // txt_width
            // 
            this.txt_width.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_width.Location = new System.Drawing.Point(82, 88);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(162, 26);
            this.txt_width.TabIndex = 1;
            this.txt_width.Text = "32";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Size";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(15, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 20);
            this.label.TabIndex = 0;
            this.label.Text = "width";
            // 
            // imageListObjects
            // 
            this.imageListObjects.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListObjects.ImageSize = new System.Drawing.Size(64, 64);
            this.imageListObjects.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnHide
            // 
            this.btnHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHide.Location = new System.Drawing.Point(1472, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(57, 28);
            this.btnHide.TabIndex = 6;
            this.btnHide.Text = ">>";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // subMenu_DeleteObject
            // 
            this.subMenu_DeleteObject.Name = "subMenu_DeleteObject";
            this.subMenu_DeleteObject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.subMenu_DeleteObject.Size = new System.Drawing.Size(229, 26);
            this.subMenu_DeleteObject.Text = "Delete Object";
            this.subMenu_DeleteObject.Click += new System.EventHandler(this.subMenu_DeleteObject_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu_DeleteObject});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // subMenu_OpenFile
            // 
            this.subMenu_OpenFile.Name = "subMenu_OpenFile";
            this.subMenu_OpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.subMenu_OpenFile.Size = new System.Drawing.Size(240, 26);
            this.subMenu_OpenFile.Text = "Open File";
            this.subMenu_OpenFile.Click += new System.EventHandler(this.subMenu_OpenFile_Click);
            // 
            // subMenu_OpenImage
            // 
            this.subMenu_OpenImage.Name = "subMenu_OpenImage";
            this.subMenu_OpenImage.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.subMenu_OpenImage.Size = new System.Drawing.Size(240, 26);
            this.subMenu_OpenImage.Text = "Open Image";
            // 
            // subMenu_New
            // 
            this.subMenu_New.Name = "subMenu_New";
            this.subMenu_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.subMenu_New.Size = new System.Drawing.Size(240, 26);
            this.subMenu_New.Text = "New";
            this.subMenu_New.Click += new System.EventHandler(this.subMenu_Open_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subMenu_New,
            this.subMenu_OpenImage,
            this.subMenu_OpenFile});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1574, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1574, 706);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.worldSpace.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gr_object.ResumeLayout(false);
            this.gr_object.PerformLayout();
            this.gr_map.ResumeLayout(false);
            this.gr_map.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TextBox txt_Size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Excute;
        private System.Windows.Forms.ComboBox cb_direction;
        private System.Windows.Forms.Button btnSaveQuadTree;
        private System.Windows.Forms.CheckBox check_deleteObject;
        private System.Windows.Forms.ComboBox cb_typeObject;
        private System.Windows.Forms.ToolStripStatusLabel location;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btn_OpenImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gr_object;
        private System.Windows.Forms.TextBox txt_H;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_W;
        private System.Windows.Forms.TextBox txt_Y;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_X;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gr_map;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ImageList imageListObjects;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.ToolStripMenuItem subMenu_DeleteObject;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subMenu_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem subMenu_OpenImage;
        private System.Windows.Forms.ToolStripMenuItem subMenu_New;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ImageBox worldSpace;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

