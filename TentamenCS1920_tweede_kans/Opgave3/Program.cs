using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] kaart_overijssel = new string[,]
            {
                {".", ".", ".", "." },
                {".", ".", ".", "." },
                {"=", "=", "^", "*" },
                {".", ".", ".", "." },
                {".", ".", ".", "." },
                {"^", "^", "^", "^" },
                {"=", "=", "=", "=" },
                {"=", "=", "=", "=" },
                {"=", "=", "=", "=" },
                {".", ".", "^", "^" },
                {"*", "*", "*", "*" },
            };
            Simulatie s = new Simulatie(kaart_overijssel);
            //Opgave 3a
            Console.WriteLine("Opgave 3a");
            Console.WriteLine(s.ToString());

            //Opgave 3c
            Console.WriteLine("\n\n Opgave 3c");
            Console.WriteLine($"-1, -1 grenst niet aan weg. Resultaat methode: {s.GrenstAanWeg(-1, -1)}");
            Console.WriteLine($"0, 1 grenst niet aan weg. Resultaat methode: {s.GrenstAanWeg(0, 0)}");
            Console.WriteLine($"2, 1 grenst aan weg. Resultaat methode: {s.GrenstAanWeg(2, 1)}");

            Console.WriteLine($"-1, -1 grenst niet aan huis. Resultaat methode: {s.GrenstAanHuis(-1, -1)}");
            Console.WriteLine($"0, 1 grenst niet aan huis. Resultaat methode: {s.GrenstAanHuis(0, 0)}");
            Console.WriteLine($"2, 1 grenst aan huis. Resultaat methode: {s.GrenstAanHuis(2, 1)}");

            Console.WriteLine($"-1, -1 is geen gras. Resultaat methode: {s.IsGras(-1, -1)}");
            Console.WriteLine($"0, 1 is gras. Resultaat methode: {s.IsGras(0, 1)}");
            Console.WriteLine($"2, 0 is geen gras. Resultaat methode: {s.IsGras(2, 0)}");

            //Opgave 3d
            //Console.WriteLine("\n\n Opgave 3d");
            //s.GeschikteLocatiesVoorHuisMetSchuur();

        }
    }

    class Simulatie
    {
        private string[,] _kaart;
        public Simulatie(string[,] kaart)
        {
            _kaart = kaart;
        }

        //Opdracht 3a
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < _kaart.GetLength(0); i++)
            {
                for (int j = 0; j < _kaart.GetLength(1); j++)
                {
                    if (j < 3)
                    {
                        sb.Append(_kaart[i, j]);
                    }
                    else
                    {
                        sb.Append(_kaart[i, j]).AppendLine();
                    }
                }
            }

            return sb.ToString();
        }

        //Opdracht 3b
        public bool OpKaart(int x, int y)
        {
            if(x > _kaart.GetLength(0) || x < 0 || y > _kaart.GetLength(1) || y < 0)
            {
                return false;
            }
            return true;
        }

        //helper methode die de buren van een locatie retourneert. Optioneel te gebruiken/implementeren.
        public List<(int, int)> Buren(int x, int y)
        {
            throw new NotImplementedException();
        }

        //helper methode om te bepalen of een locatie grenst aan een type grondgebruik. Optioneel te gebruiken/implementeren.
        public bool Grenst(int x, int y, string grondGebruik)
        {
            throw new NotImplementedException();
        }

        //Opgave 3c
        public bool GrenstAanWeg(int x, int y)
        {
            int xa = x - 1;
            int xb = x + 1;
            int ya = y - 1;
            int yb = y + 1;

            if(OpKaart(xa, y)) 
            {
                if (_kaart[xa, y] == "=")
                {
                    return true;
                }
            }

            if (OpKaart(x, ya))
            {
                if (_kaart[x, ya] == "=")
                {
                    return true;
                }
            }

            if (OpKaart(xb, y))
            {
                if (_kaart[xb, y] == "=")
                {
                    return true;
                }
            }

            if (OpKaart(x, yb))
            {
                if (_kaart[xb, yb] == "=")
                {
                    return true;
                }
            }

            return false;
        }

        public bool GrenstAanHuis(int x, int y)
        {
            int xa = x - 1;
            int xb = x + 1;
            int ya = y - 1;
            int yb = y + 1;

            if (OpKaart(xa, y))
            {
                if (_kaart[xa, y] == "^")
                {
                    return true;
                }
            }

            if (OpKaart(x, ya))
            {
                if (_kaart[x, ya] == "^")
                {
                    return true;
                }
            }

            if (OpKaart(xb, y))
            {
                if (_kaart[xb, y] == "^")
                {
                    return true;
                }
            }

            if (OpKaart(x, yb))
            {
                if (_kaart[x, yb] == "^")
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsGras(int x, int y)
        {
            if (OpKaart(x, y))
            {
                if (_kaart[x, y] == ".")
                {
                    return true;
                }
            }

            return false;
        }

        public bool GrenstAanGras(int x, int y)
        {
            int xa = x - 1;
            int xb = x + 1;
            int ya = y - 1;
            int yb = y + 1;

            if (OpKaart(xa, y))
            {
                if (_kaart[xa, y] == ".")
                {
                    return true;
                }
            }

            if (OpKaart(x, ya))
            {
                if (_kaart[x, ya] == ".")
                {
                    return true;
                }
            }

            if (OpKaart(xb, y))
            {
                if (_kaart[xb, y] == ".")
                {
                    return true;
                }
            }

            if (OpKaart(x, yb))
            {
                if (_kaart[xb, yb] == ".")
                {
                    return true;
                }
            }

            return false;
        }



        //Opgave 3d
        public void GeschikteLocatiesVoorHuisMetSchuur()
        {
            throw new NotImplementedException();
        }

    }
}
