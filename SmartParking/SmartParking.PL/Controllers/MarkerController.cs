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
    }
}
