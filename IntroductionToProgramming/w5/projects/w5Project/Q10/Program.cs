/*
 * Name: Visa elegibilty
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Decides if you are elegible to issue a Visa card
 */

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int UPPER_BOUNDARY = 25, LOWER_BOUNDARY = 18, TAB_INDENTATION = -35;
            string userName;
            int userAge;

            //Input
            Console.WriteLine("Visa issuing");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name",TAB_INDENTATION}: ");
            userName = Console.ReadLine();
            Console.Write($"{"Enter your age",TAB_INDENTATION}: ");
            userAge = int.Parse(Console.ReadLine());

            //Processing & Output
            if (userAge <= UPPER_BOUNDARY && userAge >= LOWER_BOUNDARY)
            {
                Console.WriteLine($"\n{userName}, you are eligible for Visa");
            }
            else
            {
                Console.WriteLine($"\n{userName}, you are not eligible for Visa");
            }

            Console.WriteLine("\n******End of program******\n");
        }
    }
}