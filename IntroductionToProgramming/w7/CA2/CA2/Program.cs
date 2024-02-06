/*
 * Name: Painting Cost
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Calculates the cost of the resources and labour for a paint company
 */

using System.Transactions;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const double PAINT_VAT = 0.2, LABOUR_VAT = 0.1;
            const int TAB_INDENTATION = -40, MEASURE = 15, LABOUR_HOURLY_COST = 20, LABOUR_PER_MEASURE = 6;
            const string OUTPUT_TAB = "{0,-30}{1,-20}{2,20}";
            string userName;
            int numberOfRooms, totalSpace;
            int wallSpace;

            double costOfPaintInput, costOfPaint, vatPaintCost, paintTotalLitres, paintTotalCost;
            double labourCostExVat, labourTotalHours, labourVatCost, labourTotalCost;
            double jobTotalCost, nettCost;
            double discountRate, discountAmount;

            //Input
            Console.WriteLine("Painting Cost");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name", TAB_INDENTATION}: ");
            userName = Console.ReadLine();
            Console.Write($"{"Number of rooms",TAB_INDENTATION}: ");
            numberOfRooms = int.Parse(Console.ReadLine());
            Console.Write($"{"Size of rooms (in m^2)", TAB_INDENTATION}: ");
            wallSpace = int.Parse(Console.ReadLine());
            Console.Write($"{"Enter the cost of paint per liter",TAB_INDENTATION}: ");
            costOfPaintInput = double.Parse(Console.ReadLine());

            //Processing

            totalSpace = wallSpace * numberOfRooms;

            //Paint cost calculation
            paintTotalLitres = (totalSpace / MEASURE);
            costOfPaint = paintTotalLitres * costOfPaintInput;
            vatPaintCost = costOfPaint * PAINT_VAT;
            paintTotalCost = costOfPaint + vatPaintCost;

            //Labour cost calculation
            labourTotalHours = (totalSpace / MEASURE) * LABOUR_PER_MEASURE;
            labourCostExVat = labourTotalHours * LABOUR_HOURLY_COST;
            labourVatCost = labourCostExVat * LABOUR_VAT;
            labourTotalCost = labourVatCost + labourCostExVat;

            //total
            jobTotalCost = paintTotalCost + labourTotalCost;

            if (jobTotalCost > 1000 && jobTotalCost <= 5000)
            {
                discountRate = 0.05;
            }
            else if (jobTotalCost > 5000)
            {
                discountRate = 0.07;
            }
            else
            {
                discountRate = 0;
            }

            discountAmount = jobTotalCost * discountRate;
            nettCost = jobTotalCost - discountAmount;

            //Output
            Console.WriteLine("\nJob Quote");
            Console.WriteLine("========================\n");
            Console.WriteLine(OUTPUT_TAB, "Customer name", ":", $"{userName}");
            Console.WriteLine(OUTPUT_TAB, "Total number of litres", ":", $"{paintTotalLitres}");
            Console.WriteLine(OUTPUT_TAB, "Total hours of labour", ":", $"{labourTotalHours}");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Cost of paint", ":", $"{costOfPaint:c}");
            Console.WriteLine(OUTPUT_TAB, "Paint VAT", ":", $"{PAINT_VAT:p}");
            Console.WriteLine(OUTPUT_TAB, "Cost of VAT", ":", $"{vatPaintCost:c}");
            Console.WriteLine(OUTPUT_TAB, "", "", "==========");
            Console.WriteLine(OUTPUT_TAB, "Total cost of Paint", ":", $"{paintTotalCost:c}");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Labour Hourly Cost", ":", $"{LABOUR_HOURLY_COST:c}");
            Console.WriteLine(OUTPUT_TAB, "Labour Cost", ":", $"{labourCostExVat:c}");
            Console.WriteLine(OUTPUT_TAB, "Labour VAT", ":", $"{LABOUR_VAT:p}");
            Console.WriteLine(OUTPUT_TAB, "Labour VAT Cost", ":", $"{labourVatCost:c}");
            Console.WriteLine(OUTPUT_TAB, "", "", "==========");
            Console.WriteLine(OUTPUT_TAB, "Total Labour Cost", ":", $"{labourTotalCost:c}");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Total Job Cost", ":", $"{jobTotalCost:c}");
            Console.WriteLine(OUTPUT_TAB, "", "", "==========");
            Console.WriteLine(OUTPUT_TAB, "Discount rate", ":", $"{discountRate:p}");
            Console.WriteLine(OUTPUT_TAB, "Discount amount", ":", $"{discountAmount:c}");
            Console.WriteLine(OUTPUT_TAB, "", "", "==========");
            Console.WriteLine(OUTPUT_TAB, "Nett Cost", ":", $"{nettCost:c}");

            Console.WriteLine("\n******End of program******\n");
        }
    }
}