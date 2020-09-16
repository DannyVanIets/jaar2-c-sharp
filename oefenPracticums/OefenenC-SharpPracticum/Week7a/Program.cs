using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7a
{
    class Program
    {
        delegate bool Integers(int x, int y);

        static void Main(string[] args)
        {
            var menu = new List<MenuItem>()
            {
                new MenuItem("Hamburger",  562,  9.4,   2.5, false, true),
                new MenuItem("Milkshake",  344,   54,  0.51, true,  false),
                new MenuItem("Friet",      330,  0.4,  0.53, true,  false),
                new MenuItem("Vegaburger", 421,    7,   2.2, true,  true),
                new MenuItem("Salade",     137,  7.4,  0.66, false, true)
            };

            var calorieënBurgers = from item in menu
                                   where item.Omschrijving.Contains("burger")
                                   select item.KCal;

            foreach (int kcal in calorieënBurgers)
            {
                //Console.WriteLine(kcal);
            }

            var omschrijving = from item in menu
                               where item.Suikers < 10 && item.Zout < 1
                               select item.Omschrijving;

            foreach (string oms in omschrijving)
            {
                //Console.WriteLine(oms);
            }

            var itemsmetMinderDan5Suiker = (from item in menu
                                            where item.Suikers >= 5
                                            select item.Omschrijving).Take(3);

            foreach (string oms in itemsmetMinderDan5Suiker)
            {
                //Console.WriteLine(oms);
            }

            //Console.WriteLine(menu.Max(x => x.Suikers));

            var minsteSuiker = (from item in menu
                                where item.KCal == (from i in menu select i.KCal).Max()
                                select item).First();

            Console.WriteLine(minsteSuiker.Suikers);

            //Console.WriteLine(menu.Min(x => x.KCal));

            var namen = new List<string>() { "Ernst", "Henk", "Freek", "Eugène", "Hieke", "Ada", "Ruby", "Miranda" };

            var NamenVanVier = (from naam in namen
                                let lengte = omschrijving.Count()
                                let naamVanPersoon = naam
                                where lengte == 4
                                select naamVanPersoon);
            //select new {naamVanPersoon});

            //Print(NamenVanVier);
        }

        static bool IsKleinderDan(int x, int y)
        {
            if (x < y)
            {
                return true;
            }
            return false;
        }

        public void week7a()
        {
            int a = 5;
            int b = 7;

            Integers integer = IsKleinderDan;

            Integers integerAnon = delegate (int x, int y)
            {
                return x < y;
            };

            Integers integerLambda = (x, y) => x < y;

            Console.WriteLine(integer(a, b));
            Console.WriteLine(integerAnon(a, b));
            Console.WriteLine(integerLambda(a, b));

            Func<int, int, bool> integerFunc = IsKleinderDan;
            Console.WriteLine(integerFunc(a, b));

            Func<int, int, bool> integerFunc2 = (x, y) => a < b;
            Console.WriteLine(integerFunc2(a, b));

            List<string> list = new List<string>();

            var menu = new List<MenuItem>()
            {
                new MenuItem("Hamburger",  562,  9.4,   2.5, false, true),
                new MenuItem("Milkshake",  344,   54,  0.51, true,  false),
                new MenuItem("Friet",      330,  0.4,  0.53, true,  false),
                new MenuItem("Vegaburger", 421,    7,   2.2, true,  true),
                new MenuItem("Salade",     137,  7.4,  0.66, false, true)
            };

            var menuVegatarisch = menu.FindAll(g => g.Vegetarisch);
            foreach (MenuItem menuitem in menuVegatarisch)
            {
                Console.WriteLine(menuitem.Omschrijving);
            }

            var CalorieënBurgers = menu.FindAll(g => g.Omschrijving.Contains("burger"));
            foreach (MenuItem menuitem in CalorieënBurgers)
            {
                Console.WriteLine($"{menuitem.Omschrijving}: {menuitem.KCal}");
            }

            //Je kan ook menu.Where(g => g.Suikers < 10).Where(g => g.Zout < 1).Select(g => g.Omschrijving); doen inplaats van 1 where.
            var WeinigSuikerEnZout = menu.Where(g => g.Suikers < 10 && g.Zout < 1).Select(g => g.Omschrijving);
            foreach (string menuitem in WeinigSuikerEnZout)
            {
                Console.WriteLine($"{menuitem}");
            }

            var Minimaal3MetSuikerBoven5 = menu.Where(g => g.Suikers > 5).Take(3);
            foreach (MenuItem menuitem in Minimaal3MetSuikerBoven5)
            {
                Console.WriteLine($"{menuitem.Omschrijving}");
            }
        }
    }

    public class MenuItem
    {
        public string Omschrijving { get; set; }
        public int KCal { get; set; }
        public double Suikers { get; set; }
        public double Zout { get; set; }
        public bool Vegetarisch { get; set; }
        public bool BevatGluten { get; set; }

        public MenuItem(string omschrijving, int kcal, double suiker, double zout, bool vegaterisch, bool bevatgluten)
        {
            Omschrijving = omschrijving;
            KCal = kcal;
            Suikers = suiker;
            Zout = zout;
            Vegetarisch = vegaterisch;
            BevatGluten = bevatgluten;
        }
    }

}