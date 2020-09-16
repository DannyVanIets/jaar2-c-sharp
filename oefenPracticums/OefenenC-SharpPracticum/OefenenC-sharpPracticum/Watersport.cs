using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1b
{
    class Animal { }

    class Olifant : Animal { }

    class Leeuw : Animal { }


    class Watersport
    {
        static void Main(string[] args)
        {
            Olifant o = new Olifant();
            Leeuw l = new Leeuw();

            Animal a = o;
            Olifant o3 = (Olifant)a;

            int i = 10;
            double d = i;

            Speedboot boot = new Speedboot(50, "gaaf");
            Boot boot2 = new Boot("gaaf");
            Console.WriteLine($"{boot.Snelheid}, {boot.naam}");
            boot.Sturen("rechts");
            boot2.Sturen("links");
        }

        class Speedboot : Boot
        {
            public Speedboot(int snelheid, string name) : base(name)
            {
                Snelheid = snelheid;
            }

            public override void Sturen(string richting)
            {
                Console.WriteLine($"De boot stuurt heel snel naar {richting}");
            }
        }

        public class Boot
        {
            public int Snelheid { get; set; } // Krijg je door prop en dan twee keer tab te doen.
            private string Naam;

            public string naam
            {
                set
                {
                    if(value.Length < 4)
                    {
                        throw new ArgumentOutOfRangeException($"{nameof(value)} moet groter zijn dan 3 tekens.");
                    }
                    Naam = value;
                }
                get
                {
                    return $"De naam is: {Naam}";
                }
            }

            public Boot(string name)
            {
                naam = name;
            }

            public virtual void Sturen(string richting)
            {
                Console.WriteLine($"De boot stuurt naar {richting}");
            }
        }
    }
}
