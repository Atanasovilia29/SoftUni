namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();

            int numberOfNightsStaying = int.Parse(Console.ReadLine());

            double discount = 0;

            double discountForAppartment = 0;

            double studio = 0;
            double appartment = 0;

            if (month == "May" || month == "October")
            {
                studio = 50;
                appartment = 65;
                if (numberOfNightsStaying > 7)
                {

                    if (numberOfNightsStaying > 14)
                    {
                        discount = studio * 0.30;
                        discountForAppartment = appartment * 0.10;

                    }
                    else
                    {
                        discount = studio * 0.05;

                    }
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20;
                appartment = 68.70;
                if (numberOfNightsStaying > 14)
                {
                    discountForAppartment = appartment * 0.10;

                    discount = studio * 0.20;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76;
                appartment = 77;
                if (numberOfNightsStaying > 14)
                {
                    discountForAppartment = appartment * 0.10;

                }
            }
            studio -= discount;

            appartment -= discountForAppartment;

            Console.WriteLine($"Apartment: {appartment * numberOfNightsStaying:f2} lv.");

            Console.WriteLine($"Studio: {studio * numberOfNightsStaying:f2} lv.");
        }
    }
}