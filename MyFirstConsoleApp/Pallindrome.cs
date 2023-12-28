namespace MyFirstConsoleApp
{
    internal class Pallindrome
    {
        static void Main()
        {
            Console.WriteLine("Enter the word");
            string? wrd = Console.ReadLine();
            char[] chars = wrd.ToCharArray();
            Array.Reverse(chars);
            string? rev = new string(chars);
            if (Array.Equals(wrd, rev))
            {
                Console.WriteLine("Pallindrome");
            }
            else
            {
                Console.WriteLine("Not Pallindrome");
            }
        }
    }
}
