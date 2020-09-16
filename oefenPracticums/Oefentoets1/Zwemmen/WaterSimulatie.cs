using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwemmen
{
    class WaterSimulatie<T> where T: KanZwemmen
    {
        List<T> lijst = new List<T>();

        public void Add(T value)
        {
            lijst.Add(value);
        }

        public void Simuleer()
        {
            for(int i = 0; i < 3; i++)
            {
                foreach(KanZwemmen zwem in lijst)
                {
                    zwem.Zwem();
                }
            }
        }
    }
}
