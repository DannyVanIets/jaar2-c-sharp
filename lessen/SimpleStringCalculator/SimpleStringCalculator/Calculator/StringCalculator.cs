using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleStringCalculator.Calculator
{
    public class StringCalculator
    {
        public StringCalculator() { }

        public int Add(string input)
        {
            int total = 0;
            if (!string.IsNullOrEmpty(input))
            {
                string[] numbers = input.Split(',');
                foreach (string number in numbers)
                    total += TryParseToInteger(number);
                Console.WriteLine($"Result of Add({input}) = {total}\n");
            }
            else Console.WriteLine($"Invalid Argument!\n");
            return total;
        }

        public int Mul(string input)
        {
            int total = 1; //The multiplicative identity is 1
            if (!string.IsNullOrEmpty(input))
            {
                string[] numbers = input.Split(',');
                foreach (string number in numbers)
                    total *= TryParseToInteger(number);
                Console.WriteLine($"Result of Mul({input}) = {total}\n");
            }
            else Console.WriteLine($"Invalid Argument!\n");
            return total;
        }

        private int TryParseToInteger(string input)
        {
            int number = 0;
            if (!int.TryParse(input, out number))
                throw new ArgumentException("Input format incorrect!");
            return number;
        }

        public int Divide(string input)
        {
            int i = 0;

            if (!int.TryParse(input, out i))
                throw new ArgumentException("Input format incorrect!");
            
            string[] numbers = input.Split(',');

            int number1 = 0;
            int number2 = 0;

            foreach (string number in numbers)
            {
                if (i == 0)
                {
                    number1 = TryParseToInteger(number);
                }
                else if (i == 1)
                {
                    number2 = TryParseToInteger(number);
                }
                i++;
            }
            return number1 / number2;
        }
    }
}
