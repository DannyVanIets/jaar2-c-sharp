using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public abstract class Vastgoed
    {
        private int kavelNummer;

        public int KavelNummer
        {
            get
            {
                return kavelNummer;
            }
            set
            {
                if (value >= 1000 || value < 1)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} moet tussen de 0 en de 1000 zijn!");
                }
                kavelNummer = value;
            }
        }
        public int MinimumPrijs { get; set; }

        public string Details()
        {
            return $"Kavelnummer:{KavelNummer}, Minimumprijs: {MinimumPrijs}";
        }
    }
}
