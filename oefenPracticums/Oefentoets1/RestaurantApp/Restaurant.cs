using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    delegate void Besteld(MenuItem item); //Daarna deze.

    class Restaurant //Publisher
    {
        public event Besteld ItemBesteld; //Eerst maak je deze event

        public void Bestel(MenuItem item)
        {
            if(ItemBesteld != null) //Dit moet erbij, anders punten aftrek
            {
                ItemBesteld(item); //Dit als laatst
            }
        }
    }
}
