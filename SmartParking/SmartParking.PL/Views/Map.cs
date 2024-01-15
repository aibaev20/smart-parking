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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SmartParking.PL.Controllers;


namespace SmartParking.PL.Views
{
    public partial class Map : Form
    {
        private static AccountController accountController = AccountController.GetInstance();
        private static MarkerController markerController = MarkerController.GetInstance();
        public static bool isAdmin;
        private static Map instance;
        private GMapOverlay markersOverlay;
        private int markerId = 0;

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
            AddMarkers();
        }

        private void InitializeMap()
        {
            // Set up GMapControl with OpenStreetMap provider
            burgasGMapControl.MapProvider = GMapProviders.OpenStreetMap;
            // Fetch map data from the server and cache it for future use
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            //GMaps.Instance.UseRouteCache = true;

            burgasGMapControl.ShowCenter = false;


            // Set initial coordinates for Burgas
            double lat = 42.5047;
            double lng = 27.4626;

            // Set the initial position and zoom level
            burgasGMapControl.Position = new PointLatLng(lat, lng);
            burgasGMapControl.MinZoom = 5;
            burgasGMapControl.MaxZoom = 20;
            burgasGMapControl.Zoom = 12;

            markersOverlay = new GMapOverlay("markersOverlay");

            burgasGMapControl.Overlays.Add(markersOverlay);
        }

