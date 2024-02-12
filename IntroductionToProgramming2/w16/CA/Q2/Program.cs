/*
 * Name: CA Q2
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: Ballin Bus company program
 * Notes: This program contains CA Q1 and also CA Q2
 * 
 * I wanted to use decimal values instead of doubles, but it didn't let multiply them. 
 * I forgot to check the decimal properties. Not going to happen next time :)
 */


using System.Net.Sockets;
using System.Security;

namespace Q2
{
    internal class Program
    {
        //Input Handlerer variables
        static double finalPrice, basePrice;
        static string customerType, ticketType;

        //Journey report variables
        static int busSeats = 10, busSeatsOccupied, busSeatsCurrent = busSeats, ticketsSold;
        static double moneyCollected;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Input
            Console.WriteLine("Ballin Bus Company");
            Console.WriteLine("\n******Start of program******\n");
            Menu();
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            bool exit = false;

            string ticketTypeInput, customerTypeInput;

            Console.Write("Enter the base price of the ticket: ");
            while (!double.TryParse(Console.ReadLine(), out basePrice))
            {
                Console.WriteLine("Invalid input. Try again!");
                Console.Write("> ");
            }

            while (exit == false)
            {
                Console.Write("Enter the ticket type (SINGLE, RETURN): ");
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
                Console.Write("Enter the customer type (child, student, OAP, adult): ");
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
        static void DisplayTab()
        {
            Console.WriteLine("\n*************************");
            Console.WriteLine("1. Buy Ticket");
            Console.WriteLine("2. Check in return Ticket");
            Console.WriteLine("3. Print journey report");
            Console.WriteLine("4. Exit...");
            Console.WriteLine("*************************\n");
        }
        static void Menu()
        {
            bool exit = false;
            int option;

            while (exit == false)
            {
                DisplayTab(); //Displays menu

                Console.Write("Enter an option: ");
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }

                switch (option)
                {
                    case 1:
                        BuyTicket();
                        break;

                    case 2:
                        CheckTicket();
                        break;

                    case 3:
                        JourneyReport();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        Console.Write("> ");
                        break;

                }
            }

        }
        //Q1 methods
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
        //End of Q1 methods
        static void BuyTicket()
        {
            Console.WriteLine("\n****** Buy Ticket ******");

            if (busSeats > 0)
            {
                InputHandlerer();
                moneyCollected += ApplyDiscount(CalculateTicketPrice(basePrice, ticketType), customerType); //calculates the cost and adds it to the global variable moneyCollected
                Console.WriteLine($"\nBallin-Sligo: {customerType} {ticketType}: {finalPrice:c}");
                busSeatsCurrent--;
                busSeatsOccupied++;
                ticketsSold++;
            }
            else
            {
                Console.WriteLine("Bus full...");
            }


        }
        static void CheckTicket()
        {
            Console.WriteLine("\n****** Check Seat ******");

            if (busSeatsCurrent > 0)
            {
                Console.WriteLine("You've checked in your seat");
                busSeatsCurrent--;
                busSeatsOccupied++;
                Console.WriteLine($"Seats available: {busSeatsCurrent}");
            }
            else
            {
                Console.WriteLine("Bus full...");
            }
        }
        static void JourneyReport()
        {
            Console.WriteLine("\n****** Journey Report ******");
            Console.WriteLine($"Number of tickets sold: {ticketsSold}");
            Console.WriteLine($"Money collected: {moneyCollected:c}");
            Console.WriteLine($"Total seats occupied: {busSeatsOccupied}");
            Console.WriteLine("****************************\n");
        }
    }
}
