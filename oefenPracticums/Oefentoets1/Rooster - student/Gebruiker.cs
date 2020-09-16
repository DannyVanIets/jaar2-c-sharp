using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooster___student
{
    abstract class Gebruiker
    {
        public string Code { get; set; }

        protected Gebruiker(string code)
        {
            
        }

        public abstract override string ToString();
    }
}
