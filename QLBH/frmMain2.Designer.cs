namespace QLBH
{
    partial class frmMain2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain2));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCungCấpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýCôngNợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.nhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton4 = new System.Windows.Forms.ToolStripSplitButton();
            this.backupDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thiếtLậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton5 = new System.Windows.Forms.ToolStripSplitButton();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.kiểmTraTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripSplitButton3,
            this.toolStripSplitButton4,
            this.toolStripSplitButton5});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(843, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.kiểmTraTồnKhoToolStripMenuItem});
            this.toolStripSplitButton1.Image = global::QLBH.Properties.Resources.warehouse;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(153, 24);
            this.toolStripSplitButton1.Text = "Nhập xuất hàng";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::QLBH.Properties.Resources.ip_report;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem1.Text = "Lập phiếu xuất";
            this.toolStripMenuItem1.ToolTipText = "Lập phiếu xuất";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::QLBH.Properties.Resources.import;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem2.Text = "Nhập hàng";
            this.toolStripMenuItem2.ToolTipText = "Nhập hàng";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.nhàCungCấpToolStripMenuItem,
            this.quảnLýCôngNợToolStripMenuItem});
            this.toolStripSplitButton2.Image = global::QLBH.Properties.Resources.cooperation;
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(96, 24);
            this.toolStripSplitButton2.Text = "Đối tác";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Image = global::QLBH.Properties.Resources.people;
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.ToolTipText = "Hiển thị danh sách khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // nhàCungCấpToolStripMenuItem
            // 
            this.nhàCungCấpToolStripMenuItem.Image = global::QLBH.Properties.Resources.delivery_truck;
            this.nhàCungCấpToolStripMenuItem.Name = "nhàCungCấpToolStripMenuItem";
            this.nhàCungCấpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nhàCungCấpToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.ToolTipText = "Hiển thị danh sách nhà cung cấp";
            this.nhàCungCấpToolStripMenuItem.Click += new System.EventHandler(this.nhàCungCấpToolStripMenuItem_Click);
            // 
            // quảnLýCôngNợToolStripMenuItem
            // 
            this.quảnLýCôngNợToolStripMenuItem.Image = global::QLBH.Properties.Resources.debit;
            this.quảnLýCôngNợToolStripMenuItem.Name = "quảnLýCôngNợToolStripMenuItem";
            this.quảnLýCôngNợToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.quảnLýCôngNợToolStripMenuItem.Text = "Quản lý công nợ";
            this.quảnLýCôngNợToolStripMenuItem.Click += new System.EventHandler(this.quảnLýCôngNợToolStripMenuItem_Click);
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhânViênToolStripMenuItem});
            this.toolStripSplitButton3.Image = global::QLBH.Properties.Resources.organization_chart;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(100, 24);
            this.toolStripSplitButton3.Text = "Tổ chức";
            // 
            // nhânViênToolStripMenuItem
            // 
            this.nhânViênToolStripMenuItem.Image = global::QLBH.Properties.Resources.business;
            this.nhânViênToolStripMenuItem.Name = "nhânViênToolStripMenuItem";
            this.nhânViênToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.nhânViênToolStripMenuItem.Text = "Nhân viên";
            this.nhânViênToolStripMenuItem.ToolTipText = "Hiển thị danh sách nhân viên";
            this.nhânViênToolStripMenuItem.Click += new System.EventHandler(this.nhânViênToolStripMenuItem_Click);
            // 
            // toolStripSplitButton4
            // 
            this.toolStripSplitButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDữLiệuToolStripMenuItem,
            this.thiếtLậpToolStripMenuItem});
            this.toolStripSplitButton4.Image = global::QLBH.Properties.Resources.copy_writing;
            this.toolStripSplitButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton4.Name = "toolStripSplitButton4";
            this.toolStripSplitButton4.Size = new System.Drawing.Size(110, 24);
            this.toolStripSplitButton4.Text = "Hệ thống";
            // 
            // backupDữLiệuToolStripMenuItem
            // 
            this.backupDữLiệuToolStripMenuItem.Image = global::QLBH.Properties.Resources.data;
            this.backupDữLiệuToolStripMenuItem.Name = "backupDữLiệuToolStripMenuItem";
            this.backupDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.backupDữLiệuToolStripMenuItem.Text = "Sao lưu dữ liệu";
            this.backupDữLiệuToolStripMenuItem.ToolTipText = "Chức năng sao lưu dữ liệu";
            this.backupDữLiệuToolStripMenuItem.Click += new System.EventHandler(this.backupDữLiệuToolStripMenuItem_Click);
            // 
            // thiếtLậpToolStripMenuItem
            // 
            this.thiếtLậpToolStripMenuItem.Image = global::QLBH.Properties.Resources.settings;
            this.thiếtLậpToolStripMenuItem.Name = "thiếtLậpToolStripMenuItem";
            this.thiếtLậpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.thiếtLậpToolStripMenuItem.Text = "Thiết lập";
            this.thiếtLậpToolStripMenuItem.ToolTipText = "Thiết lập hệ thống";
            this.thiếtLậpToolStripMenuItem.Click += new System.EventHandler(this.thiếtLậpToolStripMenuItem_Click);
            // 
            // toolStripSplitButton5
            // 
            this.toolStripSplitButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem1});
            this.toolStripSplitButton5.Image = global::QLBH.Properties.Resources.user;
            this.toolStripSplitButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton5.Name = "toolStripSplitButton5";
            this.toolStripSplitButton5.Size = new System.Drawing.Size(110, 24);
            this.toolStripSplitButton5.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Image = global::QLBH.Properties.Resources.power_off;
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.ToolTipText = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 498);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // kiểmTraTồnKhoToolStripMenuItem
            // 
            this.kiểmTraTồnKhoToolStripMenuItem.Name = "kiểmTraTồnKhoToolStripMenuItem";
            this.kiểmTraTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kiểmTraTồnKhoToolStripMenuItem.Text = "Kiểm tra tồn kho";
            this.kiểmTraTồnKhoToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraTồnKhoToolStripMenuItem_Click);
            // 
            // frmMain2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 523);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain2";
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frmMain2_Shown);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCungCấpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.ToolStripMenuItem nhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton4;
        private System.Windows.Forms.ToolStripMenuItem backupDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thiếtLậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton5;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýCôngNợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraTồnKhoToolStripMenuItem;
    }
}



