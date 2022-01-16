using DAL;
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

namespace QLBH.Pages.Cooperation
{
    public partial class frmCustomer : Form
    {
        DataTable dtShow, dtFull;
        public frmCustomer()
        {
            InitializeComponent();
            InitLoad();
            dgvData.RowPrePaint += DgvData_RowPrePaint;
        }

        private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!dgvData.Rows[e.RowIndex].IsNewRow)
            {
                dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            }
        }

        void InitLoad()
        {
            try
            {
                dtFull = CustomerDAL.Instance.GetCustomerList();
                if(dtFull != null)
                {
                    dtShow = dtFull.Copy();
                    dgvData.DataSource = dtShow;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
