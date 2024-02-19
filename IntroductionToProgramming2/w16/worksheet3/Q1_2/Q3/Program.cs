/*
 * Name: Q3
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: 
 */

using System.Diagnostics.Metrics;

namespace Q3
{
    internal class Program
    {

        static int[] array = { 12, 2, 5, 36, 3, 565, 3, 32, 1, 2, 41, 1, 5, 2, 4, 6, 7, 3, 3, 3, 3, 4, 56, 65 };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            ArraySort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]}");
            }

            //Output
            Console.WriteLine("\n******End of program******\n");

            static void ArraySort(int[] array)
            {
                int smallest = array[0], counter = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < smallest)
                    {
                        smallest = array[i];
                        array[i] = array[counter];
                        array[counter] = smallest;
                        if (counter == 0)
                        {
                            i = 0;
                        }
                    }
                    if (i == array.Length - 1)
                    {
                        smallest = array[counter + 1];
                        counter++;
                        i = counter;
                    }
                }
            }
        }
    }
}