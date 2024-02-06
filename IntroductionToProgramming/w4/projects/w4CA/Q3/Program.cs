/*
 * Project name: Tip rate
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: It calculates the cost of the dinner based on how much tip you are willing to left to the waiter
 */
namespace Q2_temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const double TIPRATE = 0.125;
            double priceOfTheDinner, tipInEuros, totalDue, dinerSplit;
            int diners;
            //Input
            Console.WriteLine("> Tip rate <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the dinner price",-30}: ");
            priceOfTheDinner = double.Parse(Console.ReadLine());
            Console.Write($"{"Enter the number of diners",-30}: ");
            diners = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            //Processing & Output
            tipInEuros = priceOfTheDinner * TIPRATE;
            totalDue = priceOfTheDinner + tipInEuros;
            dinerSplit = totalDue / diners; 

            Console.WriteLine($"{"Meal Cost:",-40} {priceOfTheDinner:c}");
            Console.WriteLine($"{"Tip Rate:",-40} {TIPRATE:p}");
            Console.WriteLine($"{"Tip:",-40} {tipInEuros:c}");
            Console.WriteLine($"{"Total due:",-40} {totalDue:c}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"If you want to split the bill between {diners} diners,");
            Console.WriteLine($"{"\nThe cost for each one will be:",-41} {dinerSplit:c}");
            if (totalDue >= 45)
            {
                Console.WriteLine("\nSince your bill exceeded amount of 45 dollars, you will recieve 10% discount card for your next visit :]");
            }
            Console.WriteLine("\n******End of program******\n");
        }
    }
}