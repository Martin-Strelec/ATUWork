/*
 * Name: CA
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: 
 */


// I wanted to use decimal values instead of doubles, but it didn't let multiply them. I forgot to check the decimal properties. Not going to happen next time :)

using System.Reflection.Metadata.Ecma335;

namespace Q1
{
    internal class Program
    {
        //global variables
        static double basePrice, finalPrice;
        static string ticketType, customerType;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Processing
            ApplyDiscount(CalculateTicketPrice(basePrice, ticketType), customerType);
            if (finalPrice == 0)
            {
                Console.WriteLine($"The final price is: FREE");
            }
            else
            {
                Console.WriteLine($"The final price is: {finalPrice:c}");
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            bool exit = false;

            string ticketTypeInput, customerTypeInput;

            Console.Write("Enter the base price of the ticket: ");
            while (!double.TryParse(Console.ReadLine(), out basePrice)) {
                Console.WriteLine("Invalid input. Try again!");
                Console.Write("> ");
            }

            while (exit == false)
            {
                Console.Write("Enter the ticket type: ");
                ticketTypeInput = Console.ReadLine();
                ticketType = ticketTypeInput.ToUpper();
                if (ticketType == "SINGLE" || ticketType == "RETURN")
                {
                    exit = true;                  
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("> ");
                }
                
            }
            exit = false;

            while (exit == false)
            {
                Console.Write("Enter the customer type(child, student, OAP, adult): ");
                customerTypeInput = Console.ReadLine();
                customerType = customerTypeInput.ToUpper();
                if (customerType == "STUDENT" || customerType == "OAP" || customerType == "CHILD" || customerType == "ADULT")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("> ");
                }               
            }
        }

        static double CalculateTicketPrice(double baseprice, string ticketType)
        {

            double journeyPrice = baseprice;
            if (ticketType == "RETURN")
            {
                journeyPrice *= 1.5;
            }
            else if (baseprice < 0)
            {
                journeyPrice = 0;
            }

            return journeyPrice;
        }

        static double ApplyDiscount(double price, string customerType)
        {

            if (customerType == "CHILD")
            {
                finalPrice = price * 0.5;
            }
            else if (customerType == "OAP")
            {
                finalPrice = 0;
            }
            else if (customerType == "STUDENT")
            {
                finalPrice = price * 0.3;
            }
            else if (customerType == "ADULT")
            {
                finalPrice = price;
            }
            else
            {
                finalPrice = price;
            }

            return finalPrice;
        }
    }
}