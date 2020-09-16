using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public class VerkoopEventArgs : EventArgs
    {
        public Vastgoed Vastgoed { get; set; }
        public int VerkoopPrijs { get; set; }
    }
}
