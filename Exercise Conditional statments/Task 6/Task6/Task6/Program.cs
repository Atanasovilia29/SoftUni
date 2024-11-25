using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int hours = int.Parse(Console.ReadLine());

            int minutes =int.Parse(Console.ReadLine());


            if (hours < 0 || hours >= 24)
            {
                Console.WriteLine($"Invalid time inputed please use the 24 time frame");
            }
            else
            {
                minutes = minutes + 15;
                Console.WriteLine($"{hours}:{minutes}");
            }
            
        }
    }
}