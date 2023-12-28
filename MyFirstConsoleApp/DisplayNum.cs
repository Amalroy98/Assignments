using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class DisplayNum
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2=int.Parse(Console.ReadLine());
            for(int i = num1+1; i < num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
