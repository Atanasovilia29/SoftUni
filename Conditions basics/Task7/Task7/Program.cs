using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // static prices for diifernt toys:
            const double priceOfPuzel = 2.60;
            const double priceOfTalkingDoll = 3;
            const double priceOfTedyBear = 4.10;
            const double priceOfMinion = 8.20;
            const double priceOfTruck = 2;

            //Inputs from user 
            //Vacation
            Console.WriteLine("Please put in the amount of vacation money you have: ");
            double priceForVacation = double.Parse(Console.ReadLine());
            bool isPirceForVacation = priceForVacation <= 10000 && priceForVacation >= 1;
            while (!isPirceForVacation)
            {
                Console.WriteLine($"The Exursion price: {priceForVacation} you've put is bellow 1.00lv. You cannot purchase no products or negative numberand over a 10000.00lv ");
                Console.WriteLine("Please Try Again: ");
                priceForVacation = double.Parse(Console.ReadLine());
                break;
            }


            Console.WriteLine("Nice Go next");

            //Puzzels amount
            Console.WriteLine("Please put in the amount of puzzels you want: ");
            double countOfPuzzelse = double.Parse(Console.ReadLine());
            bool isCountOfPuzzelse = countOfPuzzelse <= 1000 && countOfPuzzelse >= 1;
            while (!isCountOfPuzzelse)
            {
                Console.WriteLine($"The Puzzel number: {countOfPuzzelse} you've put is bellow 1. You cannot purchase no products or negative number and over a 1000 ");
                Console.WriteLine("Please Try Again: ");
                countOfPuzzelse = double.Parse(Console.ReadLine());
                break;
            }

            Console.WriteLine("Nice Go next");


            //Talking Dolls amount
            Console.WriteLine("Please put in the amount of Talking Dolls you want: ");
            double countOfTalkingDolls = double.Parse(Console.ReadLine());
            bool isCountOfTalkingDolls = countOfTalkingDolls <= 1000 && countOfTalkingDolls >= 1;
            while (!isCountOfTalkingDolls)
            {
                Console.WriteLine($"The Puzzel number: {countOfTalkingDolls} you've put is bellow 1. You cannot purchase no products or negative number and over a 1000 ");
                Console.WriteLine("Please Try Again: ");
                countOfTalkingDolls = double.Parse(Console.ReadLine());
                break;
            }


            Console.WriteLine("Nice Go next");

            // Tedy Bears amount
            Console.WriteLine("Please put in the amount of Tedy Bears you want: ");
            double countOfTedyBears = double.Parse(Console.ReadLine());
            bool isCountOfTedyBears = countOfTedyBears <= 1000 && countOfTedyBears >= 1;
            while (!isCountOfTedyBears)
            {
                Console.WriteLine($"The Puzzel number: {countOfTedyBears} you've put is bellow 1. You cannot purchase no products or negative number and over a 1000 ");
                Console.WriteLine("Please Try Again: ");
                countOfTedyBears = double.Parse(Console.ReadLine());
                break;
            }

            Console.WriteLine("Nice Go next");

            // Minions amount
            Console.WriteLine("Please put in the amount of Minions you want: ");
            double countOfMinions = double.Parse(Console.ReadLine());
            bool isCountOfMinions = countOfMinions <= 1000 && countOfMinions >= 1;
            while (!isCountOfMinions)
            {
                Console.WriteLine($"The Puzzel number: {countOfMinions} you've put is bellow 1. You cannot purchase no products or negative number and over a 1000 ");
                Console.WriteLine("Please Try Again: ");
                countOfMinions = double.Parse(Console.ReadLine());
                break;
            }

            Console.WriteLine("Nice Go next");

            // Trucks amount
            Console.WriteLine("Please put in the amount of Trucks you want: ");
            double countOfTrucks = double.Parse(Console.ReadLine());
            bool isCountOfTrucks = countOfTrucks <= 1000 && countOfTrucks >= 1;
            while (!isCountOfTrucks)
            {
                Console.WriteLine($"The Puzzel number: {countOfTrucks} you've put is bellow 1. You cannot purchase no products or negative number and over a 1000 ");
                Console.WriteLine("Please Try Again: ");
                countOfTrucks = double.Parse(Console.ReadLine());
                break;
            }

            Console.WriteLine("Nice Go next");

            //Logic of the solution

            //Toys amount in total

            double countOfToys = countOfPuzzelse + countOfTalkingDolls + countOfTedyBears + countOfMinions + countOfTrucks;



            Console.WriteLine($"You have selected this amount of toys: {countOfToys}");

            //Sum of the amount and the prices of the toys 
            double sum = priceOfPuzel * countOfPuzzelse + priceOfTalkingDoll * countOfTalkingDolls + priceOfTedyBear * countOfTedyBears + priceOfMinion * countOfMinions + priceOfTruck * countOfTrucks;
            double discount = sum * 0.25;

            if (countOfToys >= 50)
            {
                Console.WriteLine($"You qualify so you get this much out of the total: {discount} lv");

            }
            else
            {
                Console.WriteLine("You don't qualify for the discount");
            }
            double discountAmount = sum - discount;
            Console.WriteLine($"The total price of the toys is: {discountAmount:f2} lv");

            double rentAmount = discountAmount * 0.10;
            Console.WriteLine($"The amount of rent needed to be paid: {rentAmount} lv");

            double profitAmount = discountAmount - rentAmount;
            Console.WriteLine($"The amount of profit made: {profitAmount} lv");

            if (profitAmount > priceForVacation)
            {

                Console.WriteLine($"You have enough for the vacation this is what you have left: {profitAmount - priceForVacation} lv");
            }
            else
            {
                Console.WriteLine($"You need a bit more: {profitAmount - priceForVacation}  lv");
            }
        }
    }
}