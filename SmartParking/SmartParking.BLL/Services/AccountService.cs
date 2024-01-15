using SmartParking.DAL.Repositories;
using SmartParking.DAL.Models;
using SmartParking.BLL.Interfaces;
using System.Collections.Generic;

namespace SmartParking.BLL.Services
{
    // Service class for managing user accounts.
    public class AccountService : IAccountService
    {
        private static AccountService instance = null;
        private static AccountRepository repositoryInstance = AccountRepository.GetInstance();

        // Gets an instance of the AccountService.
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

        // Verifies if an account with the given username and password exists.
        public bool VerifyAccount(string username, string password)
        {
            Account account = new Account();
            account.Username = username;
            account.Password = password;

            bool accountVerified = repositoryInstance.VerifyAccount(account.Username, account.Password);

            return accountVerified;
        }

        // Checks if an account with the given email or username is already registered.
        public bool IsAccountAlreadyRegistered(string email, string username)
        {
            Account account = new Account();
            account.Email = email;
            account.Username = username;

            return repositoryInstance.IsAccountAlreadyRegistered(account.Email, account.Username);
        }

        // Checks if the account with the given username has admin privileges.
        public bool IsAdmin(string username)
        {
            return repositoryInstance.IsAdmin(username);
        }

        // Adds a new account to the database.
        public void AddAccount(string username, string email, string password)
        {
            Account account = new Account();
            account.Username = username;
            account.Email = email;
            account.Password = password;

            repositoryInstance.AddAccount(account.Username, account.Email, account.Password);
        }
    }
}
