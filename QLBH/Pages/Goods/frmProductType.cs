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

namespace QLBH.Pages.Goods
{
    public partial class frmProductType : Form
    {

        DataTable dtShow, dtFull;
        public frmProductType()
        {
            InitializeComponent();
            InitLoad();
            dgvData.RowPrePaint += FormHandler.RowPrepaintHandler;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isOK = FormHandler.Save("NhomHang", dtShow);
            if (isOK) InitLoad();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = FormHandler.ShowWarningMessage("Bạn có muốn khôi phục lại dữ liệu ban đầu?", true);
            if(result == DialogResult.OK)
            {
                dtShow.RejectChanges();
            }
        }

        void InitLoad()
        {
            try
            {
                dtFull = GoodsTypeDAL.Instance.GetGoodsTypeList();
                if (dtFull != null)
                {
                    dtShow = dtFull.Copy();
                    dgvData.DataSource = dtShow;
                }
            }
            catch (Exception e)
            {
                FormHandler.ShowErrorMessage(e.Message);
            }
        }
    }
}
