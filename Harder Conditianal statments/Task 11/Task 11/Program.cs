using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string userFruitChoice = Console.ReadLine();
            
            string dayOfweek = Console.ReadLine();
            


            double amount = double.Parse(Console.ReadLine());


            if (dayOfweek == "Sunday" || dayOfweek == "Saturday")
            {
                switch (userFruitChoice)
                {
                    case "banana":
                        Console.WriteLine($"{2.70 * amount:f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{1.25 * amount:f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{0.90 * amount:f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{1.60 * amount:f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{3.00 * amount:f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{5.60 * amount:f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{4.20 * amount:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (dayOfweek == "Monday" || dayOfweek == "Tuesday" || dayOfweek == "Wednesday" || dayOfweek == "Thursday" || dayOfweek == "Friday")
            {
                switch (userFruitChoice)
                {
                    case "banana":
                        Console.WriteLine($"{2.50 * amount:f2}");
                        break;
                    case "apple":
                        Console.WriteLine($"{1.20 * amount:f2}");
                        break;
                    case "orange":
                        Console.WriteLine($"{0.85 * amount:f2}");
                        break;
                    case "grapefruit":
                        Console.WriteLine($"{1.45 * amount:f2}");
                        break;
                    case "kiwi":
                        Console.WriteLine($"{2.70 * amount:f2}");
                        break;
                    case "pineapple":
                        Console.WriteLine($"{5.50 * amount:f2}");
                        break;
                    case "grapes":
                        Console.WriteLine($"{3.85 * amount:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}