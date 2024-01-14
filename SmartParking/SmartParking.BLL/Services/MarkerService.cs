using SmartParking.DAL.Models;
using SmartParking.DAL.Repositories;
using SmartParking.BLL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.BLL.Services
{
    public class MarkerService : IMarkerService
    {
        private static MarkerService instance = null;
        private static MarkerRepository repositoryInstance = MarkerRepository.GetInstance();

        public static MarkerService GetInstance()
        {
            if (instance == null)
            {
                instance = new MarkerService();
            }

            return instance;
        }
        public double GetLatitudeById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetLatitudeById(marker.Id);
        }

        public double GetLongitudeById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetLongitudeById(marker.Id);
        }

        public string GetNameById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetNameById(marker.Id);
        }

        public int GetParkingSpacesById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetParkingSpacesById(marker.Id);
        }

        public string GetMonthlySubscriptionPriceById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetMonthlySubscriptionPriceById(marker.Id);
        }

        public string GetStayForADayPriceById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetStayForADayPriceById(marker.Id);
        }

        public string GetStayPerHourPriceById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetStayPerHourPriceById(marker.Id);
        }

        public string GetCapacityById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetCapacityById(marker.Id);
        }

        public string GetChargerWorkingHoursById(int id)
        {
            Marker marker = new Marker();
            marker.Id = id;

            return repositoryInstance.GetChargerWorkingHoursById(marker.Id);
        }
    }
}
