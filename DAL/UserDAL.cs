using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DTO;

namespace DAL
{
    public class UserDAL
    {
        public UserDAL()
        {
            
        }
        public static bool IsExistUser(User user)
        {
            try
            {
                OleDbParameter[] param =
                {
                    new OleDbParameter("user", user.UserName),
                };
                DataTable dt = DataProvider.GetInstance().SelectData("NguoiDung", param,"*", "TenDangNhap=@user");
                int count = dt.Rows.Count;
                if (count > 0)
                {
                    string pwd = dt.Rows[0]["MatKhau"].ToString();
                    return Encrypto.SHACheck(user.Password, pwd);
                }
            }
            catch(Exception e)
            {
                throw e.InnerException;
            }

            return false;
        }

        public static int AddUser(User user)
        {
            if (IsExistUser(user))
            {
                return -1;
            }
            string pwd = Encrypto.SHAHash(user.Password);
            OleDbParameter[] param =
            {
                new OleDbParameter("user", user.UserName),
                new OleDbParameter("pass", pwd),
            };
            return DataProvider.GetInstance().UpdateData("NguoiDung", param, "C", "TenDangNhap,MatKhau");
        }
    }
}
