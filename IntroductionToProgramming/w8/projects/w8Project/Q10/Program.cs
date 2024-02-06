/*
 * Name: Loan interest calculator
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Calculator that calculates monthly payment based on selected monthly rate
 */

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -35;
            double userInput, result = 0;
            double[] interests = { 0.15, 0.17, 0.18};
            char selector = '0';
            int choice = -1; 

            //Input
            Console.WriteLine("Monthly interest Calculator");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the value of the loan", TAB_INDENTATION}: ");
            userInput = double.Parse(Console.ReadLine());

            //Processing
            while (selector != 'E')
            {
                Console.WriteLine("\nChoose the interest:");
                Console.WriteLine($"Loan value: {userInput}");
                Console.WriteLine("--------");
                Console.WriteLine("A. 15%");
                Console.WriteLine("B. 17%");
                Console.WriteLine("C. 18%");
                Console.WriteLine("E. Exit");
                Console.WriteLine("--------");
                selector = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                if (!(selector != 'A' && selector != 'B' && selector != 'C'))
                {
                    switch (selector)
                    {
                        case 'A':
                            result = userInput * interests[0];
                            choice = 0;
                            break;
                        case 'B':
                            result = userInput * interests[1];
                            choice = 1;
                            break;
                        case 'C':
                            result = userInput * interests[2];
                            choice = 2;
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine($"{$"\nMonthly interest paid on {userInput:c} at {interests[choice]:p} is",TAB_INDENTATION}: {result:c}");
                    break;
                }
                else if (selector == 'E')
                {
                    Console.WriteLine("\nExiting...");
                }
                else
                {
                    Console.WriteLine("\nInvalid input. Try again!");
                }
            }
            //Output    
            Console.WriteLine("\n******End of program******\n");
        }
    }
}