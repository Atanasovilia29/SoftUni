using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersNTo1 = int.Parse(Console.ReadLine());

            for (int i = numbersNTo1; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}