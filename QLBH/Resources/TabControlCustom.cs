using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Resources
{
    public partial class TabControlCustom : UserControl
    {
        List<Panel> panls = new List<Panel>();
        List<Button> btns = new List<Button>();
        public TabControlCustom()
        {
            InitializeComponent();
            panls.Clear();
            btns.Clear();
            DrawTabButton();
        }

        public void AddControl(Form frm, string title)
        {
            Panel pn = new Panel();
            pn.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            pn.Controls.Add(frm);
            panel1.Controls.Add(pn);
            panls.Add(pn);
        }

        private void DrawTabButton()
        {
            
        }

        private void DrawTabPage()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
