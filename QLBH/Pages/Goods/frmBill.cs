using DAL;
using DTO;
using QLBH.Resources;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLBH.Pages.Goods
{
    public partial class frmBill : FormCustom
    {
        DataTable dtFull, dtShow;
        DataTable dtCustomer, dtEmp;
        public Bill BillInfo { get; set; }
        public frmBill()
        {
            HasReturned = true;
            InitializeComponent();
            InitLoad();
            InitDataSet();
            dgvData.RowPrePaint += FormHandler.RowPrepaintHandler;
        }

        void InitLoad()
        {
            try
            {
                dtCustomer = CustomerDAL.Instance.GetCustomerList();
                dtEmp = EmployeeDAL.Instance.GetEmployeeList();
                dtFull = BillDAL.Instance.GetBillList();

                if(dtFull != null)
                {
                    dtShow = dtFull.Copy();
                    dgvData.DataSource = dtShow;
                    
                }
            }
            catch (Exception e)
            {
                FormHandler.ShowErrorMessage(e.Message);
            }
        }

        void InitDataSet()
        {
            DataColumn[] cols = new DataColumn[2]
            {
                new DataColumn("TenKH"),
                new DataColumn("TenNV"),
            };
            try
            {
                dtShow.Columns.AddRange(cols);

                DataSet ds = new DataSet();
                ds.Tables.AddRange(new DataTable[] { dtShow, dtCustomer, dtEmp });

                DataRelation rlCus = new DataRelation("Cus_Bill", dtCustomer.Columns["ID"], dtShow.Columns["MaKH"]);
                DataRelation rlEmp = new DataRelation("Emp_Bill", dtEmp.Columns["MaNV"], dtShow.Columns["MaNV"]);
                ds.Relations.AddRange(new DataRelation[] { rlCus, rlEmp });

                ds.Tables["Table1"].Columns["TenKH"].Expression = "Parent(Cus_Bill).[TenKH]";
                ds.Tables["Table1"].Columns["TenNV"].Expression = "Parent(Emp_Bill).[TenNV]";
            }
            catch (Exception e)
            {
                FormHandler.ShowErrorMessage("Có lỗi trong khi lấy dữ liệu.\n"+e.Message);
            }
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            object dr;
            bool isOK = FormHandler.SelectRow(dgvData, dtShow, out dr);
            if (isOK)
            {
                DataRow obj = (DataRow)dr;
                Employee emp = Employee.ConvertToObj(dtEmp.Select($"MaNV={obj["MaNV"]}")[0]);
                Customer cus = Customer.ConvertToObj(dtCustomer.Select($"ID={obj["MaKH"]}")[0]);
                BillInfo = new Bill()
                {
                    BillID = obj["ID"].ToString(),
                    Employee = emp,
                    Customer = cus,
                    DeliveryDate = DateTime.Parse(obj["NgayGiao"].ToString()),
                    Address = obj["DiaChi"].ToString(),
                    CusPhone = obj["SDTKH"].ToString(),
                    EmpPhone = obj["SDTNV"].ToString(),
                    PaymentID = int.Parse(obj["HinhThucThanhToan"].ToString()),
                };
                DialogResult = DialogResult.OK;
            }
            else
            {
                //処理無し

                //FormHandler.ShowErrorMessage("")
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelect_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FormHandler.Save("PhieuXuat", dtShow);
        }
    }
}
