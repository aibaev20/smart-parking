using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.BLL.Interfaces
{
    public interface IMarkerService
    {
        double GetLatitudeById(int id);

        double GetLongitudeById(int id);

        string GetNameById(int id);

        int GetParkingSpacesById(int id);

        string GetMonthlySubscriptionPriceById(int id);

        string GetStayForADayPriceById(int id);

        string GetStayPerHourPriceById(int id);

        string GetCapacityById(int id);

        string GetChargerWorkingHoursById(int id);

        void UpdateLargeParkings(string parkingSpaces, string monthlySubscriptionPrice, string stayForADayPrice, string stayPerHourPrice, string name);

        void UpdateChargingStations(string capacity, string workingHours, string chargerName);
    }
}
