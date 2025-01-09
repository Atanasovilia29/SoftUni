using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            
            int sumWithouthMax = 0;

            int diff = 0;
            for (int i = 0; i < n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                
                sum += currNumber;
                if (currNumber > max)
                {
                    max = currNumber;
                }
            }
            sumWithouthMax = sum - max;
            
            if (sumWithouthMax == max)
            {
                Console.WriteLine($"Yes \nSum = {sumWithouthMax}");
            }
            else
            {
                
                Console.WriteLine($"No\n Diff = {diff = Math.Abs(max - sumWithouthMax)}");
            }


        }
    }
}