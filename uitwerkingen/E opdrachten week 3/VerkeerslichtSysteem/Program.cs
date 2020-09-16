using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkeerslichtSysteem
{
    class Program
    {
        static void Main(string[] args)
        {
            Verkeersplein verkeersplein = new Verkeersplein();

            Verkeerslicht verkeerslicht1 = new Verkeerslicht("verkeerslicht1", LichtKleur.groen, "reclame groen", "reclame rood");
            Verkeerslicht verkeerslicht3 = new Verkeerslicht("verkeerslicht3", LichtKleur.groen, "reclame groen", "reclame rood");
            Verkeerslicht verkeerslicht2 = new Verkeerslicht("verkeerslicht2", LichtKleur.rood, "reclame groen", "reclame rood");
            Verkeerslicht verkeerslicht4 = new Verkeerslicht("verkeerslicht4", LichtKleur.rood, "reclame groen", "reclame rood");

            //5. callback subscription
            verkeersplein.SubscribeVerkeerslicht(verkeerslicht1.SwitchLicht);
            verkeersplein.SubscribeVerkeerslicht(verkeerslicht2.SwitchLicht);
            verkeersplein.SubscribeVerkeerslicht(verkeerslicht3.SwitchLicht);
            verkeersplein.SubscribeVerkeerslicht(verkeerslicht4.SwitchLicht);

            while (true)
            {
                //6. Event afvuren 
                verkeersplein.PublishLichtenOmswitchen();
                Console.WriteLine(verkeersplein.ToString());
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
