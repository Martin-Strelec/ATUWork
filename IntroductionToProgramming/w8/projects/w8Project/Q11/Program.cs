/*
 * Name: Renting a game
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It tells you, for how many days you can rent a game. It also tells you the cost of the rent and the maximum amount of days if you 
 * exceed the maximum cost limit.
 */

using System.ComponentModel;

namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -35;
            const double BASE_RATE = 7.5, ADDITIONAL_RATE = 2.5, BASE_RATE_DAYS = 4, LOYALTY_DISCOUNT = 0.15;
            double rentCost = 0, totalCost = 0, loyaltyDiscountCost = 0;
            int numberOfDays = 0, counter = 0;
            char loyaltyMember;

            //Input
            Console.WriteLine("Game rent calculator");
            Console.WriteLine("\n******Start of program******\n");
            
            while (true)
            {

                Console.Write($"{"Enter the number of ental of days (enter -1 to exit)",TAB_INDENTATION}: "); //Input for the number of days
                numberOfDays = int.Parse(Console.ReadLine());
                if (numberOfDays == -1)
                {
                    break;
                }

                Console.Write($"{"Are you a loyalty member (Y/N)",TAB_INDENTATION}: "); //Input for the loyalty discount
                loyaltyMember = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                if (numberOfDays > -1 && numberOfDays < 14)
                {                 
                    //calculates the rent cost
                    if (numberOfDays > BASE_RATE_DAYS)
                    {
                        rentCost = BASE_RATE * BASE_RATE_DAYS + (numberOfDays - BASE_RATE_DAYS) * ADDITIONAL_RATE;
                    }
                    else
                    {
                        rentCost = numberOfDays * BASE_RATE;
                    }

                    //Decides if the user can apply loyalty discount
                    if (loyaltyMember == 'Y')
                    {
                        loyaltyDiscountCost = rentCost * LOYALTY_DISCOUNT;
                    }
                    else
                    {
                        loyaltyDiscountCost = 0;
                    }

                    totalCost = rentCost - loyaltyDiscountCost;
                    counter++;

                    //Output table
                    Console.WriteLine("\n-------------------------------------------");
                    Console.WriteLine($"{$"Game {counter} rent cost",TAB_INDENTATION}: {rentCost:c}");
                    Console.WriteLine($"{"Cost of loyalty discount",TAB_INDENTATION}: {loyaltyDiscountCost:c}");
                    Console.WriteLine($"{$"Rental charged for the Game {counter}", TAB_INDENTATION}: {totalCost:c}");
                    Console.WriteLine("-------------------------------------------\n");
                }
                else
                {
                    Console.WriteLine("\nYou've entered incorrect value or exceeded the maximum rental days. Try again!\n");
                }
                
            }
            //Processing
            //Output
            Console.WriteLine("\n******End of program******\n");

        }
    }
}