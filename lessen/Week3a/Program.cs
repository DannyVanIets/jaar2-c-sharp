using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3a
{
    class President
    {
        public void Toespreken(string toespraak)
        {
            Console.WriteLine($"{toespraak.ToUpper()}");
        }
    }

    class VicePresident
    {
        public string Toespraak { get; set; }

        public void Toespreken(ToespraakHouden toespreken)
        {
            toespreken(Toespraak);
        }
    }

    public delegate void ToespraakHouden(string toespraak);

    class Program
    {
        static void Tweet(string tekst)
        {
            Console.WriteLine(tekst.Substring(0, Math.Min(40, tekst.Length)));
        }

        static void Main(string[] args)
        {
            /*Go go = DoeIets.Lopen;

            go();*/

            var donald = new President();
            var mike = new VicePresident();

            mike.Toespraak = "Nederland is het mooiste land. Want het is een erg mooi land.";

            mike.Toespreken(donald.Toespreken);

            ToespraakHouden t = donald.Toespreken;
            //t += Program.Tweet;
            //t = Program.Tweet;
            //t -= Program.Tweet;
            //t(mike.Toespraak);

            /*PrintValues pv = new PrintValues();
            pv.ToString();*/
        }
    }

    public delegate void Go();

    class DoeIets
    {
        public static void Lopen()
        {
            Console.WriteLine("Ik ben aan het lopen.");
        }
    }

    public class PrintValues
    {
        public delegate void Print(int value);

        public PrintValues()
        {
            Print PrintDel = PrintNumber;
            PrintDel(200);
            PrintDel += PrintMoney;
            PrintDel(200);
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
