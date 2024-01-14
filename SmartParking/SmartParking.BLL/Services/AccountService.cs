﻿using SmartParking.DAL.Repositories;
using SmartParking.DAL.Models;
using SmartParking.BLL.Interfaces;
using System.Collections.Generic;

namespace SmartParking.BLL.Services
{
    public class AccountService : IAccountService
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

        public bool IsAccountAlreadyRegistered(string email, string username)
        {
            Account account = new Account();
            account.Email = email;
            account.Username = username;

            return repositoryInstance.IsAccountAlreadyRegistered(account.Email, account.Username);
        }

        public bool IsAdmin(string username)
        {
            return repositoryInstance.IsAdmin(username);
        }

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
