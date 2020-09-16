using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public class Eigenaar
    {
        private Makelaar makelaar;

        public Eigenaar(Makelaar makelaar)
        {
            this.makelaar = makelaar;
        }

        public string Naam { get; set; }
        public Vastgoed Vastgoed { get; set; }

        public void VastgoedIsVerkocht(object sender, EventArgs e)
        {
            Console.WriteLine($"{Naam} is blij, het vastgoed is verkocht voor ?? euro (kavelnr.:{Vastgoed.KavelNummer})");
        }
    }
}
