using System;

namespace Opgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 2b
            VoedselAutomaat<IProduct> v1 = new VoedselAutomaat<IProduct>();
            v1.HuidigeTemperatuur = 8;
            v1.Toevoegen(new Cola() { Gewicht = 4, Temperatuur = 3 });
            v1.Toevoegen(new Cola() { Gewicht = 4, Temperatuur = 4 });
            v1.Toevoegen(new Drop() { Gewicht = 4 });
            Console.WriteLine($"De automaat moet vijf graden koelen. ({v1.ControleerTemperatuur()})");

            VoedselAutomaat<IProduct> v2 = new VoedselAutomaat<IProduct>();
            v2.HuidigeTemperatuur = 8;
            v2.Toevoegen(new Cola() { Gewicht = 4, Temperatuur = 10 });
            v2.Toevoegen(new Drop() { Gewicht = 4 });
            Console.WriteLine($"De automaat hoeft niet te koelen. ({v2.ControleerTemperatuur()})");

            //Opgave 2d
            VoedselAutomaat<IProduct> v3 = new VoedselAutomaat<IProduct>();
            v3.HuidigeTemperatuur = 8;
            v3.Toevoegen(new Cola() { Gewicht = 400, Temperatuur = 10 });
            v3.Toevoegen(new Cola() { Gewicht = 400, Temperatuur = 4 });
            v3.Toevoegen(new Cola() { Gewicht = 100, Temperatuur = 2 });
            v3.Toevoegen(new Drop() { Gewicht = 4 });
            var zwareEnKoeleProducten = v3.Selecteer(v3.ZwaarEnKoel);
            foreach(var p in zwareEnKoeleProducten)
            {
                var pk = (IKoeling)p;
                Console.WriteLine($"Product dat zwaar en koel is, gewicht: {p.Gewicht} temperatuur: {pk.Temperatuur}");
            }

        }
    }
}
