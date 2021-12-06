namespace QLBH.Pages
{
    partial class frmGoods
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHangHoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhomHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaMua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolBars1 = new QLBH.Resources.ToolBars();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvData.ColumnHeadersHeight = 29;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHangHoa,
            this.Hang,
            this.NhaCungCap,
            this.NhomHang,
            this.DonGiaMua,
            this.DonGiaBan});
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData.Location = new System.Drawing.Point(0, 165);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1078, 641);
            this.dgvData.TabIndex = 2;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.MinimumWidth = 6;
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Width = 125;
            // 
            // TenHangHoa
            // 
            this.TenHangHoa.DataPropertyName = "TenHangHoa";
            this.TenHangHoa.HeaderText = "Tên hàng";
            this.TenHangHoa.MinimumWidth = 6;
            this.TenHangHoa.Name = "TenHangHoa";
            this.TenHangHoa.Width = 125;
            // 
            // Hang
            // 
            this.Hang.DataPropertyName = "Hang";
            this.Hang.HeaderText = "Hãng SX";
            this.Hang.MinimumWidth = 6;
            this.Hang.Name = "Hang";
            this.Hang.Width = 125;
            // 
            // NhaCungCap
            // 
            this.NhaCungCap.DataPropertyName = "NhaCungCap";
            this.NhaCungCap.HeaderText = "Nhà cung cấp";
            this.NhaCungCap.MinimumWidth = 6;
            this.NhaCungCap.Name = "NhaCungCap";
            this.NhaCungCap.Width = 125;
            // 
            // NhomHang
            // 
            this.NhomHang.DataPropertyName = "NhomHang";
            this.NhomHang.HeaderText = "Nhóm";
            this.NhomHang.MinimumWidth = 6;
            this.NhomHang.Name = "NhomHang";
            this.NhomHang.Width = 125;
            // 
            // DonGiaMua
            // 
            this.DonGiaMua.DataPropertyName = "DonGiaMua";
            this.DonGiaMua.HeaderText = "Đơn giá mua";
            this.DonGiaMua.MinimumWidth = 6;
            this.DonGiaMua.Name = "DonGiaMua";
            this.DonGiaMua.Width = 125;
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn giá bán";
            this.DonGiaBan.MinimumWidth = 6;
            this.DonGiaBan.Name = "DonGiaBan";
            this.DonGiaBan.Width = 125;
            // 
            // toolBars1
            // 
            this.toolBars1.BColorT1 = System.Drawing.Color.DarkGreen;
            this.toolBars1.BColorT2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolBars1.BColorT3 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolBars1.BColorT4 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolBars1.BColorT5 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolBars1.EnableT1 = true;
            this.toolBars1.EnableT2 = true;
            this.toolBars1.EnableT3 = true;
            this.toolBars1.EnableT4 = true;
            this.toolBars1.EnableT5 = true;
            this.toolBars1.FColorT1 = System.Drawing.SystemColors.ButtonHighlight;
            this.toolBars1.FColorT2 = System.Drawing.SystemColors.ButtonHighlight;
            this.toolBars1.FColorT3 = System.Drawing.SystemColors.ControlText;
            this.toolBars1.FColorT4 = System.Drawing.SystemColors.ControlText;
            this.toolBars1.FColorT5 = System.Drawing.SystemColors.ControlText;
            this.toolBars1.ImageT1 = null;
            this.toolBars1.ImageT2 = null;
            this.toolBars1.ImageT3 = null;
            this.toolBars1.ImageT4 = null;
            this.toolBars1.ImageT5 = null;
            this.toolBars1.Location = new System.Drawing.Point(232, 13);
            this.toolBars1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolBars1.Name = "toolBars1";
            this.toolBars1.Size = new System.Drawing.Size(554, 51);
            this.toolBars1.TabIndex = 1;
            this.toolBars1.TextT1 = "Thêm";
            this.toolBars1.TextT2 = "Sửa";
            this.toolBars1.TextT3 = "Xoá";
            this.toolBars1.TextT4 = "In";
            this.toolBars1.TextT5 = "Xuất Excel";
            this.toolBars1.FClick += new QLBH.Resources.CustomEventHandler(this.toolBars1_FClick);
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1078, 806);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.toolBars1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGoods";
            this.Text = "Hàng hoá";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.ToolBars toolBars1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHangHoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhomHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaMua;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
    }
}