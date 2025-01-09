using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double nominationPoints = 1250.5;

            string actorName = Console.ReadLine();

            double pointsInAcademy = double.Parse(Console.ReadLine()); 

            int numOfGraders = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfGraders; i++)
            {
                string nameOfGrader = Console.ReadLine();

                double pointsFromGrader = double.Parse(Console.ReadLine());

                pointsInAcademy = pointsInAcademy + nameOfGrader.Length * pointsFromGrader / 2;

                if (pointsInAcademy > nominationPoints)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsInAcademy:f1}!");
                    break;
                }
            }

            if (nominationPoints > pointsInAcademy )
            {
            Console.WriteLine($"Sorry, {actorName} you need {nominationPoints - pointsInAcademy:f1} more!");
            }
            
        }
    }
}