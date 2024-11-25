using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string passWord = Console.ReadLine();

            if (passWord == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("The password you have inputed is right!");
            }
            else
            {
                Console.WriteLine("The password you have inputed is wrong!");
            }
        }
    }
}