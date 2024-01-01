using System;
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


namespace SmartParking.PL.Views
{
    public partial class Map : Form
    {
        private bool isDragging = false;
        private Point lastMousePosition;

        private static Map instance;

        public static Map GetInstance()
        {
            if (instance == null)
            {
                instance = new Map();
            }
            return instance;
        }

        public Map()
        {
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

        private void burgasGMapControl_MouseDown(object sender, MouseEventArgs e)
        {
            // Start dragging when right mouse button is pressed
            if (e.Button == MouseButtons.Right)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void burgasGMapControl_MouseMove(object sender, MouseEventArgs e)
        {
            // Handle dragging to move the map
            if (isDragging)
            {
                // Calculate the change in mouse position
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                // Adjust the map's position based on the mouse movement
                burgasGMapControl.Position = new PointLatLng(
                    burgasGMapControl.Position.Lat + burgasGMapControl.FromLocalToLatLng(deltaY, deltaX).Lat,
                    burgasGMapControl.Position.Lng + burgasGMapControl.FromLocalToLatLng(deltaY, deltaX).Lng);

                // Update the last mouse position
                lastMousePosition = e.Location;
            }
        }

        private void burgasGMapControl_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when right mouse button is released
            if (e.Button == MouseButtons.Right)
            {
                isDragging = false;
            }
        }
    }
}
