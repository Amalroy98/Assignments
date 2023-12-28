using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to find the multiplication");
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; i<= 20; i++)
            {
                Console.WriteLine($"{ num}* {i} = { i * num}");

            }
        }
    }
}
