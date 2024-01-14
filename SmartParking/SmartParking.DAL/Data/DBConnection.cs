using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SmartParking.DAL.Data
{
    public class DBConnection
    {
        private static SqlConnection connectionInstance = null;

        private DBConnection() { }

        public static SqlConnection GetInstance()
        {
            string connectionString = @"Server = localhost\SQLEXPRESS;
                Database = SmartParkingManagement;
                Trusted_Connection=true;
                Integrated Security=true;
                TrustServerCertificate=true";

            try
            {
                if (connectionInstance == null)
                {
                    connectionInstance = new SqlConnection(connectionString);
                }

                return connectionInstance;
            }
            catch (SqlException exception)
            {
                Console.WriteLine(exception);
                return null;
            }

        }
    }
}
