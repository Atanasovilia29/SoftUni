using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();

            int rows = int.Parse(Console.ReadLine());

            int colums = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (movieType == "Premiere")
            {
                income = rows * colums * 12;
            }
            else if (movieType == "Normal")
            {
                income = rows * colums * 7.50;
            }
            else if (movieType == "Discount")
            {
                income = rows * colums * 5;
            }

            Console.WriteLine($"{income:f2} leva");




        }
    }
}