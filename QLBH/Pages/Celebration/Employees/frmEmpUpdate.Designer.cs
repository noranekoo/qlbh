namespace QLBH.Pages.Celebration.Employees
{
    partial class frmEmpUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpUpdate));
            this.btnSave = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richAddress = new System.Windows.Forms.RichTextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.dtpJobDate = new System.Windows.Forms.DateTimePicker();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cbbDepart = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(409, 318);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Location = new System.Drawing.Point(7, 42);
            this.picAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(198, 197);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 1;
            this.picAvatar.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(503, 318);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 31);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Huỷ bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(59, 247);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 31);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "Chọn ảnh";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên:";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(279, 13);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(299, 27);
            this.txtFullName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "CMND/CCCD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày nhận việc:";
            // 
            // richAddress
            // 
            this.richAddress.Location = new System.Drawing.Point(279, 75);
            this.richAddress.Name = "richAddress";
            this.richAddress.Size = new System.Drawing.Size(299, 69);
            this.richAddress.TabIndex = 2;
            this.richAddress.Text = "";
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dd/MM/yyyy";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(299, 44);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(126, 27);
            this.dtpBirthday.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(322, 149);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(256, 27);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(271, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(307, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(313, 216);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(265, 27);
            this.txtIDNumber.TabIndex = 5;
            // 
            // dtpJobDate
            // 
            this.dtpJobDate.CustomFormat = "dd/MM/yyyy";
            this.dtpJobDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpJobDate.Location = new System.Drawing.Point(335, 248);
            this.dtpJobDate.Name = "dtpJobDate";
            this.dtpJobDate.Size = new System.Drawing.Size(126, 27);
            this.dtpJobDate.TabIndex = 6;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(DTO.Employee);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bộ phận/Chức vụ:";
            // 
            // cbbDepart
            // 
            this.cbbDepart.FormattingEnabled = true;
            this.cbbDepart.Location = new System.Drawing.Point(347, 283);
            this.cbbDepart.Name = "cbbDepart";
            this.cbbDepart.Size = new System.Drawing.Size(231, 28);
            this.cbbDepart.TabIndex = 11;
            this.cbbDepart.SelectedIndexChanged += new System.EventHandler(this.cbbDepart_SelectedIndexChanged);
            // 
            // frmEmpUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 384);
            this.Controls.Add(this.cbbDepart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpJobDate);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.richAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmpUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập nhật thông tin";
            this.Load += new System.EventHandler(this.frmEmpUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richAddress;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.DateTimePicker dtpJobDate;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbDepart;
    }
}