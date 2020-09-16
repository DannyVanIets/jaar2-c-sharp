using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    class Admin
    {
        public void RegisterTime(object sender, RunnerInfo info)
        {
            Console.WriteLine($"Runner {info.Name} has arrived");
        }
    }

    class DopingControl
    {
        public void SendToDopingControl(object sender, RunnerInfo info)
        {
            Console.WriteLine($"=> {info.Name} to doping control");
        }

    }

    class Prices
    {
        public void AwardPrices(object sender, RunnerInfo info)
        {
            if (info.Rank <= 3)
            {
                Console.WriteLine($"* Runner {info.Name} wins a prize of $ {(4-info.Rank) * 5000} * ");
            }
        }

    }

}
