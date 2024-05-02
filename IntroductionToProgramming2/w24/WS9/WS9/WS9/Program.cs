/*
*	Name: Inheritance Q1
*	Author: Martin Strelec
*	Date: 24/Apr/2024
*	Purpose: 
*/

using QEmployee;
using QPartTimeEmployee;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console formatting command

            // Declaration
            Employee[] AllEmployees = new Employee[4];

            AllEmployees[0] = new PartTimeEmployee("John", "Male", 20, 10);
            AllEmployees[1] = new PartTimeEmployee("Owen", "Male", 20, 15);
            AllEmployees[2] = new Employee("Tara", "female", 20);
            AllEmployees[3] = new PartTimeEmployee("Owen", "Male", 20, 15);

            // Input
            Console.WriteLine("Inheritance Q1");
            Console.WriteLine("******Start of program******");
            // Processing
            for (int i = 0; i < AllEmployees.Length; i++)
            {
                Console.WriteLine($"{AllEmployees[i].ToString()}");
                Console.WriteLine($"Your pay: {AllEmployees[i].CalcPay()}");
            }
            // Output
            Console.WriteLine("******End of program******");
        }
    }
}