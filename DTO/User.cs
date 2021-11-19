using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string _user, string _pass)
        {
            UserName = _user;
            Password = _pass;
        }
    }
}
