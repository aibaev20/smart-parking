using System.Collections.Generic;

namespace SmartParking.BLL.Services
{
    public interface IAccountService
    {
        bool VerifyAccount(string username, string password);

        bool IsAccountAlreadyRegistered(string email, string username);

        bool IsAdmin(string username);

        void AddAccount(string username, string email, string password);
    }
}
