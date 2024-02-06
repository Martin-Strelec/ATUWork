/*
 * Name: Q2
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet tasks...
 */

namespace Q2
{
    internal class Program
    {

        static int[] array = { 1, 2, 3, 4, 5, 6, 7 };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"{IsSortedAscending(array)}");
            Console.WriteLine("\n******End of program******\n");
        }

        static bool IsSortedAscending(int[] array)
        {
            bool result = true;

           for (int i = 0; i < array.Length; i++)
           {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        result = false;
                    }
                }
           }

            return result; 
        }
    }
}