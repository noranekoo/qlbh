using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using BUS;
using DTO;
using QLBH.Resources;

namespace QLBH
{
    public partial class frmLogin : Form
    {
        string _user = "";
        Dictionary<string, Image> images = new Dictionary<string, Image>() 
        {
            {"next_unclick",Image.FromFile("images\\login_unclick.png") },
            {"next_clicked",Image.FromFile("images\\login_clicked.png") }
        };
        public frmLogin()
        {
            InitializeComponent();
            _user = $"{SystemInformation.UserDomainName}\\{SystemInformation.UserName}";
            lblUser.Text = _user;
        }

        private void lblUser_MouseHover(object sender, EventArgs e)
        {

        }

        private void lblUser_Paint(object sender, PaintEventArgs e)
        {
            Point pt = new Point(grbContainer.Width/2-lblUser.Width/2, lblUser.Location.Y);
            lblUser.Location = pt;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(_user, txtPassword.Text);
            try
            {
                if (UserBUS.IsExistUser(user))
                {
                    Hide();
                    FormHandler.UserInfo = new UserInfo()
                    {
                        Info = user,
                        FullName = SystemInformation.UserName
                    };
                    frmMain main = new frmMain();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng. Vui lòng nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = images["next_clicked"];
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = images["next_unclick"];
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                btnLogin_Click(sender, e);
            }
            
        }
    }
}
