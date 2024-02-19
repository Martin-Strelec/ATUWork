/*
 * Name: Q1
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: 
 */

using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;

namespace Q1
{
    internal class Program
    {

        static int[] array = { 1, 2, 3, 4, 6, 8, 10, 12, 14, 16, 18 };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Input
            Console.WriteLine("Array summarize");
            Console.WriteLine("\n******Start of program******\n");
            //Output
            Console.WriteLine($"Smallest Number: {ArraySmallest(array)}");
            Console.WriteLine($"Biggest Number: {ArrayLargest(array)}");
            Console.WriteLine($"Is array sorted ascending?: {ArraySortedAscending(array)}");
            ThirdElementAverage(array);
            Console.WriteLine($"The standard deviation: {StandardDeviation(array):N2}");
            Console.WriteLine("\n******End of program******\n");
        }

        static int ArrayLargest(int[] array)
        {
            int highestNumber = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > highestNumber)
                {
                    highestNumber = array[i];
                }
            }

            return highestNumber;
        }

        static int ArraySmallest(int[] array)
        {
            int smallestNumber = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < smallestNumber)
                {
                    smallestNumber = array[i];
                }
            }
            return smallestNumber;
        }

        static bool ArraySortedAscending(int[] array)
        {
            bool isAscending = true;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    isAscending = false;
                }
                else
                {
                    isAscending = true;
                }
            }
            return isAscending;
        }

        static void ThirdElementAverage(int[] array)
        {
            double averageOfThree;
            int counter = 0, sum = 0, group = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                counter++;
                if (counter == 3)
                {
                    averageOfThree = sum / counter;
                    counter = 0;
                    sum = 0;
                    group++;
                    Console.WriteLine($"The average of every group {group} with 3 elements is: {averageOfThree}");
                }

            }
        }

        static double StandardDeviation(int[] array)
        {
            double mean, sumSqr = 0, standardDeviation;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                sumSqr += Math.Pow(array[i], 2);
            }
            mean = Math.Pow(sum / array.Length, 2);

            standardDeviation = Math.Sqrt((sumSqr / array.Length) - mean);

            return standardDeviation;
        }
    }
}