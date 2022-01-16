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

namespace QLBH.Pages.Cooperation
{
    public partial class frmSupplier : Form
    {
        DataTable dtFull, dtShow;
        public frmSupplier()
        {
            InitializeComponent();
            InitLoad();
        }

        void InitLoad()
        {
            try
            {
                dtFull = SupplierDAL.Instance.GetSupplierList();

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
