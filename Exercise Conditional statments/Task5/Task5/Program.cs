using System;

namespace ConvertHours
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input
            int hours = int.Parse(Console.ReadLine());

            int minutes = int.Parse(Console.ReadLine());
            //Establishing a check
            int check = 0;
            if (hours < 0 || hours > 23 || minutes < 0 || minutes > 59)
            {
                check = -1; // makes check into -1 to indicate an error
            }
            
            int minutesSinceMidnightResult = hours + minutes;

            //Error or Resulth
            if (check == -1)
            {
                Console.WriteLine("Error: Invalid time entered.");
            }
            else
            {
                Console.WriteLine("Minutes since midnight: " + minutesSinceMidnightResult);
            }


        }
    }
}