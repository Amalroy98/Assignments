using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class TenMarks
    {
        static void Main()
        {
            int[] num = new int[10];
            int total,minimum,maximum = 0;
            double avg;
            Console.WriteLine("Enter 10 Marks");
            for (int i = 0; i < 10; i++)
            {
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            total=num.Sum();
            avg = num.Average();
            minimum = num.Min();
            maximum = num.Max();
            Console.WriteLine("Total = "+total);
            Console.WriteLine("Average = " + avg);
            Console.WriteLine("minimum = " + minimum);
            Console.WriteLine("maximum = " + maximum);
            Array.Sort(num);
            Console.Write("Ascending Order : ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" "+num[i]);
            }
            Array.Reverse(num);
            Console.Write("\nDescending Order : ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(" " + num[i]);
            }
        }
    }
}
