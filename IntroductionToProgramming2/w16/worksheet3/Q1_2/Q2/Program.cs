/*
 * Name: Q2
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: Picks the highest value and puts it at the end of the array
 */

namespace Q2
{
    internal class Program
    {

        static int[] array = { 12, 2, 5, 36, 3, 565, 3, 32, 1 };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.Write($"Array: ");
            DisplayArray(array);
            BiggestNumberAtTheEnd(array);
            Console.Write($"Biggest number at the end: ");
            DisplayArray(array);
            Console.WriteLine("\n******End of program******\n");
        }

        static void BiggestNumberAtTheEnd(int[] array)
        {
            int biggestNumber = array[0], index = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > biggestNumber)
                {
                    biggestNumber = array[i];
                    index = i;
                }
            }
            array[index] = array[array.Length - 1];
            array[array.Length - 1] = biggestNumber;
        }

        static void DisplayArray(int[] array)
        {
            foreach(int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
        }

    }
}