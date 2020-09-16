using System;
using System.Collections.Generic;
using System.Linq;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    public class Map<T>
    {
        private List<T> _bestanden;

        public void Toevoegen(T bestand)
        {
            _bestanden.Add(bestand);
        }

        public void Verwijderen(T bestand)
        {
            _bestanden.Remove(bestand);
        }

        public int TotaleOmvang()
        {
            var totaleOmvang = from bestand in _bestanden select bestand;
            return totaleOmvang.Count();
        }

        //Func<T, String>;
    }

    public interface IDocument
    {
        string Auteur { get; set; }
    }

    public interface IBestand
    {
        string Naam { get; set; }
        int Omvang { get; set; }
    }

    public class Word : IDocument, IBestand
    {
        public string Auteur { get; set; }
        public string Naam { get; set; }
        public int Omvang { get; set; }
    }

    public class Excel : IDocument, IBestand
    {
        public string Auteur { get; set; }
        public string Naam { get; set; }
        public int Omvang { get; set; }
    }

    public class Zip : IBestand
    {
        public string Naam { get; set; }
        public int Omvang { get; set; }
    }
}