using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watersport
{
    class Program
    {
        static void Main(string[] args)
        {
            Boot boot = new Boot("Druppie");
            boot.Snelheid = 40;
            //boot.Sturen = "rechts";

            Speedboot sb = new Speedboot("Druppie");
            //sb.Sturen = "Links";
            
            Console.WriteLine(boot);
            Console.WriteLine(sb);
        }
    }

    class Boot
    {
        public Boot(string naam)
        {
            Naam = naam;
        }

        public Boot(int snelheid)
        {
            Snelheid = snelheid;
        }

        public int Snelheid { get; set; }

        //public string Naam { get; set; }

        private string naam;

        public string Naam
        {
            get
            {
                return $"De naam is: {naam}";
            }
            set
            {
                if(value.Length < 3)
                {
                    throw new Exception("De naam mag niet korter zijn dan 3 tekens.");
                }
                if(value.IndexOf("  ") > -1) {
                    throw new Exception("Er mogen niet twee spaties er in zitten!");
                }
                naam = value;
            }
        }

        public virtual void Sturen(string richting)
        {
            Console.WriteLine($"De boot stuurt naar {richting}");
        }

        public override string ToString()
        {
            return $"{Naam}. Snelheid: {Snelheid}";
        }
    }

    class Speedboot : Boot
    {
        public Speedboot(string naam) : base(naam)
        {

        }

        public override void Sturen (string richting)
        {
            Console.WriteLine($"De boot stuurt heel snel naar {richting}");
        }
    }

    class Zeilboot : Boot
    {
        public int Zeiloppervlak { get; set; }

        public Zeilboot(string naam) : base(naam)
        {

        }

        public Zeilboot(int snelheid) : this("geen naam")
        {
            Snelheid = snelheid;
        }

        public Zeilboot(int snelheid, int zeiloppervlak) : this(snelheid)
        {
            Zeiloppervlak = zeiloppervlak;
        }
    }
}