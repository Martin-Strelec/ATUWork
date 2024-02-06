/*
 * Name: Payslip program
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Calculates user's payslip 
 */

using System.Reflection.PortableExecutable;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -40, HOURLY_RATE = 16, REGULAR_HOURS = 40, OVERTIME_RATE = 24;
            int[] covidPaymentRates = { 203, 250, 300, 350 };
            const double TAX = 0.2, STERLING_RATE = 0.9;
            string userName;
            int hoursWorked, grossPay, regularPay, overtimePay, covidPayment;
            double finalTax, sterlingEquivalent, takeHomePay;
            
            
            //Input
            Console.WriteLine("Payslip program");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name",TAB_INDENTATION}: ");
            userName = Console.ReadLine();
            Console.Write($"{"Enter hours worked",TAB_INDENTATION}: ");
            hoursWorked = int.Parse(Console.ReadLine());

            //Processing
            regularPay = REGULAR_HOURS * HOURLY_RATE;
            overtimePay = (hoursWorked % REGULAR_HOURS) * OVERTIME_RATE;
            grossPay = regularPay + overtimePay;
            finalTax = grossPay * TAX;
            takeHomePay = grossPay - finalTax;
            sterlingEquivalent = takeHomePay * STERLING_RATE;

            if (grossPay < 200)
            {
                covidPayment = covidPaymentRates[0];
            }
            else if (grossPay > 200 && grossPay < 300)
            {
                covidPayment = covidPaymentRates[1];
            }
            else if (grossPay > 300 && grossPay < 400)
            {
                covidPayment = covidPaymentRates[2];
            }
            else
            {
                covidPayment = covidPaymentRates[3];
            }

            //Output
            Console.WriteLine($"\n{userName}'s payslip");
            Console.WriteLine("============================");
            Console.WriteLine($"{"Total hours", TAB_INDENTATION}: {hoursWorked}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{"Hourly rate",TAB_INDENTATION}: {HOURLY_RATE}");
            Console.WriteLine($"{"Regular pay",TAB_INDENTATION}: {regularPay}");
            Console.WriteLine($"{"Overtime pay", TAB_INDENTATION}: {overtimePay}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{"Gross pay",TAB_INDENTATION}: {grossPay}");
            Console.WriteLine($"{"Tax at 20%", TAB_INDENTATION}: {finalTax}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{"Take home pay",TAB_INDENTATION}: {takeHomePay}");
            Console.WriteLine($"{"Sterling equivalent",TAB_INDENTATION}: {sterlingEquivalent}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"{"Covid payment would be", TAB_INDENTATION}: {covidPayment}");
            Console.WriteLine("\nEnd of payslip");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}