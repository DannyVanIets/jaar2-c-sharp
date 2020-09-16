using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = new string[] { "wat", "een", "prachtige", "dag" };

            Console.WriteLine(StringBewerkingen.MaakZinVanWoorden(strings));
            Console.ReadKey();
        }
    }
}
