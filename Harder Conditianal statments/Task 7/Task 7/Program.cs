using System;

namespace ssde
{
    class Program
    {
        static void Main(string[] args)
        {
            int TimeOfDay = int.Parse(Console.ReadLine());
            string week = Console.ReadLine();



            bool weekIsOpen = week == "Monday" || week == "Tuesday" || week == "Wednesday" || week == "Thursday" || week == "Friday" || week == "Saturday";
            bool hoursIsOpen = TimeOfDay >= 10 && TimeOfDay <= 18;

            if (weekIsOpen == true && hoursIsOpen == true)
            {
                Console.WriteLine("Open");
            }
            else
            {
                Console.WriteLine("Closed");
            }
            
            


        }
    }
}

