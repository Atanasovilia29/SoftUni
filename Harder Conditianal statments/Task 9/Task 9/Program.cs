using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string product = Console.ReadLine();

            string[] fruits = { "banana", "apple", "kiwi", "cherry", "lemon", "grapes" };
            string[] vegetables = { "tomato", "cucumber", "pepper" , "carrot" };

           

            if (Array.Exists(fruits, fruit => fruit == product))
            {
                Console.WriteLine($"You chose a fruit {product}");
            }
            else if (Array.Exists(vegetables, vegetable => vegetable == product)) 
            {
                Console.WriteLine($"You chose a vegetable {product}");
            }
            else
            {
                    Console.WriteLine("Unknown");
            }
        }
    }
}