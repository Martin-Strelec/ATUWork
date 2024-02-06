/*
 * Jeans Cost
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: Calculates cost of jeans with discount
 */
using System.Diagnostics.CodeAnalysis;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaration
            double discountInput, discountMultiplier;
            int costOfJeans;
            double priceAfterDiscount, discountInDollars, discount;

            //Input
            Console.Write("Insert the price of the Jeans: ");
            costOfJeans = int.Parse(Console.ReadLine()); //Get the base cost of the jeans
            Console.Write("Insert the discount: ");
            discountInput = int.Parse(Console.ReadLine()); //Get the discount
            Console.WriteLine("\n");

            //Processing
            discountMultiplier = (Convert.ToDouble(discountInput)) / 100; //Creates a multiplier from entered discount
            discount = 1 - discountMultiplier; //Number for multiplication
            priceAfterDiscount = costOfJeans * discount; //Price after applying discount
            discountInDollars = costOfJeans - priceAfterDiscount; //Discount value in dollars

            //Output
            Console.WriteLine("******Discount Calculator******\n");
            Console.WriteLine("Jean Sales");
            Console.WriteLine($"Full cost \t\t {costOfJeans:c}");
            Console.WriteLine($"Discount \t\t {discountMultiplier:p}");
            Console.WriteLine($"Discount in dollars \t {discountInDollars:c}");
            Console.WriteLine($"Total cost of Jeans \t {priceAfterDiscount:c}\n");
            Console.WriteLine($"The base cost of jeans is {costOfJeans:c}. With applied {discountMultiplier:p} discount, the final price of the jeans is {priceAfterDiscount:c}.\n");
            Console.WriteLine("******End of program******");
        }
    }
}