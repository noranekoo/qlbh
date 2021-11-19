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

        public bool IsExistUser(User user)
        {
            string sql = DataProvider.JoinSQL(Const.GET_USER, "WHERE TenDangNhap=@user AND MatKhau=@pass");
            OleDbParameter [] param = 
            {
                new OleDbParameter("user", user.UserName),
                new OleDbParameter("pass", user.Password),
            };
            DataTable dt = DataProvider.GetInstance().GetData(sql, param);
            int count = dt.Rows.Count;
            return count > 0;
        }
    }
}
