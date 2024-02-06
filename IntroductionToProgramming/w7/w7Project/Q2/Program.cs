/*
 * Name: Count and display
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Program counts and displays values
 */

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int AMOUNT = 21;
            const string MESSAGE = "Merry Christmas!";
            const string OUTPUT_TAB ="{0,20}{1,5}{2,5}{3,5}";
            int i = 1, TwentyToOne, OddNumbers = 0;

            //Input
            Console.WriteLine("Count and display");
            Console.WriteLine("\n******Start of program******\n");

            //Processing
            while (i < AMOUNT)
            {
                TwentyToOne = AMOUNT - i;
                if ((i%2) == 0) 
                {
                    OddNumbers = 0;
                }
                else
                {
                    OddNumbers = i;
                }
                Console.WriteLine(OUTPUT_TAB, $"{MESSAGE}", $"{i}", $"{TwentyToOne}", $"{OddNumbers}");
                i++;
            }

            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}