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
            this.components = new System.ComponentModel.Container();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.goodsidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodstypenmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplieridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suppliernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodstypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodspricebuyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodspricesellDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolBars1 = new QLBH.Resources.ToolBars();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnUnit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoGenerateColumns = false;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvData.ColumnHeadersHeight = 29;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsidDataGridViewTextBoxColumn,
            this.goodsnameDataGridViewTextBoxColumn,
            this.Unit_id,
            this.Unit_name,
            this.goodstypenmDataGridViewTextBoxColumn,
            this.brandidDataGridViewTextBoxColumn,
            this.brandnameDataGridViewTextBoxColumn,
            this.supplieridDataGridViewTextBoxColumn,
            this.suppliernameDataGridViewTextBoxColumn,
            this.goodstypeIdDataGridViewTextBoxColumn,
            this.goodspricebuyDataGridViewTextBoxColumn,
            this.goodspricesellDataGridViewTextBoxColumn});
            this.dgvData.DataSource = this.goodsBindingSource1;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvData.EnableHeadersVisualStyles = false;
            this.dgvData.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvData.Location = new System.Drawing.Point(0, 434);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1149, 413);
            this.dgvData.TabIndex = 2;
            // 
            // goodsidDataGridViewTextBoxColumn
            // 
            this.goodsidDataGridViewTextBoxColumn.DataPropertyName = "Goods_id";
            this.goodsidDataGridViewTextBoxColumn.HeaderText = "Mã hàng";
            this.goodsidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsidDataGridViewTextBoxColumn.Name = "goodsidDataGridViewTextBoxColumn";
            this.goodsidDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsnameDataGridViewTextBoxColumn
            // 
            this.goodsnameDataGridViewTextBoxColumn.DataPropertyName = "Goods_name";
            this.goodsnameDataGridViewTextBoxColumn.HeaderText = "Tên hàng";
            this.goodsnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsnameDataGridViewTextBoxColumn.Name = "goodsnameDataGridViewTextBoxColumn";
            this.goodsnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Unit_id
            // 
            this.Unit_id.DataPropertyName = "Unit_id";
            this.Unit_id.HeaderText = "Unit_id";
            this.Unit_id.MinimumWidth = 6;
            this.Unit_id.Name = "Unit_id";
            this.Unit_id.Visible = false;
            this.Unit_id.Width = 125;
            // 
            // Unit_name
            // 
            this.Unit_name.DataPropertyName = "Unit_name";
            this.Unit_name.HeaderText = "Đơn vị tính";
            this.Unit_name.MinimumWidth = 6;
            this.Unit_name.Name = "Unit_name";
            this.Unit_name.Width = 125;
            // 
            // goodstypenmDataGridViewTextBoxColumn
            // 
            this.goodstypenmDataGridViewTextBoxColumn.DataPropertyName = "Goods_type_nm";
            this.goodstypenmDataGridViewTextBoxColumn.HeaderText = "Nhóm hàng";
            this.goodstypenmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodstypenmDataGridViewTextBoxColumn.Name = "goodstypenmDataGridViewTextBoxColumn";
            this.goodstypenmDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandidDataGridViewTextBoxColumn
            // 
            this.brandidDataGridViewTextBoxColumn.DataPropertyName = "Brand_id";
            this.brandidDataGridViewTextBoxColumn.HeaderText = "Brand_id";
            this.brandidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandidDataGridViewTextBoxColumn.Name = "brandidDataGridViewTextBoxColumn";
            this.brandidDataGridViewTextBoxColumn.Visible = false;
            this.brandidDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandnameDataGridViewTextBoxColumn
            // 
            this.brandnameDataGridViewTextBoxColumn.DataPropertyName = "Brand_name";
            this.brandnameDataGridViewTextBoxColumn.HeaderText = "Hãng";
            this.brandnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandnameDataGridViewTextBoxColumn.Name = "brandnameDataGridViewTextBoxColumn";
            this.brandnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplieridDataGridViewTextBoxColumn
            // 
            this.supplieridDataGridViewTextBoxColumn.DataPropertyName = "Supplier_id";
            this.supplieridDataGridViewTextBoxColumn.HeaderText = "Supplier_id";
            this.supplieridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplieridDataGridViewTextBoxColumn.Name = "supplieridDataGridViewTextBoxColumn";
            this.supplieridDataGridViewTextBoxColumn.Visible = false;
            this.supplieridDataGridViewTextBoxColumn.Width = 125;
            // 
            // suppliernameDataGridViewTextBoxColumn
            // 
            this.suppliernameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_name";
            this.suppliernameDataGridViewTextBoxColumn.HeaderText = "Nhà cung cấp";
            this.suppliernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.suppliernameDataGridViewTextBoxColumn.Name = "suppliernameDataGridViewTextBoxColumn";
            this.suppliernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodstypeIdDataGridViewTextBoxColumn
            // 
            this.goodstypeIdDataGridViewTextBoxColumn.DataPropertyName = "Goods_type_Id";
            this.goodstypeIdDataGridViewTextBoxColumn.HeaderText = "Goods_type_Id";
            this.goodstypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodstypeIdDataGridViewTextBoxColumn.Name = "goodstypeIdDataGridViewTextBoxColumn";
            this.goodstypeIdDataGridViewTextBoxColumn.Visible = false;
            this.goodstypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodspricebuyDataGridViewTextBoxColumn
            // 
            this.goodspricebuyDataGridViewTextBoxColumn.DataPropertyName = "Goods_price_buy";
            this.goodspricebuyDataGridViewTextBoxColumn.HeaderText = "Đơn giá mua";
            this.goodspricebuyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodspricebuyDataGridViewTextBoxColumn.Name = "goodspricebuyDataGridViewTextBoxColumn";
            this.goodspricebuyDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodspricesellDataGridViewTextBoxColumn
            // 
            this.goodspricesellDataGridViewTextBoxColumn.DataPropertyName = "Goods_price_sell";
            this.goodspricesellDataGridViewTextBoxColumn.HeaderText = "Đơn giá bán";
            this.goodspricesellDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodspricesellDataGridViewTextBoxColumn.Name = "goodspricesellDataGridViewTextBoxColumn";
            this.goodspricesellDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsBindingSource1
            // 
            this.goodsBindingSource1.DataSource = typeof(DTO.Goods);
            // 
            // toolBars1
            // 
            this.toolBars1.BColorT1 = System.Drawing.Color.DarkGreen;
            this.toolBars1.BColorT2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.toolBars1.BColorT3 = System.Drawing.Color.Red;
            this.toolBars1.BColorT4 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolBars1.BColorT5 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.toolBars1.EnableT1 = true;
            this.toolBars1.EnableT2 = true;
            this.toolBars1.EnableT3 = true;
            this.toolBars1.EnableT4 = true;
            this.toolBars1.EnableT5 = true;
            this.toolBars1.FColorT1 = System.Drawing.SystemColors.ButtonHighlight;
            this.toolBars1.FColorT2 = System.Drawing.SystemColors.ButtonHighlight;
            this.toolBars1.FColorT3 = System.Drawing.SystemColors.ButtonHighlight;
            this.toolBars1.FColorT4 = System.Drawing.SystemColors.ControlText;
            this.toolBars1.FColorT5 = System.Drawing.SystemColors.ControlText;
            this.toolBars1.ImageT1 = null;
            this.toolBars1.ImageT2 = null;
            this.toolBars1.ImageT3 = null;
            this.toolBars1.ImageT4 = null;
            this.toolBars1.ImageT5 = null;
            this.toolBars1.Location = new System.Drawing.Point(230, 80);
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
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataSource = typeof(DTO.Goods);
            // 
            // btnBrand
            // 
            this.btnBrand.Location = new System.Drawing.Point(12, 12);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(104, 38);
            this.btnBrand.TabIndex = 3;
            this.btnBrand.Text = "Hãng";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(122, 12);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(143, 38);
            this.btnSupplier.TabIndex = 3;
            this.btnSupplier.Text = "Nhà cung cấp";
            this.btnSupplier.UseVisualStyleBackColor = true;
            // 
            // btnGroup
            // 
            this.btnGroup.Location = new System.Drawing.Point(271, 12);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(143, 38);
            this.btnGroup.TabIndex = 3;
            this.btnGroup.Text = "Nhóm hàng";
            this.btnGroup.UseVisualStyleBackColor = true;
            // 
            // btnUnit
            // 
            this.btnUnit.Location = new System.Drawing.Point(420, 12);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(143, 38);
            this.btnUnit.TabIndex = 3;
            this.btnUnit.Text = "Đơn vị tính";
            this.btnUnit.UseVisualStyleBackColor = true;
            // 
            // frmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1149, 847);
            this.Controls.Add(this.btnUnit);
            this.Controls.Add(this.btnGroup);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnBrand);
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
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.ToolBars toolBars1;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private System.Windows.Forms.BindingSource goodsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodstypenmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplieridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suppliernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodstypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodspricebuyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodspricesellDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBrand;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnUnit;
    }
}