/*
 * FormattingNumber
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: This program Formats one number into different formats
 */
using System.Diagnostics.CodeAnalysis;

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaration
            double number = 999999.014;

            //Processing
            //Output
            Console.WriteLine("\n******Number formats******\n");
            Console.WriteLine($"Base number: \t\t\t\t\t{number}");
            Console.WriteLine($"{number} in dollars:   \t\t\t{number:c}");
            Console.WriteLine($"{number} with 3 decimal places:   \t\t{number:f3}");
            Console.WriteLine($"{number} with 2 decimal places:   \t\t{number:f2}");
            Console.WriteLine($"22 as a percentage using 0.22:p0:   \t\t{0.22:p0}");
            Console.WriteLine($"{number} as a number with commas: \t\t{number:n0}");
            Console.WriteLine($"{number} as a int using Convert.ToInt32:   \t{Convert.ToInt32(number)}");
            Console.WriteLine("\n******End of program******");
        }
    }
}