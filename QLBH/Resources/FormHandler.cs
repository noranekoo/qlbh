using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using DTO;

namespace QLBH.Resources
{
    public class FormHandler
    {
        public enum MessageIcon
        {
            Information,
            Warning,
            Question,
            Error
        }

        public enum ModeControl
        {
            NONE,
            ADD,
            EDIT,
            DELETE,
            PRINT,
            EX_EXCEL
        }

        public static UserInfo UserInfo = null;
        public static Form frmLogin = new frmLogin();
        /// <summary>
        /// ツールバー処理
        /// </summary>
        /// <param name="tlbar"></param>
        /// <param name="cso"></param>
        public static void SetControlState(ToolBars tlbar, ModeControl cso)
        {
            switch (cso)
            {
                case ModeControl.ADD:
                    tlbar.EnableT1 = false;
                    tlbar.EnableT2 = true;
                    tlbar.EnableT3 = true;
                    tlbar.EnableT4 = false;
                    tlbar.EnableT5 = false;
                    break;
                case ModeControl.EDIT:
                    tlbar.EnableT1 = true;
                    tlbar.EnableT2 = false;
                    tlbar.EnableT3 = true;
                    tlbar.EnableT4 = false;
                    tlbar.EnableT5 = false;
                    break;
                case ModeControl.DELETE:
                    tlbar.EnableT1 = true;
                    tlbar.EnableT2 = true;
                    tlbar.EnableT3 = true;
                    tlbar.EnableT4 = false;
                    tlbar.EnableT5 = false;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="title"></param>
        /// <param name="icon"></param>
        /// <param name="owner"></param>
        //public static void ShowMessage(string message, string title, MessageIcon icon, Form owner = null)
        //{
        //    //MessageCustom mc = new MessageCustom() { Message = message, MessageTitle = title, MessageIcon = icon };
        //    //if(owner != null)
        //    //{
        //    //    mc.ShowDialog(owner);
        //    //}
        //    //else
        //    //{
        //    //    mc.ShowDialog();
        //    //}
            
        //}

        public static void ControlImageChange(Control c, Image img)
        {
            c.BackgroundImage = img;
        }
        /// <summary>
        /// タップページにフォームを追加処理
        /// </summary>
        /// <param name="tab"></param>
        /// <param name="c"></param>
        public static void SetTabContent(TabControl tab, params Form [] c)
        {
            if(c.Length <= tab.TabPages.Count)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    c[i].FormBorderStyle = FormBorderStyle.None;
                    c[i].TopLevel = false;
                    c[i].Dock = DockStyle.Fill;
                    c[i].Show();
                    tab.TabPages[i].Controls.Add(c[i]);
                }
            }
        }

        public static bool Save(string tblName, DataTable dt, ref DataTable mData)
        {
            try
            {
                DataProvider.Instance.UpdateData(tblName, dt, "*");
                ShowInfoMessage("Cập nhật dữ liệu thành công");
                mData = DataProvider.Instance.SelectData(tblName, new System.Data.OleDb.OleDbParameter[0], "*");
                return true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Có lỗi khi lưu dữ liệu.\n{ex.Message}");
            }
            return false;
        }

        public static bool Save(string tblName, DataTable dt, bool showMessage = true)
        {
            try
            {
                DataProvider.Instance.UpdateData(tblName, dt, "*");
                if(showMessage) ShowInfoMessage("Cập nhật dữ liệu thành công");
                //mData = DataProvider.Instance.SelectData(tblName, new System.Data.OleDb.OleDbParameter[0], "*");
                return true;
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Có lỗi khi lưu dữ liệu.\n{ex.Message}");
            }
            return false;
        }

        public static void RowPrepaintHandler(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewCustom dgvData = sender as DataGridViewCustom;
            if (!dgvData.Rows[e.RowIndex].IsNewRow)
            {
                dgvData.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
            }
        }

        public static bool SelectRow(DataGridViewCustom dgvData, DataTable dtShow, out object info)
        {
            info = null;
            try
            {
                if (!dgvData.Rows[dgvData.RowSelectedIndex].IsNewRow
                    && dgvData.RowSelectedIndex < dtShow.Rows.Count
                    && dgvData.RowSelectedIndex > -1
                    )
                {
                    if (!string.IsNullOrEmpty(dgvData[1, dgvData.RowSelectedIndex].Value.ToString()))
                    {
                        DataRow dr = dtShow.Rows[dgvData.RowSelectedIndex];
                        info = dr;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Dữ liệu chưa tồn tại.\nVui lòng nhấn nút LƯU.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                FormHandler.ShowErrorMessage(ex.Message);
            }
            return false;
        }

        //public static bool SelectRow(DataGridViewCustom dgvData,ref DataTable dtShow, out object info)
        //{
        //    info = null;
        //    try
        //    {
        //        if (!dgvData.Rows[dgvData.RowSelectedIndex].IsNewRow
        //            && dgvData.RowSelectedIndex < dtShow.Rows.Count
        //            && dgvData.RowSelectedIndex > -1
        //            )
        //        {
        //            if (!string.IsNullOrEmpty(dgvData[1, dgvData.RowSelectedIndex].Value.ToString()))
        //            {
        //                DataRow dr = dtShow.Rows[dgvData.RowSelectedIndex];
        //                info = dr;
        //                return true;
        //            }
        //            else
        //            {
        //                FormHandler.ShowWarningMessage("Dữ liệu chưa được lưu.\nVui lòng nhấn nút LƯU.",false);
        //                return false;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        FormHandler.ShowErrorMessage(ex.Message);
        //    }
        //    return false;
        //}

        public static void ShowErrorMessage(string message)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Error;

            MessageBox.Show(message, "Lỗi", button, icon);
        }

        public static DialogResult ShowWarningMessage(string message, bool okcan)
        {
            MessageBoxButtons button = okcan ? MessageBoxButtons.OKCancel : MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Warning;

            return MessageBox.Show(message, "Thông báo", button, icon);
        }

        public static DialogResult ShowQuestionMessage(string message)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            return MessageBox.Show(message, "Thông báo", button, icon);
        }

        public static void ShowInfoMessage(string message)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.Information;

            MessageBox.Show(message, "Thông tin", button, icon);
        }

        public static void Save(DataSet ds)
        {
            // 処理無し
        }

        public static bool HasChanged(DataTable dt)
        {
            foreach(DataRow dr in dt.Rows)
            {
                if (dr.RowState != DataRowState.Unchanged && dr.RowState != DataRowState.Detached) return true;
            }
            return false;
        }
    }
}
