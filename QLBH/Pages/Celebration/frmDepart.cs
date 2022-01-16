using DAL;
using DAL.Celebration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Resources;

namespace QLBH.Pages.Celebration
{
    /// <summary>
    /// 部分フォームのクラス
    /// 2021/12/25
    /// テイ
    /// </summary>
    public partial class frmDepart : Form
    {
        DataTable dtFull, dtShow;
        public frmDepart()
        {
            InitializeComponent();
            dgvData.RowPrePaint += DgvData_RowPrePaint;
            //dgvData.RowValidated += DgvData_RowValidated;
            InitLoad();
        }

        /// <summary>
        ///　グリッドのRowPrePaintにエベント処理
        ///　2021/12/25
        ///　テイ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!dgvData.Rows[e.RowIndex].IsNewRow)
            {
                dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvData_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            //rowIsValid = true;
        }

        /// <summary>
        /// セーフボタンにクリック処理
        /// 2021/12/25
        /// テイ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider.Instance.UpdateData("BoPhan", dtShow, "*");
                dtFull = DepartDAL.Instance.GetDepartList();
                MessageBox.Show("Cập nhật dữ liệu thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// リセットボタンにクリック処理
        /// 2021/12/25
        /// テイ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("RESET sẽ huỷ bỏ tất cả thay đổi đối với dữ liệu. Bạn có chắc chắn chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes.Equals(result))
            {
                //データ変更されたことを拒絶する
                dtShow.RejectChanges();
            }

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// 検索ボタンにクリック処理
        /// 2021/12/25
        /// テイ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtShow.Rows.Clear();
            StringBuilder filterStr = new StringBuilder("1=1");
            string dpName = txtName.Text;
            if (!string.IsNullOrEmpty(dpName))
            {
                filterStr.Append($" AND TenBoPhan LIKE '%{dpName}%'");
            }
            //検索情報が無い場合、dtFullのデータを取る
            if (filterStr.ToString().Equals("1=1")) { dtShow = dtFull.Copy(); }

            else　//検索情報によると、検索処理
            {
                DataRow[] drs = dtFull.Select(filterStr.ToString());
                foreach (DataRow dr in drs)
                {
                    dtShow.Rows.Add(dr.ItemArray);
                }

                dtShow.AcceptChanges();
            }
            dgvData.DataSource = dtShow;
        }
       
        void InitLoad()
        {
            try
            {
                dtFull = DepartDAL.Instance.GetDepartList();
                if(dtFull != null)
                {
                    if(dtFull.Rows.Count > 0)
                    {
                        dtShow = dtFull.Copy();
                        dgvData.DataSource = dtShow;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
    }
}
