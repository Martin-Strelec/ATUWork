/*
 * Name: Q10
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet tasks...
 */

namespace Q10
{
    internal class Program
    {

        static int numberOfKids = 4;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"Your discount {numberOfKids} kids is: {HolidayDiscount(numberOfKids):p}");
            Console.WriteLine("\n******End of program******\n");
        }

        static double HolidayDiscount(int numberOfKids)
        {
            double discount = 0;

            if (numberOfKids >= 1 && numberOfKids <= 2)
            {
                discount = 0.05;
            }
            else if (numberOfKids >= 3 && numberOfKids <= 5)
            {
                discount = 0.10;
            }
            else if (numberOfKids > 5)
            {
                discount = 0.15;
            }

            return discount;
        }
    }
}