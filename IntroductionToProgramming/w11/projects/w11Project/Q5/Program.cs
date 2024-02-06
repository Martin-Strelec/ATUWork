/*
 * Name: For loop introduction part 5 
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Displays a certain pattern
 */

namespace Q5
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
            for (int i = 8; i > 0; i--)
            {               
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n******End of program******\n");
        }
    }
}