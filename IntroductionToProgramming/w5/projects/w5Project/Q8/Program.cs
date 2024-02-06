/*
 * Name: Juice Bar Sales
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It calculates sales price for every product for each month. Every month there is a 10% increase in sales price
 */

using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -40;
            const double INCREASE = 0.1;
            const string OUTPUT_TAB = "{0,-15}{1,-5}{2,-15:c}{3,-15:c}{4,-15:c}{5,-15:c}";
            int amountOfProducts;
            string firstProductName, secondProductName;
            double firstProductSalesForJ = 0, secondProductSalesForJ = 0;
            double[] totalCost;
            string[] months = { "January", "February", "March", "April" }, productname;
            double[,] sales;
            
            //Input
            Console.WriteLine("Juice bar sales");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the amount of products",TAB_INDENTATION}: ");
            amountOfProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            sales = new double[amountOfProducts, months.Length];
            productname = new string[amountOfProducts];
            totalCost = new double[months.Length];

            //Manages Input for products and their sales for January
            for (int i = 0; i < amountOfProducts; i++)
            {
                Console.Write($"{$"Enter Product {i+1} name", TAB_INDENTATION}: ");
                productname[i] = Console.ReadLine();
                Console.Write($"{$"Enter Euro sales of {productname[i]} the {months[0]}", TAB_INDENTATION}: ");
                sales[i, 0] = int.Parse(Console.ReadLine());
            }

            //Processing
            
            //Calculates the sales price for each product in each month
            for (int i = 0; i < amountOfProducts; i++)
            {
                for (int j = 0; j < (months.Length - 1); j++)
                {
                    sales[i, j+1] = Math.Round((sales[i,j] * INCREASE) + sales[i,j],2);
                }
            }
           
            //Sums up sales for every month
            for (int i = 0; i < months.Length; i++)
            {
                for (int j = 0; j < amountOfProducts; j++)
                {
                    totalCost[i] += sales[j,i];
                }
            }

            //Output
            Console.WriteLine("\n");
            Console.WriteLine(OUTPUT_TAB, "Product", "|", "January", "February", "March", "April");
            Console.WriteLine("----------------------------------------------------------------------");
            for (int i = 0; i < amountOfProducts; i++)
            {
                Console.WriteLine(OUTPUT_TAB, productname[i], "|", sales[i, 0], sales[i, 1], sales[i, 2], sales[i, 3]);
            }
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Total cost", "|", totalCost[0], totalCost[1], totalCost[2], totalCost[3]);
            Console.WriteLine("\n******End of program******\n");
        }
    }
}