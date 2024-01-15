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
        // Single instance of AccountRepository
        private static AccountRepository instance = null;

        // Method to get the single instance of AccountRepository
        public static AccountRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new AccountRepository();
            }

            return instance;
        }

        // Method to verify an account based on username and password
        public bool VerifyAccount(string username, string password)
        {
            SqlConnection connection = DBConnection.GetInstance();

            // SQL command to check if an account with the given username and password exists
            string commandString = "SELECT COUNT(*) FROM [Accounts] WHERE Username = @Username AND Password = @Password";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Password", password);

            // Execute the command and get the count
            int count = (int)command.ExecuteScalar();

            command.ExecuteNonQuery();

            connection.Close();

            return count > 0;
        }

        // Method to check if an account with the given email is already registered
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

        // Method to check if an account with the given email or username is already registered
        // Overload method
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

        // Method to check if an account has admin role
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

        // Method to add a new account to the database
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
