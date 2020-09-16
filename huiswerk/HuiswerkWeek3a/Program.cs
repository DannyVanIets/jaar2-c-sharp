using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuiswerkWeek3a
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmSysteem alarm1 = new AlarmSysteem();
            alarm1.Alarmtaken += AlarmTakenCollectie.Sprinker;
            alarm1.Alarmtaken += AlarmTakenCollectie.AlarmCentraleInlichten;
            alarm1.Alarmtaken += AlarmTakenCollectie.HokkenOpenZetten;
            alarm1.AlarmSlaan("Windesheim");
        }
    }

    delegate void AlarmTaak(string locatie);

    class AlarmSysteem
    {
        public AlarmTaak Alarmtaken { get; set; }

        public void AlarmSlaan(string locatie)
        {
            Alarmtaken(locatie);
        }
    }

    class AlarmTakenCollectie
    {
        public static void Sprinker(string locatie)
        {
            Console.WriteLine($"Sprinkling op locatie: {locatie}");
        }

        public static void AlarmCentraleInlichten(string locatie)
        {
            Console.WriteLine($"Beste alarmcentrale, het gaat niet goed op locatie: {locatie}");
        }

        public static void HokkenOpenZetten(string locatie)
        {
            Console.WriteLine($"Alle hokken zijn geopend op locatie: {locatie}");
        }
    }
}
