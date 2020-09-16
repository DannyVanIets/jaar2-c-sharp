using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2Verkeersplein
{
    class Program
    {
        static void Main(string[] args)
        {
            Verkeersplein vk = new Verkeersplein();

            Verkeerslicht vk1 = new Verkeerslicht(LichtKleur.groen, "Reclame 1", "reclame groen", "reclame rood");
            Verkeerslicht vk2 = new Verkeerslicht(LichtKleur.rood, "Reclame 2", "reclame groen", "reclame rood");
            Verkeerslicht vk3 = new Verkeerslicht(LichtKleur.groen, "Reclame 3", "reclame groen", "reclame rood");
            Verkeerslicht vk4 = new Verkeerslicht(LichtKleur.rood, "Reclame 4", "reclame groen", "reclame rood");
            //Verkeerslicht verkeerslicht4 = new Verkeerslicht("verkeerslicht4", LichtKleur.rood, "reclame groen", "reclame rood");

            //5. callback subscription
            vk.SubscribeVerkeerslicht(vk1.SwitchLight);
            vk.SubscribeVerkeerslicht(vk2.SwitchLight);
            vk.SubscribeVerkeerslicht(vk3.SwitchLight);
            vk.SubscribeVerkeerslicht(vk4.SwitchLight);

            while (true)
            {
                vk.PublishLichtenOmswitchen();
                Console.WriteLine(vk.ToString());
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    delegate void SwitchVerkeersLicht();
    public enum LichtKleur { rood, groen }; 

    class Verkeersplein
    {
        private event SwitchVerkeersLicht BaanSwitch;

        public void SubscribeVerkeerslicht(SwitchVerkeersLicht baanSwitch)
        {
            BaanSwitch += baanSwitch;
        }

        public void PublishLichtenOmswitchen()
        {
            BaanSwitch();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            foreach (var item in BaanSwitch.GetInvocationList())
            {
                sb.Append(item.Target.ToString() + "\n");
            }
            return sb.ToString();
        }
    }

    class Verkeerslicht
    {
        public LichtKleur lichtkleur { get; set; }
        public string ID { get; private set; }
        public string ReclameGroen { get; set; }
        public string ReclameRood { get; set; }
        public bool Geblokkerd { get; set; }
        
        public Verkeerslicht(LichtKleur lk, string id, string reclameGroen, string reclameRood)
        {
            lichtkleur = lk;
            ID = id;
            ReclameGroen = reclameGroen;
            ReclameRood = reclameRood;
        }

        public void SwitchLight()
        {
            if (lichtkleur == LichtKleur.groen)
            {
                lichtkleur = LichtKleur.rood;
                if (!Geblokkerd)
                {
                    Console.WriteLine($"id: {ID}, toont reclame: {ReclameRood}");
                }
            }
            else
            {
                lichtkleur = LichtKleur.groen;
                if (!Geblokkerd)
                {
                    Console.WriteLine($"id: {ID}, toont reclame: {ReclameGroen}");
                }
            }
        }

        public override string ToString()
        {
            return $"ID: {ID}, kleur: {lichtkleur}";
        }
    }
}
