using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class WoedCmp
    {
        static void Main()
        {
            Console.WriteLine("Enter 2 words");
            string? wrd1 = Console.ReadLine();
            string? wrd2 = Console.ReadLine();
            if(Array.Equals(wrd1, wrd2))
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("Not Same");
            }
        }
    }
}
