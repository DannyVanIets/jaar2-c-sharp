using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht1e
{
    class Program
    {
        static void Main(string[] args)
        {
            string vraag1 = "Wat is uw naam";
            string vraag2 = "Wat is uw woonplaats";
            string vraag3 = "Wat is uw achternaam";
            string vraag4 = "Heeft u een huisdier";
            string vraag5 = "Waar zit u op school";
            string vraag6 = "Volgende vraag (als u de applicatie wilt afsluiten, zeg dan 'sluit'):";

            Console.WriteLine("U kunt uit deze vragen een vraag stellen: ");
            Console.WriteLine($"{vraag1}\n{vraag2} \n{vraag3}\n{vraag4} \n{vraag5} \n");
                
            while (1 < 2)
            {
                string input = Console.ReadLine();
                if (input == $"{vraag1.ToLower()}")
                {
                    Console.WriteLine("Danny!\n");
                }
                else if (input == $"{vraag2.ToLower()}")
                {
                    Console.WriteLine("Nijkerk!\n");
                }
                else if(input == $"{vraag3.ToLower()}")
                {
                    Console.WriteLine("van Bokhorst!\n");
                }
                else if(input == $"{vraag4.ToLower()}")
                {
                    Console.WriteLine("Ja het is een hond die Paco heet!\n");
                }
                else if(input == $"{vraag5.ToLower()}")
                {
                    Console.WriteLine("Windesheim in zwolle.\n");
                }
                else if (input == "sluit")
                {
                    Console.WriteLine("Applicatie sluit af in 2 seconden!");
                    System.Threading.Thread.Sleep(2000);
                    Environment.Exit(0);
                }
                Console.WriteLine($"{vraag6}");
            }
        }
    }
}
