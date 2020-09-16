using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkeerslichtSysteem
{

//1. delegate definitie
public delegate void SwitchVerkeersLicht();

//publisher
class Verkeersplein
    {
        //2. event definitie
        private event SwitchVerkeersLicht BaanSwitch;   
        
        //3. subscribe
        public void SubscribeVerkeerslicht(SwitchVerkeersLicht verkeerslicht)
        {
            BaanSwitch += verkeerslicht;
        }

        //4. publish
        public void PublishLichtenOmswitchen()
        {
            BaanSwitch();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var item in BaanSwitch.GetInvocationList())
            {
                sb.Append(item.Target.ToString() + "\n");
            }
            return sb.ToString();
        }
    }
}
