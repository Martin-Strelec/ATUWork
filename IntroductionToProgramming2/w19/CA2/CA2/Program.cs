/*
 * Name: 
 * Author: M.Strelec
 * Date:
 * Purpose: 
 */

using System.Diagnostics.Metrics;
using System.Reflection;
using System.Transactions;

namespace Q1
{
    internal class Program
    {
        static char[] marks = { 'A', 'B', 'C', 'D', 'E', 'F' };
        static int[] score;
        static double[,] sums = new double[2, marks.Length];
        static bool exit = false;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            while (exit == false)
            {
                InputHandlerer(0, 100, -999);
            }
            Console.WriteLine();
            MarkAverage(score);
            //Processing
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer(int lowerRange, int upperRange, int exitCode)
        {
            int input;
            List<int> temporaryMark = new List<int>(); //Dynamic list for storing temporary values

            Console.Write($"Enter mark for student: ");
            try //Catches invalid format
            {
                input = int.Parse(Console.ReadLine());
                if (input >= lowerRange && input <= upperRange)
                {
                    temporaryMark.Add(input);
                    MarkDisplay(input);
                }
                else if (input == exitCode)
                {
                    exit = true;
                    try
                    {
                        score = temporaryMark.ToArray();
                    }
                    catch (IndexOutOfRangeException myError)
                    {
                        Console.WriteLine(myError.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    Console.Write("> ");
                }
            }
            catch (FormatException myError)
            {
                Console.WriteLine(myError.Message);
                Console.WriteLine("Invalid input");
                Console.Write("> ");
            }

        }

        static void MarkDisplay(int score)
        {
            if (score <= 39)
            {
                Console.WriteLine($"Your mark is: {marks[marks.Length - 1]}");
                sums[0, marks.Length - 1] += score;
                sums[1, marks.Length - 1]++;
            }
            else if (score >= 40 && score <= 49)
            {
                Console.WriteLine($"Your mark is: {marks[marks.Length - 2]}");
                sums[0, marks.Length - 2] += score;
                sums[1, marks.Length - 2]++;
            }
            else if (score >= 50 && score <= 59)
            {
                Console.WriteLine($"Your mark is: {marks[marks.Length - 3]}");
                sums[0, marks.Length - 3] += score;
                sums[1, marks.Length - 3]++;
            }
            else if (score >= 60 && score <= 69)
            {
                Console.WriteLine($"Your mark is: {marks[marks.Length - 4]}");
                sums[0, marks.Length - 4] += score;
                sums[1, marks.Length - 4]++;
            }
            else if (score >= 70 && score <= 79)
            {
                Console.WriteLine($"Your mark is: {marks[marks.Length - 5]}");
                sums[0, marks.Length - 5] += score;
                sums[1, marks.Length - 5]++;
            }
            else if (score >= 79)
            {
                Console.WriteLine($"Your mark is: {marks[0]}");
                sums[0, 0] += score;
                sums[1, 0]++;
            }
        }

        static void MarkAverage(int[] score)
        {
            double average = 0;
            bool markPresent = true;

            for (int i = 0; i < marks.Length; i++)
            {
                if (sums[1, i] == 0)
                {
                    Console.WriteLine($"No students with {marks[i]} mark.");                    markPresent = false;
                }
                else
                {
                    average = sums[0, i] / sums[1, i];
                }
                if (markPresent == true)
                {
                    Console.WriteLine($"The average for mark {marks[i]} is: {average}");

                }
            }
        }

    }


}
