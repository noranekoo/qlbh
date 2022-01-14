namespace QLBH.Resources
{
    partial class EmployeeDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblJobDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::QLBH.Properties.Resources.boy;
            this.picAvatar.Location = new System.Drawing.Point(52, 4);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(221, 199);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày bắt đầu làm việc:";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(52, 265);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(106, 31);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Xem chi tiết";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblFullName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFullName.Location = new System.Drawing.Point(59, 213);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 20);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "Họ tên:";
            // 
            // lblJobDate
            // 
            this.lblJobDate.AutoSize = true;
            this.lblJobDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblJobDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblJobDate.Location = new System.Drawing.Point(164, 242);
            this.lblJobDate.Name = "lblJobDate";
            this.lblJobDate.Size = new System.Drawing.Size(91, 20);
            this.lblJobDate.TabIndex = 6;
            this.lblJobDate.Text = "Ngày tháng";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 31);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Sửa thông tin";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblJobDate);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EmployeeDetail";
            this.Size = new System.Drawing.Size(323, 306);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblJobDate;
        private System.Windows.Forms.Button btnUpdate;
    }
}
