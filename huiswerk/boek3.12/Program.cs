using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boek3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int y = 25;
            int x = 24;
            int z = 26;

            //A
            y = 2 * a * b + 2 * a * c;
            //B
            z = x * 1 + x - y * 1 + y;
            //C
            x = x * y / 3;
            //D
            y = 4 * a * b / (4 * a + 4 * b);
            //E
            z = x * Convert.ToInt32(Math.Pow(a, 3)) + y * Convert.ToInt32(Math.Pow(b, 3));
            //F
            x = a * c * Convert.ToInt32(Math.Pow(b * d, 4));
            */

            //Opdracht 3.13. A
            /*Console.WriteLine(3 * 6 / 2 + 7 - 1 + " antwoord: 15");
            //B
            Console.WriteLine((2 % 2) + (2 * 2) - (2 / 2) + " antwoord: 3");
            //C
            Console.WriteLine(3 / 3 * 9 + 3 * 9 * 3 + " antwoord: 90");

            //Opdracht 3.13 A
            Console.WriteLine("4 3 2 1");
            //B
            Console.Write("4 ");
            Console.Write("3 ");
            Console.Write("2 ");
            Console.Write("1 ");
            //C
            string tekst = $"{a} {b} {c} {d}";
            Console.WriteLine($"{tekst}");
            */

            //Opdracht 3.15
            /*int number1;
            int number2;
            int number3;
            double sum;

            Console.Write("Fill in the first price: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("\nFill in the second price: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("\nFill in the third price: ");
            number3 = int.Parse(Console.ReadLine());

            sum = number1 + number2 + number3;
            sum = sum / 100 * 90;

            Console.WriteLine($"\nU krijgt 10% korting! De totale prijs is: {sum}");*/

            //Opdracht 3.16
            /*Console.Write("Enter an integer: ");
            int input = int.Parse(Console.ReadLine());

            if (input >= 1 && input <= 5)
            {
                Console.WriteLine("Working day");
            }
            else if (input >= 6 && input <= 7)
            {
                Console.WriteLine("Weekend");
            }
            else
            {
                Console.WriteLine("Invalid!");
            }*/

            //Opdracht 3.18
            /*Console.WriteLine("********\n*      *\n*      *\n*      *\n*      *\n*      *\n*      *\n********\n");
            Console.WriteLine("  ***  \n *   * \n*     *\n*     *\n*     *\n*     *\n*     *\n*     *\n *   * \n  ***  \n");
            Console.WriteLine("   *   \n  ***  \n *****\n   *   \n   *   \n   *   \n   *   \n   *   \n   *   \n   *   \n");
            Console.WriteLine("   *   \n  * *  \n *   *\n*     *\n *   *\n  * *  \n   *   \n");
            */

            //Opdracht 3.22
            //Het laat welcome zien

            //Opdracht 3.24
            /*Console.Write("Vul een nummer in: ");
            int input = int.Parse(Console.ReadLine());
            if (input % 2 == 0)
            {
                Console.WriteLine("Het nummer is even!");
            }
            else
            {
                Console.WriteLine("Het nummer is oneven!");
            }*/

            //Opdracht 3.25
            /*Console.Write("Vul een nummer in: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Vul een tweede nummer in: ");
            int input2 = int.Parse(Console.ReadLine());

            if (input1 % input2 == 0)
            {
                Console.WriteLine($"{input1} is een multiple van {input2}");
            }
            else
            {
                Console.WriteLine($"{input1} is niet een multiple van {input2}");
            }*/

            //Opdracht 3.26
            /*Console.Write("Radius van je cirkel: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDiameter: " + 2 * input + ", circumference: " + 2 * Math.PI * input + " en area: " + Math.PI * input * input);
            */

            //Opdracht 3.27
            /*Console.WriteLine($"The charachter {'A'} has the value {(int)'A'}");
            Console.WriteLine($"The charachter {'B'} has the value {(int)'B'}");
            Console.WriteLine($"The charachter {'C'} has the value {(int)'C'}");

            Console.WriteLine($"The charachter {'a'} has the value {(int)'a'}");
            Console.WriteLine($"The charachter {'b'} has the value {(int)'b'}");
            Console.WriteLine($"The charachter {'c'} has the value {(int)'c'}");

            Console.WriteLine($"The charachter {'0'} has the value {(int)'0'}");
            Console.WriteLine($"The charachter {'1'} has the value {(int)'1'}");
            Console.WriteLine($"The charachter {'2'} has the value {(int)'2'}");

            Console.WriteLine($"The charachter {'$'} has the value {(int)'$'}");
            Console.WriteLine($"The charachter {'*'} has the value {(int)'*'}");
            Console.WriteLine($"The charachter {'+'} has the value {(int)'+'}");

            Console.WriteLine($"The charachter {'/'} has the value {(int)'/'}");
            Console.WriteLine($"The charachter {' '} has the value {(int)' '}");*/

            //Opdracht 3.28 ???
            /* Console.WriteLine("Vul een 5 cijferig nummer in");
            int input = int.Parse(Console.ReadLine());

            if(input)*/
            //Opdracht 3.29
            Console.Write("Input a number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The table is: ");
            Console.WriteLine($"{n} X 1 = " + n * 1);
            Console.WriteLine($"{n} X 2 = " + n * 2);
            Console.WriteLine($"{n} X 3 = " + n * 3);
            Console.WriteLine($"{n} X 4 = " + n * 4);
            Console.WriteLine($"{n} X 5 = " + n * 5);
            Console.WriteLine($"{n} X 6 = " + n * 6);
            Console.WriteLine($"{n} X 7 = " + n * 7);
            Console.WriteLine($"{n} X 8 = " + n * 8);
            Console.WriteLine($"{n} X 9 = " + n * 9);
            Console.WriteLine($"{n} X 10 = " + n * 10);
        }
    }
}
