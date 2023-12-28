using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Celsius
    {
        static void Main()
        {
            Console.WriteLine("Enter the tempeture in fahrenheit");
            int f = int.Parse(Console.ReadLine());
            int c = (f - 32) * 5 / 9;
            Console.WriteLine("celsius="+c);
        }
    }
}
