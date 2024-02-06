/*
 * Name: Day counter
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: It displays the message with corresponding number
 */

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int DAYS = 7;
            const string MESSAGE = "It is now day ";
            int i = 1;

            //Input
            Console.WriteLine("Day counter");
            Console.WriteLine("\n******Start of program******\n");

            //Processing
            while (i <= DAYS)
            {
                Console.WriteLine($"{MESSAGE}{i}");
                i++;
            }

            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}