/*
 * Name: Q3 
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks... 
 */

namespace Q3
{
    internal class Program
    {
        static int regions = 3, stores = 5;
        static decimal[,] sales = new decimal[regions + 1, stores + 1]; //Added one for the Sum and the averages.
                                                                        //Check weekly sales array navigation comment
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Processing
            WeeklySales(regions, stores);
            //Output
            DisplayTab();
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {

            for (int i = 0; i < regions; i++)
            {
                Console.WriteLine($"\nRegion {i+1}");
                for (int j = 0; j < stores; j++)
                {
                    Console.Write($"Enter sale for store {j+1}: ");
                    while (!decimal.TryParse(Console.ReadLine(), out sales[i, j]))
                    {
                        Console.WriteLine("Invalid input. Try again!");
                        Console.Write("> ");
                    }
                }
            }

        }
        static void WeeklySales(int regions, int stores)
        {

            /*  Sales array navigation
             *  
             *  Region  Store1 Store2 Store3 Store4 StoreN avg       
             *  Region1    .      .      .      .      .   avg1
             *      .      .      .      .      .      .    .
             *      .      .      .      .      .      .    .
             *  RegionN    .      .      .      .      .   avgN
             *   sum    sum1      .      .      .   sumN   avg.total
             *  
            */


            decimal companyAverageSum = 0;

            //
            for (int i = 0; i < regions; i++)
            {
                for (int j = 0; j < stores; j++)
                {
                    sales[regions, i] += sales[i, j];
                }
            }

            for (int i = 0; i < regions; i++)
            {
                sales[i, stores] = sales[regions, i] / stores;
            }

            for (int i = 0; i < regions; i++)
            {
                companyAverageSum += sales[i, stores];
            }
            sales[regions, stores] = companyAverageSum / regions;
        }
        static void DisplayTab()
        {
            Console.WriteLine("\n************************************");
            for (int i = 0; i < regions; i++)
            {
                Console.WriteLine($"Region {i+1} avg.sales: {sales[i, stores]:N1}$");
            }
            Console.WriteLine($"Avg. total sales: {sales[regions, stores]:N1}$");
            Console.WriteLine("************************************\n");


        }
    }
}