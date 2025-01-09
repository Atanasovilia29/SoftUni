using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double washingMachinePrice = double.Parse(Console.ReadLine());

            int toysPrice = int.Parse(Console.ReadLine());
           
            double birthDayMoneyIncrease = 0;
            int toys = 0;
            int brotherStealing = 0;
            int b = 0;

            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    birthDayMoneyIncrease += 10 * brotherStealing;
                    brotherStealing++;
                }
                else
                {
                    toys++;
                    
                }
            }
            double moneyAfterBrotherTax = birthDayMoneyIncrease - brotherStealing;

            double toysTotal = toys * toysPrice;

            double savings = toysTotal + moneyAfterBrotherTax;

            savings -= washingMachinePrice;


            if (savings > 0)
            {
            Console.WriteLine($"Yes! {savings:f2}");
            }
            else
            {
            Console.WriteLine($"No! {Math.Abs(savings):f2}");
            }
        }
    }
}