using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public User()
        {

        }

        public User(string _user, string _pass)
        {
            UserName = _user;
            Password = _pass;
        }
    }

    public class UserInfo
    {
        public User Info { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FullName { get; set; }
    }
}
