using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking
{
    class Rooster
    {
        private List<Roostermoment> momenten;
        public Gebruiker Gebruiker { get; set; }

        public Rooster(Gebruiker gebruiker)
        {
            Gebruiker = gebruiker;
            momenten = new List<Roostermoment>();
        }

        public void Plus(Roostermoment moment)
        {
            momenten.Add(moment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("Gebruiker: ");
            sb.AppendLine(Gebruiker.ToString());
            foreach (Roostermoment moment in momenten)
            {
                sb.AppendLine(moment.ToString());
            }
            return sb.ToString();
        }

        public Roostermoment GeefRoosterMomentOpUur(int uur)
        {
            foreach (Roostermoment moment in momenten)
            {
                if (moment.Uur == uur)
                {
                    return moment;

                }
            }
            return null;
        }
    }
}
