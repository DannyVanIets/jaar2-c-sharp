using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenten = new List<Student> {
                new Student("Jager", "Hermen", new int[] { 5, 9, 3, 6 }),
                new Student("Bosman", "Fenne", new int[] { 3, 2, 6, 7 }),
                new Student("Bakker", "Fenne", new int[] { 1, 4, 6 }),
                new Student("Jansen", "Jan", new int[] { 9, 8 }),
                new Student("Taekema", "Taeke", new int[] { 8, 7, 7 }),
                new Student("Daniel", "Daniel", new int[] { 9, 9, 9 })
            };

            // Opdracht a
            Console.WriteLine("achternamen gesorteerd: ");
            var selectieAchternamen = ...;
            foreach (string achternaam in selectieAchternamen)
                Console.WriteLine(achternaam);
            Console.WriteLine();

            // Opdracht b
            var selectie2Studenten = ...
            SchrijfStudentenLijst("achternaam is gelijk aan voornaam", selectie2Studenten);

            // Opdracht c
            selectie2Studenten = ...
            SchrijfStudentenLijst("studenten met meer dan drie cijfers", selectie2Studenten);

            // Opdracht d
            selectie2Studenten = ...
            SchrijfStudentenLijst("student heeft een cijfer groter of gelijk aan 9", selectie2Studenten);

            // Opdracht e
            var achternamenMetGemiddelde = ...
            Console.WriteLine("gemiddeld cijfer: ");
            foreach (var element in achternamenMetGemiddelde)
                Console.WriteLine(element);

            Console.ReadKey();

        }

        static void SchrijfStudentenLijst(string tekst, IEnumerable<Student> studenten)
        {
            Console.WriteLine(tekst + ": ");
            foreach (Student student in studenten)
                Console.WriteLine(student);
            Console.WriteLine();
        }

    }
}
