using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using AspGoogleMap.Models;

namespace AspGoogleMap
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {                
                GLatLng mainLocation = new GLatLng(34.0477964, -118.2581307);

                GMap1.setCenter(mainLocation, 14);

                XPinLetter xpinLetter = new XPinLetter(PinShapes.pin_star, "H", Color.Blue, Color.White, Color.Chocolate);
                GMap1.Add(new GMarker(mainLocation, new GMarkerOptions(new GIcon(xpinLetter.ToString(), xpinLetter.Shadow()))));

                List<HotelMaster> hotels = new List<HotelMaster>();
                using (HotelDatabaseEntities dc = new HotelDatabaseEntities())
                {
                    hotels = dc.HotelMasters.Where(a => a.HotelArea.Equals("Los Angeles Downtown")).ToList();
                }

                PinIcon p;
                GMarker gm;
                GInfoWindow win;
                foreach(var i in hotels)
                {
                    p = new PinIcon(PinIcons.home, Color.Cyan);
                    gm = new GMarker(new GLatLng(Convert.ToDouble(i.LocLat), Convert.ToDouble(i.LocLong)), new GMarkerOptions(new GIcon(p.ToString(), p.Shadow())));

                    win = new GInfoWindow(gm, i.HotelName + "<a href='"+i.ReadMoreUrl+"'> Read more...</a>", false, GListener.Event.mouseover);
                    GMap1.Add(win);
                }
            }
        }
    }
}