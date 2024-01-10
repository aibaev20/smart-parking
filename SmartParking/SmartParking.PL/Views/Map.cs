﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsPresentation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SmartParking.PL.Controllers;


namespace SmartParking.PL.Views
{
    public partial class Map : Form
    {
        private static AccountController accountController = AccountController.GetInstance();
        public static bool isAdmin;
        private static Map instance;

        public static Map GetInstance(string username)
        {
            if (instance == null)
            {
                instance = new Map(username);
            }
            return instance;
        }

        public Map(string username)
        {
            isAdmin = accountController.IsAdmin(username);
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            // Set up GMapControl with OpenStreetMap provider
            burgasGMapControl.MapProvider = GMapProviders.OpenStreetMap;
            // Fetch map data from the server and cache it for future use
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            burgasGMapControl.ShowCenter = false;

            // Set initial coordinates for Burgas
            double lat = 42.5047;
            double lng = 27.4626;

            // Set the initial position and zoom level
            burgasGMapControl.Position = new PointLatLng(lat, lng);
            burgasGMapControl.MinZoom = 5;
            burgasGMapControl.MaxZoom = 20;
            burgasGMapControl.Zoom = 12;
        }

    }
}
