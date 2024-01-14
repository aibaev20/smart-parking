using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using SmartParking.DAL.Data;

namespace SmartParking.DAL.Repositories
{
    public class MarkerRepository
    {
        private static MarkerRepository instance = null;

        public static MarkerRepository GetInstance()
        {
            if (instance == null)
            {
                instance = new MarkerRepository();
            }

            return instance;
        }

        public double GetLatitudeById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [Latitude] FROM [Informations] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            double result = (double)command.ExecuteScalar();

            connection.Close();

            return result;
        }

        public double GetLongitudeById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [Longitude] FROM [Informations] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            double result = (double)command.ExecuteScalar();

            connection.Close();

            return result;
        }
    }
}
