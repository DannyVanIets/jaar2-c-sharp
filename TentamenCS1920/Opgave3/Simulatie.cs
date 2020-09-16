using System;
using System.Collections.Generic;
using System.Text;

namespace Opgave3
{
    public class Simulatie
    {
        private bool[,] _bord;

        public Simulatie(bool[,] start)
        {
            _bord = start;
        }

        public void VolgendeStap()
        {
            bool[,] nieuwBord = { }; //Vergeet niet een nieuw bool hier te zetten!
            for (int x = 0; x < _bord.GetLength(0); x++)
            {
                for (int y = 0; y < _bord.GetLength(1); y++)
                {
                    nieuwBord[x, y] = _bord[x, y] ? Blijft(x, y) : Nieuw(x, y);
                }
            }
            _bord = nieuwBord;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < _bord.GetLength(0); i++)
            {
                for (int j = 0; j < _bord.GetLength(1); j++)
                {
                    if (_bord[i, j])
                    {
                        builder.Append("O");
                    }
                    else
                    {
                        builder.Append(".");
                    }
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

        public bool CellStatus(string input)
        {
            string[] numbers = input.Split(',');

            int x = 0;
            int y = 0;

            foreach (string number in numbers)
            {
                x = TryParseToInteger(number);
                y = TryParseToInteger(number);
            }

            if (_bord.GetLength(0) < x || _bord.GetLength(1) < y) //Alle controles in een if bestand doen.
            {
                return false;
            }
            return _bord[x, y];
        }

        public int AantalBuren(string input) //Veel minder code hiervoor gebruiken. Bijvoorbeeld met x - 1 hele tijd
        {
            string[] numbers = input.Split(',');

            int x = 0;
            int y = 0;

            foreach (string number in numbers)
            {
                x = TryParseToInteger(number);
                y = TryParseToInteger(number);
            }

            int aantalBuren = 0;

            for (int horizontaal = 0; horizontaal < _bord.GetLength(1); horizontaal++)
            {
                if (CellStatus($"{x}, {horizontaal}"))
                {
                    aantalBuren++;
                }
            }

            for (int verticaal = 0; verticaal < _bord.GetLength(0); verticaal++)
            {
                if (CellStatus($"{verticaal}, {y}"))
                {
                    aantalBuren++;
                }
            }

            //De volgende twe while loops worden gebruikt voor het diagonale.
            int a = x;
            int b = y;

            while (CellStatus($"{a}, {b}"))
            {
                a++;
                b++;

                if (CellStatus($"{a}, {b}"))
                {
                    aantalBuren++;
                }
            }

            while (CellStatus($"{x}, {y}"))
            {
                x--;
                y--;

                if (CellStatus($"{x}, {y}"))
                {
                    aantalBuren++;
                }
            }

            return aantalBuren;
        }

        public bool Nieuw(int x, int y)
        {
            if (_bord[x, y] == false && AantalBuren($"{x}, {y}") == 3)
            {
                return true;
            }
            return false;
        }

        public bool Blijft(int x, int y)
        {
            if (AantalBuren($"{x}, {y}") == 2 || AantalBuren($"{x}, {y}") == 3)
            {
                return true;
            }
            return false;
        }

        private int TryParseToInteger(string input)
        {
            int number = 0;
            if (!int.TryParse(input, out number))
            {
                throw new ArgumentException("Input format incorrect!");
            }
            return number;
        }
    }
}
