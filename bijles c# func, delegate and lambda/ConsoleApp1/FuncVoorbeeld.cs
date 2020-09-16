using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bijles
{
    class FuncVoorbeeld
    {
        public Func<int, int, int> OppervlakteFunc;

        public FuncVoorbeeld()
        {
            OppervlakteFunc = BerekenOppervlakte;
        }

        public int BerekenOppervlakteRechthoek(Func<int, int, int> BerekenOppervlakte, int lengte, int breedte)
        {
            return BerekenOppervlakte(lengte, breedte);
        }

        public int BerekenOppervlakteVierkant(Func<int, int, int> BerekenOppervlakte, int lengte)
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
