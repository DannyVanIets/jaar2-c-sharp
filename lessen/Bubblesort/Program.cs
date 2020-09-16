using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] items = new int[] { 5, 1, 3, 7, 6 };
            Bubblesort(items, GreaterThan);
        }

        public delegate bool ComparisonHandler(int first, int second);

        public static bool GreaterThan(int first, int second)
        {
            return first > second;
        }

        public static void Bubblesort(int[] items, ComparisonHandler ch)
        {
            int i; int j; int temp;
            if(items == null)
            {
                return;
            }

            for(i = items.Length - 1; i >= 0; i--)
            {
                for(j = 1; j <= i; j++)
                {
                    if(ch(items[j - 1], items[j]))
                    {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }

            foreach(int ic in items)
            {
                Console.WriteLine($"{ic}");
            }
        }
    }
}
