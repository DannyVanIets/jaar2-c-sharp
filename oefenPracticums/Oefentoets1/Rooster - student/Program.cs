using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooster___student
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Docent nanja = new Docent("VSN01", "Nanja Vos");
            Docent eltjo = new Docent("VEE02", "Eltjo Voorhoeve");
            Docent freek = new Docent("JEF01", "Freek de Jonge");
            Klas se1a = new Klas("ICT.SE1a");
            Klas se1b = new Klas("ICT.SE1b");

            Console.WriteLine("\n===== Opgave 1a+b =====");
            Console.WriteLine(nanja);
            Console.WriteLine(se1a);


            // Opgave 1c

            DateTime d = new DateTime(2015, 9, 16);
            Roostermoment m1 = new Roostermoment(nanja, se1a, "Coaching", d, 5);
            Roostermoment m2 = new Roostermoment(freek, se1a, "C#", d, 7);
            Roostermoment m3 = new Roostermoment(eltjo, se1a, "Scrum", d, 8);
            Roostermoment m4 = new Roostermoment(freek, se1b, "C#", d, 8);

            Roostermoment m5 = new Roostermoment(freek, se1b, "UML", d, 13);


            Console.WriteLine("\n===== Opgave 1c =====");
            Console.WriteLine(m1);
            Console.WriteLine(m5);

            Rooster se1a_rooster = new Rooster(se1a);
            Rooster freek_rooster = new Rooster(freek);


            // Opgave 1e+f

            se1a_rooster.Plus(m1);
            se1a_rooster.Plus(m2);
            se1a_rooster.Plus(m3);
            Console.WriteLine("\n===== Opgave 1e+f =====");
            Console.WriteLine(se1a_rooster);


            // Opgave 1g

            freek_rooster.Plus(m2);
            freek_rooster.Plus(m4);

            Console.WriteLine("\n===== Opgave 1g (stap 1) =====");
            Console.WriteLine(se1a_rooster.GeefRoosterMomentOpUur(5));
            Console.WriteLine("\n===== Opgave 1g (stap 2) =====");
            for (int i = 1; i <= 10; i++)
                if (freek_rooster.GeefRoosterMomentOpUur(i) != null)
                    Console.WriteLine(freek_rooster.GeefRoosterMomentOpUur(i));

            
        }
    }
}
