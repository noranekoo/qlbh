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

        public static UserInfo UserInfo = null;
        public static void ShowMessage(string message, string title, MessageIcon icon, Form owner = null)
        {
            MessageCustom mc = new MessageCustom() { Message = message, MessageTitle = title, MessageIcon = icon };
            if(owner != null)
            {
                mc.ShowDialog(owner);
            }
            else
            {
                mc.ShowDialog();
            }
            
        }

        public static void ControlImageChange(Control c, Image img)
        {
            c.BackgroundImage = img;
        }
    }
}
