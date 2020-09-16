using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class Rekening
    {
        private List<MenuItem> items = new List<MenuItem>();

        public void VoegToe(MenuItem item)
        {
            items.Add(item);
        }

        public decimal Totaalbedrag {
            get
            {
                decimal totaal = 0;
                foreach (var item in items)
                {
                    totaal += item.Prijs;
                }
                return totaal;
            }
        }
    }
}
