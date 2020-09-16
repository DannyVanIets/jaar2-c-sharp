using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            Marathon boston17 = new Marathon();
            DopingControl usada = new DopingControl();
            Admin iaaf = new Admin();
            Prices baa = new Prices();

            boston17.RunnerFinished += iaaf.RegisterTime;
            boston17.RunnerFinished += baa.AwardPrices;
            boston17.RunnerFinished += usada.SendToDopingControl;

            string [] runners = { "Kirui", "Rupp", "Osako", "Biwott", "Chebet", "Abdirahman",
                "Maiyo", "Sefir", "Puskedra", "Ward"};

            List<string> orderedRunners = new List<string>(runners);
            Random rnd = new Random((int) DateTime.Now.Ticks);
            var shuffledRunners = orderedRunners.OrderBy(item => rnd.Next());

            uint rank = 1;
            foreach (string runner in shuffledRunners)
            {
                Thread.Sleep((int) (rnd.NextDouble() * 1000));
                boston17.Finished(runner, rank);
                rank++;
            }
            
        }
    }
}
