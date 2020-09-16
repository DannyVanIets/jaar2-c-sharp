using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooster___student
{
    class Klas : Gebruiker
    {
        public Klas(string code) : base(code)
        {
            Code = code;
        }

        public override string ToString()
        {
            return $"Klascode: {Code}";
        }
    }
}
