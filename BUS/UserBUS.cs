using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using DAL;
namespace BUS
{
    public class UserBUS
    {
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

        public static int AddUser(User user)
        {
            return UserDAL.AddUser(user);
        }
    }
}
