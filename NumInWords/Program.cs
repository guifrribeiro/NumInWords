using System;
using Reader;

namespace NumInWords
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine("-------------------NUMBER INTO WORDS HEXAGON-------------------");
            Console.WriteLine("Enter 'exit' to finish the system!");
            Console.Write("Enter a number: ");
            string info = Console.ReadLine();

            while (info != "exit")
            {
                bool successParse = double.TryParse(info, out double number);
                if (!string.IsNullOrEmpty(info) && successParse)
                {
                    Console.WriteLine($"RESULT: {NumberReader.NumberIntoWord(number)}");
                }

                Console.Write($"Enter a {(successParse ? string.Empty : "valid")} number: ");
                info = Console.ReadLine();
            }
        }
    }
}
