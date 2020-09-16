using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public class Huis : Vastgoed
    {
        public WoningType WoningType { get; set; }

        public Huis(WoningType woningType, int kavelNummer)
        {
            WoningType = WoningType;
            KavelNummer = kavelNummer;
        }

        public Huis(int kavelNummer)
        {
            KavelNummer = kavelNummer;
        }

        public new string Details()
        {
            return $"Kavelnummer:{KavelNummer}, Minimumprijs: {MinimumPrijs}";
        }
    }
}
