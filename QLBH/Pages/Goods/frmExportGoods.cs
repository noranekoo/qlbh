using DAL;
using DTO;
using QLBH.Pages.Cooperation;
using QLBH.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Pages.Goods
{
    public partial class frmExportGoods : FormCustom
    {
        DataTable dtEmployee = null, dtUnit = null, dtBill= null, dtProduct = null;
        DataSet ds = new DataSet();
        Product product = null;
        Customer customer = null;
        Employee employee = null;
        Bill billInfo = null;
        DataTable dtExProduct = new DataTable("CTPX");
        DataRow dr = null;
        string bID = Guid.NewGuid().ToString();
        public frmExportGoods()
        {
            InitializeComponent();
            InitLoad();
            InitDataSet();
            dgvData.RowPrePaint += FormHandler.RowPrepaintHandler;
            //dgvData.RowPrePaint += DgvData_RowPrePaint;
            //dgvData.CellFormatting += DgvData_CellFormatting;
            //dgvData.CellParsing += DgvData_CellParsing;
            //BindData();
            //dgvData.DataError += DgvData_DataError;
        }

        private void DgvData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //MessageBox.Show(e.Exception.Message);
        }

        //private void DgvData_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        //{
        //    if (e != null)
        //    {
        //        if(e.Value != null)
        //        {
        //            try
        //            {
        //                e.Value = "xxxx";
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show(ex.Message);
        //            }
                    
        //        }
        //    }
        //}

        void BindData()
        {
            txtCustomerName.DataBindings.Add(new Binding("Text", customer, "CustomerName"));
            txtPhone.DataBindings.Add(new Binding("Text", customer, "Phone"));
            rchAddress.DataBindings.Add(new Binding("Text", customer, "Address"));
            cbbEmployeeName.DataBindings.Add(new Binding("SelectedValue", employee, "ID"));
            txtPhoneEmp.DataBindings.Add(new Binding("Text", employee, "Phone"));
        }

        private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //if (dgvData.Rows.Count > 0 && !dgvData.Rows[e.RowIndex].IsNewRow)
            //{
            //    string val = dgvData[5, e.RowIndex].Value.ToString();
            //    //string formatted = "555";
            //    dgvData[5, e.RowIndex].Value = formatted;
            //}
        }

        void InitLoad()
        {
            try
            {
                dtUnit = UnitDAL.Instance.GetUnitList();
                dtBill = BillDAL.Instance.GetBillList();
                dtProduct = GoodsDAL.Instance.GetProductList();
                dtEmployee = EmployeeDAL.Instance.GetEmployeeList();
                employee = new Employee();
                customer = new Customer();
                
                dtEmployee.Rows.InsertAt(dtEmployee.NewRow(), 0);
                dgvData.DataSource = dtExProduct;
            }
            catch(Exception e)
            {
                FormHandler.ShowErrorMessage(e.Message);
            }
        }

        void CreateColumn(bool isInit = false)
        {
            dtExProduct = BillDAL.Instance.GetDetailBillList(bID);
            
            DataColumn[] cols = new DataColumn[3]
            {
                  new DataColumn("TenSP", typeof(string)),
                  new DataColumn("DVT", typeof(int)),
                  new DataColumn("DonGia",typeof(decimal)),
            };
            dtExProduct.Columns.AddRange(cols);
            if (ds.Tables.Contains("Table1"))
            {
                ds.Tables["Table1"].Constraints.Clear();
            }
            ds.Relations.Clear();
            ds.Tables.Clear();
            ds.Tables.AddRange(new DataTable[] { dtExProduct, dtProduct });
            DataRelation rl = new DataRelation("Product_Bill", dtProduct.Columns["MaHang"], dtExProduct.Columns["MaSP"]);
            ds.Relations.Add(rl);
            ds.Tables["Table1"].Columns["TenSP"].Expression = "Parent(Product_Bill).[TenHangHoa]";
            ds.Tables["Table1"].Columns["DVT"].Expression = "Parent(Product_Bill).[DonViTinh]";
            ds.Tables["Table1"].Columns["DonGia"].Expression = "Parent(Product_Bill).[DonGiaBan]";
            dgvData.DataSource = dtExProduct;
        }

        void InitDataSet()
        {
            //DataColumn[] cols = new DataColumn[6]
            //{
            //    new DataColumn("MaPhieu", typeof(string)),
            //    new DataColumn("MaSP",typeof(string)),
            //    new DataColumn("SoLuong", typeof(int)),
            //    new DataColumn("ChietKhau", typeof(decimal)),
            //    new DataColumn("ThanhTien", typeof(decimal)),
            //    new DataColumn("GhiChu", typeof(string)),
            //}; /*("MaPhieu", typeof(string));*/
            //dtShow.Columns.AddRange(cols);
            try
            {
                DataGridViewComboBoxColumn dgvc = new DataGridViewComboBoxColumn();
                dgvc.DataPropertyName = "DVT";
                dgvc.DataSource = dtUnit;
                dgvc.ReadOnly = true;
                dgvc.HeaderText = "ĐVT";
                dgvc.DisplayMember = "TenDonVi";
                dgvc.ValueMember = "ID";
                dgvData.Columns.Insert(4, dgvc);
                CreateColumn(true);
                dr = dtBill.NewRow();
                List<Payment> payment = new List<Payment>()
                {
                    new Payment(0, "Chuyển khoản"),
                    new Payment(1, "Tiền mặt")
                };
                cbbPayment.DataSource = payment;
                cbbPayment.DisplayMember = "PaymentName";
                cbbPayment.ValueMember = "ID";
                cbbEmployeeName.DataSource = dtEmployee;
                cbbEmployeeName.DisplayMember = "TenNV";
                cbbEmployeeName.ValueMember = "MaNV";
                cbbEmployeeName.SelectedIndexChanged += cbbEmployeeName_SelectedIndexChanged;
            }
            catch (Exception e)
            {
                FormHandler.ShowErrorMessage(e.Message);
            }
            
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.HasReturned = true;
            DialogResult result = frm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                customer = frm.CustomerInfo;
                BindCustomer(customer);
            }

        }

        void BindCustomer(Customer customer)
        {
            txtCustomerName.Text = customer.CustomerName;
            rchAddress.Text = StringHandler.Or(billInfo.Address, customer.Address);
            txtPhone.Text = StringHandler.Or(billInfo.CusPhone, customer.Phone);
        }

        private void cbbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = -1;
            bool s = int.TryParse(cbbEmployeeName?.SelectedValue?.ToString(), out id);
            if(s)
            {
                if(id > -1)
                {
                    DataRow[] dr = dtEmployee.Select($"MaNV={id}");
                    if (dr.Length > 0)
                    {
                        Employee emp = Employee.ConvertToObj(dr[0]);
                        txtPhoneEmp.Text = emp.Phone;
                    }
                }
            }
            else
            {
                txtPhoneEmp.Text = "";
            }
        }

        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            frmGoods frm = new frmGoods();
            frm.HasReturned = true;
            DialogResult result = frm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                product = frm.ProductInfo;
                txtProductID.Text = product.GoodsID;
                lblProductName.Text = product.GoodsName;
                lblUnitPrice.Text = StringHandler.FormatForCurrency(product.PriceSell.ToString(), " VNĐ");
                rchRemark.Text = "";
                numQuantity.Enabled = true;
                numDiscount.Enabled = true;
                numQuantity.Value = 1;
                txtQuantity_TextChanged(null, null);
                btnAdd.Enabled = true;

            }
            else
            {
                //処理無し
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            numQuantity.Value = 0;
            numQuantity.ReadOnly = true;
            txtProductID.Text = "";
            lblProductName.Text = "";
            lblTotalPrice.Text = "0 VNĐ";
            lblUnitPrice.Text = "0 VNĐ";
            product = new Product();
            btnAdd.Enabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row;
            try
            {
                if(IsExistData(txtProductID.Text, out row))
                {
                    row["MaPhieu"] = bID;
                    row["SoLuong"] = numQuantity.Value+ int.Parse(row["SoLuong"].ToString());
                    row["ChietKhau"] = numDiscount.Value;
                    row["ThanhTien"] = TotalPriceCal(row);
                    row["GhiChu"] = rchRemark.Text;
                }
                else
                {
                    row = dtExProduct.NewRow();
                    row["MaPhieu"] = bID;
                    row["MaSP"] = product.GoodsID;
                    //row["TenSP"] = info.GoodsName;
                    //row["DVT"] = info.UnitID;
                    row["SoLuong"] = numQuantity.Value;
                    //row["DonGia"] = info.PriceSell;
                    row["ChietKhau"] = numDiscount.Value;
                    row["ThanhTien"] = TotalPriceCal();
                    row["GhiChu"] = rchRemark.Text;
                    dtExProduct.Rows.Add(row);
                }
            }
            catch(Exception ex)
            {
                FormHandler.ShowErrorMessage($"Có lỗi khi thêm sản phẩm.\n{ex.Message}");
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblProductName_Paint(object sender, PaintEventArgs e)
        {
            int w = grbProductName.Width;
            lblProductName.Location = new Point((w / 2) - lblProductName.Width / 2, lblProductName.Location.Y);
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (numQuantity.Value >=0)
            {
                lblTotalPrice.Text = StringHandler.FormatForCurrency(TotalPriceCal().ToString(), " VNĐ");
                //if (isDOK)
                //{
                    
                //}
                //else
                //{
                //    FormHandler.ShowErrorMessage("Số lượng nhập vào phải là số");
                //}
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numQuantity_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue > 47 && e.KeyValue < 58)
            {
                numQuantity_ValueChanged(null, null);
            }
        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            if (!AllowNewOrUpdateBill()) return;
            ResetInfo();
        }

        /// <summary>
        /// 
        /// </summary>
        void ResetInfo()
        {
            ResetProductInfo();
            ResetCusAndEmpInfo();
            grb1.Enabled = true;
            grb2.Enabled = true;
            billInfo = new Bill();
            bID = Guid.NewGuid().ToString();
            CreateColumn();
        }

        void ResetProductInfo()
        {
            product = new Product();
            txtProductID.Text = "";
            lblProductName.Text = "";
            numDiscount.Value = 0;
            numQuantity.Value = 0;
            lblUnitPrice.Text = "0 VNĐ";
            lblTotalPrice.Text = "0 VNĐ";
            btnAdd.Enabled = false;
        }

        void ResetCusAndEmpInfo()
        {
            employee = new Employee();
            customer = new Customer();
            txtCustomerName.Text = "";
            txtPhone.Text = "";
            txtPhoneEmp.Text = "";
            rchAddress.Text = "";
            dtpDeliDate.Value = DateTime.Now;
            cbbEmployeeName.SelectedIndex = 0;
        }

        private void btnSelectBill_Click(object sender, EventArgs e)
        {
            if (!AllowNewOrUpdateBill()) return;
            frmBill frm = new frmBill();
            frm.IsAllowReset = false;
            frm.HasReturned = true;
            DialogResult result = frm.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                billInfo = frm.BillInfo;
                bID = billInfo.BillID;
                employee = billInfo.Employee;
                customer = billInfo.Customer;
                BindCustomer(customer);
                cbbEmployeeName.SelectedValue = employee.ID;
                dtpDeliDate.Value = billInfo.DeliveryDate;
                cbbPayment.SelectedValue = billInfo.PaymentID;
                cbbPayment.SelectedValue = billInfo.PaymentID;
                cbbPayment.SelectedValue = billInfo.PaymentID;
                cbbPayment.SelectedValue = billInfo.PaymentID;
                txtPhoneEmp.Text = billInfo.EmpPhone;
                if(dgvData.Rows.Count> 0)
                {
                    dgvData.Rows[0].Selected = true;
                }
                grb1.Enabled = true;
                grb2.Enabled = true;
                GetProductList(bID);
            }
        }

        void GetProductList(string billID)
        {
            dtExProduct = BillDAL.Instance.GetDetailBillList(billID);
            if (dtExProduct != null)
            {
                CreateColumn();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOK2 = false;
            if(!btnAddBill_Click()) return;
            if (dtExProduct != null)
            {
                isOK2 = FormHandler.Save("ChiTietPhieuXuat", dtExProduct, false);
            }
            
            if (isOK2)
            {
                //InitLoad();
                //ResetInfo();
                
            }
            FormHandler.ShowInfoMessage("Dữ liệu đã được cập nhật");
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private bool btnAddBill_Click()
        {
            try
            {
                if (customer.CustomerID.Equals(0))
                {
                    FormHandler.ShowWarningMessage("Vui lòng chọn khách hàng", false);
                    return false;
                }
                if (cbbEmployeeName.SelectedValue.Equals(0) || cbbEmployeeName.SelectedIndex <1)
                {
                    FormHandler.ShowWarningMessage("Vui lòng chọn nhân viên giao hàng", false);
                    return false;
                }
                //DataRow dr = dtBill.NewRow();
                dr["ID"] = bID;
                dr["MaKH"] = customer.CustomerID;
                dr["MaNV"] = cbbEmployeeName.SelectedValue;
                dr["NgayGiao"] = dtpDeliDate.Value;
                dr["DiaChi"] = rchAddress.Text;
                dr["SDTKH"] = txtPhone.Text;
                dr["SDTNV"] = txtPhoneEmp.Text;
                dr["HinhThucThanhToan"] = cbbPayment.SelectedValue;
                bool isOK = BillDAL.Instance.UpdateBill(dr);
                //DataProvider.Insta1nce.UpdateData("PhieuXuat", dtBill, "*");
                //FormHandler.ShowInfoMessage("Phiếu đã được lập, bạn có thể thêm sản phẩm vào phiếu");
                //grb2.Enabled = true;
                //grb1.Enabled = false;
                return isOK;
            }
            catch (Exception ex)
            {
                FormHandler.ShowErrorMessage(ex.Message);
            }
            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = FormHandler.ShowWarningMessage("", true);
            if(result == DialogResult.OK)
            {
                dtExProduct.RejectChanges();
                FormHandler.ShowInfoMessage("Dữ liệu đã được khôi phục gốc");
            }
            else
            {
                //処理なし
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pID"></param>
        /// <param name="dr"></param>
        /// <returns></returns>
        bool IsExistData(string pID, out DataRow dr)
        {
            dr = null;
            DataRow [] drs = dtExProduct.Select($"MaSP='{pID}'");
            if (drs.Length > 0)
            {
                dr = drs[0];
                return true;
            }
            return false;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                DataRow dr = dtExProduct.Rows[e.RowIndex];
                //product = Product.ConvertToObj(dr);
                product = new Product()
                {
                    GoodsID = dr["MaSP"].ToString(),
                    GoodsName = dr["TenSP"].ToString(),
                    PriceSell = decimal.Parse(dr["DonGia"].ToString()),
                };
                BindProduct(dr);
                numQuantity.Enabled = true;
                numDiscount.Enabled = true;
                btnAdd.Enabled = true;
               //grb2.Enabled = true;
            }
        }

        void BindProduct(DataRow dr)
        {
            txtProductID.Text = product.GoodsID;
            lblProductName.Text = product.GoodsName;
            lblUnitPrice.Text = StringHandler.FormatForCurrency(product.PriceSell.ToString(), "VNĐ");
            lblTotalPrice.Text = StringHandler.FormatForCurrency(dr["ThanhTien"].ToString(), "VNĐ");
            numQuantity.Value = decimal.Parse(dr["SoLuong"].ToString());
            numDiscount.Value = decimal.Parse(dr["ChietKhau"].ToString());
            rchRemark.Text = dr["GhiChu"].ToString();
        }

        private void btnCusAndEmpReset_Click(object sender, EventArgs e)
        {
            BindCustomer(customer);
            cbbEmployeeName.SelectedValue = employee.ID;
            cbbPayment.SelectedValue = billInfo.PaymentID;
            txtPhoneEmp.Text = billInfo.EmpPhone;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();
            //ds.Tables.AddRange(new DataTable[] { dtExProduct, dtBill});
            frmReportViewer frm = new frmReportViewer("",ds);

        }

        //bool AllowNewOrUpdateBill()
        //{
        //    if (customer != null)
        //    {
        //        if (customer.CustomerID != 0)
        //        {
        //            DialogResult res = FormHandler.ShowQuestionMessage("Dữ liệu đang được nhập, bạn có chắc chắn muốn huỷ bỏ?");
        //            if (res == DialogResult.No)
        //            {
        //                return false;
        //            }
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        bool AllowNewOrUpdateBill()
        {
            if (FormHandler.HasChanged(dtBill) || FormHandler.HasChanged(dtExProduct))
            {
                DialogResult result = FormHandler.ShowQuestionMessage("Dữ liệu đang thay đổi, bạn có muốn lưu lại không?");

                if (result == DialogResult.Yes)
                {
                    btnSave_Click(null, null);
                }
                else
                {
                    dtExProduct.RejectChanges();
                    dtBill.RejectChanges();
                }
                return true;
            }
            else
            {
                dr = dr is null ? dtBill.NewRow() : dr;
                return true;
            }
        }

        decimal TotalPriceCal()
        {
            decimal qty = numQuantity.Value;
            decimal discount = numDiscount.Value;
            decimal pSell = product.PriceSell;
            return (qty * pSell * (100 - discount)) / 100;
        }

        decimal TotalPriceCal(DataRow dr)
        {
            decimal qty = decimal.Parse(dr["SoLuong"].ToString());
            decimal discount = decimal.Parse(dr["ChietKhau"].ToString());
            decimal pSell = product.PriceSell;
            return (qty * pSell * (100 - discount)) / 100;
        }
    }
}
