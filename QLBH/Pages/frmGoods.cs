using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QLBH.Pages
{
    public partial class frmGoods : Form
    {
        public frmGoods()
        {
            InitializeComponent();
        }

        private void toolBars1_FClick(object sender, Resources.CustomEvent e)
        {
            MessageBox.Show(e.Key.ToString());
        }

        private void frmGoods_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("aaaa");
            //DataTable dt = GoodsBUS.GetData(); 
            dgvData.DataSource = GoodsBUS.GetData();
            
            
        }
    }
}
