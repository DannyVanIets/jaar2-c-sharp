using System;

namespace Opgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1a 3 punten.
             * 1b 0 punten
             * 1c 4 punten
             * 1d 4 punten 
             * 1e 0 Hier is het vooral belangrijk dat je events en delegates nog goed snapt.
             * 1f 0
             * 1g 0 
             * 2a 4 T type goed snappen! Dat is een generic!
             * 2b 0 LINQ nog effe goed bijleren. Ook voor properties.
             * 2c 0 Hier ook weer generic G. Was ook een erg moeilijke.
             * 2d 0 Hier goed FUNC en LAMBDA expressie goed gebruiken.
             * 2e 0 Goed leren wat een ? doet in een return!
             * 2f 0 IEnumerable leren!
             * 3a 5 
             * 3b 0
             * 3c 0
             * 3d 5
             * 3e 3 Temporary variables goed weten!
             * 3f 0
             * 3g 0
             * 3h 0
             * 3i 0
             */ 
            // Opgave 1b


            Pakketje pakketje = new Pakketje("Freek", "5466UP", 23);
            Pakketje pakketje2 = new Pakketje("Martijn", "1234ZP", 87, 12, Pakketje.Doos.Groot);
            Brief brief = new Brief("Henk", "7890QW", 25, false);
            Brief brief2 = new Brief("Windesheim", "8001AA", 25, true);

            Console.WriteLine(pakketje.Label());
            Console.WriteLine(pakketje2.Label());
            Console.WriteLine(brief.Label());
            Console.WriteLine(brief2.Label());



            // Opgave 1g

            
            PostKantoor postKantoor = new PostKantoor("Zwolle");

            Bezorger ernst = new Bezorger("Ernst", postKantoor);
            postKantoor.Aannemen(pakketje);
            postKantoor.Aannemen(brief);
            
        }
    }

    public abstract class Post
    {
        public string Naam { get; set; }
        public string Postcode { get; set; }
        public int Huisnummer { get; set; }

        public Post(string naam, string postcode, int huisnummer)
        {
            Naam = naam;
            Postcode = postcode;
            Huisnummer = huisnummer;
        }

        public string Label() //Moet met virtual en kan niet leeg zijn.
        {
            return "";
        }
    }

    public class Brief : Post
    {
        public bool Aangetekend { get; set; }

        public Brief(string naam, string postcode, int huisnummer, bool aangetekend) : base(naam, postcode, huisnummer)  // Abstract ontbreekt
        {
            Aangetekend = aangetekend;
        }

        public new string Label() //Override moet hier 
        {
            if (Aangetekend)
            {
                return $"Aangetekende brief voor {Naam} {Postcode} {Huisnummer}";
            }
            return $"Brief voor {Naam} {Postcode} {Huisnummer}";
        }
    }

    public class Pakketje : Post //Enum ontbreekt hier.
    {
        private double gewicht { get; set; } //Get en set kon hier wel weg. Is wel voor de rest goed.
        public double Gewicht
        {
            set
            {
                if(value >= 15)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"Pakketje voor {Naam} moet onder de 15 kilo liggen!");
                }
                gewicht = value;
            }
            get
            {
                return gewicht;
            }
        }

        public Doos Afmeting { get; set; }
        public enum Doos { Brievenbus, Klein, Groot };

        public Pakketje(string naam, string postcode, int huisnummer, double gewicht, Doos afmeting) : base(naam, postcode, huisnummer)
        {
            Gewicht = gewicht;
            Afmeting = afmeting;
        }

        public Pakketje(string naam, string postcode, int huisnummer) : base(naam, postcode, huisnummer)
        {
            Gewicht = 2;
            Afmeting = Doos.Brievenbus;
        }

        public new string Label()
        {
            return $"{Afmeting} pakketje van {Gewicht} kilo voor {Naam} {Postcode} {Huisnummer}";
        }
    }

    public class PostKantoor // Invoke ontbreekt hier voor het handlen van postevenargs.
    {
        public event EventHandler NieuwePost;
        public string Plaats { get; set; }

        public PostKantoor(string plaats)
        {
            Plaats = plaats;
        }

        public void Aannemen(Post post)
        {
            //NieuwePost(Plaats, post);
        }
    }

    public class Bezorger //Postkantoor moet wel veel beter. Is niet een goede delegate en eventhandler.
    {
        public string Naam { get; set; }

        public Bezorger(string naam, PostKantoor postkantoor) 
        {
            Naam = naam;
            postkantoor.NieuwePost += PostKantoor_NieuwePost;
        }

        public void PostKantoor_NieuwePost(object sender, EventArgs e)
        {
            Console.WriteLine($"");
        }
    }

    public class PostEvenArgs : EventArgs
    {
        public Post Post { get; set; }
    }
}
