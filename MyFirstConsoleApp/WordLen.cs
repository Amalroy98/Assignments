using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    internal class WordLen
    {
        static void Main()
        {//Write a program in C# to accept a word from the user and display the length of it
            Console.WriteLine("Enter A word");
            string wrd=Console.ReadLine();
            Console.WriteLine(wrd.Length);
        }
    }
}
