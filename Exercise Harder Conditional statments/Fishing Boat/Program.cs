using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Цената за наем на кораба през пролетта е  3000 лв.
            //Цената за наем на кораба през лятото и есента е  4200 лв.
            //Цената за наем на кораба през зимата е  2600 лв.



            int groupBudget = int.Parse(Console.ReadLine());

            string season = Console.ReadLine();

            int numberOfFishers = int.Parse(Console.ReadLine());
            //"Spring", "Summer", "Autumn", "Winter"

            double shipCost = 0;
            double discount = 0;

            bool isEvenOrOdd = numberOfFishers / 2 == 0;

            if (season == "Spring")
            {
                shipCost = 3000;
                if (numberOfFishers <= 6 )
                {
                    discount = 0.10;
                }
                else if (numberOfFishers >= 7 && numberOfFishers <= 11)
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.25;
                }
                if (isEvenOrOdd) { discount = discount + 0.05; }
            }
            if (season == "Summer")
            {
                shipCost = 4200;
                if (numberOfFishers <= 6)
                {
                    discount = 0.10;
                }
                else if (numberOfFishers >= 7 && numberOfFishers <= 11)
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.25;
                }
                if (isEvenOrOdd) { discount = discount + 0.05; }
            }
            if (season == "Autumn")
            {
                shipCost = 4200;
                if (numberOfFishers <= 6)
                {
                    discount = 0.10;
                }
                else if (numberOfFishers >= 7 && numberOfFishers <= 11)
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.25;
                }  
            }
            if (season == "Winter")
            {
                shipCost = 2600;
                if (numberOfFishers <= 6)
                {
                    discount = 0.10;
                }
                else if (numberOfFishers >= 7 && numberOfFishers <= 11)
                {
                    discount = 0.15;
                }
                else
                {
                    discount = 0.25;
                }
                if (isEvenOrOdd) { discount = discount + 0.05; }
            }

            double totalDiscount = shipCost * discount;

            double totalPrice = shipCost - totalDiscount;

            double moneyLeft = totalPrice - groupBudget;

            if (moneyLeft < 0) { Console.WriteLine($"Yes! You have {Math.Abs(moneyLeft):f2} leva left."); }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(moneyLeft):f2} leva.");
            }

        }
    }
}