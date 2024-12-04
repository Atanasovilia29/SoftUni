using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeOfExamHours = int.Parse(Console.ReadLine());
            int timeOfExamMinutes = int.Parse(Console.ReadLine());

            int timeOfArrivalHours = int.Parse(Console.ReadLine());
            int timeOfArrivalMinutes = int.Parse(Console.ReadLine());

            int examTimeInMinutes = timeOfExamHours * 60 + timeOfExamMinutes;
            int arrivalTimeInMinutes = timeOfArrivalHours * 60 + timeOfArrivalMinutes;

            int timeDifference = arrivalTimeInMinutes - examTimeInMinutes;

            if (timeDifference < 0 && Math.Abs(timeDifference) <= 30)
            {
                Console.WriteLine("On-time");
                Console.WriteLine($"{Math.Abs(timeDifference)} minutes before the start");
            }
            else if (timeDifference < -30)
            {
                Console.WriteLine("Early");
                int absDifference = Math.Abs(timeDifference);
                int hours = absDifference / 60;
                int minutes = absDifference % 60;

                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes before the start");
                }
            }
            else if (timeDifference > 0)
            {
                Console.WriteLine("Late");
                int hours = timeDifference / 60;
                int minutes = timeDifference % 60;

                if (hours > 0)
                {
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{minutes} minutes after the start");
                }
            }
        }
    }
}
