using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using BUS;
using DTO;
using QLBH.Resources;
using DAL;

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

        public bool IsCheckSession { get; set; } = true;
        
        public frmLogin()
        {
            FormHandler.frmLogin = this;
            _user = $"{SystemInformation.UserDomainName}\\{SystemInformation.UserName}";
            
            
            InitializeComponent();
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
                    FormHandler.UserInfo = UserBUS.GetUser(user);
                    FormHandler.UserInfo.FullName = !string.IsNullOrEmpty(FormHandler.UserInfo.FullName) ? FormHandler.UserInfo.FullName : SystemInformation.UserName;
                    frmMain main = new frmMain();
                    main.Show();
                    txtPassword.Clear();
                    //Bắt đầu 2021_12_15 - Xử lý khi chọn Lưu đăng nhập - Thi
                    if (ckbSaveSession.Checked)
                    {
                        int result = UserDAL.Instance.SaveSession(user, false);
                        if(result == -1)
                        {
                            MessageBox.Show("Có lỗi khi lưu lại phiên đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    //Kết thúc 2021_12_15 - Thi
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

        bool CheckSession()
        {
            try
            {
                return UserDAL.Instance.GetSession(_user);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
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

        private void ckbSaveSession_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            if (CheckSession() && IsCheckSession)
            {
                Hide();
                FormHandler.UserInfo = UserDAL.Instance.GetUser(_user);
                FormHandler.UserInfo.FullName = !string.IsNullOrEmpty(FormHandler.UserInfo.FullName) ? FormHandler.UserInfo.FullName : SystemInformation.UserName;
                frmMain frm = new frmMain();
                frm.Show(this);
            }
            else
            {


                //FormHandler.UserInfo = null;
            }
        }
    }
}
