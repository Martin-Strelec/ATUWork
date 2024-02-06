/*
 * Name: Q3
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet tasks...
 */

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"{IsValidAge(23)}");
            Console.WriteLine("\n******End of program******\n");
        }

        static bool IsValidAge(int age)
        {
            bool result = false;

            if (age >= 18 && age <= 21)
            {
                return true;
            }

            return result;
        }
    }
}