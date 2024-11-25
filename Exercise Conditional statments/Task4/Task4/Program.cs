using System;
using System.Diagnostics.Metrics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double numForMessuringUnit = double.Parse(Console.ReadLine());

            string inputTypeOfMessurmentUnit = Console.ReadLine();
           
            string outputTypeOfMesure = Console.ReadLine();

            if (inputTypeOfMessurmentUnit == "m" && outputTypeOfMesure == "cm")
            {
                Console.WriteLine($"{numForMessuringUnit * 100:f3}");

            }
            else if (inputTypeOfMessurmentUnit == "m" && outputTypeOfMesure == "mm")
            {
                Console.WriteLine($"{numForMessuringUnit * 1000:f3}");
            }
            else if (inputTypeOfMessurmentUnit == "cm" && outputTypeOfMesure == "mm")
            {
                Console.WriteLine($"{numForMessuringUnit * 10:f3}");
            }
            else if (inputTypeOfMessurmentUnit == "mm" && outputTypeOfMesure == "cm")
            {
                Console.WriteLine($"{numForMessuringUnit / 10:f3}");
            }
            else if (inputTypeOfMessurmentUnit == "mm" && outputTypeOfMesure == "m")
            {
                Console.WriteLine($"{numForMessuringUnit / 1000:f3}");
            }
            else if (inputTypeOfMessurmentUnit == "cm" && outputTypeOfMesure == "m")
            {
                Console.WriteLine($"{numForMessuringUnit * 10:f3}");
            }
            else if (inputTypeOfMessurmentUnit == "cm" && outputTypeOfMesure == "mm")
            {
                Console.WriteLine($"{numForMessuringUnit * 10:f3}");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}

