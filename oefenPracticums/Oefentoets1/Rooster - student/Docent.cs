using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rooster___student
{
    class Docent : Gebruiker
    {
        public string Naam { get; set; }

        public Docent(string code, string naam) : base(code)
        {
            Code = code;
            Naam = naam;
        }

        public override string ToString()
        {
            return $"Naam: {Naam} ({Code})";
        }
    }
}
