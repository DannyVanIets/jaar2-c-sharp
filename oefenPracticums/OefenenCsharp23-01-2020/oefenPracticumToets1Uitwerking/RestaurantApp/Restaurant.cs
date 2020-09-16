using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    delegate void Besteld(MenuItem item);

    class Restaurant
    {
        public event Besteld ItemBesteld;
 
        public void Bestel(MenuItem item)
        {
            OnItemBesteld(item);
        }

        public void OnItemBesteld(MenuItem item)
        {
            ItemBesteld?.Invoke(item);
        }

    }
}
