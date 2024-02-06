/*
 * Name: Salary calculator
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It says, if your salary is adequate or not
 */

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int SALARY_LIMIT = 10000, TAB_INDENTATION = -45;
            string name;
            double salary;
            //Input
            Console.WriteLine("Program to evaluate salary");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name",TAB_INDENTATION}: ");
            name = Console.ReadLine();
            Console.Write($"{$"Please enter your salary, {name}",TAB_INDENTATION}: ");
            salary = double.Parse(Console.ReadLine());
            //Processing
            if (salary > SALARY_LIMIT)
            {
                Console.WriteLine("\nYour salary is great!");
            }
            else if (salary < SALARY_LIMIT)
            {
                Console.WriteLine("\nYour salary isn't great :(");
            }
            else
            {
                Console.WriteLine("\nYour salary is ok.");
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}