using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijles
{
    class DelegateVoorbeeld
    {
        //Een delegate wijst naar een functie. Het is een variable die wijst naar een methode.
        public delegate int BerekenOppervlakteDelegate(int lengte, int breedte);

        //Instantie van deze delegate maken.
        public BerekenOppervlakteDelegate BerekenOppervlakteDelegateReferentie;

        public DelegateVoorbeeld()
        {
            BerekenOppervlakteDelegateReferentie = BerekenOppervlakte;
        }

        public int BerekenOppervlakteRechthoek(int lengte, int breedte)
        {
            return BerekenOppervlakte(lengte, breedte);
        }

        public int BerekenOppervlakteVierkant(int lengte)
        {
            return BerekenOppervlakte(lengte, lengte);
        }

        /// <summary>
        /// Dit is een nieuwe klasse
        /// </summary>
        /// <param name="lengte"></param>
        /// <param name="breedte"></param>
        /// <returns></returns>
        public int BerekenOppervlakte(int lengte, int breedte)
        {
            return lengte * breedte;
        }
    }
}
