﻿using System;
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
    }
}
