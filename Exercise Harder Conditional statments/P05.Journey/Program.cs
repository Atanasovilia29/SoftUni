namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());

            string season = Console.ReadLine();

            double partOfTheBudget = 0;

            if (budget <= 100)
            {
                string placeForJourney = "Bulgaria";
                if (season == "summer")
                {
                    string restingPlace = "Camp";
                    partOfTheBudget = 0.30;
                    double totalPrice = budget * partOfTheBudget;

                    Console.WriteLine($"Somewhere in {placeForJourney} \n{restingPlace} - {totalPrice:f2}");
                }
                else if (season == "winter")
                {
                    string restingPlace = "Hotel";
                    partOfTheBudget = 0.70;
                    double totalPrice = budget * partOfTheBudget;

                    Console.WriteLine($"Somewhere in {placeForJourney} \n{restingPlace} - {totalPrice:f2}");
                }

            }
            else if (budget <= 1000)
            {
                string placeForJourney = "Balkans";
                if (season == "summer")
                {
                    string restingPlace = "Camp";
                    partOfTheBudget = 0.40;
                    double totalPrice = budget * partOfTheBudget;

                    Console.WriteLine($"Somewhere in {placeForJourney} \n{restingPlace} - {totalPrice:f2}");
                }
                else if (season == "winter")
                {
                    string restingPlace = "Hotel";
                    partOfTheBudget = 0.80;
                    double totalPrice = budget * partOfTheBudget;

                    Console.WriteLine($"Somewhere in {placeForJourney} \n{restingPlace} - {totalPrice:f2}");
                }
            }
            else if (budget > 1000)
            {
                string placeForJourney = "Europe";
                partOfTheBudget = 0.90;
                if (season == "summer")
                {
                    string restingPlace = "Hotel";
                    double totalPrice = budget * partOfTheBudget;

                    Console.WriteLine($"Somewhere in {placeForJourney} \n{restingPlace} - {totalPrice:f2}");
                }
                else if (season == "winter")
                {
                    string restingPlace = "Hotel";
                    double totalPrice = budget * partOfTheBudget;

                    Console.WriteLine($"Somewhere in {placeForJourney} \n{restingPlace} - {totalPrice:f2}");
                }
            }
        }
    }
}