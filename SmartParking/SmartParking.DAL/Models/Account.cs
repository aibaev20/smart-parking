using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.DAL.Models
{
    // Represents a user account in the system.
    public class Account
    {
        private string username;
        private string email;
        private string password;
        private string role;

        // Gets or sets the username of the account.
        public string Username
        { 
            get { return username; } 
            set { username = value; } 
        }

        // Gets or sets the email of the account.
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Gets or sets the password of the account.
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Gets or sets the role of the account (e.g., User, Admin).
        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        // Initializes a new instance of the Account class with default values.
        public Account()
        {
            Username = "NotDefined";
            Email = "NotDefined";
            Password = "NotDefined";
            Role = "NotDefined";
        }
    }
}
