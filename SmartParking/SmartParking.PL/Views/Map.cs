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
            markersOverlay.Markers.Add(parkingLargeMarker1);

            GMarkerGoogle parkingLargeMarker2 = new GMarkerGoogle(
                    new PointLatLng(markerController.GetLatitudeById(2), markerController.GetLongitudeById(2)),
                    parkingLargeMarker);
            markersOverlay.Markers.Add(parkingLargeMarker2);

            GMarkerGoogle chargerDC1 = new GMarkerGoogle(
                    new PointLatLng(markerController.GetLatitudeById(3), markerController.GetLongitudeById(3)),
                    chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC1);

            GMarkerGoogle chargerDC2 = new GMarkerGoogle(
                    new PointLatLng(markerController.GetLatitudeById(4), markerController.GetLongitudeById(4)),
                    chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC2);

            GMarkerGoogle chargerDC3 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(5), markerController.GetLongitudeById(5)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC3);

            GMarkerGoogle chargerDC4 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(6), markerController.GetLongitudeById(6)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC4);

            GMarkerGoogle chargerDC5 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(7), markerController.GetLongitudeById(7)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC5);

            GMarkerGoogle chargerDC6 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(8), markerController.GetLongitudeById(8)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC6);

            GMarkerGoogle chargerDC7 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(9), markerController.GetLongitudeById(9)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC7);

            GMarkerGoogle chargerDC8 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(10), markerController.GetLongitudeById(10)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC8);

            GMarkerGoogle chargerDC9 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(11), markerController.GetLongitudeById(11)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC9);

            GMarkerGoogle chargerDC10 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(12), markerController.GetLongitudeById(12)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC10);

            GMarkerGoogle chargerDC11 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(13), markerController.GetLongitudeById(13)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC11);

            GMarkerGoogle chargerDC12 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(14), markerController.GetLongitudeById(14)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC12);

            GMarkerGoogle chargerDC13 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(15), markerController.GetLongitudeById(15)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC13);

            GMarkerGoogle chargerDC14 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(16), markerController.GetLongitudeById(16)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC14);

            GMarkerGoogle chargerDC15 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(17), markerController.GetLongitudeById(17)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC15);

            GMarkerGoogle chargerDC16 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(18), markerController.GetLongitudeById(18)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC16);

            GMarkerGoogle chargerDC17 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(19), markerController.GetLongitudeById(19)),
                   chargerDCMarker);
            markersOverlay.Markers.Add(chargerDC17);

            GMarkerGoogle chargerAC1 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(20), markerController.GetLongitudeById(20)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC1);

            GMarkerGoogle chargerAC2 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(21), markerController.GetLongitudeById(21)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC2);

            GMarkerGoogle chargerAC3 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(22), markerController.GetLongitudeById(22)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC3);

            GMarkerGoogle chargerAC4 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(23), markerController.GetLongitudeById(23)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC4);

            GMarkerGoogle chargerAC5 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(24), markerController.GetLongitudeById(24)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC5);

            GMarkerGoogle chargerAC6 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(25), markerController.GetLongitudeById(25)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC6);

            GMarkerGoogle chargerAC7 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(26), markerController.GetLongitudeById(26)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC7);

            GMarkerGoogle chargerAC8 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(27), markerController.GetLongitudeById(27)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC8);

            GMarkerGoogle chargerAC9 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(28), markerController.GetLongitudeById(28)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC9);

            GMarkerGoogle chargerAC10 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(29), markerController.GetLongitudeById(29)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC10);

            GMarkerGoogle chargerAC11 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(30), markerController.GetLongitudeById(30)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC11);

            GMarkerGoogle chargerAC12 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(31), markerController.GetLongitudeById(31)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC12);

            GMarkerGoogle chargerAC13 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(32), markerController.GetLongitudeById(32)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC13);

            GMarkerGoogle chargerAC14 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(33), markerController.GetLongitudeById(33)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC14);

            GMarkerGoogle chargerAC15 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(34), markerController.GetLongitudeById(34)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC15);

            GMarkerGoogle chargerAC16 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(35), markerController.GetLongitudeById(35)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC16);

            GMarkerGoogle chargerAC17 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(36), markerController.GetLongitudeById(36)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC17);

            GMarkerGoogle chargerAC18 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(37), markerController.GetLongitudeById(37)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC18);

            GMarkerGoogle chargerAC19 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(38), markerController.GetLongitudeById(38)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC19);

            GMarkerGoogle chargerAC20 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(39), markerController.GetLongitudeById(39)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC20);

            GMarkerGoogle chargerAC21 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(40), markerController.GetLongitudeById(40)),
                   chargerACMarker);
            markersOverlay.Markers.Add(chargerAC21);

            GMarkerGoogle parkingDisabled1 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(41), markerController.GetLongitudeById(41)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled1);

            GMarkerGoogle parkingDisabled2 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(42), markerController.GetLongitudeById(42)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled2);

            GMarkerGoogle parkingDisabled3 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(43), markerController.GetLongitudeById(43)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled3);

            GMarkerGoogle parkingDisabled4 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(44), markerController.GetLongitudeById(44)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled4);

            GMarkerGoogle parkingDisabled5 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(45), markerController.GetLongitudeById(45)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled5);

            GMarkerGoogle parkingDisabled6 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(46), markerController.GetLongitudeById(46)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled6);

            GMarkerGoogle parkingDisabled7 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(47), markerController.GetLongitudeById(47)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled7);

            GMarkerGoogle parkingDisabled8 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(48), markerController.GetLongitudeById(48)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled8);

            GMarkerGoogle parkingDisabled9 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(49), markerController.GetLongitudeById(49)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled9);

            GMarkerGoogle parkingDisabled10 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(50), markerController.GetLongitudeById(50)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled10);

            GMarkerGoogle parkingDisabled11 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(51), markerController.GetLongitudeById(51)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled11);

            GMarkerGoogle parkingDisabled12 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(52), markerController.GetLongitudeById(52)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled12);

            GMarkerGoogle parkingDisabled13 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(53), markerController.GetLongitudeById(53)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled13);

            GMarkerGoogle parkingDisabled14 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(54), markerController.GetLongitudeById(54)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled14);

            GMarkerGoogle parkingDisabled15 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(55), markerController.GetLongitudeById(55)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled15);

            GMarkerGoogle parkingDisabled16 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(56), markerController.GetLongitudeById(56)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled16);

            GMarkerGoogle parkingDisabled17 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(57), markerController.GetLongitudeById(57)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled17);

            GMarkerGoogle parkingDisabled18 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(58), markerController.GetLongitudeById(58)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled18);

            GMarkerGoogle parkingDisabled19 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(59), markerController.GetLongitudeById(59)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled19);

            GMarkerGoogle parkingDisabled20 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(60), markerController.GetLongitudeById(60)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled20);

            GMarkerGoogle parkingDisabled21 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(61), markerController.GetLongitudeById(61)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled21);

            GMarkerGoogle parkingDisabled22 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(62), markerController.GetLongitudeById(62)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled22);

            GMarkerGoogle parkingDisabled23 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(63), markerController.GetLongitudeById(63)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled23);

            GMarkerGoogle parkingDisabled24 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(64), markerController.GetLongitudeById(64)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled24);

            GMarkerGoogle parkingDisabled25 = new GMarkerGoogle(
                   new PointLatLng(markerController.GetLatitudeById(65), markerController.GetLongitudeById(65)),
                   parkingDisabledMarker);
            markersOverlay.Markers.Add(parkingDisabled25);

            burgasGMapControl.Refresh();
        }
    }
}
