/*
 * Name: worksheet2Part1
 * Author: M.Strelec
 * Date:1/2024
 * Purpose: worsheet tasks...
 */

namespace worksheet2Part1
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
            //Output
            Console.WriteLine($"{SumOddNumbers(2, 5)}");
            Console.WriteLine("\n******End of program******\n");
        }

        static int SumOddNumbers (int num1, int num2)
        {
            int result = 0;

            for (int i = num1; i <= num2; i++)
            {
                if ((i % 2) == 0)
                {
                    result += i;
                }
            }
            return result;
        }
    }


}