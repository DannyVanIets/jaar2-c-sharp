using System;
using System.Collections.Generic;
using System.Text;

namespace WatersimulatieProject
{
    class WaterSimulatie<T> where T: KanZwemmen
    {
        private List<T> lijst = new List<T>();

        public void Add(T t)
        {
            lijst.Add(t);
        }

        public void Simuleer()
        {
            foreach (T t in lijst)
            {
                for (int i=0; i<3; i++)
                {
                    t.Zwem();
                }
            }
        }
    }
}
