using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkeerslichtSysteem
{
    public enum LichtKleur { groen, rood }

    class Verkeerslicht
    {
        
        public LichtKleur LichtAan { get; set; }
        public string Id { get; private set; }
        public string ReclameGroen { get; set; }
        public string ReclameRood { get; set; }
        public bool Geblokkeerd { get; set; }
        public Verkeerslicht(string id, LichtKleur kleur, string reclameGroen, string reclameRood)
        {
            Id = id;
            LichtAan = kleur;
            ReclameGroen = reclameGroen;
            ReclameRood = reclameRood;
        }

        public void SwitchLicht()
        {
            if(LichtAan == LichtKleur.groen)
            {
                LichtAan = LichtKleur.rood;
                if (!Geblokkeerd)
                {
                    Console.WriteLine($"id: {Id}, toont reclame: {ReclameRood}");
                }
            }
            else
            {
                LichtAan = LichtKleur.groen;
                if (!Geblokkeerd)
                {
                    Console.WriteLine($"id: {Id}, toont reclame: {ReclameGroen}");
                }
            }
        }

        public override string ToString()
        {
            return $"id: {Id}, kleur: {LichtAan} reclamerood: {ReclameRood}, reclamegroen: {ReclameGroen}, geblokkeerd: {Geblokkeerd}";
        }
    }
}
