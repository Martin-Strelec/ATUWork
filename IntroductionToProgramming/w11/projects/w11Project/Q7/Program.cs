/*
 * Name: Arrays introduction part 1
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Stores 6 values from console into PlayerAges array
 */

using System.Transactions;

namespace Q7
{
    internal class Program
    {
        static int[] playerAge = new int[6];

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string[] playerNames = new string[6]; //Question number 7
            
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Enter the number {i+1}: ");
                playerAge[i] = int.Parse(Console.ReadLine());
            }

            //Processing

            //Output
            DisplayElements();

            Console.WriteLine("\n******End of program******\n");
        }

        static void DisplayElements()
        {
            Console.WriteLine($"\nDisplaying first, third and last element in array: {playerAge[0]}, {playerAge[2]}, {playerAge[playerAge.Length - 1]}");
        }
    }
}