/* Project name: Gross pay calculator
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: Calculates user's gross pay from his inputed data
 */
namespace CA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const double HOURLY_PAY = 15.5, TAX_RATE = 0.25;
            string userName;
            double hoursWorked, grossPay, netPay, taxPaid;

            //Input
            Console.WriteLine("> Program to calculate pay <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write("Enter your name\t\t\t:");
            userName = Console.ReadLine();
            Console.Write("Enter hours worked\t\t:");
            hoursWorked = double.Parse(Console.ReadLine());

            //Process
            grossPay = hoursWorked * HOURLY_PAY; //Formula for calculating the gross pay
            netPay = grossPay - (grossPay * TAX_RATE); //Formula for calculating the net pay (pay after tax)
            taxPaid = grossPay - netPay; //Formula for calculating the amount of tax paid

            //Output
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"{userName}'s Payslip\n");
            Console.WriteLine($"Gross pay:\t\t{grossPay:c}");
            Console.WriteLine($"Tax Rate:\t\t{TAX_RATE:p}");
            Console.WriteLine($"Tax Paid:\t\t{taxPaid:c}");
            Console.WriteLine("\t\t===============");
            Console.WriteLine($"Net pay:\t\t{netPay:c}");
            Console.WriteLine("-------------------------------\n");
            Console.WriteLine("\n******End of program******");
        }
    }
}