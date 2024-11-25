using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("Slow");
            }
            else if (speed <= 50 )
            {
                Console.WriteLine("Average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("Fast");
            }
            else if ( speed <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else
            {
                Console.WriteLine("Extreamly Fast");
            }
        }
    }
}
