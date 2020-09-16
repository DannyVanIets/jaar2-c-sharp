using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boekchapter5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opdracht 5.18

            /*string itemCode = "ABC123";
            int initialNumberOfUnits = 450;
            int numberPurchased = 400;
            int numberIssued = 725;
            Console.WriteLine((double)(initialNumberOfUnits + numberPurchased - numberIssued) / 100);
            if (1 >= (double) (initialNumberOfUnits + numberPurchased - numberIssued) / 100)
            {
                Console.WriteLine("Procure more units immediately");
            }
            else
            {
                Console.WriteLine("All is fine");
            }*/

            //Opdracht 5.19

            /*int counter = 0;
            double[] items = { 239.99, 129.75, 99.95, 350.89 };

            Console.Write("Enter sold or -1 to quit: ");
            int sold = int.Parse(Console.ReadLine());
            while (sold != -1)
            {
                double total = 0;
                double totalSold = 0;
                counter++;
                foreach (double i in items)
                {
                    Console.Write($"How many times did person {counter} sell the item that's worth {i}: ");
                    sold = int.Parse(Console.ReadLine());
                    totalSold = totalSold + (sold * i);
                }
                total = total + 200 + totalSold / 100 * 9;
                Console.WriteLine($"The person {counter} has earned a total of {total} money!");

                Console.Write("Enter sold or -1 to quit: ");
                sold = int.Parse(Console.ReadLine());
            }*/

            //Opdracht 5.20
            /*int counter = 0;
            double total = 0;

            int[] itemPrices = new int[10];
            int input = 0;
            Random rnd = new Random();

            while (input != -1)
            {
                int item = rnd.Next(1, 1000);

                Console.Write($"Wilt u een item kopen van {item} euro? Voer 1 in voor ja en -1 om te stoppen met winkelen: ");
                input = int.Parse(Console.ReadLine());

                if (input != -1)
                {
                    total = total + item;
                    itemPrices[counter] = item;
                    counter++;
                }
            }

            Console.WriteLine($"U heeft in totaal {counter} items gekocht met de prijzen: ");
            counter = 1;

            foreach (double i in itemPrices)
            {
                Console.WriteLine($"Item {counter}: {i} euro");
                counter++;
            }
            Console.Write($"Dit heeft in totaal {total} euro gekost, ");
            if (total <= 5000)
            {
                total = total / 100 * 90;
                Console.WriteLine($"u krijgt 10% korting hierop waardoor het {total} euro kost voor u.");
            }
            else
            {
                total = total / 100 * 80;
                Console.WriteLine($"u krijgt 20% korting hierop waardoor het {total} euro kost voor u.");
            }*/

            //Opdracht 5.21
            /*int counter = 0;
            int number = 0;

            int[] numbers = new int[10]; 
            int largest = 0;

            while(counter < 10)
            {
                Console.Write($"Voer een nummer in: ");
                number = int.Parse(Console.ReadLine());
                numbers[counter] = number;
                counter++;
            }

            Console.WriteLine("Alle ingevoerde nummers: ");

            foreach (int i in numbers)
            {
                largest = Math.Max(i, largest);
                Console.WriteLine($"{i}");
            }

            Console.WriteLine($"Het grootste nummer is: {largest}");*/

            //Opdracht 5.22
            /*int counter = 0;

            int[] n = new int[5] { 10, 20, 30, 40, 50};

            Console.WriteLine($"N     N2     N3      N2+N3");

            while (counter < 5)
            {
                Console.WriteLine($"{n[counter]}    {n[counter] * n[counter]}    {n[counter] * n[counter] * n[counter]}    {n[counter] * n[counter] + n[counter] * n[counter] * n[counter]}");
                counter++;
            }*/

            //Opdracht 5.38
            int counter = 0;

            Console.Write("Voer een nummer in: ");
            counter = int.Parse(Console.ReadLine());

            int total = counter;
            while(counter > 1)
            {
                counter--;
                total = total * counter;
            }
            Console.WriteLine($"Het totaal is: {total}");
        }
    }
}
