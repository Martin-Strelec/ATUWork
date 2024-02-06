/*
 * Name: Lawn laying cost calculator 
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Calculates company cost of laying new lawn for customers
 */

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -50;
            const int LABOUR_COST = 25; //Per hour 
            const int LABOUR_TIME = 5, S_METERS_PER_UNIT = 25, SEED_BAGS_COUNT = 2; //Corresponds to 25m^2 of labour(h)
            const double FERTILIZER_VAT = 0.2, SEED_VAT = 0.2, LABOUR_VAT = 0.15; //VAT %
            const double STERLING_RATE = 0.86;
            const string OUTPUT_TAB = "{0,-30}{1,5}{2,30}";

            string customerName;
            int numberOfLawns;

            double ferCostInput,fertilizerCostGross, fertilizerCostVAT; //variables for fertilizer values
            double seedCostInput, seedCostGross, seedCostVAT; //variables for seed bags values
            double labourCostInput, labourCostGross, labourCostVAT; //variables for labour values
            double discount = 0, discountValue;
            double sterlingNett;

            double totalArea = 0, totalLawnCost, totalLabourCost, totalCost, totalCostWithVAT; //Total values
            double[] lawnArea; 

            //Input
            Console.WriteLine("Lawn laying cost calculator");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name", TAB_INDENTATION}: ");
            customerName = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Write($"{"Enter the number of lawns to be laid", TAB_INDENTATION}: ");
            numberOfLawns = int.Parse(Console.ReadLine());

            lawnArea = new double[numberOfLawns];

            for (int i = 0; i < numberOfLawns; i++)
            {
                Console.Write($"{$"Enter the area of the lawn {i+1} (in m^2)", TAB_INDENTATION}: ");
                lawnArea[i] = double.Parse(Console.ReadLine());
                totalArea += lawnArea[i]; 
            }

            Console.WriteLine("\n");
            Console.Write($"{"Enter the price of the fertiliser (50l before TAX)",TAB_INDENTATION}: ");
            ferCostInput = double.Parse(Console.ReadLine());
            Console.Write($"{"Enter the price of the bag of seed (25kg bag before TAX)",TAB_INDENTATION}: ");
            seedCostInput = double.Parse(Console.ReadLine());

            //Processing            

            //Cost of the fertilizer
            fertilizerCostGross = (totalArea / S_METERS_PER_UNIT) * ferCostInput;
            fertilizerCostVAT = fertilizerCostGross * FERTILIZER_VAT;
            //Cost of seed bags
            seedCostGross = (totalArea / S_METERS_PER_UNIT) * (seedCostInput * SEED_BAGS_COUNT);
            seedCostVAT = seedCostGross * SEED_VAT;

            totalLawnCost = (fertilizerCostGross + fertilizerCostVAT) + (seedCostGross + seedCostVAT);

            //Cost of labour
            labourCostGross = ((totalArea / S_METERS_PER_UNIT) * LABOUR_TIME) * LABOUR_COST;
            labourCostVAT = labourCostGross * LABOUR_VAT;
            totalLabourCost = labourCostGross + labourCostVAT;

            totalCost = totalLawnCost + totalLabourCost;

            if (totalCost > 1000 && totalCost <= 5000)
            {
                discount = 0.05;
            }
            else if (totalCost > 5000)
            {
                discount = 0.08;
            }

            discountValue = totalCost * discount;
            totalCostWithVAT = totalCost - discountValue;

            sterlingNett = Math.Round(totalCostWithVAT * STERLING_RATE,2);

            //Output
            Console.WriteLine("\nMurphy Bros Garden Centre");
            Console.WriteLine("{0,15}", "Job Quote");
            Console.WriteLine("\n=================================================================");
            Console.WriteLine(OUTPUT_TAB, "Total number of lawns", "|", $"{numberOfLawns}");
            Console.WriteLine(OUTPUT_TAB, "Cost of 50l of fertiliser", "|", $"{ferCostInput:c}");
            Console.WriteLine(OUTPUT_TAB, "Cost of one 25kg bag of seeds", "|", $"{seedCostInput:c}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Cost of fertilizer", "|", $"{fertilizerCostGross:c}");
            Console.WriteLine(OUTPUT_TAB, "fertilizer VAT", "|", $"{fertilizerCostVAT:c}");
            Console.WriteLine(OUTPUT_TAB, "Cost of seed", "|", $"{seedCostGross:c}");
            Console.WriteLine(OUTPUT_TAB, "seed VAT", "|", $"{seedCostVAT:c}");
            Console.WriteLine(OUTPUT_TAB, "Total lawn cost", "|", $"{totalLawnCost:c}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Labour hourly cost", "|", $"{LABOUR_COST:c}");
            Console.WriteLine(OUTPUT_TAB, "Labour cost", "|", $"{labourCostGross:c}");
            Console.WriteLine(OUTPUT_TAB, "seed VAT", "|", $"{labourCostVAT:c}");
            Console.WriteLine(OUTPUT_TAB, "Total labour cost", "|", $"{totalLabourCost:c}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Total cost of Job", "|", $"{totalCost:c}");
            Console.WriteLine(OUTPUT_TAB, "Discount", "|", $"{discount:p}");
            Console.WriteLine(OUTPUT_TAB, "Discount value", "|", $"{discountValue:c}");
            Console.WriteLine(OUTPUT_TAB, "Nett cost", "|", $"{totalCostWithVAT:c}");
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Nett cost (in Sterlings)", "|", $"{sterlingNett}");
            Console.WriteLine("=================================================================");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}