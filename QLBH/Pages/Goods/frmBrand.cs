using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;
using static QLBH.Resources.FormHandler;
using Const = QLBH.Resources.Const;
namespace QLBH.Pages.Goods
{
    public partial class frmBrand : Form
    {
        DataTable dtFull = null;
        DataTable dtShow = null;
        ModeControl mode = ModeControl.NONE;
        int currentRow = 0;
        DataRow dr = null;
        public frmBrand()
        {
            InitializeComponent();
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
            GetData();
            dgvData.CellValueChanged += DgvData_CellValueChanged;
            dgvData.RowValidated
                += DgvData_RowValidated;
            dgvData.RowPrePaint += DgvData_RowPrePaint;
            //dgvData.RowStateChanged += DgvData_RowStateChanged;
            //dgvData.RowValidating += DgvData_RowValidating;
            dgvData.CellValidating += DgvData_CellValidating;
            dgvData.EditingControlShowing += DgvData_EditingControlShowing;
            //dgvData.CellBeginEdit+=
            dgvData.CellClick += DgvData_CellClick;
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
            //if(currentRow < dgvData.Rows.Count - 1)
            //{
            //    MessageBox.Show(dtShow.Rows[currentRow]["MaHang"].ToString());
            //}
            
        }

        private void DgvData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int id = string.IsNullOrEmpty(dgvData.Rows[e.RowIndex].Cells[1].Value.ToString()) ? 0 : int.Parse(dgvData.Rows[e.RowIndex].Cells[1].Value.ToString());
            string name = e.FormattedValue.ToString();
            //if (string.IsNullOrEmpty(name))
            //{
            //    MessageBox.Show("Dữ liệu không được để rỗng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    e.Cancel = true;
            //    return;
            //}
        }

        private void DgvData_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            
        }

        private void DgvData_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //e.CellStyle.BackColor = Color.Black;
        }

        private void DgvData_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //e.StateChanged == DataGridViewElementStates.
        }

        private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!dgvData.Rows[e.RowIndex].IsNewRow)
            {
                dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            }
            ChangeColor();
        }
            

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Search(name);
            dgvData.DataSource = dtShow;
        }
        
        void Search(string name)
        {
            dtShow.Rows.Clear();
            //dtShow.Rows.Add(dtFull.Rows[0]);
            if (string.IsNullOrEmpty(name)) { dtShow = dtFull.Copy(); }
            else
            {
                foreach (DataRow dr in dtFull.Rows)
                {
                    if (dr["TenHang"].ToString().ToLower().Contains(name.ToLower()))
                    {
                        dtShow.Rows.Add(dr.ItemArray);
                    }
                }
            }
            dtShow.AcceptChanges();
        }

        void GetData()
        {
            try
            {
                dtFull = BrandDAL.GetBrandList();
                if (dtFull != null)
                {
                    dtShow = dtFull.Copy();
                    dgvData.DataSource = dtShow;
                    DataGridViewTextBoxColumn dgvtb = new DataGridViewTextBoxColumn();
                    dgvtb.HeaderText = "STT";
                    dgvtb.Name = "STT";
                    dgvtb.Width = 30;
                    dgvtb.ReadOnly = true;
                    dgvData.Columns.Insert(0, dgvtb);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolBars_FClick(object sender, Resources.CustomEvent e)
        {
            switch (e.Key)
            {
                case 1:
                    mode = ModeControl.ADD;
                    break;
                case 2:
                    mode = ModeControl.EDIT;
                    break;
                case 3:
                    mode = ModeControl.DELETE;
                    break;
                default:
                    break;
            }
            //SetControlState(toolBars, mode);
        }

        private void DgvData_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            ChangeColor();
        }

        
        private void DgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                //dgvData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                //dgvData.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
            }
            
        }

        void ChangeColor()
        {
            int index = 0;
            foreach(DataRow dr in dtShow.Rows)
            {
                switch (dr.RowState)
                {
                    case DataRowState.Added:
                        dgvData.Rows[index].DefaultCellStyle.BackColor = Color.Green;
                        dgvData.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                        break;
                    case DataRowState.Modified:
                        dgvData.Rows[index].DefaultCellStyle.BackColor = Color.Blue;
                        dgvData.Rows[index].DefaultCellStyle.ForeColor = Color.White;
                        break;
                    default:
                        dgvData.Rows[index].DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Window);
                        dgvData.Rows[index].DefaultCellStyle.ForeColor = Color.Black;
                        break;
                }
                index++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                BrandDAL.UpdateData("Hang", dtShow);
                MessageBox.Show("Cập nhật dữ liệu thành công");
                dtFull = BrandDAL.GetBrandList();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvData_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = dgvData.CurrentCell.RowIndex;
            if(row > -1)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult.Yes.Equals(result))
                {
                    dtShow.Rows[row].Delete();
                }
            }
        }

        private void dgvData_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("RESET sẽ huỷ bỏ tất cả thay đổi đối với dữ liệu. Bạn có chắc chắn chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes.Equals(result))
            {
                dtShow.RejectChanges();
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            
            if (currentRow > -1 && currentRow < dgvData.Rows.Count - 1)
            {
                if (
                    dtShow.Rows[currentRow].RowState != DataRowState.Unchanged
                    )
                {
                    DialogResult result = MessageBox.Show("Dữ liệu này chưa tồn tại. Bạn có muốn cập nhật dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        btnSave_Click(sender, e);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        DialogResult = DialogResult.Cancel;
                    }
                }
            }

        }

        //bool CheckDataExist(int id, string name)
        //{
        //    foreach(DataRow dr in dtFull.Rows)
        //    {
        //        string names = dr["TenHang"].ToString();
        //        if (!(dr.RowState == DataRowState.Added))
        //        {
        //            int ids = int.Parse(dr["MaHang"].ToString());
        //            if (names.Equals(name) && ids != id)
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    DataTable tmp = dtShow.GetChanges(DataRowState.Added);
        //    if(tmp != null)
        //    {
        //        foreach (DataRow dr in tmp.Rows)
        //        {
        //            string names = dr["TenHang"].ToString();
        //            if (names.Equals(name))
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    return false;
        //}

    }
}
