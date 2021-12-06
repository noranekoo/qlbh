
using QLBH.Resources;

namespace QLBH
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlRightBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new QLBH.Resources.ButtonCustom();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnMaximize = new QLBH.Resources.ButtonCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new QLBH.Resources.ButtonCustom();
            this.pnlLeftBar = new System.Windows.Forms.Panel();
            this.btnGoodsIE = new System.Windows.Forms.Button();
            this.lklInfo = new System.Windows.Forms.LinkLabel();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnCooperation = new System.Windows.Forms.Button();
            this.btnCelebration = new System.Windows.Forms.Button();
            this.btnGeneral = new System.Windows.Forms.Button();
            this.pnlDivPage = new System.Windows.Forms.Panel();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tabPage = new System.Windows.Forms.TabControl();
            this.flowTool = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLeftBar.SuspendLayout();
            this.pnlDivPage.SuspendLayout();
            this.tblLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnBackup);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.pnlRightBar);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 53);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnBackup
            // 
            this.btnBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBackup.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBackup.Image = global::QLBH.Properties.Resources.data_integration;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(682, 11);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(35, 31);
            this.btnBackup.TabIndex = 5;
            this.btnBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            this.btnBackup.Paint += new System.Windows.Forms.PaintEventHandler(this.btnBackup_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnLogout.Image = global::QLBH.Properties.Resources.power_on;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(928, 10);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 32);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlRightBar
            // 
            this.pnlRightBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRightBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.pnlRightBar.Location = new System.Drawing.Point(1042, -2);
            this.pnlRightBar.Name = "pnlRightBar";
            this.pnlRightBar.Size = new System.Drawing.Size(8, 56);
            this.pnlRightBar.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.ActiveColor = System.Drawing.Color.Empty;
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DeactiveColor = System.Drawing.Color.Empty;
            this.btnMinimize.EnableChangeImageClick = false;
            this.btnMinimize.FirstClickImage = null;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMinimize.Image = global::QLBH.Properties.Resources.minimize;
            this.btnMinimize.IsActive = false;
            this.btnMinimize.Location = new System.Drawing.Point(1079, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.SecondClickImage = null;
            this.btnMinimize.Size = new System.Drawing.Size(21, 23);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFullName.ForeColor = System.Drawing.Color.Coral;
            this.lblFullName.Location = new System.Drawing.Point(764, 14);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(139, 23);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Nguyen Anh Thi";
            this.lblFullName.Paint += new System.Windows.Forms.PaintEventHandler(this.lblFullName_Paint);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSettings.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(723, 10);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(35, 31);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.btnSettings_Paint);
            // 
            // btnMaximize
            // 
            this.btnMaximize.ActiveColor = System.Drawing.Color.Empty;
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.DeactiveColor = System.Drawing.Color.Empty;
            this.btnMaximize.EnableChangeImageClick = true;
            this.btnMaximize.FirstClickImage = global::QLBH.Properties.Resources.maximize;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMaximize.Image = global::QLBH.Properties.Resources.normal;
            this.btnMaximize.IsActive = false;
            this.btnMaximize.Location = new System.Drawing.Point(1100, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.SecondClickImage = global::QLBH.Properties.Resources.normal;
            this.btnMaximize.Size = new System.Drawing.Size(21, 23);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(49, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ KHO HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLBH.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ActiveColor = System.Drawing.Color.Empty;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DeactiveColor = System.Drawing.Color.Empty;
            this.btnClose.EnableChangeImageClick = false;
            this.btnClose.FirstClickImage = null;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::QLBH.Properties.Resources.delete_button;
            this.btnClose.IsActive = false;
            this.btnClose.Location = new System.Drawing.Point(1120, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.SecondClickImage = null;
            this.btnClose.Size = new System.Drawing.Size(20, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlLeftBar
            // 
            this.pnlLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pnlLeftBar.Controls.Add(this.btnGoodsIE);
            this.pnlLeftBar.Controls.Add(this.lklInfo);
            this.pnlLeftBar.Controls.Add(this.btnReport);
            this.pnlLeftBar.Controls.Add(this.panel3);
            this.pnlLeftBar.Controls.Add(this.btnGoods);
            this.pnlLeftBar.Controls.Add(this.btnCooperation);
            this.pnlLeftBar.Controls.Add(this.btnCelebration);
            this.pnlLeftBar.Controls.Add(this.btnGeneral);
            this.pnlLeftBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftBar.Location = new System.Drawing.Point(0, 53);
            this.pnlLeftBar.Name = "pnlLeftBar";
            this.pnlLeftBar.Size = new System.Drawing.Size(186, 694);
            this.pnlLeftBar.TabIndex = 1;
            // 
            // btnGoodsIE
            // 
            this.btnGoodsIE.BackColor = System.Drawing.Color.Navy;
            this.btnGoodsIE.FlatAppearance.BorderSize = 0;
            this.btnGoodsIE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGoodsIE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoodsIE.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGoodsIE.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGoodsIE.Image = global::QLBH.Properties.Resources.warehouse;
            this.btnGoodsIE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoodsIE.Location = new System.Drawing.Point(1, 225);
            this.btnGoodsIE.Name = "btnGoodsIE";
            this.btnGoodsIE.Size = new System.Drawing.Size(184, 37);
            this.btnGoodsIE.TabIndex = 6;
            this.btnGoodsIE.Text = "    Nhập-Xuất hàng";
            this.btnGoodsIE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoodsIE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGoodsIE.UseVisualStyleBackColor = false;
            this.btnGoodsIE.Click += new System.EventHandler(this.btnGoodsIE_Click);
            // 
            // lklInfo
            // 
            this.lklInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lklInfo.AutoSize = true;
            this.lklInfo.LinkColor = System.Drawing.Color.Cyan;
            this.lklInfo.Location = new System.Drawing.Point(43, 665);
            this.lklInfo.Name = "lklInfo";
            this.lklInfo.Size = new System.Drawing.Size(72, 20);
            this.lklInfo.TabIndex = 5;
            this.lklInfo.TabStop = true;
            this.lklInfo.Text = "Thông tin";
            this.lklInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklInfo_LinkClicked);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Navy;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReport.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnReport.Image = global::QLBH.Properties.Resources.report;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(2, 188);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(183, 37);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "    Báo cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 37);
            this.panel3.TabIndex = 3;
            // 
            // btnGoods
            // 
            this.btnGoods.BackColor = System.Drawing.Color.Navy;
            this.btnGoods.FlatAppearance.BorderSize = 0;
            this.btnGoods.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoods.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGoods.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGoods.Image = ((System.Drawing.Image)(resources.GetObject("btnGoods.Image")));
            this.btnGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoods.Location = new System.Drawing.Point(1, 151);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(184, 37);
            this.btnGoods.TabIndex = 1;
            this.btnGoods.Text = "    Hàng hoá";
            this.btnGoods.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGoods.UseVisualStyleBackColor = false;
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnCooperation
            // 
            this.btnCooperation.BackColor = System.Drawing.Color.Navy;
            this.btnCooperation.FlatAppearance.BorderSize = 0;
            this.btnCooperation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCooperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCooperation.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCooperation.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCooperation.Image = global::QLBH.Properties.Resources.cooperation;
            this.btnCooperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCooperation.Location = new System.Drawing.Point(1, 114);
            this.btnCooperation.Name = "btnCooperation";
            this.btnCooperation.Size = new System.Drawing.Size(184, 37);
            this.btnCooperation.TabIndex = 2;
            this.btnCooperation.Text = "    Đối tác";
            this.btnCooperation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCooperation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCooperation.UseVisualStyleBackColor = false;
            this.btnCooperation.Click += new System.EventHandler(this.btnCooperation_Click);
            // 
            // btnCelebration
            // 
            this.btnCelebration.BackColor = System.Drawing.Color.Navy;
            this.btnCelebration.FlatAppearance.BorderSize = 0;
            this.btnCelebration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCelebration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCelebration.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCelebration.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCelebration.Image = global::QLBH.Properties.Resources.organization_chart;
            this.btnCelebration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCelebration.Location = new System.Drawing.Point(1, 77);
            this.btnCelebration.Name = "btnCelebration";
            this.btnCelebration.Size = new System.Drawing.Size(184, 37);
            this.btnCelebration.TabIndex = 0;
            this.btnCelebration.Text = "    Tổ chức";
            this.btnCelebration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCelebration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCelebration.UseVisualStyleBackColor = false;
            this.btnCelebration.Click += new System.EventHandler(this.btnCelebration_Click);
            // 
            // btnGeneral
            // 
            this.btnGeneral.BackColor = System.Drawing.Color.Navy;
            this.btnGeneral.FlatAppearance.BorderSize = 0;
            this.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneral.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGeneral.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnGeneral.Image = global::QLBH.Properties.Resources.admin;
            this.btnGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneral.Location = new System.Drawing.Point(1, 40);
            this.btnGeneral.Name = "btnGeneral";
            this.btnGeneral.Size = new System.Drawing.Size(184, 37);
            this.btnGeneral.TabIndex = 0;
            this.btnGeneral.Text = "    Tổng quan";
            this.btnGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGeneral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGeneral.UseVisualStyleBackColor = false;
            this.btnGeneral.Click += new System.EventHandler(this.btnGeneral_Click);
            // 
            // pnlDivPage
            // 
            this.pnlDivPage.Controls.Add(this.tblLayout);
            this.pnlDivPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDivPage.Location = new System.Drawing.Point(186, 53);
            this.pnlDivPage.Name = "pnlDivPage";
            this.pnlDivPage.Size = new System.Drawing.Size(957, 694);
            this.pnlDivPage.TabIndex = 3;
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayout.Controls.Add(this.tabPage, 0, 1);
            this.tblLayout.Controls.Add(this.flowTool, 0, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayout.Size = new System.Drawing.Size(957, 694);
            this.tblLayout.TabIndex = 0;
            // 
            // tabPage
            // 
            this.tabPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabPage.ItemSize = new System.Drawing.Size(0, 1);
            this.tabPage.Location = new System.Drawing.Point(3, 48);
            this.tabPage.Name = "tabPage";
            this.tabPage.SelectedIndex = 0;
            this.tabPage.Size = new System.Drawing.Size(977, 654);
            this.tabPage.TabIndex = 0;
            // 
            // flowTool
            // 
            this.flowTool.Location = new System.Drawing.Point(3, 3);
            this.flowTool.Name = "flowTool";
            this.flowTool.Size = new System.Drawing.Size(942, 39);
            this.flowTool.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1143, 747);
            this.Controls.Add(this.pnlDivPage);
            this.Controls.Add(this.pnlLeftBar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLeftBar.ResumeLayout(false);
            this.pnlLeftBar.PerformLayout();
            this.pnlDivPage.ResumeLayout(false);
            this.tblLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ButtonCustom btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private ButtonCustom btnMaximize;
        private System.Windows.Forms.Panel pnlLeftBar;
        private System.Windows.Forms.Button btnCelebration;
        private System.Windows.Forms.Button btnGeneral;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnCooperation;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblFullName;
        private ButtonCustom btnMinimize;
        private System.Windows.Forms.Panel pnlRightBar;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlDivPage;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.TabControl tabPage;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.LinkLabel lklInfo;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnGoodsIE;
        private System.Windows.Forms.FlowLayoutPanel flowTool;
    }
}