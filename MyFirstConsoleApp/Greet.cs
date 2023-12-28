using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class Greet
    {
        static void Main()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("HI! " + name);
            Console.WriteLine("WELCOME TO THE WORLD OF C#");
        }

    }
}
