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
            return GetUser(user) != null;
        }
        /// <summary>
        /// Lấy thông tin người dùng
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static UserInfo GetUser(User user)
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
                    bool isMatchPass = Encrypto.SHACheck(user.Password, pwd);
                    if (isMatchPass)
                    {
                        UserInfo info = new UserInfo()
                        {
                            Info = user,
                            FullName = dt.Rows[0]["HoTen"].ToString(),
                            Email = dt.Rows[0]["Email"].ToString(),
                            Phone = dt.Rows[0]["SDT"].ToString(),
                            Address = dt.Rows[0]["DiaChi"].ToString()
                        };
                        return info;
                    }
                }
            }
            catch(Exception e)
            {
                throw e.InnerException;
            }

            return null;
        }
        /// <summary>
        /// Thêm người dùng mới
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Thay đổi thông tin
        /// </summary>
        /// <param name="uInfo"></param>
        /// <returns></returns>
        public static bool ChangeInfo(UserInfo uInfo)
        {
            try
            {
                
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
            return false;
        }

        /// <summary>
        /// Thay đổi thông tin
        /// </summary>
        /// <param name="user"></param>
        /// <param name="uInfo"></param>
        /// <returns></returns>
        public static bool ChangeInfo(User user, UserInfo uInfo)
        {
            try
            {
                UserInfo oldInfo = GetUser(user);
                if (oldInfo != null)
                {
                    if (user.Password.Equals(uInfo.Info.Password))
                    {

                        return true;
                    }
                }
            }
            catch (Exception e)
            {

                throw e.InnerException;
            }
            return false;
        }
    }
}
