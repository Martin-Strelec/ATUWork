/* Test 
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: Revision codes (1. cost of jeans, 2. Dinner cost)
 */
namespace CA1_testik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            //Jeans
            double costOfJeans, discount, priceAfterDiscount, discountInEuros;
            //Dinner
            double costOfTheDinner, Tip, costAfterTip, tipInEuros;

            //Input
            Console.WriteLine("\n******Start of program******\n");           
            //Jeans
            Console.WriteLine("\n1st program: Cost of Jeans\n");
            Console.Write("Enter the price of Jeans: ");
            costOfJeans = double.Parse(Console.ReadLine());
            Console.Write("Enter the discount (in %): ");
            discount = double.Parse(Console.ReadLine());
            //Dinner
            Console.WriteLine("\n2nd program: Dinner cost\n");
            Console.Write("Enter the cost of the dinner: ");
            costOfTheDinner = double.Parse(Console.ReadLine());
            Console.Write("Enter the tip amount (in %): ");
            Tip = double.Parse(Console.ReadLine());

            //Process
            //Jeans
            priceAfterDiscount = (costOfJeans * ((100 - discount) / 100));
            discountInEuros = costOfJeans - priceAfterDiscount;
            //Dinner
            costAfterTip = costOfTheDinner + (costOfTheDinner * (Tip / 100));
            tipInEuros = costAfterTip - costOfTheDinner;

            //Output
            //Jeans
            Console.WriteLine("Jeans Output");
            Console.WriteLine($"\nDiscount in Euros: \t{discountInEuros}");
            Console.WriteLine($"Price after discount: \t{priceAfterDiscount}");
            //Dinner
            Console.WriteLine("Dinner Output");
            Console.WriteLine($"\nCost of the dinner after the tip: \t{costAfterTip}");
            Console.WriteLine($"Tip in Euros: \t\t\t\t{tipInEuros}");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}