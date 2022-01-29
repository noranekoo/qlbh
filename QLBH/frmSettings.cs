using System;
using System.Windows.Forms;
using DAL;
using DTO;
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
            txtOldPassword.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pwd = FormHandler.UserInfo.Info.Password;
            if (!pwd.Equals(txtOldPassword.Text))
            {
                MessageBox.
                    Show("Mật khẩu cũ không đúng");
            }
            else
            {
                if (!txtRNewPassword.Text.Equals(txtNewPassword.Text))
                {
                    MessageBox.Show("Mật khẩu xác nhận khớp với mật khẩu cũ");
                }
                else
                {
                    UserInfo info = UserDAL.Instance.ChangePassword(FormHandler.UserInfo, txtNewPassword.Text);
                    if(info != null)
                    {
                        FormHandler.UserInfo = info;
                        MessageBox.Show("Mật khẩu đã được thay đổi!");
                    }
                    else
                    {
                        MessageBox.Show("Đổi mật khẩu thất bại.");
                    }
                }
            }
        }
    }
}
