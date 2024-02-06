/*
 * Name: Repayment
 * Author: M.Strelec
 * Date:
 * Purpose: 
 */

namespace Q17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -50;
            int paymentMonths, valueOfTheLoan;
            double annualInterest, payment, monthlyRate;
     
            //Input
            Console.WriteLine("Calculate monthly repayment");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Please, Enter the number of payments in months",TAB_INDENTATION}: ");
            paymentMonths = int.Parse(Console.ReadLine());
            Console.Write($"{"Please, enter your annual interest",TAB_INDENTATION}: ");
            annualInterest = double.Parse(Console.ReadLine());
            Console.Write($"{"Please, enter the current value of the loan", TAB_INDENTATION}: ");
            valueOfTheLoan = int.Parse(Console.ReadLine());

            //Processing

            monthlyRate = (annualInterest / 12)/100;
            //formula for calculating Monthly repayment
            payment = (monthlyRate * valueOfTheLoan) / (1-(1/(Math.Pow(1+monthlyRate,paymentMonths))));

            //Output
            Console.WriteLine($"\nYour monthly repayment will cost {payment:c} each month");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}