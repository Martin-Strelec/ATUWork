/*
 * Name: Q2
 * Author: M.Strelec
 * Date: 3/2024
 * Purpose: CA2 Mock Questions
 */

using System.Reflection.Metadata.Ecma335;

namespace Q2
{
    internal class Program
    {

        static bool exit = false;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            while (exit == false)
            {
                DisplayTab();
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        WeightInput(0, 20000);
                        break;

                    case 2:
                        //Report();
                        break;

                    case 3:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option!");
                        Console.Write("> ");
                        break;
                }
            }
            //Output
            DisplayTab();
            Console.WriteLine("\n******End of program******\n");
        }

        static void DisplayTab()
        {
            string[] options = { "Calculate Quote", "Report", "Exit" };
            Console.WriteLine("\n*****************");
            Console.WriteLine("Menu: ");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{options[i]}");
            }
            Console.WriteLine("*****************");
        }

        static int WeightInput(int lowerRange, int upperRange)
        {
            int input;
            Console.Write("Enter the weight of your package (kg): ");
            while (!int.TryParse(Console.ReadLine(), out input) || !(input >= lowerRange && input <= upperRange))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }

            return input;
        }

        static string DestinationInput(string[] validCountries, string input)
        {
            while (exit == false)
            {
                for (int i = 0; i < validCountries.Length; i++)
                {
                    if ()
            }
            }
            



            return;
        }
    }
}