using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Fabonacci
    {
        static void Main(string[] args)
        {
            int a=0,b=1,c=0;
            Console.Write($"{a} {b} ");
            for(int i= 2; i<=40; i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.Write(b + " ");
            }
        }
    }
}
