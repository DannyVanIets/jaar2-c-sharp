using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zwemmen
{
    class Program
    {
        static void Main(string[] args)
        {
            Goudvis goudvis1 = new Goudvis();
            Mens mens1 = new Mens();

            WaterSimulatie<KanZwemmen> watersimulatie = new WaterSimulatie<KanZwemmen>();

            watersimulatie.Add(goudvis1);
            watersimulatie.Add(mens1);

            watersimulatie.Simuleer();
        }
    }
}
