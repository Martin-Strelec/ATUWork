/*
 * Name: For loops introduction part 3
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Checks if user is inputting right password
 */

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string password = "haha";
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            for (int i = 1; i <= 7; i++)
            {
                Console.Write("Enter password: ");
                if (Console.ReadLine() == password)
                {
                    Console.WriteLine("\nCorrect!");
                    Console.WriteLine($"Correct password after {i} tries.");
                    break;
                }
                Console.WriteLine("Wrong password. Try again!\n");
            }
            Console.WriteLine("\n******End of program******\n");
        }
    }
}   