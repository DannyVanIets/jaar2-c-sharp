using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Uitwerking
{
    class Roostermoment
    {
        
        public Docent Docent { get; set; }
        public Klas Klas { get; set; }

        public string Vak { get; set; }
        public DateTime Datum { get; set; }

        private int uur;
        public int Uur
        {
            get
            {
                return uur;
            }
            set
            {
                uur = value;
                if (value < 1 || value > 12)
                {
                    uur = 0;
                }
            }
        }

        public Roostermoment(Docent doc, Klas klas, string vak, DateTime datum, int uur)
        {
            Docent = doc;
            Klas = klas;
            Vak = vak;
            Datum = datum;
            Uur = uur;
        }
        public override string ToString()
        {
            string datumS = Datum.Date.ToString("d");
            return $"{datumS}  {Uur}  {Klas}  {Docent}\t{Vak}";
        }
    }
}
