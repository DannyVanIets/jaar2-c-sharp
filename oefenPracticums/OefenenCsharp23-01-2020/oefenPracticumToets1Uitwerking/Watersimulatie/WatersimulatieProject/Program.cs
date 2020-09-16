using System;

namespace WatersimulatieProject
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterSimulatie<KanZwemmen> watersimulatie1 = new WaterSimulatie<KanZwemmen>();
            watersimulatie1.Add(new Mens());
            watersimulatie1.Add(new Goudvis());

            watersimulatie1.Simuleer();

            Console.WriteLine();

            WaterSimulatie<Goudvis> watersimulatie2 = new WaterSimulatie<Goudvis>();
            watersimulatie2.Add(new Goudvis());
            watersimulatie2.Add(new Goudvis());

            watersimulatie2.Simuleer();
        }
    }
}
