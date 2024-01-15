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
            string connectionString = @"Server=tcp:smart-parking-rg.database.windows.net,1433;Initial Catalog=smart-parking-database;Persist Security Info=False;User ID=aibaev20;Password=Voj82358;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

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
