using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlarmSysteemDierentuin
{
    class AlarmTakenCollectie
    {
        public static void Sprinkler(string locatie)
        {
            Console.WriteLine($"Sprinkling op locatie: {locatie}");
        }

        public static void AlarmcentraleInlichten(string locatie)
        {
            Console.WriteLine($"Beste alarmcentrale, het gaat niet goed op locatie: {locatie}");
        }

        public static void HokkenOpenZetten(string locatie)
        {
            Console.WriteLine($"Alle hokken zijn geopend op locatie: {locatie}");
        }

    }
}
