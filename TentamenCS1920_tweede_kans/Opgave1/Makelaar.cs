using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave1
{
    public class Makelaar
    {
        public delegate int vastgoedVerkocht(int bedrag, Vastgoed vastgoed);

        public event EventHandler VastgoedVerkocht;

        public Makelaar()
        {

        }

        public bool Bieden(int bedrag, Vastgoed vastgoed)
        {
            if (bedrag >= vastgoed.MinimumPrijs)
            {
                //VastgoedVerkocht?.Invoke(this);
                return true;
            }
            return false;
        }
    }
}
