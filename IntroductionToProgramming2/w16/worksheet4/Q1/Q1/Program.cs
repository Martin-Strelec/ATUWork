/*
 * Name: Q1
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: String and data validation
 */

using System.ComponentModel;
using System.Net.Sockets;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            string[] array = {"E12345", "E23456", "E34567"};
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            InputHandlererForStrings(array);
            InputHandlererForDoublesHours();
            InputHandlererForDoublesRate();
            //Processing
            //Output
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
            double hoursWorked;
            bool pass = false;

            Console.Write("\nEnter hours worked: ");
            while (!double.TryParse(Console.ReadLine(), out hoursWorked) || !(hoursWorked >= 10 && hoursWorked <= 50)) 
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }
            Console.WriteLine($"You've entered {hoursWorked} hours of work");
            return pass = true;
        }
        static bool InputHandlererForDoublesRate()
        {
            double payRate;
            bool pass = false;

            Console.Write("\nEnter pay rate: ");
            while (!double.TryParse(Console.ReadLine(), out payRate) || !(payRate >= 10 && payRate <= 65))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }
            Console.WriteLine($"You've entered {payRate:c} per hour pay rate.");
            return pass = true;
        }
    }
}