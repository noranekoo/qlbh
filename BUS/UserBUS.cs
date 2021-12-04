using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class UserBUS
    {
        /// <summary>
        /// Kiểm tra người dùng có đúng hay không
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool IsExistUser(User user)
        {   
            try
            {
                return UserDAL.IsExistUser(user);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
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
                return UserDAL.GetUser(user);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// Thêm người dùng
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int AddUser(User user)
        {
            return UserDAL.AddUser(user);
        }
    }
}
