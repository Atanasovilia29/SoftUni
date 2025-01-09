namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            int totalNumbers1 = 0;
            int totalNumbers2 = 0;
            int totalNumbers3 = 0;
            int totalNumbers4 = 0;
            int totalNumbers5 = 0;

            for (int i = 0; i < n; i++)
            {

                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    totalNumbers1++;
                }
                else if (num >= 200 && num <= 399)
                {
                    totalNumbers2++;
                }
                else if (num >= 400 && num <= 599)
                {
                    totalNumbers3++;
                }
                else if (num >= 600 && num <= 799)
                {
                    totalNumbers4++;
                }
                else
                {
                    totalNumbers5++;
                }

            }
            p1 = (double)totalNumbers1 / (double)n * 100;
            p2 = (double)totalNumbers2 / (double)n * 100;
            p3 = (double)totalNumbers3 / (double)n * 100;
            p4 = (double)totalNumbers4 / (double)n * 100;
            p5 = (double)totalNumbers5 / (double)n * 100;
            Console.WriteLine($"{p1:f2}%\n{p2:f2}%\n{p3:f2}%\n{p4:f2}%\n{p5:f2}%");


        }
    }
}