/*
 * Name: Format table
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It outputs numbers in different formats
 */

namespace Q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            //Input
            Console.WriteLine("Formatted output");
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"{1547.2:c}");
            Console.WriteLine($"{0.23:p}");
            Console.WriteLine($"{15000:###,###}");
            Console.WriteLine($"{432.8175:N3}");
            Console.WriteLine($"{300000:E}");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}