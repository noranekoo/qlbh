using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DTO;

namespace QLBH.Resources
{
    public partial class EmployeeDetail : UserControl
    {
        private Employee _employeeInfo;
        public Employee EmployeeInfo
        {
            get => _employeeInfo;
            set
            {
                _employeeInfo = value;
                lblFullName.Text = _employeeInfo.FullName;
                lblJobDate.Text = _employeeInfo.JobDate.ToString("dd/MM/yyyy");
                picAvatar.Image = _employeeInfo.Avatar;
            }
        }
        private event EventHandler _detailClick;
        private event EventHandler _updateClick;

        public event EventHandler DetailClick
        {
            add
            {
                _detailClick += value;
            }
            remove
            {
                _detailClick -= value;
            }
        }
        public event EventHandler UpdateClick
        {
            add
            {
                _updateClick += value;
            }
            remove
            {
                _updateClick -= value;
            }
        }

        public EmployeeDetail()
        {
            InitializeComponent();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            _detailClick(this, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _updateClick(this, e);
        }
    }
}
