/*
 * Name: CAPart1 
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: Calculates fares for a taxi company
 */

namespace CAPart1
{

    internal class Program
    {

        static double distanceTravelled, totalMoneyTaken;
        static int minutesTravelled, totalNumberOfJourneys, shortJourneys, longJourneys, shorterJourneys;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            Menu();
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            Console.Write("Enter the distance travelled (in km): ");
            while (!double.TryParse(Console.ReadLine(), out distanceTravelled))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }

            Console.Write("Enter the time it took to travel that distance: ");
            while (!int.TryParse(Console.ReadLine(), out minutesTravelled))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }
        }
        static void CalculateFare(double distance, int time)
        {
            const double STANDARD_FARE = 1.5, ADDITIONAL_FARE = 0.25;
            const int MINIMUM_FARE = 2;
            double totalFare = 0, estimatedTime = 0;
            bool minimumDistance = false;

            if (distance <= 1)
            {
                totalFare = MINIMUM_FARE;
                minimumDistance = true;
            }
            else
            {
                EstimatedTime(distance, time);
            }

            if (minimumDistance == false)
            {
                if (estimatedTime == time || time < estimatedTime)
                {
                    totalFare = distance * STANDARD_FARE;

                }
                else
                {
                    totalFare = (distance * STANDARD_FARE) + ((time - estimatedTime) * 0.25);
                }
            }

            if (distance <= 10)
            {
                shorterJourneys++;
            }
            else
            {
                longJourneys++;
            }

            totalMoneyTaken += totalFare;
            totalNumberOfJourneys++;

            Console.WriteLine($"\nYour fare for {distance}km taking {time}m is: {totalFare:c}\n");
        }
        static void EstimatedTime(double distance, int time)
        {
            double estimatedTime;

            if (distance <= 10)
            {
                estimatedTime = (distance / 20) * 60;
            }
            else
            {
                estimatedTime = 30;
                if (!((distance - 10) < 0))
                {
                    estimatedTime += ((distance - 10) / 80) * 60;
                }
            }

            Console.WriteLine($"\nThe trip of {distance}km should take you {estimatedTime:N0}m.\n");
        }
        static void DisplayTab()
        {
            Console.WriteLine("\n*********************");
            Console.WriteLine("1 . Estimate Journey Time");
            Console.WriteLine("2 . Process Fare");
            Console.WriteLine("3 . Print report");
            Console.WriteLine("4 . Exit");
            Console.WriteLine("*********************\n");
        }
        static void TaxiStats()
        {
            Console.WriteLine("\n****** Taxi Statistics ******\n");
            Console.WriteLine($"Number of short journeys: {shortJourneys}");
            Console.WriteLine($"Number of long journeys: {longJourneys}");
            Console.WriteLine("********************************");
            Console.WriteLine($"\nNumber of journeys: {totalNumberOfJourneys}");
            Console.WriteLine($"Total money taken: {totalMoneyTaken:c}\n");

        }
        static void Menu()
        {

            bool exit = false;
            int option;

            while (exit == false)
            {
                DisplayTab();
                Console.Write("Enter an option: ");
                while (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                switch (option)
                {
                    case 1:
                        InputHandlerer();
                        EstimatedTime(distanceTravelled, minutesTravelled);
                        break;

                    case 2:
                        InputHandlerer();
                        CalculateFare(distanceTravelled, minutesTravelled);
                        break;

                    case 3:
                        TaxiStats();
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
    }
}
