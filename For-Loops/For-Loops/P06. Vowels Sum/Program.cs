using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine(); 

        int vowellsCounter = 0;

       

        for (int i = 0; i < input.Length; i++)
        {
            char letter = char.ToLower(input[i]);
            
            if (letter == 'a')
            {
                vowellsCounter += 1;
            }
            else if (letter == 'e')
            {
                vowellsCounter += 2;
            }
            else if (letter == 'i')
            {
                vowellsCounter += 3;
            }
            else if (letter == 'o')
            {
                vowellsCounter += 4;
            }
            else if (letter == 'u')
            {
                vowellsCounter += 5;
            }
            
        }
        Console.WriteLine(vowellsCounter);
    }

    }
