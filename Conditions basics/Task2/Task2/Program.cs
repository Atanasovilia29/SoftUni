using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            bool isBigger = num > num2;

            if (isBigger)
            {
                Console.WriteLine(num);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}