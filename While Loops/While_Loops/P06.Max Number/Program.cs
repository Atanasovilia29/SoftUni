using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int bigNumb = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Stop")
                { 
                    break;
                }

               if  (int.TryParse(input, out int number))
               {
                   if (bigNumb < number)
                   {
                       bigNumb = number;
                   }
               }
            }
            Console.WriteLine($"{bigNumb}");

        }
    }
}