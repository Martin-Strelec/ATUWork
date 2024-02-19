/*
 * Name: Q4 
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

using System.Numerics;

namespace Q4
{
    internal class Program
    {

        static int[,] xMatrix = { { 2, 4, 6 }, 
                                  { 6, 8, 2 }, 
                                  { 2, 7, 4 } };

        static int[,] yMatrix = { { 2, 4, 6 }, 
                                  { 6, 8, 2 }, 
                                  { 2, 7, 4 } };

        static int[,] sum = new int[xMatrix.GetLength(0), xMatrix.GetLength(1)];

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            AddMatrices(xMatrix, yMatrix);
            //Output
            //Console.WriteLine($"{xMatrix.GetLength(1)}");
            DisplayTab();
            Console.WriteLine("\n******End of program******\n");
        }

        static void AddMatrices(int[,] matrix1, int[,] matrix2)
        {

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
        }

        static void DisplayTab()
        {
            const string OUTPUT_TAB = "{0,3}{1,3}{2,3}{3,3}{4,3}{5,3}{6,3}{7,3}{8,3}{9,3}{10,3}{11,3}{12,3}{13,3}{14,3}{15,3}{16,3}";
            for (int i = 0; i < xMatrix.GetLength(0); i++)
            {
                Console.WriteLine(OUTPUT_TAB, "|", $"{xMatrix[i, 0]}", $"{xMatrix[i, 1]}", $"{xMatrix[i, 2]}", "|", $"{(i == 1 ? "+" : "")}",
                                          "|", $"{yMatrix[i, 0]}", $"{yMatrix[i, 1]}", $"{yMatrix[i, 2]}", "|",$"{(i == 1 ? "=" : "")}",
                                          "|", $"{sum[i, 0]}", $"{sum[i, 1]}", $"{sum[i, 2]}", "|");
            }

        }
    }
}