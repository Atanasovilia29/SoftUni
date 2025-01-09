using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double grade = 0;

            int classGrade = 0;

            double gradeAverage = 0;

            int fails = 0;

            while (true)
            {
                
                grade = double.Parse(Console.ReadLine());
                classGrade++;

                gradeAverage += grade;
                if (grade <= 3)
                {
                    ++fails;
                }


                if (fails >= 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {classGrade - 1} grade");
                    break;
                }
                else if (classGrade >= 12)
                {
                    gradeAverage /= (double)classGrade;
                    Console.WriteLine($"{studentName} graduated. Average grade: {gradeAverage:F2}");
                    break;
                }
            }
        }
    }
}