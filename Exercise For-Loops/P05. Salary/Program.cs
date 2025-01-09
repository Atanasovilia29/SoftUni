using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOpenWindows = int.Parse(Console.ReadLine());
            
            int salary = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfOpenWindows; i++)
            {
                string sitesVisited = Console.ReadLine().ToLower();

                if (sitesVisited == "facebook")
                {
                    salary -= 150;
                }
                else if (sitesVisited == "instagram")
                {
                    salary -= 100;
                }
                else if (sitesVisited == "reddit")
                {
                    salary -= 50;
                }
                
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }

            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
            


        }
    }
}