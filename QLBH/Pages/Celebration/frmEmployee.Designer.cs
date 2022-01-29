namespace QLBH.Pages.Celebration
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlListEmpInfo = new System.Windows.Forms.Panel();
            this.btnDepart = new System.Windows.Forms.Button();
            this.toolBar = new QLBH.Resources.ToolBars();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::QLBH.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(323, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 27);
            this.txtName.TabIndex = 1;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập từ khoá:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlListEmpInfo
            // 
            this.pnlListEmpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListEmpInfo.AutoScroll = true;
            this.pnlListEmpInfo.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlListEmpInfo.Location = new System.Drawing.Point(13, 59);
            this.pnlListEmpInfo.Name = "pnlListEmpInfo";
            this.pnlListEmpInfo.Size = new System.Drawing.Size(1149, 601);
            this.pnlListEmpInfo.TabIndex = 3;
            // 
            // btnDepart
            // 
            this.btnDepart.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnDepart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDepart.Image = global::QLBH.Properties.Resources.department;
            this.btnDepart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepart.Location = new System.Drawing.Point(997, 10);
            this.btnDepart.Name = "btnDepart";
            this.btnDepart.Size = new System.Drawing.Size(100, 32);
            this.btnDepart.TabIndex = 5;
            this.btnDepart.Text = "Bộ phận";
            this.btnDepart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepart.UseVisualStyleBackColor = false;
            this.btnDepart.Click += new System.EventHandler(this.btnDepart_Click);
            // 
            // toolBar
            // 
            this.toolBar.BColorT1 = System.Drawing.SystemColors.Control;
            this.toolBar.BColorT2 = System.Drawing.SystemColors.Control;
            this.toolBar.BColorT3 = System.Drawing.SystemColors.Control;
            this.toolBar.BColorT4 = System.Drawing.SystemColors.Control;
            this.toolBar.BColorT5 = System.Drawing.SystemColors.Control;
            this.toolBar.EnableT1 = true;
            this.toolBar.EnableT2 = false;
            this.toolBar.EnableT3 = false;
            this.toolBar.EnableT4 = false;
            this.toolBar.EnableT5 = false;
            this.toolBar.FColorT1 = System.Drawing.SystemColors.ControlText;
            this.toolBar.FColorT2 = System.Drawing.SystemColors.ControlText;
            this.toolBar.FColorT3 = System.Drawing.SystemColors.ControlText;
            this.toolBar.FColorT4 = System.Drawing.SystemColors.ControlText;
            this.toolBar.FColorT5 = System.Drawing.SystemColors.ControlText;
            this.toolBar.ImageT1 = null;
            this.toolBar.ImageT2 = null;
            this.toolBar.ImageT3 = null;
            this.toolBar.ImageT4 = null;
            this.toolBar.ImageT5 = null;
            this.toolBar.Location = new System.Drawing.Point(437, 1);
            this.toolBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(554, 52);
            this.toolBar.TabIndex = 4;
            this.toolBar.TextT1 = "Thêm";
            this.toolBar.TextT2 = "Sửa";
            this.toolBar.TextT3 = "Xoá";
            this.toolBar.TextT4 = "In";
            this.toolBar.TextT5 = "Xuất Excel";
            this.toolBar.FClick += new QLBH.Resources.CustomEventHandler(this.toolBar_FClick);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1172, 672);
            this.Controls.Add(this.btnDepart);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.pnlListEmpInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.ShowInTaskbar = false;
            this.Text = "Quản lý nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlListEmpInfo;
        private Resources.ToolBars toolBar;
        private System.Windows.Forms.Button btnDepart;
    }
}