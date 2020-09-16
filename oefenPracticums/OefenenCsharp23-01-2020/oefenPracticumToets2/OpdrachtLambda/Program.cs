using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtLambda
{
    class Program
    {
        // Voor opgave b onderstaande methode verwijderen uit de code!
        /*static List<int> SelectGetallenGroterDanNul(List<int> getallen)
        {
            List<int> result = new List<int>();
            foreach (int getal in getallen)
            {
                if (getal > 0)
                    result.Add(getal);
            }

            return result;
        }*/

        static List<int> SelectGetallenDeelbaarDoorElf(List<int> getallen)
        {
            List<int> result = new List<int>();
            foreach (int getal in getallen)
            {
                if (getal % 11 == 0)
                    result.Add(getal);
            }

            return result;
        }

        // Voor opgave a onderstaande delegate verwijderen uit de code!
        delegate List<int> SelectGetallen(List<int> getallen);

        static void Main(string[] args)
        {
            List<int> getallen = new List<int> {44, -55, 99, 34};

            //SelectGetallen selector1 = SelectGetallenGroterDanNul;
            //SelectGetallen selector2 = SelectGetallenDeelbaarDoorElf;

            // Opgave a (uitwerking vervangt bovenstaande twee regels code):
            Func<List<int>, List<int>> selector1 = SelectGetallenGroterDanNul;
            Func<List<int>, List<int>> selector2 = SelectGetallenDeelbaarDoorElf;

            // Opgave b (lambda expressie vervangt de methode SelectGetallenGroterDanNul)
            //selector1 = ..;

            // Opgave c 
            //selector1 = ..;

            // Selecteer getallen groter dan nul en deelbaar door elf
            List<int> geselecteerdeGetallen = selector2(selector1(getallen));

            Console.WriteLine("Geselecteerde getallen: ");
            foreach (int getal in geselecteerdeGetallen)
            {
                Console.Write($"{getal} ");
            }

            Console.ReadKey();
        }
    }
}
