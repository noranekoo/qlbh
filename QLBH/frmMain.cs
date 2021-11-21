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

namespace QLBH
{
    public partial class frmMain : Form
    {
        Dictionary<string, Image> images = new Dictionary<string, Image>()
        {
            //{"logout_unclick", Image.FromFile("images\\logout_unclick.png") },
            //{"logout_clicked", Image.FromFile("images\\logout_clicked.png") },
        };
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormHandler.ShowMessage();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            lblFullName.Text = FormHandler.UserInfo.FullName;
        }

        private void btnLogout_MouseEnter(object sender, EventArgs e)
        {
            ///FormHandler.ControlImageChange(btnLogout, images["logout_clicked"]);
        }

        private void btnLogout_MouseLeave(object sender, EventArgs e)
        {
            //FormHandler.ControlImageChange(btnLogout, images["logout_unclick"]);
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }
    }
}
