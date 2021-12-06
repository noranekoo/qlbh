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
       

        public static string GetMessageByCode(string code)
        {
            string message = "";
            switch (code)
            {
                case "M01":
                    message = "Hiện có một tab tương tự đang được mở";
                    break;
                case "M02":
                    message = "Bạn có chắc chắn muốn thoát hoàn toàn chương trình?\n Mọi dữ liệu sẽ không được lưu lại!";
                    break;
                case "M03":
                    message = "Bạn có chắc chắn muốn đăng xuất?";
                    break;
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
