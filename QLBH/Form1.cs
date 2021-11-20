using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using ATcrypto;
using System.Text;
using System.Security.Cryptography;
using BUS;
using DTO;
namespace QLBH
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User(this.txtUser.Text, this.txtPass.Text);
            if (UserBUS.IsExistUser(user))
            {
                MessageBox.Show("Dăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
