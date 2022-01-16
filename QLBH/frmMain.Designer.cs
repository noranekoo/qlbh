
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnGoods = new System.Windows.Forms.Button();
            this.btnCooperation = new System.Windows.Forms.Button();
            this.btnSystem = new System.Windows.Forms.Button();
            this.btnOrganization = new System.Windows.Forms.Button();
            this.btnInExGoods = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnGoods);
            this.panel1.Controls.Add(this.btnCooperation);
            this.panel1.Controls.Add(this.btnSystem);
            this.panel1.Controls.Add(this.btnOrganization);
            this.panel1.Controls.Add(this.btnInExGoods);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 665);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblFullName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 42);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "username";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFullName.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblFullName.Location = new System.Drawing.Point(3, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(134, 21);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Nguyễn Anh Thi";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnLogout.Image = global::QLBH.Properties.Resources.power_off;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(395, 458);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(340, 180);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnGoods
            // 
            this.btnGoods.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGoods.FlatAppearance.BorderSize = 0;
            this.btnGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoods.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGoods.Image = global::QLBH.Properties.Resources.goods;
            this.btnGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGoods.Location = new System.Drawing.Point(395, 268);
            this.btnGoods.Name = "btnGoods";
            this.btnGoods.Size = new System.Drawing.Size(340, 180);
            this.btnGoods.TabIndex = 6;
            this.btnGoods.Text = "Hàng hoá";
            this.btnGoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGoods.UseVisualStyleBackColor = false;
            this.btnGoods.Click += new System.EventHandler(this.btnGoods_Click);
            // 
            // btnCooperation
            // 
            this.btnCooperation.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCooperation.FlatAppearance.BorderSize = 0;
            this.btnCooperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCooperation.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCooperation.Image = global::QLBH.Properties.Resources.cooperation;
            this.btnCooperation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCooperation.Location = new System.Drawing.Point(395, 78);
            this.btnCooperation.Name = "btnCooperation";
            this.btnCooperation.Size = new System.Drawing.Size(340, 180);
            this.btnCooperation.TabIndex = 6;
            this.btnCooperation.Text = "Đối tác";
            this.btnCooperation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCooperation.UseVisualStyleBackColor = false;
            this.btnCooperation.Click += new System.EventHandler(this.btnCooperation_Click);
            // 
            // btnSystem
            // 
            this.btnSystem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSystem.FlatAppearance.BorderSize = 0;
            this.btnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSystem.Image = global::QLBH.Properties.Resources.settings;
            this.btnSystem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystem.Location = new System.Drawing.Point(43, 458);
            this.btnSystem.Name = "btnSystem";
            this.btnSystem.Size = new System.Drawing.Size(340, 180);
            this.btnSystem.TabIndex = 5;
            this.btnSystem.Text = "Hệ thống";
            this.btnSystem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystem.UseVisualStyleBackColor = false;
            this.btnSystem.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnOrganization
            // 
            this.btnOrganization.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnOrganization.FlatAppearance.BorderSize = 0;
            this.btnOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrganization.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnOrganization.Image = global::QLBH.Properties.Resources.organization_chart;
            this.btnOrganization.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrganization.Location = new System.Drawing.Point(43, 268);
            this.btnOrganization.Name = "btnOrganization";
            this.btnOrganization.Size = new System.Drawing.Size(340, 180);
            this.btnOrganization.TabIndex = 5;
            this.btnOrganization.Text = "Tổ chức";
            this.btnOrganization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrganization.UseVisualStyleBackColor = false;
            this.btnOrganization.Click += new System.EventHandler(this.btnCelebration_Click);
            // 
            // btnInExGoods
            // 
            this.btnInExGoods.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnInExGoods.FlatAppearance.BorderSize = 0;
            this.btnInExGoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInExGoods.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnInExGoods.Image = global::QLBH.Properties.Resources.warehouse;
            this.btnInExGoods.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInExGoods.Location = new System.Drawing.Point(43, 78);
            this.btnInExGoods.Name = "btnInExGoods";
            this.btnInExGoods.Size = new System.Drawing.Size(340, 180);
            this.btnInExGoods.TabIndex = 4;
            this.btnInExGoods.Text = "Nhập xuất hàng";
            this.btnInExGoods.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInExGoods.UseVisualStyleBackColor = false;
            this.btnInExGoods.Click += new System.EventHandler(this.btnInExGoods_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(783, 665);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Button btnInExGoods;
        private System.Windows.Forms.Button btnOrganization;
        private System.Windows.Forms.Button btnCooperation;
        private System.Windows.Forms.Button btnGoods;
        private System.Windows.Forms.Button btnSystem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}