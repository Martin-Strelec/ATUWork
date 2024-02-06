/*
 * Name: Methods 6
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: 
 */

using System.Diagnostics;
using System.Reflection.Metadata;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -25;
            int userChoice;
            double userInputLoan;

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            while (true)
            {
                char another; 

                Console.Write($"{"\nEnter the value of your loan",TAB_INDENTATION}: ");
                userInputLoan = double.Parse(Console.ReadLine());

                DisplayMenu(); //Displays menu

                Console.WriteLine($"\nYour monthtly interest will be {Result(InterestCalculator(), userInputLoan):c}");
                Console.Write("\nCalculate another? (Y / N): ");
                another = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                if (another == 'N')
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
            }
            

            //Processing
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static void DisplayMenu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"1. {0.15:p}");
            Console.WriteLine($"2. {0.17:p}");
            Console.WriteLine($"3. {0.18:p}");
            Console.WriteLine($"4. Exit");
            Console.WriteLine("----------------------------");
        }
        static private double InterestCalculator()
        {
            double interest = 0;
            int choice = 0;

            Console.Write("Choose the interest: ");
            choice = int.Parse(Console.ReadLine());
                                         
            switch (choice)
                {
                case 1:
                    interest = 0.15;
                    break;
                case 2:
                    interest = 0.17;
                    break;
                case 3:
                    interest = 0.18;
                    break;
                default:
                    Console.WriteLine("\nGoodbye!");
                    break;
                }                          
            return interest;
        }
        static private double Result(double interest, double loanValue)
        {
            double result = Math.Round(loanValue * interest,2);
            return result;
        }
    }
}