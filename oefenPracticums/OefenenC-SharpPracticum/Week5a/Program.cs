using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5a
{
    class Program
    {
        public enum Bloedgroep { AB, A, B, O };

        static void Main(string[] args)
        {
            TemperatuurMetingen();
            Console.WriteLine("RectangularArray: ");
            TemperatuurRectangularArrays();
            Console.WriteLine("Jaggedarray: ");
            TemperatuurJaggedArrays();
            Bloedgroep donor = Bloedgroep.B;
            Bloedgroep ontvanger = Bloedgroep.B;

            if (KanGeven(donor, ontvanger))
            {
                Console.WriteLine($"Bloedgroep {donor} kan geven aan {ontvanger}");
            }
            else
            {
                Console.WriteLine($"Bloedgroep {donor} kan NIET geven aan {ontvanger}");
            }
        }

        public static bool KanGeven(Bloedgroep donor, Bloedgroep ontvanger)
        {
            switch (donor)
            {
                case Bloedgroep.A:
                    return ontvanger == Bloedgroep.A || ontvanger == Bloedgroep.AB;
                    break;
                case Bloedgroep.B:
                    return ontvanger == Bloedgroep.B || ontvanger == Bloedgroep.AB;
                    break;
                case Bloedgroep.AB:
                    return ontvanger == Bloedgroep.AB;
                    break;
                case Bloedgroep.O:
                    return ontvanger == Bloedgroep.A || ontvanger == Bloedgroep.B || ontvanger == Bloedgroep.AB;
                    break;
            }
            return false;
        }

        public static void TemperatuurJaggedArrays()
        {
            int[][] temperatuurMeting = { new int [] { 21, 19, 17, 23, 25, 25, 28 },
                                       new int[] { 27, 27, 25, 22, 20, 10, 20 },
                                       new int[] { 21, 23, 23 } };

            for (int i = 0; i < temperatuurMeting.GetLength(0); i++)
            {
                for (int j = 0; j < temperatuurMeting[i].Length; j++)
                {
                    Console.Write($"{temperatuurMeting[i][j]}   ");
                }
                Console.WriteLine();
            }
        }

        public static void TemperatuurRectangularArrays()
        {
            int[,] temperatuurMeting = { { 21, 19, 17, 23, 25, 25, 28 },
                                       { 27, 27, 25, 22, 20, 10, 20 },
                                       { 21, 23, 23, 26, 29, 21, 25 } };

            for (int i = 0; i < temperatuurMeting.GetLength(0); i++)
            {
                for (int j = 0; j < temperatuurMeting.GetLength(1); j++)
                {
                    Console.Write($"{temperatuurMeting[i, j]}   ");
                }
                Console.WriteLine();
            }
        }

        public static void TemperatuurMetingen()
        {
            int[] temperatuurMeting = new int[] { 21, 19, 17, 23, 25, 25, 28 };

            foreach (int i in temperatuurMeting)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"Gemiddelde: {Gemiddelde(temperatuurMeting)}");
        }

        public static int Gemiddelde(int[] array)
        {
            return array.Sum() / array.Length;
        }
    }
}
