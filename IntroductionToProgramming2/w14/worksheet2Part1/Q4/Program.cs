/*
 * Name: Q4
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet tasks...
 */

namespace Q4
{

    

    internal class Program
    {
        static int[] array = { 2, 6, 3, 78, 4 };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output

            Console.Write("Your array: ");
            foreach (int n in array)
            {
                Console.Write($"{n},");
            }


            AllTheNines(array);
            Console.WriteLine();

            Console.Write("Your new array: ");
            foreach (int n in array)
            {
                Console.Write($"{n},");
            }

            Console.WriteLine();
            Console.Write("\n******End of program******\n");
        }

        static void AllTheNines(int[] array)
        {
            int i = 0;          
            foreach (int n in array)
            {
                array[i] = 9;
                i++;
            }


        }
    }
}