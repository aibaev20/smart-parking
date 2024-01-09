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
        private static AccountController instance;
        private static AccountService serviceInstance = AccountService.GetInstance();

        public static AccountController GetInstance()
        {
            if (instance == null)
            {
                instance = new AccountController();
            }

            return instance;
        }

        private AccountController()
        {

        }

        public bool VerifyAccount(string username, string password)
        {
            return serviceInstance.VerifyAccount(username, password);
        }

        public bool IsEmailAlreadyRegistered(string email)
        {
            return serviceInstance.IsEmailAlreadyRegistered(email);
        }

        public void AddAccount(string username, string email, string password)
        {
            serviceInstance.AddAccount(username, email, password);
        }
    }
}
