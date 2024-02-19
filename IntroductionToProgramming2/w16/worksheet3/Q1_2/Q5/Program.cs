/*
 * Name: Q6
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            var random = new Random();
            int count = 100, j = 0;
            int[] array = new int[count];
            List<int> index = new List<int>();

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            for (int i = 0; i < count; i++)
            {
                array[i] = random.Next(0, 10);
                if (array[i] == 7)
                {
                    index.Add(i);
                    j++;
                }
            }
            Console.Write("The position of number 7 in random array of length 100 is: ");
            foreach (int i in index)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}