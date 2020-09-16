using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooster___student
{
    class Rooster
    {
        public Gebruiker Gebruiker { get; set; }
        public List<Roostermoment> momenten = new List<Roostermoment>();

        public Rooster(Gebruiker gebruiker)
        {
            Gebruiker = gebruiker;
        }

        public void Plus(Roostermoment rm)
        {
            momenten.Add(rm);
        }

        public string GeefRoosterMomentOpUur(int uur)
        {
            foreach (Roostermoment moment in momenten)
            {
                if(moment.Uur == uur)
                {
                    return moment.ToString();
                }
            }
            return null;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Roostermoment moment in momenten)
            {
                result += moment.ToString() + "\n";
            }
            return result;
        }
    }
}
