/*
 * Name: Q11
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet tasks...
 */

namespace Q11
{
    internal class Program
    {
        static decimal accountBalance, rate;
        static int term;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command
            //Input
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Output
            Console.WriteLine($"{accountBalance:c} saved for {term} years at {rate / 100:p} will result in a new balance: ${CalculateCompoundBalance(accountBalance, rate, term):N2}");
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            Console.Write("Enter your account balance: ");
            while(!decimal.TryParse(Console.ReadLine(), out accountBalance))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }

            Console.Write("Enter interest rate (in %): ");
            while (!decimal.TryParse(Console.ReadLine(), out rate))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }

            Console.Write("Enter the duration: ");
            while (!int.TryParse(Console.ReadLine(), out term))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }
        }
        static decimal CalculateCompoundBalance(decimal balance, decimal rate, int term)
        {
            decimal result;

            for (int i = 0; i < term; i++)
            {
                balance *= ((100+rate)/100);
            }
            result = balance;

            return result;
        }
    }
}