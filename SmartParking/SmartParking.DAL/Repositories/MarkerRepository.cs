using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using SmartParking.DAL.Data;
using SmartParking.DAL.Models;

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

        public void UpdateLargeParkings(string parkingSpaces, string monthlySubscriptionPrice, string stayForADayPrice, string stayPerHourPrice, string name)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "UPDATE [lp] SET [lp].[ParkingSpaces] = @ParkingSpaces," +
                "[lp].[MonthlySubscriptionPrice] = @MonthlySubscriptionPrice," +
                "[lp].[StayForADayPrice] = @StayForADayPrice," +
                "[lp].[StayPerHourPrice] = @StayPerHourPrice FROM [LargeParkings] AS [lp]" +
                "JOIN [Informations] AS [i] ON [lp].[InformationsId] = [i].[Id] WHERE [i].[Name] = @Name;";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@ParkingSpaces", parkingSpaces);
            command.Parameters.AddWithValue("@MonthlySubscriptionPrice", monthlySubscriptionPrice);
            command.Parameters.AddWithValue("@StayForADayPrice", stayForADayPrice);
            command.Parameters.AddWithValue("@StayPerHourPrice", stayPerHourPrice);
            command.Parameters.AddWithValue("@Name", name);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public void UpdateChargingStations(string capacity, string workingHours, string chargerName)
        {
            SqlConnection connection = DBConnection.GetInstance();

            string commandString = "UPDATE [cs] SET [cs].[Capacity] = @Capacity," +
                "[cs].[WorkingHours] = @WorkingHours FROM [ChargingStations] AS [cs]" +
                "JOIN [Informations] AS [i] ON [cs].[InformationsId] = [i].[Id]" +
                "WHERE [i].[Name] = @Name;";

            connection.Open();

            SqlCommand command = new SqlCommand(commandString, connection);

            command.Parameters.AddWithValue("@Capacity", capacity);
            command.Parameters.AddWithValue("@WorkingHours", workingHours);
            command.Parameters.AddWithValue("@Name", chargerName);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
