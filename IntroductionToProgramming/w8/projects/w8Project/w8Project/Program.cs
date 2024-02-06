/*
 * Name: Grades
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: User enters marks and based on the value of the mark it will tell the user how many times he passed or failed. 
 */

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command 

            //Declaration
            const int TAB_INDENTATION = -35, SENTINEL = -1, PASS_VALUE = 40, TUITION = 7;
            int userInput = -2, failed = 0, passed = 0, count = 0, total = 0;
            float average;

            //Input
            Console.WriteLine("Grades");
            Console.WriteLine("\n******Start of program******\n");

            while (userInput != SENTINEL)
            {
                if (!(userInput < 0))
                {
                    if (userInput >= PASS_VALUE && userInput != -2)
                    {
                        passed++;
                    }
                    if (userInput < PASS_VALUE && userInput != -2)
                    {
                        failed++;
                    }
                    count++;
                    total += userInput;
                }                
                Console.Write($"{$"Enter marks (to end, press {SENTINEL})",TAB_INDENTATION}: ");
                userInput = int.Parse(Console.ReadLine());
            }

            //Processing
            average = (float) total / count;

            //Output
            Console.WriteLine("\n");
            Console.WriteLine($"{"Passed", TAB_INDENTATION}: {passed}");
            Console.WriteLine($"{"Failed", TAB_INDENTATION}: {failed}");
            Console.WriteLine($"{$"The average mark for {count} students is",TAB_INDENTATION}: {average:N1}");
            Console.WriteLine("\n");

            if (passed >= TUITION)
            {
                Console.WriteLine("\n*********************");
                Console.WriteLine("****Raise Tuition****");
                Console.WriteLine("*********************\n");
            }

            Console.WriteLine("\n******End of program******\n");
        }
    }
}