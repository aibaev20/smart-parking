using SmartParking.DAL.Repositories;
using SmartParking.DAL.Models;
using System.Collections.Generic;

namespace SmartParking.BLL.Services
{
    public class AccountService
    {
        private static AccountService instance = null;
        private static AccountRepository repositoryInstance = AccountRepository.GetInstance();

        public static AccountService GetInstance()
        {
            if (instance == null)
            {
                instance = new AccountService();
            }

            return instance;
        }

        private AccountService()
        {

        }

        public bool VerifyAccount(string username, string password)
        {
            Account account = new Account();
            account.Username = username;
            account.Password = password;

            bool accountVerified = repositoryInstance.VerifyAccount(account.Username, account.Password);

            return accountVerified;
        }
    }
}
