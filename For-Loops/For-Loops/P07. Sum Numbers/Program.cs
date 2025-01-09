using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumNum = 0;
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sumNum += num;
            }
                Console.WriteLine(sumNum);
        }
    }
}