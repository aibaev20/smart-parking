using System;
using System.Collections.Generic;
using System.Text;

namespace SmartParking.DAL.Models
{
    public class Marker
    {
        private int id;
        private string name;
        private string latitude;
        private string longitude;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Latitude
        {
            get { return latitude; }
            set { latitude = value; }
        }
        public string Longitude
        {
            get { return longitude; }
            set { longitude = value; }
        }

        public Marker()
        {
            Id = 0;
            Name = "NotDefined";
            Latitude = "NotDefined";
            Longitude = "NotDefined";
        }
    }
}
