using System;
using System.Collections.Generic;

namespace Opgave1
{
    public enum WoningType { Tussenwoning, Vrijstaand }
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1b
            List<Vastgoed> v = new List<Vastgoed>
            {
                new Huis(WoningType.Tussenwoning, 1){ MinimumPrijs = 100000},
                new Huis(2){ MinimumPrijs = 2000000},
                new Huis(WoningType.Vrijstaand, 3){ MinimumPrijs = 3000000},
                new Garage(250, 4){ MinimumPrijs = 10000}
            };
            foreach(var vg in v)
            {
                if(vg is Garage)
                {
                    var g = (Garage)vg;
                    Console.WriteLine(g.Details() + "\n");
                }
                else
                {
                    Console.WriteLine(vg.Details() + "\n");
                }

            }

            //Opgave 1c
            //var h1 = new Huis(0); //throws ArgumentOutOfRangeException
            //var h2 = new Huis(1000); //throws ArgumentOutOfRangeException
            //var h3 = new Huis(1001); //throws ArgumentOutOfRangeException

            //Opgave 1g
            var makelaar = new Makelaar();
            var vastgoed = new Huis(WoningType.Tussenwoning, 7);
            vastgoed.MinimumPrijs = 10;
            var eigenaar = new Eigenaar(makelaar) { Naam = "Marjo" };
            makelaar.Bieden(25, vastgoed);
        }
    }
}