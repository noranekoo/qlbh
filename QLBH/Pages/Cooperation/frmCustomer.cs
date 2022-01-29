using DAL;
using DTO;
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
    public partial class frmCustomer : FormCustom
    {
        DataTable dtShow, dtFull;
        public Customer CustomerInfo { get; set; }
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

        private void btnSelect_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (!dgvData.Rows[dgvData.RowSelectedIndex].IsNewRow 
            //        && dgvData.RowSelectedIndex < dtShow.Rows.Count
            //        && dgvData.RowSelectedIndex > -1
            //        )
            //    {
            //        if(!string.IsNullOrEmpty(dgvData[1,dgvData.RowSelectedIndex].Value.ToString()))
            //        {
            //            DataRow dr = dtShow.Rows[dgvData.RowSelectedIndex];
            //            CustomerInfo = Customer.ConvertToObj(dr);
            //            DialogResult = DialogResult.OK;
            //        }
            //        else
            //        {
            //            MessageBox.Show("Khách hàng chưa tồn tại trong dữ liệu.\nVui lòng nhấn nút LƯU.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            object dr = null;

            bool isOK = FormHandler.SelectRow(dgvData, dtShow, out dr);
            if (isOK)
            {
                CustomerInfo = Customer.ConvertToObj((DataRow)dr);
                DialogResult = DialogResult.OK;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if(dtShow.GetChanges().Rows.Count> 0)
                {
                    DataProvider.Instance.UpdateData("KhachHang", dtShow, "*");
                    MessageBox.Show("Dữ liệu đã được lưu", "Thông báo");
                    dtFull = CustomerDAL.Instance.GetCustomerList();
                    InitLoad();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtShow.Rows.Clear();
            StringBuilder query = new StringBuilder("");
            string str = txtName.Text.Trim();
            if (!string.IsNullOrEmpty(str))
            {
                query.Append($"TenKH LIKE '%{str}%'");
                query.Append($" OR DiaChi LIKE '%{str}%'");
                query.Append($" OR SDT LIKE '%{str}%'");
                query.Append($" OR Email LIKE '%{str}%'");
                DataRow[] drs = dtFull.Select(query.ToString());
                if(drs.Length > 0)
                {
                    foreach(DataRow dr in drs)
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

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, null);
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (HasReturned)
            {
                btnSelect_Click(null, null);
            }
        }

        /// <summary>
        /// 
        /// </summary>
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
