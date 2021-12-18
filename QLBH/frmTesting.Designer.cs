namespace QLBH
{
    partial class frmTesting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.TestAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTB2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTB2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TestAID,
            this.TenTb,
            this.MoTa,
            this.MaTB2,
            this.TenTB2});
            this.dgvData.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvData.Location = new System.Drawing.Point(12, 33);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(906, 454);
            this.dgvData.TabIndex = 3;
            // 
            // TestAID
            // 
            this.TestAID.DataPropertyName = "MaTb1";
            this.TestAID.HeaderText = "Column1";
            this.TestAID.MinimumWidth = 6;
            this.TestAID.Name = "TestAID";
            this.TestAID.Visible = false;
            this.TestAID.Width = 74;
            // 
            // TenTb
            // 
            this.TenTb.DataPropertyName = "TenTb";
            this.TenTb.HeaderText = "TenTB";
            this.TenTb.MinimumWidth = 6;
            this.TenTb.Name = "TenTb";
            this.TenTb.Width = 78;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.Width = 77;
            // 
            // MaTB2
            // 
            this.MaTB2.DataPropertyName = "MaTb2";
            this.MaTB2.HeaderText = "Mãtb2";
            this.MaTB2.MinimumWidth = 6;
            this.MaTB2.Name = "MaTB2";
            this.MaTB2.Visible = false;
            this.MaTB2.Width = 81;
            // 
            // TenTB2
            // 
            this.TenTB2.DataPropertyName = "TenTb2";
            this.TenTB2.HeaderText = "Tên TB 2";
            this.TenTB2.MinimumWidth = 6;
            this.TenTB2.Name = "TenTB2";
            this.TenTB2.Width = 94;
            // 
            // frmTesting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 504);
            this.Controls.Add(this.dgvData);
            this.Name = "frmTesting";
            this.Text = "frmTesting";
            this.Load += new System.EventHandler(this.frmTesting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTb;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTB2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTB2;
    }
}