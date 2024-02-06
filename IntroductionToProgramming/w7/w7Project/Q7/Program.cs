/*
 * Name: Loopcount
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Counts the number of loops 
 */

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            //Input
            Console.WriteLine("Loopcount");
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"The value of loopcount is {i}");
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}