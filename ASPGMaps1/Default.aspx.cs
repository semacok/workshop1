using Subgurim.Controles;
using Subgurim.Controles.GoogleChartIconMaker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPGMaps1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GLatlng mainlocation = new GLatlng(12.1234, 23.1234);
                GMap1.setCenter(mainlocation, 14);
                
                XPinLetter xpinLetter = new XPinLetter(PinShapes.pin_star, "H", System.Drawing.Color.Blue, System.Drawing.Color.White, System.Drawing.Color.Brown );
                GMap1.Add(new GMarker (mainlocation, new GMarkerOptions(new GIcon(xpinLetter, ToString(), xpinLetter.Shadow()))));

                List<IlanMaster> ilanlar = new List<IlanMaster>();
                using (MyDatabaseEntities dc = new MyDatabaseEntities())
                {
                    ilanlar = dc.IlanMasters.Where(a => a.IlanArea.Equals("Istanbul")).ToList();
                }
                PinIcon p;
                GMarker gm;
                GInfoWindow win;
                foreach (var I in ilanlar)
                {
                    p = new PinIcon(PinIcons.home, System.Drawing.Color.Cyan);
                    gm = new GMarker(new GLatLng(Convert.ToDouble(I.LocLat), Convert.ToDouble(I.LocLong)),
                        new GMarkerOptions(new GIcon(p.ToString(), p.Shadow())));

                    win = new GInfoWindow(gm, I.IlanName + "<a href = ' " + I.ReadMoreUrl + "'+Read more.../a>", false, GListener.Event.mouseover);
                    GMap1.Add(win);
                }
            }
        }
    }
}