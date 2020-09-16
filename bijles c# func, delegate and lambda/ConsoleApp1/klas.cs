using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class klas
    {
        public List<string> voornamen = new List<string>();

        public klas()
        {
            voornamen.Add("Tom");
            voornamen.Add("Jan");
            voornamen.Add("Danny");
        }

        public List<string> CheckOfNamenBestaan(string voornaam)
        {
            //Kan ook var namenDieOvereenKomen inplaats van IEnumerable<string> namenDieOvereenKomen.
            IEnumerable<string> namenDieOvereenKomen =
            from naam in voornamen
            where naam == voornaam
            select naam;

            foreach (string naam in namenDieOvereenKomen) {
                Console.WriteLine(naam);
            }

            //return voornamen.Where(s => s == voornaam).ToList(); Deze is vooral LAMBDA.

            return namenDieOvereenKomen.ToList();
        }

        public bool NaamIs(string naam)
        {
            return naam == "Danny" || naam.ToLower().Contains('m');
        }

        public List<string> VindMetFunc(Func<string, bool> predicaat)
        {
            List<string> alleNamen = new List<string>();

            foreach(string naam in voornamen)
            {
                if (predicaat(naam))
                {
                    alleNamen.Add(naam);
                    Console.WriteLine(naam);
                }            
            }

            return alleNamen;

            /*
            var studenten =
                from student in voornamen
                where predicaat(student)
                select student;

            return studenten.ToList();
            */
        }
    }
}
