using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

            string flowers = Console.ReadLine();

            int countOfFlowers = int.Parse(Console.ReadLine());

            int budget = int.Parse(Console.ReadLine());

            double discount = 0;

            double income = 0;

            double markup = 0;

            if (flowers == "Roses")
            {
                income = 5;
                if (countOfFlowers > 80)
                {
                    discount = 0.10;
                }
            }
            else if (flowers == "Dahlias")
            {
                income = 3.80;
                if (countOfFlowers > 90)
                {
                    discount = 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                income = 2.80;
                if (countOfFlowers > 80)
                {
                    discount = 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                income = 3;
                if (countOfFlowers < 120)
                {
                    markup = 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                income = 2.50;
                if (countOfFlowers < 80)
                {
                    markup = 0.20 ;
                }
            }

            double totalPrice = countOfFlowers * income;
            if (markup > 0)
            {
                totalPrice += totalPrice * markup;
            }

            if (discount > 0)
            {
                double totalPriceAndDiscount = totalPrice * discount;
                totalPrice = totalPrice - totalPriceAndDiscount;
            }
            

            double totalPriceOutOfBudget = budget - totalPrice;

            if (totalPriceOutOfBudget > 0)
            {
                Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {flowers} and {totalPriceOutOfBudget:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(totalPriceOutOfBudget):f2} leva more.");
            }
        }
    }
}