/*
 * Name: For loops introduction part 4
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Displays the of result of multiplication of user inputted number
 */

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            double userInput;
            //Input
            Console.WriteLine("Multiplication table");
            Console.WriteLine("\n******Start of program******\n");

            Console.Write("Enter a number: ");
            userInput = double.Parse(Console.ReadLine());
            Console.Write("\n");
            //Processing
            //Output
            for (int i = 1; i <= 10; i++)
            {               
                double result = userInput * i;
                Console.WriteLine($"{userInput} X {i} = {result:N2}");
            }
            Console.WriteLine("\n******End of program******\n");
        }
    }
}