using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            int num = 0;

            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);


            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // print each number in numbers
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            
            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i <= (numbers.Count) && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}

