/*
 * Project name: Club entrance fee
 * Name: M. Strelec
 * Date 1/2024
 * Purpose: Calculates the entry fee for each customer
*/

using System.Xml.Schema;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string TAB = "{0,30}{1,30}";
            const int MINIMUM_FEE = 2;
            const double ADDITIONAL_FEE = 0.5;
            double customerCharge, total = 0;
            bool exit = false;
            int input;

            while(exit == false)
            {
                Console.Write("Enter the number of hours (-999 to exit): ");
                input = int.Parse(Console.ReadLine());
                if (input == -999)
                {
                    exit = true;
                }

                if (input >= 3)
                {
                    customerCharge = 2 + (input - 3)*0.5; 
                }
                else
                {
                    customerCharge = MINIMUM_FEE; 
                }

                total += customerCharge;

                Console.WriteLine(TAB, $"Customer charge: {customerCharge:N2}",$"Total Receipt: {total:N2}");
            }
        }
    }
}