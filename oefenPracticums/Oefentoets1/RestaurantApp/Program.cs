using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var keuken = new Keuken();
            var tosti = new MenuItem("tosti", 5.50m);
            var wrap = new MenuItem("wrap", 6.50m);
            
            //Restaurant is de publisher
            var t1 = new Restaurant();
            t1.ItemBesteld += keuken.Maak; //Gaf overload error voor Maak dat matched met delegete Besteld.

            t1.Bestel(tosti);
            t1.Bestel(wrap);
        }
    }
}
