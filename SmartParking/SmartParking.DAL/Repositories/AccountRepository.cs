using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using SmartParking.DAL.Data;

namespace SmartParking.DAL.Repositories
{
    public class AccountRepository
    {
        private static AccountRepository instance = null;

        public static AccountRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new AccountRepository();
            }

            return instance;
        }

        public bool VerifyAccount(string username, string password)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT COUNT(*) FROM [Accounts] WHERE Username = @Username AND Password = @Password";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            int count = (int)command.ExecuteScalar();

            command.ExecuteNonQuery();

            connection.Close();

            return count > 0;
        }

        public bool IsAccountAlreadyRegistered(string email)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string emailCommandString = "SELECT COUNT(*) FROM [Accounts] WHERE [Email] = @Email";

            connection.Open();

            SqlCommand emailCommand = new SqlCommand(emailCommandString, connection);

            emailCommand.Parameters.AddWithValue("@Email", email);

            int emailCount = (int)emailCommand.ExecuteScalar();

            connection.Close();

            return emailCount > 0;
        }

        public bool IsAccountAlreadyRegistered(string email, string username)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string emailCommandString = "SELECT COUNT(*) FROM [Accounts] WHERE [Email] = @Email";
            string usernameCommandString = "SELECT COUNT(*) FROM [Accounts] WHERE [Username] = @Username";

            connection.Open();

            SqlCommand emailCommand = new SqlCommand(emailCommandString, connection);
            SqlCommand usernameCommand = new SqlCommand(usernameCommandString, connection);

            emailCommand.Parameters.AddWithValue("@Email", email);
            usernameCommand.Parameters.AddWithValue("@Username", username);

            int emailCount = (int)emailCommand.ExecuteScalar();
            int usernameCount = (int)usernameCommand.ExecuteScalar();

            connection.Close();

            return emailCount > 0 || usernameCount > 0;
        }

        public bool IsAdmin(string username)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [Role] FROM [Accounts] WHERE [Username] = @Username";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Username", username);

            string result = (string)command.ExecuteScalar();

            connection.Close();

            return result == "Admin";
        }

        public void AddAccount(string username, string email, string password)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "INSERT INTO [Accounts]" +
                "([Username], [Email], [Password], [Role]) " +
                "VALUES(@Username, @Email, @Password, @Role)";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@Role", "User");

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
