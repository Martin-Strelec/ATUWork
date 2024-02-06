/*
 * Name: 
 * Author: M.Strelec
 * Date:
 * Purpose: 
 */

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"Month number: {i + 1} | Number of days: {Months(i)}");
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static int Months(int index)
        {
            int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int value = days[index];
            return value;
        }
    }    
}