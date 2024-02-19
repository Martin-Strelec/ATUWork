/*
 * Name: Q1
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

using System.Net.Sockets;
using System.Xml.Schema;

namespace Q1
{
    internal class Program
    {

        static string[] names = { "Pat", "John", "Kim", "Betty", "Ivana" };
        static int numberOfMatches = 4; //Enter one more for final score
        static int[,] score = new int[names.Length + 1, numberOfMatches];

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Processing
            //Output
            DisplayTab();
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"\nEnter score for {names[i]}");
                for (int j = 0; j < numberOfMatches; j++)
                {
                    Console.Write($"Match {j + 1}: ");
                    while (!int.TryParse(Console.ReadLine(), out score[i, j]))
                    {
                        Console.WriteLine("Invalid input. Try again!");
                        Console.Write("> ");
                    }
                }

            }

            for (int i = 0; i < numberOfMatches; i++)
            {
                for (int j = 0; j < names.Length; j++)
                {
                    score[names.Length, i] += score[j, i];
                }
            }
        }
        static void DisplayTab()
        {
            const string OUTPUT_TAB = "{0,-10} {1,-5} {2,-7} {3,-7} {4,-7} {5,-7}";

            Console.WriteLine("");
            Console.WriteLine(OUTPUT_TAB, "Player", "|", "Match 1", "Match 2", "Match 3", "Match 4");
            Console.WriteLine("-----------|-----------------------------------");
            for (int i = 0; i < names.Length; i++)
            { 
                Console.WriteLine(OUTPUT_TAB, $"{names[i]}", "|", $"{score[i, 0]}", $"{score[i, 1]}", $"{score[i, 2]}", $"{score[i, 3]}");
            }
            Console.WriteLine("-----------|-----------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Totals","|", $"{score[names.Length, 0]}",
                                                        $"{score[names.Length, 1]}",
                                                        $"{score[names.Length, 2]}",
                                                        $"{score[names.Length, 3]}");
            Console.WriteLine("-----------|-----------------------------------");


        }
    }
}