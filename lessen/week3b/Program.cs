using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Model m = new Model()
            {
                Getal = 4
            };
            TriViewData3 tvd3 = new TriViewData3();
            TriViewData4 tvd4 = new TriViewData4();

            m.AddObserver(tvd3.ShowData);
            m.AddObserver(tvd4.ShowData);

            m.WijzigGetal(5);
        }
    }
    
    delegate void Observer(Model model);

    class Model
    {
        public int Getal { get; set; }
        private Observer Observer;

        public void AddObserver(Observer obs)
        {
            Observer += obs;
        }

        public void WijzigGetal(int getal)
        {
            Getal = getal;
            Observer(this);
        }

        public int GetGetal()
        {
            return Getal;
        }
    }

    class TriViewData3
    {
        public void ShowData(Model model)
        {
            Console.WriteLine("Scherm 3 meldt: getal gewijzigd " + model.GetGetal());
        }
    }

    class TriViewData4
    {
        public void ShowData(Model model)
        {
            Console.WriteLine("Scherm 4 meldt: getal gewijzigd " + model.GetGetal());
        }
    }
}
