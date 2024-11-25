using System;

namespace GodzilaVsKingKong
{
    class Program
    {
        static void Main(string[] args)
        {
            // INPUTS USER 
            double movieBudget = double.Parse(Console.ReadLine());
            
            int extraCount = int.Parse(Console.ReadLine());
            
            double priceForOutfitPerExtra = double.Parse(Console.ReadLine());

            // CALCULATIONS 
            double sumOutfit = extraCount * priceForOutfitPerExtra;
            
            double decourPrice = movieBudget * 0.10;

            double totalMoney = sumOutfit + decourPrice;
            
            double moneyLeft = movieBudget - totalMoney;
            
            //DISCOUNT CHECK
            if (extraCount >= 150)
            {
                Console.WriteLine($"{priceForOutfitPerExtra * 0.10}");
            }
            else
            {
                Console.WriteLine("You don't qualify for the discount");
            }
            
            //CHECK FOR VALID INPUT
            if (movieBudget < 1.00 || movieBudget > 1000000.00)
            {
            Console.WriteLine($"You cannot input any budget less than 1.00lv up to 1000000.00 lv");
            }
            else if (extraCount < 1 || extraCount > 500)
            {
                Console.WriteLine($"You cannot have less than 1 extra or more than 500. Try again");
            }
            else if (extraCount < 1.00 || extraCount > 1000.00)
            {
                Console.WriteLine($"Your oufits cannot cost less than 1.00 lv or more than 1000.00 lv");
            }
            else
            {
            Console.WriteLine("Everything alright!");
            }
            
            // LAST CHECK AND PRINT FOR APPROVAL OR DISAPPROVAL FOR THE MOVIE
            if (moneyLeft < 0 )
            { 
            Console.WriteLine("Not enough money");
            Console.WriteLine($"Wingard needs {Math.Abs(moneyLeft):f2}leva");    
            }
            else
            {
            Console.WriteLine($"Wingard starts filming with {moneyLeft:f2}leva left");      
            }
        }
    }
}