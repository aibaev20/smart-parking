using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.DAL.Models
{
    public class Account
    {
        private string username;
        private string email;
        private string password;
        private string role;

        public string Username
        { 
            get { return username; } 
            set { username = value; } 
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public Account()
        {
            Username = "NotDefined";
            Email = "NotDefined";
            Password = "NotDefined";
            Role = "NotDefined";
        }
    }
}
