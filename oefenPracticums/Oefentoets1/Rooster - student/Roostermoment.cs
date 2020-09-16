using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooster___student
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
                if (value >= 1 && value <= 12)
                {
                    uur = value;
                }
                else
                {
                    uur = 0;
                }
            }
        }

        public Roostermoment(Docent docent, Klas klas, string vak, DateTime datum, int uren)
        {
            Docent = docent;
            Klas = klas;
            Vak = vak;
            Datum = datum;
            Uur = uren;
        }

        public override string ToString()
        {
            return $"{Datum.ToString("d")}    {uur}   {Klas}  {Docent}    {Vak}";
        }
    }
}
