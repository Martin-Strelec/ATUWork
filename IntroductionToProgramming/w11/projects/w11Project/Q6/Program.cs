/*
 * Name: For loop introduction part 6
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Display an 'L' shape out of asterisks
 */

namespace Q6
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
            for (int i = 0; i < 7; i++)
            {
                if (i == 6)
                {
                    Console.WriteLine("********");
                }
                else
                {
                    Console.WriteLine("*");
                }
            }
            Console.WriteLine("\n******End of program******\n");
        }
    }
}