/*
 * Name: Renting a game
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It tells you, for how many days you can rent a game. It also tells you the cost of the rent and the maximum amount of days if you 
 * exceed the maximum cost limit.
 */

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -35;
            const double BASE_RATE = 2, ADDITIONAL_RATE = 1.5, BASE_RATE_DAYS = 3, MAXIMUM_COST = 80;
            double rentCost = 0, rentCostCheck = 0;
            int numberOfDays, maxDays, i;

            //Input

            Console.WriteLine("Cost of renting a game");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter for how many days you want to rent a game",TAB_INDENTATION}: ");
            numberOfDays = int.Parse(Console.ReadLine());

            //Processing

            rentCost = ((numberOfDays - BASE_RATE_DAYS) * ADDITIONAL_RATE) + (BASE_RATE_DAYS * BASE_RATE); //Formula for calculating the rent cost. First three days are for 2 euros, the others are for 1.5 euro.

            //Checks the maximum amount of days of rental
            for (i = 1; rentCostCheck <= MAXIMUM_COST; i++)
            {
                if (i <= 3)
                {
                    rentCostCheck = i * BASE_RATE;
                }
                else
                {
                    rentCostCheck = ((i - BASE_RATE_DAYS) * ADDITIONAL_RATE) + (BASE_RATE_DAYS * BASE_RATE);
                }
            }

            maxDays = i - 2; //It might happen, that in a for loop the value will exceed the max limit. I substitute two to have it below MAXIMUM_COST

            //Decides if you exceeded the maximum amount of days
            if (rentCost > MAXIMUM_COST)
            {
                Console.WriteLine($"\nYou've exceeded the maximum days for renting a game. You can only rent a game for a maximum of {maxDays} days");
            }
            else
            {
                Console.WriteLine($"\nYou want to rent a game for {numberOfDays} days. The total cost will be {rentCost} euros");
            }

            Console.WriteLine("\n******End of program******\n");

        }
    }
}