/*
 * WageCalculator
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: Calculates wages
 */
using System.Diagnostics.CodeAnalysis;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaration
            int baseHourlyRate, regularHours, overtimeHours;
            const double  percent = 0.15;
            double Sum, overtimeRate;
            //Input
            Console.Write("Enter base hourly rate: ");
            baseHourlyRate = int.Parse(Console.ReadLine());
            Console.Write("Enter how many hours you have worked: ");
            regularHours = int.Parse(Console.ReadLine());
            Console.Write("Enter overtime rate: ");
            overtimeRate = double.Parse(Console.ReadLine());
            Console.Write("Enter overtime hours: ");
            overtimeHours = int.Parse(Console.ReadLine());
            //Processing
            Sum = (baseHourlyRate * regularHours) + (overtimeHours * overtimeRate);
            //Output
            
            Console.WriteLine($"\n******Wage Calculatorrrrrr******\n");
            Console.WriteLine($"Base hourly rate: \t{baseHourlyRate:c}/h");
            Console.WriteLine($"Worked hours:  \t\t{regularHours}");
            Console.WriteLine($"Overtime rate: \t\t{overtimeRate:c}/h");
            Console.WriteLine($"Overtime hours: \t{overtimeHours}");
            Console.WriteLine($"\nIn total you have worked {regularHours} hours with {overtimeHours} hours of overtime. In total you made {Sum:c}");
            Console.WriteLine("\n******End of program******");
        }
    }
}