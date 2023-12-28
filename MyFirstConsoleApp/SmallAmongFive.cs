using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class SmallAmongFive
    {
        static void Main()
        {
            int[] numbers = new int[5];

            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Find the smallest number
            int smallest = numbers[0];
            for (int i = 1; i < 5; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            Console.WriteLine("The smallest number is: {0}", smallest);
        }
    }
}
