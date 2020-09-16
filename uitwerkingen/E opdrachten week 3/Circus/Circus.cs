using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circus
{
    class Circus
    {
        private event EventHandler<VoorstellingEventArgs> Voorstelling; 

        public void SubscribeArtiest(EventHandler<VoorstellingEventArgs> ArtiestActMethod)
        {
            Voorstelling += ArtiestActMethod;
        }

        public void VoerActsUit(VoorstellingMoment moment)
        {
            OnUitvoerenActs(new VoorstellingEventArgs(moment));
        }

        public void OnUitvoerenActs(VoorstellingEventArgs voorstellingEventArgs)
        {
            if(Voorstelling != null)
            {
                Voorstelling(this, voorstellingEventArgs);
            }
        }
    }
}
