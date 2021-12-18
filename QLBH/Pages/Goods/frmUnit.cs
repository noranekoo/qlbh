using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
namespace QLBH.Pages.Goods
{
    public partial class frmUnit : Form
    {

        DataTable dtFull = null;
        DataTable dtShow = null;
        int currentRow = -1;
        public frmUnit()
        {
            InitializeComponent();
            Init();
            LoadData();
            dgvData.CellClick += DgvData_CellClick;
            dgvData.RowPrePaint += DgvData_RowPrePaint;
        }

        private void DgvData_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (!dgvData.Rows[e.RowIndex].IsNewRow)
            {
                dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex+ 1;
            }
            ChangeColor();
        }

        void Init()
        {
            DataGridViewTextBoxColumn dgvtb = new DataGridViewTextBoxColumn();
            dgvtb.Name = "Number";
            dgvtb.HeaderText = "STT";
            dgvtb.Width = 30;
            dgvData.Columns.Insert(0,dgvtb);
        }

        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
        }

        void LoadData()
        {
            try
            {
                dtFull = UnitDAL.Instance.GetUnitList();
                if(dtFull != null)
                {
                    dtShow = dtFull.Copy();
                    dgvData.DataSource = dtShow;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
                    DialogResult result = MessageBox.Show("Dữ liệu này chưa tồn tại hoặc đã bị thay đổi. Bạn có muốn cập nhật dữ liệu này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        void Search(string name)
        {
            dtShow.Rows.Clear();
            if (string.IsNullOrEmpty(name)) 
            {
                dtShow = dtFull.Copy();
                dgvData.DataSource = dtShow; 
            }
            else
            {
                foreach (DataRow dr in dtFull.Rows)
                {
                    if (dr["TenDonVi"].ToString().ToLower().Contains(name.ToLower()))
                    {
                        dtShow.Rows.Add(dr.ItemArray);
                    }
                }
                dtShow.AcceptChanges();
            }
        }

        void ChangeColor()
        {
            int index = 0;
            foreach (DataRow dr in dtShow.Rows)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Search(name);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dtShow.GetChanges().Rows.Count > 0)
            {
                try
                {
                    UnitDAL.Instance.UpdateData(dtShow);
                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    dtFull = UnitDAL.Instance.GetUnitList();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }

        private void frmUnit_Load(object sender, EventArgs e)
        {

        }

        private void dgvData_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu này?", "Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    if(currentRow > -1 && currentRow < dgvData.Rows.Count -1)
                    {
                        dtShow.Rows[currentRow].Delete();
                    }
                }
            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            if(dtShow.GetChanges().Rows.Count> 0)
            {
                dtShow.RejectChanges();
            }
        }
    }
}
