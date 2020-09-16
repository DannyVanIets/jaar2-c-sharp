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
            // Query syntax:
            var selectieAchternamen = from student in studenten
                                      orderby student.Achternaam
                                      select student.Achternaam;
            // Method syntax:
            //var selectieAchternamen = studenten.OrderBy(s => s.Achternaam).Select(s => s.Achternaam);
            foreach (string achternaam in selectieAchternamen)
                Console.WriteLine(achternaam);
            Console.WriteLine();

            // Opdracht b
            var selectieStudenten = from student in studenten
                                    where student.Achternaam.StartsWith(student.Voornaam)
                                    select student;
            // Method syntax:
            //var selectieStudenten = studenten.Where(s => s.Achternaam.StartsWith(student.Voornaam));
            SchrijfStudentenLijst("achternaam is gelijk aan voornaam", selectieStudenten);

            // Opdracht c
            // Query syntax:
            selectieStudenten = from student in studenten
                                where student.Cijfers.Length > 3
                                select student;
            // Method syntax:
            // selectieStudenten = studenten.Where(s => s.Cijfers.Length > 3);
            SchrijfStudentenLijst("studenten met meer dan drie cijfers", selectieStudenten);

            // Opdracht d
            // Query syntax:
            selectieStudenten = from student in studenten
                                where student.Cijfers.Any(c => c >= 9)
                                select student;
            // Method syntax:
            //selectieStudenten = studenten.Where(s => s.Cijfers.Any(c => c >= 9));
            SchrijfStudentenLijst("student heeft een cijfer groter of gelijk aan 9", selectieStudenten);

            // Opdracht e
            // Query syntax:
            var achternamenMetGemiddelde = from student in studenten
                                           let gemiddelde = student.Cijfers.Average()
                                           select new { student.Achternaam, gemiddelde };
            // Alternatief als je Average niet kent: 
            //var achternamenMetGemiddelde = from student in studenten
            //                               let gemiddelde = student.Cijfers.Sum() * 1.0 / student.Cijfers.Count()
            //                               select new { student.Achternaam, gemiddelde };
            // Method syntax:
            //var achternamenMetGemiddelde = studenten.Select(
            //    s => new { s.Achternaam, gemiddelde = s.Cijfers.Average() });
            // Alternatief als je Average niet kent: 
            //var achternamenMetGemiddelde = studenten.Select(
            //   s => new { s.Achternaam, gemiddelde = s.Cijfers.Sum() * 1.0 / s.Cijfers.Count() });
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
