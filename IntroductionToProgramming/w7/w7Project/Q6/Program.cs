/*
 * Name: Average of user inputed values
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Calculates the average of 5 values inputed by the users
 */

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int NUMBER_OF_INPUTS = 5, TAB_INDENTATION = -35;
            double average, userInput, sum = 0;

            //Input
            Console.WriteLine("Average calculator");
            Console.WriteLine("\n******Start of program******\n");
            for (int i = 0; i < NUMBER_OF_INPUTS; i++)
            {
                Console.WriteLine($"{$"Enter the number {i+1}", TAB_INDENTATION}: ");
                userInput = double.Parse(Console.ReadLine());
                sum += userInput;
            }

            //Processing
            average = sum / NUMBER_OF_INPUTS;
            
            //Output
            Console.WriteLine($"\nTotal grade is {sum} with average of {average}");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}