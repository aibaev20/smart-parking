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

        public bool IsEmailAlreadyRegistered(string email)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT COUNT(*) FROM [Accounts] WHERE [Email] = @Email";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Email", email);

            int count = (int)command.ExecuteScalar();

            connection.Close();

            return count > 0;
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
