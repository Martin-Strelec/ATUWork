/*
 * Name: Even or Odd number
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It checks, if the number is Even or Odd
 */

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -25;
            int inputNumber, decision;

            //Input
            Console.WriteLine("Even or Odd number");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the number (without decimal places)",TAB_INDENTATION}: ");
            inputNumber = int.Parse(Console.ReadLine());
            //Processing

            decision = inputNumber % 2; //Uses modulo to check if the number is divisible by 2 without leftover

            if (decision != 0)
            {
                Console.WriteLine($"\nThe number {inputNumber} is an odd number!");
            }
            else
            {
                Console.WriteLine($"\nThe number {inputNumber} is an even number!");
            }

            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}