        private void AddMarkers()
        {
            Bitmap parkingLargeMarker = Properties.Resources.markerLargeParking;
            Bitmap chargerDCMarker = Properties.Resources.markerDC;
            Bitmap chargerACMarker = Properties.Resources.markerAC;
            Bitmap parkingDisabledMarker = Properties.Resources.markerParkingDisabled;

            GMarkerGoogle parkingLargeMarker1 = new GMarkerGoogle(
                    new PointLatLng(markerController.GetLatitudeById(1), markerController.GetLongitudeById(1)),
                    parkingLargeMarker);
            parkingLargeMarker1.Tag = 1;
            markersOverlay.Markers.Add(parkingLargeMarker1);

            GMarkerGoogle parkingLargeMarker2 = new GMarkerGoogle(
                    new PointLatLng(markerController.GetLatitudeById(2), markerController.GetLongitudeById(2)),
                    parkingLargeMarker);
            parkingLargeMarker2.Tag = 2;
            markersOverlay.Markers.Add(parkingLargeMarker2);

            GMarkerGoogle chargerDC1 = new GMarkerGoogle(
                    new PointLatLng(markerController.GetLatitudeById(3), markerController.GetLongitudeById(3)),
                    chargerDCMarker);
            chargerDC1.Tag = 3;
            markersOverlay.Markers.Add(chargerDC1);

            GMarkerGoogle chargerDC2 = new GMarkerGoogle(
                    new PointLatLng(markerController.GetLatitudeById(4), markerController.GetLongitudeById(4)),
                    chargerDCMarker);
            chargerDC2.Tag = 4;
            markersOverlay.Markers.Add(chargerDC2);

            GMarkerGoogle chargerDC3 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(5), markerController.GetLongitudeById(5)),
                   chargerDCMarker);
            chargerDC3.Tag = 5;
            markersOverlay.Markers.Add(chargerDC3);

            GMarkerGoogle chargerDC4 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(6), markerController.GetLongitudeById(6)),
                   chargerDCMarker);
            chargerDC4.Tag = 6;
            markersOverlay.Markers.Add(chargerDC4);

            GMarkerGoogle chargerDC5 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(7), markerController.GetLongitudeById(7)),
                   chargerDCMarker);
            chargerDC5.Tag = 7;
            markersOverlay.Markers.Add(chargerDC5);

            GMarkerGoogle chargerDC6 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(8), markerController.GetLongitudeById(8)),
                   chargerDCMarker);
            chargerDC6.Tag = 8;
            markersOverlay.Markers.Add(chargerDC6);

            GMarkerGoogle chargerDC7 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(9), markerController.GetLongitudeById(9)),
                   chargerDCMarker);
            chargerDC7.Tag = 9;
            markersOverlay.Markers.Add(chargerDC7);

            GMarkerGoogle chargerDC8 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(10), markerController.GetLongitudeById(10)),
                   chargerDCMarker);
            chargerDC8.Tag = 10;
            markersOverlay.Markers.Add(chargerDC8);

            GMarkerGoogle chargerDC9 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(11), markerController.GetLongitudeById(11)),
                   chargerDCMarker);
            chargerDC9.Tag = 11;
            markersOverlay.Markers.Add(chargerDC9);

            GMarkerGoogle chargerDC10 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(12), markerController.GetLongitudeById(12)),
                   chargerDCMarker);
            chargerDC10.Tag = 12;
            markersOverlay.Markers.Add(chargerDC10);

            GMarkerGoogle chargerDC11 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(13), markerController.GetLongitudeById(13)),
                   chargerDCMarker);
            chargerDC11.Tag = 13;
            markersOverlay.Markers.Add(chargerDC11);

            GMarkerGoogle chargerDC12 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(14), markerController.GetLongitudeById(14)),
                   chargerDCMarker);
            chargerDC12.Tag = 14;
            markersOverlay.Markers.Add(chargerDC12);

            GMarkerGoogle chargerDC13 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(15), markerController.GetLongitudeById(15)),
                   chargerDCMarker);
            chargerDC13.Tag = 15;
            markersOverlay.Markers.Add(chargerDC13);

            GMarkerGoogle chargerDC14 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(16), markerController.GetLongitudeById(16)),
                   chargerDCMarker);
            chargerDC14.Tag = 16;
            markersOverlay.Markers.Add(chargerDC14);

            GMarkerGoogle chargerDC15 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(17), markerController.GetLongitudeById(17)),
                   chargerDCMarker);
            chargerDC15.Tag = 17;
            markersOverlay.Markers.Add(chargerDC15);

            GMarkerGoogle chargerDC16 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(18), markerController.GetLongitudeById(18)),
                   chargerDCMarker);
            chargerDC16.Tag = 18;
            markersOverlay.Markers.Add(chargerDC16);

            GMarkerGoogle chargerDC17 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(19), markerController.GetLongitudeById(19)),
                   chargerDCMarker);
            chargerDC17.Tag = 19;
            markersOverlay.Markers.Add(chargerDC17);

            GMarkerGoogle chargerAC1 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(20), markerController.GetLongitudeById(20)),
                   chargerACMarker);
            chargerAC1.Tag = 20;
            markersOverlay.Markers.Add(chargerAC1);

            GMarkerGoogle chargerAC2 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(21), markerController.GetLongitudeById(21)),
                   chargerACMarker);
            chargerAC2.Tag = 21;
            markersOverlay.Markers.Add(chargerAC2);

            GMarkerGoogle chargerAC3 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(22), markerController.GetLongitudeById(22)),
                   chargerACMarker);
            chargerAC3.Tag = 22;
            markersOverlay.Markers.Add(chargerAC3);

            GMarkerGoogle chargerAC4 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(23), markerController.GetLongitudeById(23)),
                   chargerACMarker);
            chargerAC4.Tag = 23;
            markersOverlay.Markers.Add(chargerAC4);

            GMarkerGoogle chargerAC5 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(24), markerController.GetLongitudeById(24)),
                   chargerACMarker);
            chargerAC5.Tag = 24;
            markersOverlay.Markers.Add(chargerAC5);

            GMarkerGoogle chargerAC6 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(25), markerController.GetLongitudeById(25)),
                   chargerACMarker);
            chargerAC6.Tag = 25;
            markersOverlay.Markers.Add(chargerAC6);

            GMarkerGoogle chargerAC7 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(26), markerController.GetLongitudeById(26)),
                   chargerACMarker);
            chargerAC7.Tag = 26;
            markersOverlay.Markers.Add(chargerAC7);

            GMarkerGoogle chargerAC8 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(27), markerController.GetLongitudeById(27)),
                   chargerACMarker);
            chargerAC8.Tag = 27;
            markersOverlay.Markers.Add(chargerAC8);

            GMarkerGoogle chargerAC9 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(28), markerController.GetLongitudeById(28)),
                   chargerACMarker);
            chargerAC9.Tag = 28;
            markersOverlay.Markers.Add(chargerAC9);

            GMarkerGoogle chargerAC10 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(29), markerController.GetLongitudeById(29)),
                   chargerACMarker);
            chargerAC10.Tag = 29;
            markersOverlay.Markers.Add(chargerAC10);

            GMarkerGoogle chargerAC11 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(30), markerController.GetLongitudeById(30)),
                   chargerACMarker);
            chargerAC11.Tag = 30;
            markersOverlay.Markers.Add(chargerAC11);

            GMarkerGoogle chargerAC12 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(31), markerController.GetLongitudeById(31)),
                   chargerACMarker);
            chargerAC12.Tag = 31;
            markersOverlay.Markers.Add(chargerAC12);

            GMarkerGoogle chargerAC13 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(32), markerController.GetLongitudeById(32)),
                   chargerACMarker);
            chargerAC13.Tag = 32;
            markersOverlay.Markers.Add(chargerAC13);

            GMarkerGoogle chargerAC14 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(33), markerController.GetLongitudeById(33)),
                   chargerACMarker);
            chargerAC14.Tag = 33;
            markersOverlay.Markers.Add(chargerAC14);

            GMarkerGoogle chargerAC15 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(34), markerController.GetLongitudeById(34)),
                   chargerACMarker);
            chargerAC15.Tag = 34;
            markersOverlay.Markers.Add(chargerAC15);

            GMarkerGoogle chargerAC16 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(35), markerController.GetLongitudeById(35)),
                   chargerACMarker);
            chargerAC16.Tag = 35;
            markersOverlay.Markers.Add(chargerAC16);

            GMarkerGoogle chargerAC17 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(36), markerController.GetLongitudeById(36)),
                   chargerACMarker);
            chargerAC17.Tag = 36;
            markersOverlay.Markers.Add(chargerAC17);

            GMarkerGoogle chargerAC18 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(37), markerController.GetLongitudeById(37)),
                   chargerACMarker);
            chargerAC18.Tag = 37;
            markersOverlay.Markers.Add(chargerAC18);

            GMarkerGoogle chargerAC19 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(38), markerController.GetLongitudeById(38)),
                   chargerACMarker);
            chargerAC19.Tag = 38;
            markersOverlay.Markers.Add(chargerAC19);

            GMarkerGoogle chargerAC20 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(39), markerController.GetLongitudeById(39)),
                   chargerACMarker);
            chargerAC20.Tag = 39;
            markersOverlay.Markers.Add(chargerAC20);

            GMarkerGoogle chargerAC21 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(40), markerController.GetLongitudeById(40)),
                   chargerACMarker);
            chargerAC21.Tag = 40;
            markersOverlay.Markers.Add(chargerAC21);

            GMarkerGoogle parkingDisabled1 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(41), markerController.GetLongitudeById(41)),
                   parkingDisabledMarker);
            parkingDisabled1.Tag = 41;
            markersOverlay.Markers.Add(parkingDisabled1);

            GMarkerGoogle parkingDisabled2 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(42), markerController.GetLongitudeById(42)),
                   parkingDisabledMarker);
            parkingDisabled2.Tag = 42;
            markersOverlay.Markers.Add(parkingDisabled2);

            GMarkerGoogle parkingDisabled3 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(43), markerController.GetLongitudeById(43)),
                   parkingDisabledMarker);
            parkingDisabled3.Tag = 43;
            markersOverlay.Markers.Add(parkingDisabled3);

            GMarkerGoogle parkingDisabled4 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(44), markerController.GetLongitudeById(44)),
                   parkingDisabledMarker);
            parkingDisabled4.Tag = 44;
            markersOverlay.Markers.Add(parkingDisabled4);

            GMarkerGoogle parkingDisabled5 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(45), markerController.GetLongitudeById(45)),
                   parkingDisabledMarker);
            parkingDisabled5.Tag = 45;
            markersOverlay.Markers.Add(parkingDisabled5);

            GMarkerGoogle parkingDisabled6 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(46), markerController.GetLongitudeById(46)),
                   parkingDisabledMarker);
            parkingDisabled6.Tag = 46;
            markersOverlay.Markers.Add(parkingDisabled6);

            GMarkerGoogle parkingDisabled7 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(47), markerController.GetLongitudeById(47)),
                   parkingDisabledMarker);
            parkingDisabled7.Tag = 47;
            markersOverlay.Markers.Add(parkingDisabled7);

            GMarkerGoogle parkingDisabled8 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(48), markerController.GetLongitudeById(48)),
                   parkingDisabledMarker);
            parkingDisabled8.Tag = 48;
            markersOverlay.Markers.Add(parkingDisabled8);

            GMarkerGoogle parkingDisabled9 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(49), markerController.GetLongitudeById(49)),
                   parkingDisabledMarker);
            parkingDisabled9.Tag = 49;
            markersOverlay.Markers.Add(parkingDisabled9);

            GMarkerGoogle parkingDisabled10 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(50), markerController.GetLongitudeById(50)),
                   parkingDisabledMarker);
            parkingDisabled10.Tag = 50;
            markersOverlay.Markers.Add(parkingDisabled10);

            GMarkerGoogle parkingDisabled11 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(51), markerController.GetLongitudeById(51)),
                   parkingDisabledMarker);
            parkingDisabled11.Tag = 51;
            markersOverlay.Markers.Add(parkingDisabled11);

            GMarkerGoogle parkingDisabled12 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(52), markerController.GetLongitudeById(52)),
                   parkingDisabledMarker);
            parkingDisabled12.Tag = 52;
            markersOverlay.Markers.Add(parkingDisabled12);

            GMarkerGoogle parkingDisabled13 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(53), markerController.GetLongitudeById(53)),
                   parkingDisabledMarker);
            parkingDisabled13.Tag = 53;
            markersOverlay.Markers.Add(parkingDisabled13);

            GMarkerGoogle parkingDisabled14 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(54), markerController.GetLongitudeById(54)),
                   parkingDisabledMarker);
            parkingDisabled14.Tag = 54;
            markersOverlay.Markers.Add(parkingDisabled14);

            GMarkerGoogle parkingDisabled15 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(55), markerController.GetLongitudeById(55)),
                   parkingDisabledMarker);
            parkingDisabled15.Tag = 55;
            markersOverlay.Markers.Add(parkingDisabled15);

            GMarkerGoogle parkingDisabled16 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(56), markerController.GetLongitudeById(56)),
                   parkingDisabledMarker);
            parkingDisabled16.Tag = 56;
            markersOverlay.Markers.Add(parkingDisabled16);

            GMarkerGoogle parkingDisabled17 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(57), markerController.GetLongitudeById(57)),
                   parkingDisabledMarker);
            parkingDisabled17.Tag = 57;
            markersOverlay.Markers.Add(parkingDisabled17);

            GMarkerGoogle parkingDisabled18 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(58), markerController.GetLongitudeById(58)),
                   parkingDisabledMarker);
            parkingDisabled18.Tag = 58;
            markersOverlay.Markers.Add(parkingDisabled18);

            GMarkerGoogle parkingDisabled19 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(59), markerController.GetLongitudeById(59)),
                   parkingDisabledMarker);
            parkingDisabled19.Tag = 59;
            markersOverlay.Markers.Add(parkingDisabled19);

            GMarkerGoogle parkingDisabled20 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(60), markerController.GetLongitudeById(60)),
                   parkingDisabledMarker);
            parkingDisabled20.Tag = 60;
            markersOverlay.Markers.Add(parkingDisabled20);

            GMarkerGoogle parkingDisabled21 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(61), markerController.GetLongitudeById(61)),
                   parkingDisabledMarker);
            parkingDisabled21.Tag = 61;
            markersOverlay.Markers.Add(parkingDisabled21);

            GMarkerGoogle parkingDisabled22 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(62), markerController.GetLongitudeById(62)),
                   parkingDisabledMarker);
            parkingDisabled22.Tag = 62;
            markersOverlay.Markers.Add(parkingDisabled22);

            GMarkerGoogle parkingDisabled23 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(63), markerController.GetLongitudeById(63)),
                   parkingDisabledMarker);
            parkingDisabled23.Tag = 63;
            markersOverlay.Markers.Add(parkingDisabled23);

            GMarkerGoogle parkingDisabled24 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(64), markerController.GetLongitudeById(64)),
                   parkingDisabledMarker);
            parkingDisabled24.Tag = 64;
            markersOverlay.Markers.Add(parkingDisabled24);

            GMarkerGoogle parkingDisabled25 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(65), markerController.GetLongitudeById(65)),
                   parkingDisabledMarker);
            parkingDisabled25.Tag = 65;
            markersOverlay.Markers.Add(parkingDisabled25);

            burgasGMapControl.Refresh();
        }

        private void burgasGMapControl_OnMarkerClick(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e)
        {
            infoContainer.Visible = true;

            markerId = int.Parse(item.Tag.ToString());

            name.Text = markerController.GetNameById(markerId);
            latitude.Text = markerController.GetLatitudeById(markerId).ToString();
            longitude.Text = markerController.GetLongitudeById(markerId).ToString();

            if (markerId >= 1 && markerId <= 2)
            {
                column1Label.Text = "Parking spaces:";
                column1TextBox.Text = markerController.GetParkingSpacesById(markerId).ToString();

                column2Label.Text = "Monthly subscription:";
                column2TextBox.Text = markerController.GetMonthlySubscriptionPriceById(markerId);

                column3Label.Text = "Stay for a day:";
                column3TextBox.Text = markerController.GetStayForADayPriceById(markerId);

                column4Label.Text = "Stay per hour:";
                column4TextBox.Text = markerController.GetStayPerHourPriceById(markerId);

                column1TextBox.Size = new Size(68, 30);

                column2Label.Location = new Point(22, 325);
                column2TextBox.Location = new Point(117, 325);
                column2TextBox.Size = new Size(68, 30);

                column1Label.Visible = true;
                column1TextBox.Visible = true;

                column2Label.Visible = true;
                column2TextBox.Visible = true;

                column3Label.Visible = true;
                column3TextBox.Visible = true;

                column4Label.Visible = true;
                column4TextBox.Visible = true;

                updateButton.Visible = true;
            }

            if (markerId >= 3 && markerId <= 40)
            {
                column1Label.Text = "Capacity:";
                column1TextBox.Text = markerController.GetCapacityById(markerId);
                
                column1TextBox.Size = new Size(140, 110);

                column2Label.Text = "Working hours:";
                column2Label.Location = new Point(22, 420);
                column2TextBox.Text = markerController.GetChargerWorkingHoursById(markerId);
                column2TextBox.Location = new Point(117, 420);
                column2TextBox.Size = new Size(140, 30);

                column1Label.Visible = true;
                column1TextBox.Visible = true;

                column2Label.Visible = true;
                column2TextBox.Visible = true;

                column3Label.Visible = false;
                column3TextBox.Visible = false;

                column4Label.Visible = false;
                column4TextBox.Visible = false;

                updateButton.Visible = true;
            }

            if (markerId >= 41 && markerId <= 65)
            {
                column1Label.Visible = false;
                column1TextBox.Visible = false;

                column2Label.Visible = false;
                column2TextBox.Visible = false;

                column3Label.Visible = false;
                column3TextBox.Visible = false;

                column4Label.Visible = false;
                column4TextBox.Visible = false;

                updateButton.Visible = false;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            infoContainer.Hide();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            MarkerController markerController = MarkerController.GetInstance();

            if (markerId >= 1 && markerId <= 2)
            {
                string parkingSpaces = column1TextBox.Text.ToString();
                string monthlySubscriptionPrice = column2TextBox.Text;
                string stayForADayPrice = column3TextBox.Text;
                string stayPerHourPrice = column4TextBox.Text;
                string name = markerController.GetNameById(markerId);

                markerController.UpdateLargeParkings(parkingSpaces, monthlySubscriptionPrice, stayForADayPrice, stayPerHourPrice, name);
            }

            if (markerId >= 3 && markerId <= 40)
            {
                string capacity = column1TextBox.Text;
                string workingHours = column2TextBox.Text;
                string chargerName = markerController.GetNameById(markerId);
                markerController.UpdateChargingStations(capacity, workingHours, chargerName);
            }
        }

        private void burgasGMapControl_Load(object sender, EventArgs e)
        {
            if (isAdmin == true)
            {
                column1TextBox.Enabled = true;
                column2TextBox.Enabled = true;
                column3TextBox.Enabled = true;
                column4TextBox.Enabled = true;
            }
        }
    }
}
