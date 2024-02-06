/*
 * Name: Q2
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

namespace Q2
{
    internal class Program
    {

        static int period;
        static float[,] data;
        static float averageRainfall; 

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine("Rainfall calculation");
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Processing
            //Output
            DisplayTab();
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            Console.Write("Enter the number of years: ");
            while (!int.TryParse(Console.ReadLine(), out period))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }

            data = new float[period, 12];

            for (int i = 0; i < period; i++)
            {
                Console.WriteLine($"\nYear {i+1}");
                Console.WriteLine("Enter the amount of cm of raninfall: ");
                Console.WriteLine("");
                for (int j = 0; j < 12; j++)
                {
                    Console.Write($"Month {j + 1}: ");
                    while (!float.TryParse(Console.ReadLine(), out data[i, j])) 
                    {
                        Console.WriteLine("Invaid input!");
                        Console.Write("> ");
                    }
                }
            }

        }
        static float RainfallAverage()
        {
            float averageSum = 0;

            for (int i = 0; i < period; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    averageSum += data[i, j];
                }
            }
            averageRainfall = averageSum / (period * 12);
            return averageRainfall;
        }
        static void DisplayTab()
        {
            const string OUTPUT_TAB = "{0,-15}{1,-5}{2,10}";

            for (int i = 0; i < period; i++)
            {
                Console.WriteLine($"\nYear {i+1}");
                Console.WriteLine("******************************");
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine(OUTPUT_TAB, $"Month {j+1}", "|", $"{data[i,j]}cm");
                }
                Console.WriteLine("******************************");
            }

            Console.WriteLine($"\nAverage rainfall: {RainfallAverage():N1}cm");
        }
    }
}