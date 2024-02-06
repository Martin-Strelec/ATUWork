/*
 * Name: Summary 
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: It sums up values between two inputed numbers
 */

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            int inputNumberOne, inputNumberTwo, result;
            int i = 0;

            //Input
            Console.WriteLine("The SUM");
            Console.WriteLine("\n******Start of program******\n");
            Console.WriteLine("Enter the first number followed by second number.");
            Console.WriteLine("Remember that the second number has to be bigger than the first one!\n");
            Console.Write("Enter the first number: ");
            inputNumberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            inputNumberTwo = int.Parse(Console.ReadLine());

            //Processing
            i = inputNumberOne;
            result = i;
            while (i < inputNumberTwo) 
            {
                result += i+1;
                i++;
            }

            //Output
            Console.WriteLine($"The sum of the numbers between {inputNumberOne} and {inputNumberTwo} is: {result}");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}