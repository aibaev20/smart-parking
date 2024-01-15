using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SmartParking.DAL.Data
{
    public class DBConnection
    {
        // Single instance of SqlConnection
        private static SqlConnection connectionInstance = null;

        // Private constructor to prevent external instantiation
        private DBConnection() { }

        // Method to get the single instance of SqlConnection
        public static SqlConnection GetInstance()
        {
            // Connection string containing database server, name, and security details
            string connectionString = @"Server = localhost\SQLEXPRESS;
                Database = SmartParkingManagement;
                Trusted_Connection=true;
                Integrated Security=true;
                TrustServerCertificate=true";

            try
            {
                // Create a new SqlConnection instance if it doesn't exist
                if (connectionInstance == null)
                {
                    connectionInstance = new SqlConnection(connectionString);
                }

                // Return the singleton instance of SqlConnection
                return connectionInstance;
            }
            catch (SqlException exception)
            {
                // Print the exception if an error occurs during connection creation
                Console.WriteLine(exception);
                return null;
            }

        }
    }
}
