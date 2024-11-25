using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //USER INPUTS
            double recordSeconds = double.Parse(Console.ReadLine());

            double recordMeters = double.Parse(Console.ReadLine());

            double timePerMeter = double.Parse(Console.ReadLine());

            //CALCULATIONS
            double secNeeded = recordMeters * timePerMeter;

            double metersToSeconds = recordMeters / 15 * 12.5;

            double totalTime = metersToSeconds + secNeeded;

            // OUTPUT + FINAL COMPARISON AND CALCULATIOn
            if (totalTime < recordSeconds)
            {
                double succsessOfSwimmer = recordSeconds - totalTime;
                Console.WriteLine($"Yes, he succeeded! The new world record is {succsessOfSwimmer:f2}seconds.");
            }
            else
            {
                double succsessOfSwimmer = totalTime - recordSeconds;
                Console.WriteLine($"No, he failed! He was {Math.Abs(succsessOfSwimmer):f2} seconds slower.");
            }
            
        }
    }
}