using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp
{
    class MenuItem
    {
        public string Naam;
        public decimal Prijs;

        public MenuItem(string naam, decimal prijs)
        {
            Naam = naam;
            Prijs = prijs;
        }

        public override string ToString()
        {
            return $"{Naam} {Prijs}";
        }
    }
}
