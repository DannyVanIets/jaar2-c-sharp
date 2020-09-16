using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking
{

    interface KanZwemmen
    {
        void Zwem();
    }


    class Goudvis : KanZwemmen
    {
        public void Zwem()
        {
            Console.Write("(~~ >O ~~)");
        }
    }
    

    class Mens : KanZwemmen
    {
        public void Zwem()
        {
            Console.Write("~~ ^o^ ~~");
        }
    }


    class WaterSimulatie<T> where T : KanZwemmen
    {
        List<T> lijst = new List<T>();

        public void Add(T s)
        {
            lijst.Add(s);
        }

        public void Simuleer()
        {
            for (int i = 0; i < 3; i++)
            {
                foreach (var swimmer in lijst)
                {
                    swimmer.Zwem();
                }
            }
            Console.WriteLine();
        }
    }

}
