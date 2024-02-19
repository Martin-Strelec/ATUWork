/*
 * Name: Q5
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

using System.Net.Sockets;
using System.Xml.Schema;

namespace Q5
{
    internal class Program
    {

        static int numberOfPlayers = 11;
        static int numberOfMatches = 5; //Enter one more for final score
        static int[,] score = new int[numberOfPlayers + 1, numberOfMatches];

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
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine($"\nEnter score for Player {i + 1}");
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
                for (int j = 0; j < numberOfPlayers; j++)
                {
                    score[numberOfPlayers, i] += score[j, i];
                }
            }
        }
        static void DisplayTab()
        {
            const string OUTPUT_TAB = "{0,-10} {1,-5} {2,-7} {3,-7} {4,-7} {5,-7} {6,-7}";

            Console.WriteLine("");
            Console.WriteLine(OUTPUT_TAB, "Player", "|", "Match 1", "Match 2", "Match 3", "Match 4", "Match 5");
            Console.WriteLine("-----------|---------------------------------------------");
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine(OUTPUT_TAB, $"Player {i + 1}", "|", $"{score[i, 0]}", $"{score[i, 1]}", $"{score[i, 2]}", $"{score[i, 3]}", $"{score[i, 4]}");
            }
            Console.WriteLine("-----------|---------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Totals", "|", $"{score[numberOfPlayers, 0]}",
                                                        $"{score[numberOfPlayers, 1]}",
                                                        $"{score[numberOfPlayers, 2]}",
                                                        $"{score[numberOfPlayers, 3]}",
                                                        $"{score[numberOfPlayers, 4]}");
            Console.WriteLine("-----------|---------------------------------------------");


        }
    }
}