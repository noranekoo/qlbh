using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QLBH.Resources
{
    public class DataGridViewCustom : DataGridView
    {
        public int RowSelectedIndex { get; set; } = 0;
        public int RowOfTableIndex { get; set; } = 0;
        
        public List<int> keys = new List<int>();

        private DataTable dt = null;

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            dt = (DataTable)DataSource;
            SetDataTableRowIndex();
            
        }
        protected override void OnCellClick(DataGridViewCellEventArgs e)
        {
            base.OnCellClick(e);
            RowSelectedIndex = e.RowIndex;
            //MessageBox.Show(this[5, e.RowIndex].Value.ToString());
        }

        protected override void OnRowValidated(DataGridViewCellEventArgs e)
        {
            base.OnRowValidated(e);
            if(AllowUserToAddRows || AllowUserToDeleteRows)
            {
                ChangeColorForStateChanged(e);
            }
        }

        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            base.OnCellFormatting(e);
            if (Columns[e.ColumnIndex].Name.Contains("Price") || Columns[e.ColumnIndex].Name.Contains("price"))
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = StringHandler.FormatForCurrency(e.Value.ToString(), "");
                        }
                        catch (Exception ex)
                        {
                            FormHandler.ShowErrorMessage(ex.Message);
                        }

                    }
                }
            }
            if (Columns[e.ColumnIndex].Name.Contains("Discount"))
            {
                if (e != null)
                {
                    if (e.Value != null)
                    {
                        try
                        {
                            e.Value = e.Value + "%";
                        }
                        catch (Exception ex)
                        {
                            FormHandler.ShowErrorMessage(ex.Message);
                        }
                    }
                }
            }

            if (Columns[e.ColumnIndex].Name.Equals("Payment"))
            {
                if(e!= null)
                {
                    if(e.Value != null)
                    {
                        try
                        {
                            e.Value = e.Value.Equals(0) ? "Chuyển khoản" : "Tiền mặt";
                        }
                        catch (Exception ex)
                        {
                            FormHandler.ShowErrorMessage(ex.Message);
                        }
                    }
                }
            }
            if (Columns[e.ColumnIndex].Name.Contains("Date"))
            {
                if(e != null)
                {
                    if(e.Value != null)
                    {
                        try
                        {
                            e.Value = DateTime.Parse(e.Value.ToString()).ToString("dd/MM/yyyy");
                        }
                        catch (Exception ex)
                        {
                            FormHandler.ShowErrorMessage(ex.Message);
                        }
                    }
                }
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (dt == null) return;
            try
            {
                //Xử lý nhấn nút delete hiện thông báo
                if (e.KeyCode == Keys.Delete)
                {
                    if (RowSelectedIndex > -1 && !Rows[RowSelectedIndex].IsNewRow)
                    {
                        RowOfTableIndex = keys[RowSelectedIndex];
                        DialogResult rslt = MessageBox.Show("Bạn có chắc chắn muốn xoá dữ liệu của dòng này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (rslt == DialogResult.Yes)
                        {
                            dt.Rows[RowOfTableIndex].Delete();
                            MessageBox.Show("Dữ liệu đã bị xoá, nếu cần khôi phục có thể nhấn nút RESET");
                            RowSelectedIndex = 0;
                            Rows[RowSelectedIndex].Selected = true;
                            keys.Remove(RowOfTableIndex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                QLBHLogger.LogError(ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void SetDataTableRowIndex()
        {
            keys.Clear();
            for (int i = 0; i < dt?.Rows?.Count; i++)
            {
                keys.Add(i);
            }
            if (!Columns.Contains("STT"))
            {
                DataGridViewTextBoxColumn dgvtb = new DataGridViewTextBoxColumn();
                dgvtb.HeaderText = "STT";
                dgvtb.Name = "STT";
                dgvtb.Width = 30;
                dgvtb.ReadOnly = true;
                Columns.Insert(0, dgvtb);
            }
        }

        private void ChangeColorForStateChanged(DataGridViewCellEventArgs e)
        {
            if (dt == null) return;
            if(RowSelectedIndex> -1 &&RowSelectedIndex <= dt.Rows.Count - 1)
            {
                switch (dt.Rows[RowSelectedIndex].RowState)
                {
                    case DataRowState.Added:
                        Rows[RowSelectedIndex].DefaultCellStyle.BackColor = Color.Green;
                        Rows[RowSelectedIndex].DefaultCellStyle.ForeColor = Color.AntiqueWhite;
                        break;
                    case DataRowState.Modified:
                        Rows[RowSelectedIndex].DefaultCellStyle.BackColor = Color.Blue;
                        Rows[RowSelectedIndex].DefaultCellStyle.ForeColor = Color.AntiqueWhite;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
