using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartParking.BLL.Services;

namespace SmartParking.PL.Controllers
{
    public class AccountController
    {
        // Single instance of AccountController
        private static AccountController instance;

        // Singleton instance of AccountService
        private static AccountService serviceInstance = AccountService.GetInstance();

        // Method to get the singleton instance of AccountController
        public static AccountController GetInstance()
        {
            if (instance == null)
            {
                instance = new AccountController();
            }

            return instance;
        }

        // Private constructor for AccountController
        private AccountController()
        {

        }

        // Method to verify account credentials
        public bool VerifyAccount(string username, string password)
        {
            return serviceInstance.VerifyAccount(username, password);
        }

        // Method to check if an account is already registered
        public bool IsAccountAlreadyRegistered(string email, string username)
        {
            return serviceInstance.IsAccountAlreadyRegistered(email, username);
        }

        // Method to check if a user is an admin
        public bool IsAdmin(string username)
        {
            return serviceInstance.IsAdmin(username);
        }

        // Method to add a new account
        public void AddAccount(string username, string email, string password)
        {
            serviceInstance.AddAccount(username, email, password);
        }
    }
}
