/*
 * Name: Reactor temperature check
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Checks the temperature of the reactor and then acts acordingly
 */

using System.Transactions;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -40, LOWER_BOUNDARY = 200, UPPER_BOUNDARY = 250;
            double reactorTemp;
            //Input
            Console.WriteLine("Reactor temperature check");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the temperature of te reactor:",TAB_INDENTATION} ");
            reactorTemp = double.Parse(Console.ReadLine());
            //Processing
            if (reactorTemp > UPPER_BOUNDARY)
            {
                Console.WriteLine($"\nThe temperature is {reactorTemp}. SHUT DOWN THE REACTOR IMMIDIETALY!!!\n");
            }
            else if (reactorTemp < UPPER_BOUNDARY)
            {
                Console.WriteLine($"\nThe temperature is {reactorTemp} degrees. WARNING, the temperature is rising!\n");
            }
            else
            {
                Console.WriteLine($"\nThe temperature is {reactorTemp}. Temperature is stable.\n");
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}