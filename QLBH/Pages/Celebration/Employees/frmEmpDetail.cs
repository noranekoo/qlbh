using DAL.Celebration;
using DTO;
using System;
using System.Windows.Forms;

namespace QLBH.Pages.Celebration.Employees
{
    public partial class frmEmpDetail : Form
    {
        private Employee _employeeInfo;
        public frmEmpDetail(Employee info)
        {
            InitializeComponent();
            _employeeInfo = info;
            _employeeInfo.DepartName = DepartDAL.Instance
                .GetDepartList()
                .Select($"ID={_employeeInfo.DepartID}")[0]["TenBoPhan"]
                .ToString();
        }

        private void frmEmpDetail_Load(object sender, EventArgs e)
        {
            lblFullName.Text = _employeeInfo.FullName;
            lblBirthday.Text = _employeeInfo.Birthday.ToString("dd/MM/yyyy");
            richAddress.Text = _employeeInfo.Address;
            lblIDNumber.Text = _employeeInfo.IDNumber;
            lblPhone.Text = _employeeInfo.Phone;
            lblEmail.Text = _employeeInfo.Email;
            lblDepart.Text = _employeeInfo.DepartName;
            picAvatar.Image = _employeeInfo.Avatar;
        }

        
    }
}
