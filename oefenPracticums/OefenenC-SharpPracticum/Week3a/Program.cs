using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3a
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintValues pv = new PrintValues();
            int[] items = new int[] {6, 5, 3, 1, 8, 7, 2, 4};
            BubbleSort(items, GreaterThan);
        }

        public delegate bool ComparisionHandler(int first, int second);

        public static void BubbleSort(int[] items, ComparisionHandler ch)
        {
            int i;
            int j;
            int temp;

            if (items == null)
            {
                return;
            }

            for (i = items.Length - 1; i >= 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (ch(items[j - 1], items[j]))
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }

            foreach(int k in items)
            {
                Console.WriteLine($"{k}");
            }
        }

        public static bool GreaterThan(int first, int second)
        {
            return first > second;
        }
    }

    public class PrintValues
    {
        public delegate void Print(int value);

        public PrintValues()
        {
            Print printDel = PrintNumber;
            printDel(200);
            printDel += PrintMoney;
            printDel(200);
        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}
