using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());  // Read the target sum number

            int input = 0;  // This variable will store each input
            int inputSum = 0;  // This will accumulate the sum of inputs

            // Loop until inputSum is greater than or equal to num
            while (inputSum < num)
            {
                input = int.Parse(Console.ReadLine());  // Read each new input
                inputSum += input;  // Add the input to the sum
            }

            // Output the total sum that has accumulated
            Console.WriteLine(inputSum);
        }
    }
}
