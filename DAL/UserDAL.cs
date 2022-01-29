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
        public static UserDAL Instance { get; set; } = new UserDAL();
        public static bool IsExistUser(User user)
        {
            return GetUser(user) != null;
        }

        public UserInfo GetUser(string userName)
        {
            try
            {
                OleDbParameter[] param =
                {
                    new OleDbParameter("user", userName),
                };
                DataTable dt = DataProvider.Instance.SelectData("NguoiDung", param, "*", "TenDangNhap=@user");
                int count = dt.Rows.Count;
                if (count > 0)
                {
                    string pwd = dt.Rows[0]["MatKhau"].ToString();
                    User user = new User(userName, pwd);
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
            catch (Exception e)
            {
                throw e.InnerException;
            }

            return null;
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
                DataTable dt = DataProvider.Instance.SelectData("NguoiDung", param,"*", "TenDangNhap=@user");
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
            return 0;
            //return DataProvider.GetInstance().UpdateData("NguoiDung", param, "C", "TenDangNhap,MatKhau");
        }
        
        public int SaveSession(User user, bool isDelete)
        {
            string dt = !isDelete
                ? DateTime.Now.AddDays(1).ToString("dd/MM/yyyy")
                : DateTime.Now.AddDays(-1).ToString("dd/MM/yyyy");
            OleDbParameter[] pa = new
                OleDbParameter[1]
            {
                new OleDbParameter("userId",user.UserName),
            };
            OleDbParameter[] pa2 = new
                OleDbParameter[0];
            try
            {
                int dltResult = DataProvider.Instance.Delete("Sessions", pa2, "1=1");
                if (dltResult != -1)
                {
                    return DataProvider.Instance.Insert("Sessions", pa, "UserID, Exp", $"@userId,\'{dt}\'");
                }
            }
            catch(Exception e)
            {
                return -1;
            }

            return -1;
        }

        public bool GetSession(string userName)
        {
            OleDbParameter[] pa = new OleDbParameter[1]
            {
                new OleDbParameter("userName", userName)
            };
            try
            {
                DataTable dt = DataProvider.Instance.SelectData("Sessions", pa, "*", $"UserID=@userName");
                if(dt!= null)
                {
                    if (dt.Rows.Count > 0)
                    {
                        DateTime exp = DateTime.Parse(dt.Rows[0]["Exp"].ToString());

                        return exp.Ticks > DateTime.Now.Ticks;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                return false;
                throw e.InnerException;
            }
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

        public UserInfo ChangePassword(UserInfo info, string password)
        {
            UserInfo infos = null;
            string pwd = Encrypto.SHAHash(password);
            OleDbParameter[] pa = new OleDbParameter[1]
            {
                new OleDbParameter("user", info.Info.UserName),
            };
            try
            {
                DataTable dt = DataProvider.Instance.SelectData("NguoiDung", pa, "*", "TenDangNhap=@user");
                DataRow dr = dt.Rows[0];
                dr["MatKhau"] = pwd;
                DataProvider.Instance.UpdateData("NguoiDung",dt, "*");
                infos = info;
                infos.Info.Password = pwd;
            }
            catch(Exception e)
            {
                return infos;
            }
            return infos;
        }
    }
}
