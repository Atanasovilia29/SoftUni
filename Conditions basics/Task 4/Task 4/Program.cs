using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num < 100)
            {
                Console.WriteLine("The number is less than 100");
            }
            else if (num > 200 )
            {
                Console.WriteLine("The number is Bigger than 200");
            }
            else
            {
                Console.WriteLine("The number is between 100 and 200");
            }
        }
    }
}