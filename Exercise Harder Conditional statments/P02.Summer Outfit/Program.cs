using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int degreesOutside = int.Parse(Console.ReadLine());

            string timeOfDay = Console.ReadLine();

            if (degreesOutside >= 10 && degreesOutside <= 18)
            {
                if (timeOfDay == "Morning")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your Sweatshirt and Sneakers.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your Shirt and Moccasins.");
                }
                else if (timeOfDay == "Evening")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (degreesOutside > 18 && degreesOutside <= 24)
            {
                if (timeOfDay == "Morning")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your Shirt and Moccasins.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your T-Shirt and Sandals.");
                }
                else if (timeOfDay == "Evening")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your Shirt and Moccasins.");
                }
            }
            else if (degreesOutside >= 25)
            {
                if (timeOfDay == "Morning")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your T-Shirt and Sandals.");
                }
                else if (timeOfDay == "Afternoon")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your Swim Suit and Barefoot.");
                }
                else if (timeOfDay == "Evening")
                {
                    Console.WriteLine($"It's {degreesOutside} degrees, get your Shirt and Moccasins.");
                }
            }
            



        }
    }
}