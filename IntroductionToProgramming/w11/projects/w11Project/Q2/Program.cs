/*
 * Name: For loops introduction part 2
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Sums all numbers between 10 and 22
 */

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            int sum = 0;
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }

            //Output
            Console.WriteLine($"The sum between 1 and 10 is: {sum}");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}