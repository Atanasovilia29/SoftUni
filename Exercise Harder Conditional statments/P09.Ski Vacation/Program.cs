using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           // BASE INPUTS FROM USER 
            int daysStaying = int.Parse(Console.ReadLine());

            string roomStaying = Console.ReadLine();

            string review = Console.ReadLine();

            double roomsPrice = 0;
            double discount = 0;
            double discountAfter = 0;
            
            // TURNING DAYS INTO NIGHTS OF RESIDING
            daysStaying -= 1;

            if (roomStaying == "room for one person")
            {
                roomsPrice = 18 * daysStaying;
            }
            else if (roomStaying == "apartment")
            {
                roomsPrice = 25 * daysStaying;
                if (daysStaying < 10)
                {
                    discount = roomsPrice * 0.3;
                    
                }
                else if (daysStaying >= 10 && daysStaying <= 15) 
                {
                    discount = roomsPrice * 0.35;
                    
                }
                else
                {
                      discount = roomsPrice * 0.5;
                }
                
            }
            else if (roomStaying == "president apartment")
            {
                roomsPrice = 35 * daysStaying;
                if (daysStaying < 10)
                {
                    discount = roomsPrice * 0.1;

                }
                else if (daysStaying >= 10 && daysStaying <= 15)
                {
                    discount = roomsPrice * 0.15;

                }
                else
                {
                    discount = roomsPrice * 0.2;
                }
            }
            roomsPrice -= discount;

            if (review == "positive")
            {
                discountAfter = roomsPrice *0.25;
                roomsPrice += discountAfter;   
            }
            else if (review == "negative")
            {
                discountAfter = roomsPrice * 0.10;
                roomsPrice -= discountAfter;
            }


            Console.WriteLine($"{roomsPrice:f2}");

        }
    }
}