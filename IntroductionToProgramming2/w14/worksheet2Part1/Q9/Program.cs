/*
 * Name: Q9
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet tasks...
 */

namespace Q9
{
    internal class Program
    {

        static int numberOfDays = 1;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"The cost of renting the lawnmover for {numberOfDays} days is: {LawnMoverRent(numberOfDays):c}");
            Console.WriteLine("\n******End of program******\n");
        }

        static double LawnMoverRent(int numberOfDays)
        {
            const int STANDARD_FEE = 10, ADDITIONAL_FEE = 8, MINIMUM_FEE = 15; 
            int rentCost = MINIMUM_FEE;

            if (numberOfDays > 1 && numberOfDays <= 5)
            {
                rentCost = MINIMUM_FEE + (numberOfDays * STANDARD_FEE);
            }
            else if (numberOfDays > 5)
            {
                rentCost = MINIMUM_FEE + (5 * STANDARD_FEE) + ((numberOfDays - 5) * 8);
            }
            else if (numberOfDays >= 0 && numberOfDays <= 1)
            {
                rentCost = MINIMUM_FEE;
            }

            return rentCost;
        }
    } 
}