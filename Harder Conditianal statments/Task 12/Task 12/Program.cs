using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();

            double salesNumber = double.Parse(Console.ReadLine());

            // USING NESTED IF STATMENTS TO DETERMINE COMMISION

            if (cityName == "Sofia")
            {
                if (salesNumber < 0)
                {
                    Console.WriteLine("error");
                }
                else if (salesNumber <= 0 || salesNumber <= 500)
                {
                    Console.WriteLine($"{salesNumber * 0.05:f2}");
                }
                else if (salesNumber <= 1000)
                {
                    Console.WriteLine($"{salesNumber * 0.07:f2}");
                }
                else if (salesNumber <= 10000)
                {
                    Console.WriteLine($"{salesNumber * 0.08:f2}");
                }
                else if (salesNumber > 10000)
                {
                    Console.WriteLine($"{salesNumber * 0.12:f2}");
                }
            }
            else if (cityName == "Varna")
            {
                if (salesNumber < 0)
                {
                    Console.WriteLine("error");
                }
                else if (salesNumber <= 0 || salesNumber <= 500)
                {
                    Console.WriteLine($"{salesNumber * 0.045:f2}");
                }
                else if (salesNumber <= 1000)
                {
                    Console.WriteLine($"{salesNumber * 0.075:f2}");
                }
                else if (salesNumber <= 10000)
                {
                    Console.WriteLine($"{salesNumber * 0.10:f2}");
                }
                else if (salesNumber > 10000)
                {
                    Console.WriteLine($"{salesNumber * 0.13:f2}");
                }
            }
            else if (cityName == "Plovdiv")
            {
                if (salesNumber < 0)
                {
                    Console.WriteLine("error");
                }
                else if (salesNumber <= 0 || salesNumber <= 500)
                {
                    Console.WriteLine($"{salesNumber * 0.055:f2}");
                }
                else if (salesNumber <= 1000)
                {
                    Console.WriteLine($"{salesNumber * 0.08:f2}");
                }
                else if (salesNumber <= 10000)
                {
                    Console.WriteLine($"{salesNumber * 0.12:f2}");
                }
                else if (salesNumber > 10000)
                {
                    Console.WriteLine($"{salesNumber * 0.145:f2}");
                }

            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}