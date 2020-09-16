using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Delegate voorbeeld
            DelegateVoorbeeld delegateVoorbeeld1 = new DelegateVoorbeeld();
            Console.WriteLine(delegateVoorbeeld1.BerekenOppervlakteRechthoek(200, 200));

            //Func voorbeeld
            FuncVoorbeeld funcVoorbeeld = new FuncVoorbeeld();
            Console.WriteLine(funcVoorbeeld.BerekenOppervlakteRechthoek(200, 200));

            klas klas = new klas();
            //klas.CheckOfNamenBestaan("Danny");
            klas.VindMetFunc(klas.NaamIs);
            klas.VindMetFunc(x => x == "Danny");
        }
    }
}
