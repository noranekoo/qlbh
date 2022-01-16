using DAL;
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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn[] dc = new DataColumn[5]
            {
                new DataColumn("Cot1", typeof(string)),
                new DataColumn("Cot2",typeof(int)),
                new DataColumn("Cot3", typeof(int)),
                new DataColumn("Cot4", typeof(string)),
                new DataColumn("Cot5",typeof(string)),
            };
            dt = DataProvider.Instance.SelectData("PhieuXuat", new System.Data.OleDb.OleDbParameter[0], "*");
            //Dataset2 ds = new Dataset2();
            
            frmReportViewer viewer = new frmReportViewer("PhieuXuat.rpt", dt);

            viewer.Show();
        }
    }
}
