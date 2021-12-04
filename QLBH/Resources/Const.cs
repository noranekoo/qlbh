using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH.Resources
{
    public class Const
    {
        //public static DialogResult GetMessage(string code, string type)
        //{
        //    string message = GetMessageByCode(code);
        //    switch (type)
        //    {
        //        case "W":
        //            //return MessageBox.Show(message,"Thông báo",)
        //            break;
        //        case "I":
        //            break;
        //        default:
        //            break;
        //    }
        //    //return message;
        //}

        public static string GetMessageByCode(string code)
        {
            string message = "";
            switch (code)
            {
                case "SET01":
                    message = "Mật khẩu cũ không đúng";
                    break;
                case "SET02":
                    message = "Mật khẩu xác nhận không đúng";
                    break;
                default:
                    break;
            }
            return message;
        }
    }
}
