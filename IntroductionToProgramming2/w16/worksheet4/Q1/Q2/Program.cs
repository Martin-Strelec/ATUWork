/*
 * Name: Q2
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: 
 */

using System.ComponentModel.Design;

namespace Q2
{
    internal class Program
    {

        static decimal payRate;
        static decimal hoursWorked;
        static string[] ids = { "E12345", "E12346", "E12347" }; //ID => First letter E, length 6 letters

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            InputHandlererForStrings(ids);
            InputHandlererForDoublesHours();
            InputHandlererForDoublesRate();
            //Processing
            //Output
            Console.WriteLine($"\nYour netpay is: {NetPayCalculation(payRate, hoursWorked):c}");
            Console.WriteLine("\n******End of program******\n");
        }

        static bool InputHandlererForStrings(string[] idArray)
        {
            string input = "0";
            bool present = false, pass = false;
            int inputLength = 6;
            char startingLetter = 'E';

            while ((input[0] != startingLetter && input.Length != inputLength) || pass == false)
            {
                Console.Write("Enter your ID: ");
                input = Console.ReadLine();

                for (int i = 0; i < idArray.Length; i++)
                {
                    if (input == idArray[i])
                    {
                        present = true;
                        pass = true;
                    }
                }

                if (present == false && input.Length == inputLength)
                {
                    Console.WriteLine("\nID is not present");
                    Console.Write("> ");
                }

                if (pass == false && input.Length < inputLength)
                {
                    Console.WriteLine("\nInvalid input. Try again!");
                    Console.Write("> ");
                }
            }
            Console.WriteLine("You've entered your ID");
            return pass;
        }
        static bool InputHandlererForDoublesHours()
        {
            bool pass = false;

            Console.Write("\nEnter hours worked: ");
            while (!decimal.TryParse(Console.ReadLine(), out hoursWorked) || !(hoursWorked >= 10 && hoursWorked <= 100))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }
            Console.WriteLine($"You've entered {hoursWorked} hours of work");
            return pass = true;
        }
        static bool InputHandlererForDoublesRate()
        {
            bool pass = false;

            Console.Write("\nEnter pay rate: ");
            while (!decimal.TryParse(Console.ReadLine(), out payRate) || !(payRate >= 10 && payRate <= 65))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }
            Console.WriteLine($"You've entered {payRate:c} per hour pay rate.");
            return pass = true;
        }
        static decimal NetPayCalculation(decimal payRate, decimal hoursWorked)
        {
            decimal income = payRate * hoursWorked, netpay;

            if (income >= 3000.01M && income <= 34000)
            {
                netpay = income - (income * 0.2M); 
            }
            else if(income > 34000)
            {
                netpay = income - (income * 0.4M);
            }
            else
            {
                netpay = income;
            }

            return netpay;
        }
    }
}