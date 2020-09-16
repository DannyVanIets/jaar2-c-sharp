using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpdrachtLINQ
{
    public class Student
    {
        public string Achternaam { get; set; }
        public string Voornaam { get; set; }

        public int[] Cijfers { get; set; }

        public Student(string achternaam, string voornaam, int[] cijfers)
        {
            Achternaam = achternaam;
            Voornaam = voornaam;
            Cijfers = cijfers;
        }

        public override string ToString()
        {
            string result = Voornaam + "\t" + Achternaam + "\t";
            foreach (int cijfer in Cijfers)
                result += cijfer + " ";
            return result;
        }
    }

}
