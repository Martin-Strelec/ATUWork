/*
 * Program Name: Lab2Q5
 * Author: M. Strelec
 * Date: 9.28.2023
 * Purpose: Calculates wage 
 */
namespace Lab2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration 
            const int baseHourWage = 25, regHours = 40, overTimeHours = 10;
            const double overTimeHourlyRate = 37.5;
            double sum;
            //Input
            //Processing
            sum = (baseHourWage * regHours) + (overTimeHours * overTimeHourlyRate);
            //Output
            Console.WriteLine("******Wage Calculation******");
            Console.WriteLine($"Base hour wage is {baseHourWage} and overtime hour wage is {overTimeHourlyRate}");
            Console.WriteLine($"You've worked for {regHours} hours with {overTimeHours} hours overtime and in total you have made {sum} euros");
            Console.WriteLine("End of program");
        }
    }
}