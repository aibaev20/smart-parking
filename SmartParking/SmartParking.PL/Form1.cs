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


namespace SmartParking.PL
{
    public partial class Form1 : Form
    {
        private bool isDragging = false;
        private Point lastMousePosition;

        public Form1()
        {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap()
        {
            // Set up GMapControl with OpenStreetMap provider
            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;

            gMapControl1.ShowCenter = false;

            // Set initial coordinates for Burgas
            double lat = 42.5047;
            double lng = 27.4626;

            // Set the initial position and zoom level
            gMapControl1.Position = new PointLatLng(lat, lng);
            gMapControl1.MinZoom = 5;
            gMapControl1.MaxZoom = 20;
            gMapControl1.Zoom = 12;

        }

        private void gMapControl1_MouseDown(object sender, MouseEventArgs e)
        {
            // Start dragging when right mouse button is pressed
            if (e.Button == MouseButtons.Right)
            {
                isDragging = true;
                lastMousePosition = e.Location;
            }
        }

        private void gMapControl1_MouseMove(object sender, MouseEventArgs e)
        {
            // Handle dragging to move the map
            if (isDragging)
            {
                // Calculate the change in mouse position
                int deltaX = e.X - lastMousePosition.X;
                int deltaY = e.Y - lastMousePosition.Y;

                // Adjust the map's position based on the mouse movement
                gMapControl1.Position = new PointLatLng(
                    gMapControl1.Position.Lat + gMapControl1.FromLocalToLatLng(deltaY, deltaX).Lat,
                    gMapControl1.Position.Lng + gMapControl1.FromLocalToLatLng(deltaY, deltaX).Lng);

                // Update the last mouse position
                lastMousePosition = e.Location;
            }
        }

        private void gMapControl1_MouseUp(object sender, MouseEventArgs e)
        {
            // Stop dragging when right mouse button is released
            if (e.Button == MouseButtons.Right)
            {
                isDragging = false;
            }
        }
    }
}
