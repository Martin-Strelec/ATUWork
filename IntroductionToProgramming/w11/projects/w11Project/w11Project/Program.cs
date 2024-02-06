/*
 * Name: For loops introduction part 1
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Print out all numbers between 10 and 22
 */

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine("For loops");
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            for (int i = 10; i <= 22; i++)
            {
                Console.WriteLine($"Number {i}");
                i += 1;
            }

            Console.WriteLine("\n******End of program******\n");
        }
    }
}