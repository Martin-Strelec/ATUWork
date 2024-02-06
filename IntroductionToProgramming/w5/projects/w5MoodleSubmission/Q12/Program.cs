/*
 * Name: Cashier
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Displays how much and in which coins you should give back to the buyer and in which coins
 */

namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const string OUTPUT_TAB = "{0, -20}{1,-5}{2,-3}";
            const int TAB_INDENTATION = -35;
            int[] changeInCoins, coins = { 100, 50, 20, 5, 2, 1 };
            int index = 0;
            double amountDue, amountRecieved, changeValue;

            changeInCoins = new int[coins.Length];

            //Input
            Console.WriteLine("Cashier");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"The customer has to pay",TAB_INDENTATION}: ");
            amountDue = double.Parse(Console.ReadLine());
            Console.Write($"{"Customer paid",TAB_INDENTATION}: ");
            amountRecieved = double.Parse(Console.ReadLine());

            //Processing

            //Multiplying by 100 so I can easily divide the changeValue by int values stored in coins[]
            changeValue = Convert.ToInt32((amountRecieved - amountDue) * 100);

            //This subsitues values stored in coins array from the changeValue variable until the changeValue reaches zero
            while (changeValue != 0)
            {
                if (changeValue < coins[index])
                {
                    index++;
                }
                else
                {
                    changeValue -= coins[index];
                    changeInCoins[index]++;
                }
            }

            //Output
            Console.WriteLine("\nYou need to return: \n");
            Console.WriteLine(OUTPUT_TAB, "Euro coins", "|", changeInCoins[0]);
            Console.WriteLine(OUTPUT_TAB, "Fifty cent coins", "|",  changeInCoins[1]);
            Console.WriteLine(OUTPUT_TAB, "Twenty cent coins", "|",  changeInCoins[2]);
            Console.WriteLine(OUTPUT_TAB, "Five cent coins", "|",  changeInCoins[3]);
            Console.WriteLine(OUTPUT_TAB, "Two cent coins", "|",  changeInCoins[4]);
            Console.WriteLine(OUTPUT_TAB, "One cent coins", "|",  changeInCoins[5]);
            Console.WriteLine("\n******End of program******\n");
        }
    }
}