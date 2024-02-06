/*
 * Name: Q6
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet tasks...
 */

namespace Q6
{
    internal class Program
    {

        static int[] array = { 3, 6, 78, 54, 0, 7, 6 };
        static int passValue = 50;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"Graduates: {CountPasses(array, passValue)}");
            Console.WriteLine("\n******End of program******\n");
        }

        static int CountPasses(int[] marks, int passValue)
        {
            int passes = 0;

            foreach (int n in marks)
            {
                if (n >= passValue)
                {
                    passes++;
                }
            }

            return passes;
        }
    }
}