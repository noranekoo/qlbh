using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        /// Xử lý điều khiển thanh công cụ
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
        public static void ShowMessage(string message, string title, MessageIcon icon, Form owner = null)
        {
            //MessageCustom mc = new MessageCustom() { Message = message, MessageTitle = title, MessageIcon = icon };
            //if(owner != null)
            //{
            //    mc.ShowDialog(owner);
            //}
            //else
            //{
            //    mc.ShowDialog();
            //}
            
        }

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
    }
}
