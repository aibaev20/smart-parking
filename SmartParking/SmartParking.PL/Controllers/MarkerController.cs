using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartParking.BLL.Services;

namespace SmartParking.PL.Controllers
{
    public class MarkerController
    {
        private static MarkerController instance;
        private static MarkerService serviceInstance = MarkerService.GetInstance();

        public static MarkerController GetInstance()
        {
            if (instance == null)
            {
                instance = new MarkerController();
            }

            return instance;
        }

        private MarkerController()
        {

        }

        public double GetLatitudeById(int id)
        {
            return serviceInstance.GetLatitudeById(id);
        }

        public double GetLongitudeById(int id)
        {
            return serviceInstance.GetLongitudeById(id);
        }

        public string GetNameById(int id)
        {
            return serviceInstance.GetNameById(id);
        }

        public int GetParkingSpacesById(int id)
        {
            return serviceInstance.GetParkingSpacesById(id);
        }

        public string GetMonthlySubscriptionPriceById(int id)
        {
            return serviceInstance.GetMonthlySubscriptionPriceById(id);
        }

        public string GetStayForADayPriceById(int id)
        {
            return serviceInstance.GetStayForADayPriceById(id);
        }

        public string GetStayPerHourPriceById(int id)
        {
            return serviceInstance.GetStayPerHourPriceById(id);
        }

        public string GetCapacityById(int id)
        {
            return serviceInstance.GetCapacityById(id);
        }

        public string GetChargerWorkingHoursById(int id)
        {
            return serviceInstance.GetChargerWorkingHoursById(id);
        }
    }
}
