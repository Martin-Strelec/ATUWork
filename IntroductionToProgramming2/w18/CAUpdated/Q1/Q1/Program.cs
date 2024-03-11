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
        //Global variables
        static string[] destinations = {"Ballyshannon",
                                "Bundoran",
                                "Cliffoney",
                                "Grange",
                                "Rathcormack",
                                "Sligo"
        };
        static int[] estTravelTime = { 40, 30, 20, 15, 10 };

        //Input Handlerer variables
        static decimal finalPrice, basePrice;
        static string customerType, ticketType;

        //Journey report variables
        static int busSeats = 10, busSeatsOccupied, busSeatsCurrent = busSeats, ticketsSold, arrivalIndex, departureIndex;
        static decimal moneyCollected;
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

            string departureInput, ticketTypeInput, customerTypeInput;

            /*while (exit == false)
            {
                Console.WriteLine("Enter departing station (choose by number): ");
                for (int i = 0; i < desinations.Length; i++)
                {
                    Console.WriteLine($"{i + 1}{desinations.Length}");
                }
                while (!int.TryParse(Console.ReadLine(), out departureIndex))
                {
                    Console.WriteLine("Invalid input. Try again!");
                    Console.Write("> ");
                }

                Console.WriteLine("Enter arriving station (choose by number): ");
                for (int i = 0; i < desinations.Length; i++)
                {
                    Console.WriteLine($"{i + 1}{desinations.Length}");
                }
                while (!int.TryParse(Console.ReadLine(), out arrivalIndex) || )
                {
                    Console.WriteLine("Invalid input. Try again!");
                    Console.Write("> ");
                }
            }*/

            /*Console.Write("Enter the base price of the ticket: ");
            while (!decimal.TryParse(Console.ReadLine(), out basePrice))
            {
                Console.WriteLine("Invalid input. Try again!");
                Console.Write("> ");
            }*/
            Console.WriteLine("Enter departing station (choose by number): ");
            NumberInput(Console.ReadLine(), "int", 1, destinations.Length);

            Console.WriteLine("Enter arriving station (choose by number): ");
            NumberInput(Console.ReadLine(), "int", 1, destinations.Length);

            Console.Write("Enter the base price of the ticket: ");
            NumberInput(Console.ReadLine(), "dec", 0, 10);

            Console.Write("Enter the ticket type (SINGLE, RETURN): ");
            StringInput(Console.ReadLine(),
                        ticketType,
                        new string[] { "SINGLE", "RETURN" }
                        );

            Console.Write("Enter the customer type (child, student, OAP, adult): ");
            StringInput(Console.ReadLine(),
                        customerType,
                        new string[] { "STUDENT", "OAP", "CHILD", "ADULT" }
                        );

            void StringInput(string input, string output, string[] conditions)
            {
                int pass = 0;
                bool exit = false;
                while (exit == false)
                {
                    if (pass == 0)
                    {
                        output = input.ToUpper();
                    }                  
                    for (int i = 0; i < conditions.Length; i++)
                    {
                        if (output == conditions[i])
                        {
                            exit = true;
                        }
                    }
                    if (exit == false)
                    {
                        Console.WriteLine("Invalid input!");
                        Console.Write("> ");
                        output = Console.ReadLine().ToUpper();
                        if (pass == 0)
                        {
                            pass++;
                        }
                    }
                }
            }
            void NumberInput(string input, string type, int upperRange, int lowerRange)
            {
                bool exit = false;

                while (exit == false)
                {
                    if (type == "dec")
                    {
                        decimal number = Decimal.Parse(input);
                        while (!(number <= lowerRange && number >= upperRange))
                        {
                            Console.WriteLine("Invalid input. Try again!");
                            Console.Write("> ");
                        }
                        exit = true;
                    }
                    else if (type == "int")
                    {
                        int number = int.Parse(input);
                        while (!(number <= lowerRange && number >= upperRange))
                        {
                            Console.WriteLine("Invalid input. Try again!");
                            Console.Write("> ");
                        }
                    }
                    else if (type == "doub")
                    {
                        double number = double.Parse(input);
                        while (!(number <= lowerRange && number >= upperRange))
                        {
                            Console.WriteLine("Invalid input. Try again!");
                            Console.Write("> ");
                        }
                    }
                }
            }
        }

        static void DisplayMenu()
        {
            string[] options = { "Buy Ticket",
                                 "Check in return Ticket",
                                 "Print journey report",
                                 "Exit..."
            };

            Console.WriteLine("\n*************************");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{options[i]}");
            }
            Console.WriteLine("*************************\n");
        }
        static void Menu()
        {
            bool exit = false;
            int option;

            while (exit == false)
            {
                DisplayMenu(); //Displays menu

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
        static decimal CalculateTicketPrice(decimal baseprice, string ticketType)
        {

            decimal journeyPrice = baseprice;
            if (ticketType == "RETURN")
            {
                journeyPrice *= 1.5m;
            }
            else if (baseprice < 0)
            {
                journeyPrice = 0;
            }

            return journeyPrice;
        }
        static decimal ApplyDiscount(decimal price, string customerType)
        {

            if (customerType == "CHILD")
            {
                finalPrice = price * 0.5m;
            }
            else if (customerType == "OAP")
            {
                finalPrice = 0;
            }
            else if (customerType == "STUDENT")
            {
                finalPrice = price * 0.3m;
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
