/*
 * Name: Q5
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: 
 */

namespace Q5
{
    internal class Program
    {

        static int numberOfStores = 5;
        static int[] sales;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine("Stores sales statistics");
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Processing
            //Output
            DisplayTab();
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            sales = new int[numberOfStores];
            int placeholder;

            for (int i = 0; i < numberOfStores; i++)
            {
                Console.Write($"Store {i+1} sales: ");
                while (!int.TryParse(Console.ReadLine(), out placeholder))
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("> ");
                }
                sales[i] = RoundOff(placeholder,100);
            }
        }

        static void DisplayTab()
        {
            Console.WriteLine("\nSales statistics");
            Console.WriteLine("******************************************\n");
            for (int i = 0; i < numberOfStores; i++)
            {
                
                Console.Write($"Store {i + 1}: ");
                for (int j = 0; j < (sales[i]/100); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("\n******************************************");
        }
        static int RoundOff(int number, int interval)
        {
            int result = 0;

            int remainder = number % interval;
            if (remainder < interval / 2)
            {
                result = number - remainder;
            }
            else
            {
                result = number + (interval - remainder);
            }
            return result;
        }
    }
}