using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave2
{
    public class Cola : IKoeling, IProduct
    {
        public int Gewicht { get; set; }
        public int Temperatuur { get; set; }
    }
}
