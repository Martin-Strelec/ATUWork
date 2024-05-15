/*
*	Name: ExamMock2
*	Author: Martin Strelec
*	Date: 13/May/2024
*	Purpose: Practice
*/

using System.Runtime.CompilerServices;

namespace ExamMock2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console formatting command

            // Declaration

            // Input
            Console.WriteLine("ExamMock2");
            Console.WriteLine("******Start of program******");
            FileRead file = new FileRead("./data.csv", 3, ',',false);
            // Processing
            SearchForTown(file.Database);
            // Output
            Console.WriteLine("******End of program******");
        }

        static void SearchForTown(List<string[]> data) //Method for searching in a List 
        {
            StrModifier mod = new StrModifier();
            string input = "0";
            bool found;

            while (input.ToLower() != "no" && input.ToLower() != "n")
            {
                found = false;
                Console.WriteLine("Please enter city name: ");
                input = Console.ReadLine();
                for (int i = 0; i < data.Count; i++)
                {
                    if (mod.SimplifyString(input) == mod.SimplifyString(data[i][1]))
                    {
                        Console.WriteLine(TempEvaluation(int.Parse(data[i][2])) + " in " + data[i][1]);
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    Console.WriteLine("Town not found!");
                }

                Console.WriteLine("Find another? Y/N: ");
                input = Console.ReadLine();
            }
        }
        static string TempEvaluation(int temp) //Evaluating temperature and displaying corresponding message
        {
            if (temp > 25)
            {
                return "It's too hot";
            }
            else if (temp >= 10 && temp < 25)
            {
                return "It's moderate";
            }
            else
            {
                return "It's too cold";
            }
        }
    }
}