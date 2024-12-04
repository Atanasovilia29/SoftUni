using System;

namespace CornerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUTS USER
            
            string product = Console.ReadLine();

            string city = Console.ReadLine();

            double count = double.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(0.5 * count);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(0.40 * count);
                            break;
                        case "Varna":
                            Console.WriteLine(0.45 * count);
                            break;

                        default:
                            break;
                    }
                    break;
                case "water":
                    
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(0.80 * count);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(0.70 * count);
                            break;
                        case "Varna":
                            Console.WriteLine(0.70 * count);
                            break;

                        default:
                            break;
                    }
                    break;
                
                case "beer":
                    
                    switch (city)
                    {
                        
                        case "Sofia":
                            Console.WriteLine(1.2 * count);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.15 * count);
                            break;
                        case "Varna":
                            Console.WriteLine(1.10 * count);
                            break;

                        default:
                            break;
                    }
                    break;
                
                case "sweets":
                    
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(1.45 * count);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.30 * count);
                            break;
                        case "Varna":
                            Console.WriteLine(1.35 * count);
                            break;

                        default:
                            break;
                    }
                    break;
                
                case "peanuts":
                    
                    switch (city)
                    {
                        case "Sofia":
                            Console.WriteLine(1.60 * count);
                            break;
                        case "Plovdiv":
                            Console.WriteLine(1.50 * count);
                            break;
                        case "Varna":
                            Console.WriteLine(1.55 * count);
                            break;

                        default:
                            break;
                    }
                    break;

            }
           
        }
    }
}