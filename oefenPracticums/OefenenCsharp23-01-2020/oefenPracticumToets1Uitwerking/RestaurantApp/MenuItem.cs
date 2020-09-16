using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class MenuItem
    {
        public string Naam { get; set; }
        public decimal Prijs { get; set; }

        public MenuItem(string naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

    }
    
}
