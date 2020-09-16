using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5a
{
    class Program
    {
        public enum Bloedgroep { AB, A, B, O }

        static void Main(string[] args)
        {
            /*int[] nummers = { 1, 2, 3, 4 };
            int[] nummers2 = new int[] { 4, 5, 6, 7 };
            int[] nummers3 = new int[5];

            int[] temperaturen = { 21, 19, 17, 23, 25, 25, 28 };

            //nummers[4] = 5;
            //Console.WriteLine(nummers[4]);

            for (int i = 0; i < nummers.Length; i++)
            {
                Console.WriteLine(nummers[i]);
            }

            foreach(int nummer in nummers)
            {
                Console.WriteLine(nummer);
            }

            Console.WriteLine(Gemdiddeld(temperaturen));
            Console.WriteLine(temperaturen[0]);

            string[] rij1 = { "kruisje", "niet gezet", "rondje" };
            string[] rij2 = { "niet gezet", "rondje", "niet gezet" };
            string[] rij3 = { "rondje", "niet gezet", "kruisje" };

            string[,] speelbord = {
                { "kruisje", "niet gezet", "rondje" },
                { "rondje", "niet gezet", "kruisje" },
                { "niet gezet", "rondje", "niet gezet" },
                { "rondje", "niet gezet", "kruisje" }
            };*/

            int[,] temperatuurmetingen = {
                { 21, 19, 17, 23, 25, 25, 28 },
                { 27, 27, 25, 22, 20, 10, 20 },
                { 21, 23, 23, -274, -274, -274, -274 }
            };

            for(int i = 0; i < temperatuurmetingen.GetLength(0); i++)
            {
                for (int j = 0; j < temperatuurmetingen.GetLength(1); j++)
                {
                    if(temperatuurmetingen[i, j] != -274)
                    {
                        Console.Write($"{temperatuurmetingen[i, j]} ");
                    }
                }
                Console.WriteLine();
            }

            int[][] jaggedTemperatuur = {
                new int[] { 21, 19, 17, 23, 25, 25, 28 },
                new int[] { 27, 27, 25, 22, 20, 10, 20 },
                new int[] { 21, 23, 23, -274, -274, -274, -274 }
            };

            for (int i = 0; i < jaggedTemperatuur.GetLength(0); i++)
            {
                for (int j = 0; j < jaggedTemperatuur[i].Length; j++)
                {
                    if (jaggedTemperatuur[i][j] != -274)
                    {
                        Console.Write($"{jaggedTemperatuur[i][j]} ");
                    }
                }
                Console.WriteLine();
            }
            Bloedgroep a = Bloedgroep.A;
            Bloedgroep b = Bloedgroep.B;

            Console.WriteLine($"De donor {a} en de ontvanger {b} zijn {KanGeven(a, b)}");
        }

        public static bool KanGeven(Bloedgroep donor, Bloedgroep ontvanger)
        {
            switch (donor)
            {
                case Bloedgroep.AB:
                    return ontvanger == Bloedgroep.AB;
                case Bloedgroep.A:
                    return ontvanger == Bloedgroep.A || ontvanger == Bloedgroep.AB;
                case Bloedgroep.B:
                    return ontvanger == Bloedgroep.B || ontvanger == Bloedgroep.AB;
                case Bloedgroep.O:
                    return true;
                default:
                    return false;
            }
        }

        public static int Gemdiddeld(int[] temperaturen)
        {
            temperaturen[0] = 600;

            /*int sum = 0;

            foreach(int temp in temperaturen)
            {
                sum += temp;
            }*/

            return temperaturen.Sum() / temperaturen.Length;
        }
    }
}
