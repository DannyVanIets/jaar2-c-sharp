using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public class Garage : Vastgoed
    {
        public int Inhoud { get; set; }

        public Garage(int inhoud, int kavelNummer)
        {
            Inhoud = inhoud;
            KavelNummer = kavelNummer;
        }

        public new string Details()
        {
            return $"Kavelnummer:{KavelNummer}, Minimumprijs: {MinimumPrijs}, Inhoud: {Inhoud}";
        }
    }
}
