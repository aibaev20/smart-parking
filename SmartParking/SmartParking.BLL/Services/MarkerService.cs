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
    }
}
