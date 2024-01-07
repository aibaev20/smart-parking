using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.DAL.Models
{
    public class Account
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Account()
        {
            Username = "NotDefined";
            Email = "NotDefined";
            Password = "NotDefined";
        }
    }
}
