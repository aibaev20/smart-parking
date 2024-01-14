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

        public string GetNameById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [Name] FROM [Informations] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            string result = (string)command.ExecuteScalar();

            connection.Close();

            return result;
        }

        public int GetParkingSpacesById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [ParkingSpaces] FROM [LargeParkings] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            int result = (int)command.ExecuteScalar();

            connection.Close();

            return result;
        }

        public string GetMonthlySubscriptionPriceById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [MonthlySubscriptionPrice] FROM [LargeParkings] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            string result = (string)command.ExecuteScalar();

            connection.Close();

            return result;
        }

        public string GetStayForADayPriceById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [StayForADayPrice] FROM [LargeParkings] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            string result = (string)command.ExecuteScalar();

            connection.Close();

            return result;
        }

        public string GetStayPerHourPriceById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [StayPerHourPrice] FROM [LargeParkings] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            string result = (string)command.ExecuteScalar();

            connection.Close();

            return result;
        }

        public string GetCapacityById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [Capacity] FROM [ChargingStations] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            string result = (string)command.ExecuteScalar();

            connection.Close();

            return result;
        }

        public string GetChargerWorkingHoursById(int id)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "SELECT [WorkingHours] FROM [ChargingStations] WHERE [Id] = @Id";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Id", id);

            string result = (string)command.ExecuteScalar();

            connection.Close();

            return result;
        }
    }
}
