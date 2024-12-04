using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());

            double num2 = double.Parse(Console.ReadLine());

            string opperator = Console.ReadLine();

            double sum = 0;

            if (opperator == "+")
            {
                sum = num1 + num2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{num1} + {num2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} + {num2} = {sum} - odd");
                }

            }
            else if (opperator == "-")
            {
                sum = num1 - num2;
                if (num1 - num2 % 2 == 0)
                {
                    Console.WriteLine($"{num1} - {num2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} - {num2} = {sum} - odd");
                }
            }
            else if (opperator == "*")
            {
                sum = num1 * num2;
                if (num1 - num2 % 2 == 0)
                {
                    Console.WriteLine($"{num1} * {num2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} * {num2} = {sum} - odd");
                }


            }
            else if (opperator == "/")
            {
                sum = num1 / num2;
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} / {num2} = {sum:f2}");
                }
            }
            else if (opperator == "%")
            {
                sum = num1 % num2;
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    Console.WriteLine($"{num1} % {num2} = {sum}");
                }
                    
            }
        }
    }
}