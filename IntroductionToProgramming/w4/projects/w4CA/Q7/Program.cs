/*
 * Project name: Field expenses calculator
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: 
 */
using System.ComponentModel;
using System.Reflection;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int FERTILIZER_WEIGHT = 50 /*in grams per square meter*/, FERTILIZER_COST_PER_KG = 10; /*in dollars*/
            int length, width, area, discount;
            double fertilizerTotalCost, fertilizerAmount, totalCostAfterDiscount;
            //Input
            Console.WriteLine("> Field expenses calculator <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the width of the field (in m)",-40}: ");
            width = int.Parse(Console.ReadLine());
            Console.Write($"{"Enter the length of the field (in m)",-40}: ");
            length = int.Parse(Console.ReadLine());

            //Processing and Output

            area = length * width; //formula for calculating the area of the field
            fertilizerAmount = (area * FERTILIZER_WEIGHT) / 1000; //formula for calculating the total amount of fertilizer used
            fertilizerTotalCost = fertilizerAmount * FERTILIZER_COST_PER_KG; //formula for calculating the total cost of the fertilizer
            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine($"{"Aread of the field is",-40}: {area} m^2");
            Console.WriteLine($"{"Amount of fertilizer needed", -40}: {fertilizerAmount} kg");
            Console.WriteLine($"{"The total cost of fertilizer", -40}: {fertilizerTotalCost:c}");

            if (fertilizerTotalCost < 100)
            {
                Console.WriteLine($"\nThe total cost of fertilizer didn't exceed {100:c}. Therefore you recieve {0.1:p} discount.");
                discount = 10;
            }
            else
            {
                Console.WriteLine($"\nThe total cost of fertilizer exceeded {100:c}. Therefore you recieve {0.15:p} discount.");
                discount = 15;
            }

            totalCostAfterDiscount = fertilizerTotalCost - ((fertilizerTotalCost / 100) * discount); //formula for calculating the total cost after applying the discount

            Console.WriteLine($"{"\nIn the end, the total cost after applying the discount is",-40}: {totalCostAfterDiscount:c}");

            Console.WriteLine("\n******End of program******");
        }
    }
}