﻿using System;

class Program
{
    static void Main()
    {
        double totalAmount = 0.0; 

        while (true)
        {
            string input = Console.ReadLine(); 

            if (input == "NoMoreMoney")
            {
                break; 
            }
            if (double.TryParse(input, out double amount))
            {
                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!"); 
                    break;
                }

                Console.WriteLine($"Increase: {amount:F2}");
                totalAmount += amount; 
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a valid number."); 
            }
        }
        Console.WriteLine($"Total: {totalAmount:F2}"); 
    }
}
