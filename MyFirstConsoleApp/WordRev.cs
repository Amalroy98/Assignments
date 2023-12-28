using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class WordRev
    {
        static void Main()
        {//16. Write a program in C# to accept a word from the user and display the reverse of it.
            Console.WriteLine("Enter A word");
            string? wrd = Console.ReadLine();
            char[] chars = wrd.ToCharArray();
            Array.Reverse(chars);
            string? rev = new string(chars);
            Console.WriteLine(rev);
            
        }
    }
}
