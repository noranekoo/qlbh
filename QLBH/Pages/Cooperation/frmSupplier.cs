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
    public partial class frmSupplier : FormCustom
    {
        DataTable dtFull, dtShow;
        public frmSupplier()
        {
            InitializeComponent();
            InitLoad();
            dgvData.RowPrePaint += FormHandler.RowPrepaintHandler;
        }

        //private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        //{
        //    //FormHandler.NumberOrderial(ref dgvData, e.RowIndex);
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtShow.Rows.Clear();
            StringBuilder query = new StringBuilder("");
            string str = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(str))
            {
                query.Append($"TenNCC LIKE '%{str}%'");
                query.Append($" OR DiaChi LIKE '%{str}%'");
                query.Append($" OR SDT LIKE '%{str}%'");
                query.Append($" OR Email LIKE '%{str}%'");
                DataRow[] drs = dtFull.Select(query.ToString());
                if (drs.Length > 0)
                {
                    foreach (DataRow dr in drs)
                    {
                        dtShow.Rows.Add(dr.ItemArray);
                    }
                }
            }
            else
            {
                dtShow = dtFull.Copy();
            }
            dtShow.AcceptChanges();
            dgvData.DataSource = dtShow;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtShow.GetChanges().Rows.Count > 0)
                {
                    DataProvider.Instance.UpdateData("NhaCungCap", dtShow, "*");
                    MessageBox.Show("Dữ liệu đã được lưu", "Thông báo");
                    dtFull = SupplierDAL.Instance.GetSupplierList();
                    InitLoad();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(null, null);
            }
            
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

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
