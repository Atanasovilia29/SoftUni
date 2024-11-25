using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());


            if (grade < 5.50)
            {
                Console.WriteLine("This is not Excelent");
            }
            else
            {
                Console.WriteLine("Excelent");
            }
        }
    }
}