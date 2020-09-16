using System;
using System.Threading;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool[,] nieuwBord = new bool[,]
            {
                { false,false,false,false,false,false,false,false,false, false, false},
                { false,false,false,false,false,false,false,false,false, false, false},
                { false,false,false,false,false,false,false,false,false, false, false},
                { false,false,false,false,true,true,true,false,false, false, false},
                { false,false,false,false,false,true,false,false,false, false, false},
                { false,false,false,false,false,true,false,false,false, false, false},
                { false,false,false,false,true,true,true,false,false, false, false},
                { false,false,false,false,false,false,false,false,false, false, false},
                { false,false,false,false,true,true,true,false,false, false, false},
                { false,false,false,false,true,true,true,false,false, false, false},
                { false,false,false,false,false,false,false,false,false, false, false},
                { false,false,false,false,true,true,true,false,false, false, false},
                { false,false,false,false,false,true,false,false,false, false, false},
                { false,false,false,false,false,true,false,false,false, false, false},
                { false,false,false,false,true,true,true,false,false, false, false},
                { false,false,false,false,false,false,false,false,false, false, false},
                { false,false,false,false,false,false,false,false,false, false, false},
                { false,false,false,false,false,false,false,false,false, false, false}
            };

            Simulatie simulatie = new Simulatie(nieuwBord);

            for(int i = 0; i < 200; i++)
            {
                Console.Clear();
                Console.Write(simulatie.ToString());
                simulatie.VolgendeStap();
                Thread.Sleep(500);
            }
            
        }
    }
}
