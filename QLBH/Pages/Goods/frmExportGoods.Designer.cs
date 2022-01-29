namespace QLBH.Pages.Goods
{
    partial class frmExportGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportGoods));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.dtpDeliDate = new System.Windows.Forms.DateTimePicker();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.txtPhoneEmp = new System.Windows.Forms.TextBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.cbbPayment = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbEmployeeName = new System.Windows.Forms.ComboBox();
            this.btnSelectBill = new System.Windows.Forms.Button();
            this.btnNewBill = new System.Windows.Forms.Button();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.grbProductName = new System.Windows.Forms.GroupBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.rchRemark = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnSelectProduct = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new QLBH.Resources.ButtonCustom();
            this.dgvData = new QLBH.Resources.DataGridViewCustom();
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.grb2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.grbProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtCustomerName.Location = new System.Drawing.Point(15, 55);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(209, 27);
            this.txtCustomerName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Số điện thoại:";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(15, 236);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(209, 27);
            this.txtPhone.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ngày giao hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhân viên giao hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số điện thoại:";
            // 
            // rchAddress
            // 
            this.rchAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchAddress.Location = new System.Drawing.Point(15, 110);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(357, 100);
            this.rchAddress.TabIndex = 18;
            this.rchAddress.Text = "";
            // 
            // dtpDeliDate
            // 
            this.dtpDeliDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDeliDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliDate.Location = new System.Drawing.Point(391, 57);
            this.dtpDeliDate.Name = "dtpDeliDate";
            this.dtpDeliDate.Size = new System.Drawing.Size(126, 27);
            this.dtpDeliDate.TabIndex = 19;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.BackColor = System.Drawing.Color.Coral;
            this.btnSelectCustomer.FlatAppearance.BorderSize = 0;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSelectCustomer.Location = new System.Drawing.Point(225, 54);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(60, 28);
            this.btnSelectCustomer.TabIndex = 20;
            this.btnSelectCustomer.Text = "Chọn";
            this.btnSelectCustomer.UseVisualStyleBackColor = false;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // txtPhoneEmp
            // 
            this.txtPhoneEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneEmp.Location = new System.Drawing.Point(391, 171);
            this.txtPhoneEmp.Name = "txtPhoneEmp";
            this.txtPhoneEmp.Size = new System.Drawing.Size(209, 27);
            this.txtPhoneEmp.TabIndex = 23;
            // 
            // grb1
            // 
            this.grb1.Controls.Add(this.cbbPayment);
            this.grb1.Controls.Add(this.label8);
            this.grb1.Controls.Add(this.cbbEmployeeName);
            this.grb1.Controls.Add(this.txtPhoneEmp);
            this.grb1.Controls.Add(this.txtCustomerName);
            this.grb1.Controls.Add(this.label1);
            this.grb1.Controls.Add(this.label2);
            this.grb1.Controls.Add(this.btnSelectCustomer);
            this.grb1.Controls.Add(this.txtPhone);
            this.grb1.Controls.Add(this.dtpDeliDate);
            this.grb1.Controls.Add(this.label3);
            this.grb1.Controls.Add(this.rchAddress);
            this.grb1.Controls.Add(this.label4);
            this.grb1.Controls.Add(this.label6);
            this.grb1.Controls.Add(this.label5);
            this.grb1.Enabled = false;
            this.grb1.Location = new System.Drawing.Point(11, 54);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(681, 335);
            this.grb1.TabIndex = 24;
            this.grb1.TabStop = false;
            this.grb1.Text = "Thông tin khách hàng và nhân viên";
            // 
            // cbbPayment
            // 
            this.cbbPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPayment.FormattingEnabled = true;
            this.cbbPayment.Location = new System.Drawing.Point(391, 236);
            this.cbbPayment.Name = "cbbPayment";
            this.cbbPayment.Size = new System.Drawing.Size(259, 28);
            this.cbbPayment.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(390, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Hình thức thanh toán:";
            // 
            // cbbEmployeeName
            // 
            this.cbbEmployeeName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbEmployeeName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbEmployeeName.FormattingEnabled = true;
            this.cbbEmployeeName.Location = new System.Drawing.Point(391, 117);
            this.cbbEmployeeName.Name = "cbbEmployeeName";
            this.cbbEmployeeName.Size = new System.Drawing.Size(259, 28);
            this.cbbEmployeeName.TabIndex = 24;
            // 
            // btnSelectBill
            // 
            this.btnSelectBill.BackColor = System.Drawing.Color.Honeydew;
            this.btnSelectBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelectBill.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSelectBill.Image = global::QLBH.Properties.Resources.blogger;
            this.btnSelectBill.Location = new System.Drawing.Point(141, 12);
            this.btnSelectBill.Name = "btnSelectBill";
            this.btnSelectBill.Size = new System.Drawing.Size(119, 36);
            this.btnSelectBill.TabIndex = 35;
            this.btnSelectBill.Text = "Sửa";
            this.btnSelectBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectBill.UseVisualStyleBackColor = false;
            this.btnSelectBill.Click += new System.EventHandler(this.btnSelectBill_Click);
            // 
            // btnNewBill
            // 
            this.btnNewBill.BackColor = System.Drawing.Color.Honeydew;
            this.btnNewBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNewBill.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnNewBill.Image = ((System.Drawing.Image)(resources.GetObject("btnNewBill.Image")));
            this.btnNewBill.Location = new System.Drawing.Point(12, 12);
            this.btnNewBill.Name = "btnNewBill";
            this.btnNewBill.Size = new System.Drawing.Size(123, 36);
            this.btnNewBill.TabIndex = 35;
            this.btnNewBill.Text = "Thêm mới";
            this.btnNewBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewBill.UseVisualStyleBackColor = false;
            this.btnNewBill.Click += new System.EventHandler(this.btnNewBill_Click);
            // 
            // grb2
            // 
            this.grb2.Controls.Add(this.numDiscount);
            this.grb2.Controls.Add(this.numQuantity);
            this.grb2.Controls.Add(this.grbProductName);
            this.grb2.Controls.Add(this.btnAdd);
            this.grb2.Controls.Add(this.btnNew);
            this.grb2.Controls.Add(this.rchRemark);
            this.grb2.Controls.Add(this.label14);
            this.grb2.Controls.Add(this.label13);
            this.grb2.Controls.Add(this.label12);
            this.grb2.Controls.Add(this.lblTotalPrice);
            this.grb2.Controls.Add(this.lblUnitPrice);
            this.grb2.Controls.Add(this.label11);
            this.grb2.Controls.Add(this.label10);
            this.grb2.Controls.Add(this.label9);
            this.grb2.Controls.Add(this.label7);
            this.grb2.Controls.Add(this.txtProductID);
            this.grb2.Controls.Add(this.btnSelectProduct);
            this.grb2.Enabled = false;
            this.grb2.Location = new System.Drawing.Point(699, 12);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(533, 377);
            this.grb2.TabIndex = 25;
            this.grb2.TabStop = false;
            this.grb2.Text = "Thông tin hàng hoá";
            // 
            // numDiscount
            // 
            this.numDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numDiscount.Enabled = false;
            this.numDiscount.Location = new System.Drawing.Point(357, 141);
            this.numDiscount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(50, 23);
            this.numDiscount.TabIndex = 39;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // numQuantity
            // 
            this.numQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numQuantity.Enabled = false;
            this.numQuantity.Location = new System.Drawing.Point(88, 172);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(69, 23);
            this.numQuantity.TabIndex = 38;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            this.numQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numQuantity_KeyUp);
            // 
            // grbProductName
            // 
            this.grbProductName.Controls.Add(this.lblProductName);
            this.grbProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbProductName.Location = new System.Drawing.Point(5, 61);
            this.grbProductName.Name = "grbProductName";
            this.grbProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grbProductName.Size = new System.Drawing.Size(522, 64);
            this.grbProductName.TabIndex = 37;
            this.grbProductName.TabStop = false;
            this.grbProductName.Text = "Tên hàng hoá";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblProductName.ForeColor = System.Drawing.Color.Tomato;
            this.lblProductName.Location = new System.Drawing.Point(6, 22);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(0, 28);
            this.lblProductName.TabIndex = 36;
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProductName.Paint += new System.Windows.Forms.PaintEventHandler(this.lblProductName_Paint);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Tomato;
            this.btnAdd.Enabled = false;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAdd.Image = global::QLBH.Properties.Resources.selection;
            this.btnAdd.Location = new System.Drawing.Point(427, 335);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 32);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Honeydew;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNew.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.Location = new System.Drawing.Point(290, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(123, 36);
            this.btnNew.TabIndex = 34;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // rchRemark
            // 
            this.rchRemark.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchRemark.Location = new System.Drawing.Point(16, 235);
            this.rchRemark.Name = "rchRemark";
            this.rchRemark.Size = new System.Drawing.Size(511, 96);
            this.rchRemark.TabIndex = 33;
            this.rchRemark.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Ghi chú:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 142);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "%";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Chiết khấu:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalPrice.Location = new System.Drawing.Point(264, 171);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(74, 28);
            this.lblTotalPrice.TabIndex = 27;
            this.lblTotalPrice.Text = "0 VNĐ";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblUnitPrice.Location = new System.Drawing.Point(83, 136);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(74, 28);
            this.lblUnitPrice.TabIndex = 27;
            this.lblUnitPrice.Text = "0 VNĐ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Số lượng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Thành tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 141);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Đơn giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Mã hàng hoá:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(115, 27);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(99, 27);
            this.txtProductID.TabIndex = 21;
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.BackColor = System.Drawing.Color.Coral;
            this.btnSelectProduct.FlatAppearance.BorderSize = 0;
            this.btnSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelectProduct.ForeColor = System.Drawing.Color.White;
            this.btnSelectProduct.Location = new System.Drawing.Point(215, 26);
            this.btnSelectProduct.Name = "btnSelectProduct";
            this.btnSelectProduct.Size = new System.Drawing.Size(60, 29);
            this.btnSelectProduct.TabIndex = 22;
            this.btnSelectProduct.Text = "Chọn";
            this.btnSelectProduct.UseVisualStyleBackColor = false;
            this.btnSelectProduct.Click += new System.EventHandler(this.btnSelectProduct_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSelect.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSelect.Image = global::QLBH.Properties.Resources.selection;
            this.btnSelect.Location = new System.Drawing.Point(1044, 783);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(89, 36);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "OK";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(1137, 783);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 36);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.ActiveColor = System.Drawing.Color.Empty;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DeactiveColor = System.Drawing.Color.Empty;
            this.btnReset.EnableChangeImageClick = false;
            this.btnReset.FirstClickImage = null;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.IsActive = false;
            this.btnReset.Location = new System.Drawing.Point(12, 783);
            this.btnReset.Name = "btnReset";
            this.btnReset.SecondClickImage = null;
            this.btnReset.Size = new System.Drawing.Size(95, 36);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "RESET";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.ProductID,
            this.ProductName,
            this.UnitPrice,
            this.Unit,
            this.Quantity,
            this.Discount,
            this.TotalPrice,
            this.Remark});
            this.dgvData.GridColor = System.Drawing.Color.SandyBrown;
            this.dgvData.Location = new System.Drawing.Point(11, 396);
            this.dgvData.MultiSelect = false;
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowOfTableIndex = 0;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvData.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvData.RowSelectedIndex = 0;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(1220, 382);
            this.dgvData.TabIndex = 8;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "MaPhieu";
            this.BillID.HeaderText = "MaPhieu";
            this.BillID.Name = "BillID";
            this.BillID.Visible = false;
            this.BillID.Width = 72;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "MaSP";
            this.ProductID.HeaderText = "Mã sản phẩm";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 127;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "TenSP";
            this.ProductName.HeaderText = "Tên sản phẩm";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 129;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "DonGia";
            this.UnitPrice.HeaderText = "Đơn giá";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 91;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "DVT";
            this.Unit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.Unit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unit.HeaderText = "DonViTinh";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Unit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Unit.Visible = false;
            this.Unit.Width = 107;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "SoLuong";
            this.Quantity.HeaderText = "Số lượng";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 98;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "ChietKhau";
            this.Discount.HeaderText = "Chiết khấu";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 107;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "ThanhTien";
            this.TotalPrice.HeaderText = "Thành tiền";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 107;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "GhiChu";
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Remark.DefaultCellStyle = dataGridViewCellStyle5;
            this.Remark.HeaderText = "Ghi chú";
            this.Remark.Name = "Remark";
            this.Remark.ReadOnly = true;
            this.Remark.Width = 87;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPrint.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnPrint.Image = global::QLBH.Properties.Resources.printer;
            this.btnPrint.Location = new System.Drawing.Point(940, 783);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(98, 36);
            this.btnPrint.TabIndex = 36;
            this.btnPrint.Text = "In phiếu";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmExportGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 831);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSelectBill);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewBill);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.dgvData);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmExportGoods";
            this.Text = "Lập phiếu xuất kho";
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.grbProductName.ResumeLayout(false);
            this.grbProductName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Resources.DataGridViewCustom dgvData;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchAddress;
        private System.Windows.Forms.DateTimePicker dtpDeliDate;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.TextBox txtPhoneEmp;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.ComboBox cbbEmployeeName;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnSelectProduct;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox rchRemark;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSelect;
        private Resources.ButtonCustom btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox grbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnSelectBill;
        private System.Windows.Forms.Button btnNewBill;
        private System.Windows.Forms.ComboBox cbbPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.Button btnPrint;
    }
}