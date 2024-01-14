using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.BLL.Interfaces
{
    public interface IMarkerService
    {
        double GetLatitudeById(int id);

        double GetLongitudeById(int id);
    }
}
