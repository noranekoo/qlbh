using System;
using System.Windows.Forms;
using QLBH.Resources;

namespace QLBH
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtRNewPassword.Clear();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pwd = FormHandler.UserInfo.Info.Password;
            if (pwd.Equals(txtOldPassword.Text))
            {

                return;
            }
            if (!txtNewPassword.Text.Equals(txtRNewPassword.Text))
            {
                MessageBox.Show(Const.GetMessageByCode("SET01"));
            }
        }
    }
}
