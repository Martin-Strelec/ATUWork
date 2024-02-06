/*
 * TipCalculator
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: Calculates tips
 */
using System.Diagnostics.CodeAnalysis;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaration
            double mealCost, tipInPercent, priceAfterTip, tipInDollars;
            //Input
            Console.Write("Enter cost of meal: ");
            mealCost = int.Parse(Console.ReadLine());
            Console.Write("How much you want to tip? (in percent): ");
            tipInPercent = int.Parse(Console.ReadLine());
            //Processing
            tipInPercent = tipInPercent / 100; //Dividing by 100 to be more managable later on
            tipInDollars = mealCost * tipInPercent; //Calculate the tip in Dollars
            priceAfterTip = tipInDollars + mealCost; //Calculate the price after tip
            //Output
            Console.WriteLine($"\n******Tip Calculato******\n");
            Console.WriteLine($"Meal cost: \t\t{mealCost:c}");
            Console.WriteLine($"Tip in %:  \t\t{tipInPercent:p}");
            Console.WriteLine($"Tip in dollars: \t{tipInDollars:c}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"The meal have costed {mealCost:c}. You have tipped {tipInDollars:c}. In total you've paid {priceAfterTip:c}");
            Console.WriteLine("\n******End of program******");
        }
    }
}