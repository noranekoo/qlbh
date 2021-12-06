using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            lblYear.Text = DateTime.Now.Year.ToString();
        }

        private void lklEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start($"mailto:{lklEmail.Text}");
        }
    }
}
