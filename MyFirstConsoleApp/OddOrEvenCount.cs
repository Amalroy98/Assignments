namespace MyFirstConsoleApp
{
    internal class OddOrEvenCount
    {
        static void Main()
        {//Write a program in C# to find the total number of odd and even numbers accepted from the user
            int[] numbers = new int[5];
            int evenCount = 0, oddCount = 0;
            Console.WriteLine("Enter {0} numbers:", numbers.Length);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Total even numbers: {0}", evenCount);
            Console.WriteLine("Total odd numbers: {0}", oddCount);
        }
    }
}
