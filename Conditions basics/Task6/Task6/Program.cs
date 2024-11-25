using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string shape = Console.ReadLine();
            
            double shapeTotal = 0;

            if (shape == "square")
            {
                double shapeLeght = double.Parse(Console.ReadLine());
                shapeTotal = shapeLeght * shapeLeght;
                Console.WriteLine($"{shapeTotal:f3}");

            }
            else if (shape == "rectangle") 
            {
                double shapeWidth = double.Parse(Console.ReadLine());
                double shapeLeght = double.Parse(Console.ReadLine());
                shapeTotal = shapeWidth * shapeLeght;
                Console.WriteLine($"{shapeTotal:f3}");
            }
            else if (shape == "triangle") 
            {
                double shapeBase = double.Parse(Console.ReadLine());
                double shapeLeght = double.Parse(Console.ReadLine());
                double shapeHeight = double.Parse(Console.ReadLine());
                shapeTotal += 1/2 *shapeBase * shapeLeght;
                Console.WriteLine($"{shapeTotal:f3}");
            }
            else
            {
                double shapeRaduis = double.Parse(Console.ReadLine());
                shapeTotal = (shapeRaduis* shapeRaduis) * Math.PI;
                Console.WriteLine($"{shapeTotal:f3}");
            }

        }
    }
}