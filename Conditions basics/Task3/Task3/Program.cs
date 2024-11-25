using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool isEven = num % 2 == 0;


            if (isEven)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("ODD");
            }
        }
    }
}