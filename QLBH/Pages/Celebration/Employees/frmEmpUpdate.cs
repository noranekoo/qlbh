using DAL;
using DAL.Celebration;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Pages.Celebration.Employees
{
    public partial class frmEmpUpdate : Form
    {
        /// <summary>
        /// EmployeeInfo
        /// </summary>
        private Employee _employeeInfo = null;
        /// <summary>
        /// dtShow
        /// </summary>
        private DataTable _dt = null;
        /// <summary>
        /// Row of data
        /// </summary>
        private DataRow dr;


        public frmEmpUpdate(Employee info, DataTable dt)
        {
            InitializeComponent();
            _employeeInfo = info;
            _dt = dt;
            if(_dt != null)
            {
                if(info != null)
                {
                    dr = _dt.Select($"MaNV={info.ID}")[0];
                }
                else
                {
                    _employeeInfo = new Employee();
                    dr = _dt.NewRow();
                }
            }
            cbbDepart.DataSource = DepartDAL.Instance.GetDepartList();
            cbbDepart.DisplayMember = "TenBoPhan";
            cbbDepart.ValueMember = "ID";
            BindData();
            Text = info == null ? "Thêm thông tin" :"Cập nhật thông tin";
        }


        /// <summary>
        /// データビンディングをセット処理
        /// </summary>
        void BindData()
        {
            txtFullName.DataBindings.Add(new Binding("Text", _employeeInfo, "FullName"));
            txtEmail.DataBindings.Add(new Binding("Text", _employeeInfo, "Email"));
            txtPhone.DataBindings.Add(new Binding("Text", _employeeInfo, "Phone"));
            txtIDNumber.DataBindings.Add(new Binding("Text", _employeeInfo, "IDNumber"));
            richAddress.DataBindings.Add(new Binding("Text", _employeeInfo, "Address"));
            dtpBirthday.DataBindings.Add(new Binding("Value", _employeeInfo, "Birthday"));
            dtpJobDate.DataBindings.Add(new Binding("Value", _employeeInfo, "JobDate"));
            if(_employeeInfo.Avatar != null)
            {
                picAvatar.DataBindings.Add(new Binding("Image", _employeeInfo, "Avatar"));
            }
            cbbDepart.DataBindings.Add(new Binding("SelectedValue", _employeeInfo, "DepartID"));
        }
        /// <summary>
        /// 
        /// </summary>
        void UpdateData()
        {
            bool isSucess = SetData();
            if(isSucess)
            {
                DataProvider.Instance.UpdateData("NhanVien", _dt, "*");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool SetData()
        {
            Employee.ConvertToDataRow(_employeeInfo, ref dr);
            if (_employeeInfo.ID.Equals(0))
            {
                _dt.Rows.Add(dr);
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateData();
            MessageBox.Show("Cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;
            //MessageBox.Show(cbbDepart.SelectedValue.ToString());

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult
                 = DialogResult.Cancel;
        }

        private void frmEmpUpdate_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images|*.png;*.jpg";
            DialogResult result = dlg.ShowDialog();
            if(result == DialogResult.OK)
            {
                _employeeInfo.AvatarLink = dlg.FileName;
                picAvatar.Image = Employee.GetAvatar(_employeeInfo.AvatarLink);
            }
        }

        private void cbbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá người này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                if (EmployeeDAL.Instance.Delete(_employeeInfo) != -1)
                {
                    MessageBox.Show("Nhân viên này đã bị xoá!");
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thực hiện thao tác");
                }
                DialogResult = DialogResult.No;
            }
            
        }
    }
}
