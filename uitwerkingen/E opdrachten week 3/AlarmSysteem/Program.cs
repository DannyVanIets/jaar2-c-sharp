using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmSysteemDierentuin {

    class Program
    {
        /**
         *Situaties:
         * 1) Eén methode toegewezen (=)
         * 2) Geen methode toegewezen (null check)
         * 3) Meerdere methodes toewijzen (+=)
         */
        static void Main(string[] args)
        {
            AlarmSysteem alarmSysteem = new AlarmSysteem();

            //3 toewijzen/verwijderen delegate
            // = += -=
            alarmSysteem.AlarmTaken = new AlarmTaak
                (AlarmTakenCollectie.Sprinkler); //oude schrijfwijze
            alarmSysteem.AlarmTaken += AlarmTakenCollectie.HokkenOpenZetten;
            alarmSysteem.AlarmTaken += AlarmTakenCollectie.AlarmcentraleInlichten;

            //callbacks uitvoeren
            alarmSysteem.AlarmSlaan("Binnenplaats");
        }
    }
}
