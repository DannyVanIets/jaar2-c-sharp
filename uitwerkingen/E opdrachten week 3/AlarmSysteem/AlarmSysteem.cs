using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlarmSysteemDierentuin
{
    //1 delegate declaratie
    public delegate void AlarmTaak(String locatie);

    class AlarmSysteem
    {
       
        //2 delegate property
        public AlarmTaak AlarmTaken { get; set; }

        //4 executie methode
        public void AlarmSlaan(string locatie)
        {
            if(AlarmTaken == null)
            {
                Console.WriteLine("Geen taken uit te voeren");
                return;
            }
            AlarmTaken(locatie);
        }
    }
}
