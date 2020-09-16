using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    abstract class Artiest
    {
        public abstract void VoerActUit(object sender, VoorstellingEventArgs e);
    }

    class Goochelaar : Artiest
    {
        public override void VoerActUit(object sender, VoorstellingEventArgs e)
        {
            switch (e.Moment)
            {
                case VoorstellingMoment.opening:
                    Console.WriteLine("Goochelaar laat tijdens opening olifant verdwijnen.");
                    break;
                case VoorstellingMoment.naPauze:
                    Console.WriteLine("Goochelaar tovert na pauze olifant te voorschijn.");
                    break;
                case VoorstellingMoment.slot:
                    Console.WriteLine("Goochelaar laat aan het slot olifant door het dak wegvliegen.");
                    break;
            }            
        }
    }

    class Clown : Artiest
    {
        public override void VoerActUit(object sender, VoorstellingEventArgs e)
        {
            switch (e.Moment)
            {
                case VoorstellingMoment.opening:
                    Console.WriteLine("Clown loopt tijdens opening waggelend rond.");
                    break;
                case VoorstellingMoment.naPauze:
                    Console.WriteLine("Clown doet na de pauze de dompteur na.");
                    break;
                case VoorstellingMoment.slot:
                    Console.WriteLine("Clown rent aan het slot als eerste weg gekkebekketrekkend.");
                    break;
            }
        }
    }

    class Acrobaat: Artiest
    {
        public override void VoerActUit(object sender, VoorstellingEventArgs e)
        {
            switch (e.Moment)
            {
                case VoorstellingMoment.opening:
                    Console.WriteLine("Acrobaat komt tijdens opening vanuit de nok van de tent aan de trapeze over het publiek.");
                    break;
                case VoorstellingMoment.naPauze:
                    Console.WriteLine("Acrobaat maakt na de pauze rennend salto's");
                    break;
                case VoorstellingMoment.slot:
                    Console.WriteLine("Acrobaat laat zich aan het slot lanceren vanuit een kanon.");
                    break;
            }
        }
    }
}
