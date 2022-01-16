using QLBH.Pages.Celebration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Pages
{
    public partial class frmCelebration : Form
    {
        public frmCelebration()
        {
            InitializeComponent();
            //reportDocument1.
            //DoubleBuffered = true;
            //SetStyle(ControlStyles.ResizeRedraw, false);
            SetTabContent();
        }

        void SetTabContent()
        {
            frmEmployee frmEmp = new frmEmployee();
            frmEmp.TopLevel = false;
            frmEmp.Dock = DockStyle.Fill;
            frmEmp.Show();
            tbpEmployee.Controls.Add(frmEmp);
        }
    }
}
