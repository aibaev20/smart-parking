using System.Collections.Generic;

namespace SmartParking.BLL.Interfaces
{
    // Interface for the AccountService, defining methods related to account management.
    public interface IAccountService
    {
        // Verifies if an account with the given username and password exists.
        bool VerifyAccount(string username, string password);

        // Checks if an account with the given email or username is already registered.
        bool IsAccountAlreadyRegistered(string email, string username);

        // Checks if the account with the given username has admin privileges.
        bool IsAdmin(string username);

        // Adds account
        void AddAccount(string username, string email, string password);
    }
}
