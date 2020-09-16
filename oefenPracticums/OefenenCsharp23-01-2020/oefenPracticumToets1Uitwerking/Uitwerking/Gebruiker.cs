using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uitwerking
{
    abstract class Gebruiker
    {
        public string Code { get; set; }

        protected Gebruiker(string code)
        {
            this.Code = code;
        }

        
    }

    class Klas: Gebruiker
    {
        public Klas(string code) : base(code)
        {
            
        }
        public override string ToString()
        {
            return Code;
        }
    }

    class Docent: Gebruiker
    {
        public string Naam { get; set; }
        public Docent(string code, string naam): base(code)
        {
            Naam = naam;
        }
        
        public override string ToString()
        {
            return $"{Naam} ({Code})";
        }
    }
}
