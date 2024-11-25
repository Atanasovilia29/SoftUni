using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //User inputs for the times
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int TotalTimeInMinutes = firstTime + secondTime + thirdTime;
            int minutes = TotalTimeInMinutes / 60;
            int seconds = TotalTimeInMinutes % 60;

            if (minutes > 10 )
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
            else if (seconds < 10 && minutes < 10)
            {
                Console.WriteLine($"0{minutes}:0{seconds}");
            }
 
            else
            {
                Console.WriteLine($"0{minutes}:{seconds}");
            }
        }
    }
}