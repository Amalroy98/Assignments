using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Divisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The number Divisible by 7 list below");
            for(int i=200;i<=300;i++)
            {
                if(i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
