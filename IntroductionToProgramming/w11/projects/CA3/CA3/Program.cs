/*
 * Name: CA3
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Business calculator
 */

using System.Reflection;

namespace CA3
{
    internal class Program
    {
        static double carTravelTotal, accomodationTotal, additionalExpenseTotal;
        static int passes = 0, carAge;
        static string userName;
        static bool exit = false;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            Console.WriteLine("Employee Expense Calculator");
            Console.WriteLine("\n******Start of program******\n");
        
            //Output
            while (exit == false)
            {
                switch (DisplayMenu())
                {
                    case '1':
                        CarTravel();
                        break;
                    case '2':
                        Accomodation();
                        break;
                    case '3':
                        AdditionalExpense();
                        break;
                    case '4':
                        TotalExpense();
                        break;
                    case '5':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nWrong input. Try again!\n");
                        break;
                }
            }  
            
            Console.WriteLine("\n******End of program******\n");

        }

        static char DisplayMenu()
        {
            char option; 

            if (passes < 1)
            {
                Console.Write("Enter your name: ");
                userName = Console.ReadLine();
                Console.Write("Enter years of your car: ");
                carAge = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter expenses");
            Console.WriteLine("1. Car Travel");
            Console.WriteLine("2. Accomodation");
            Console.WriteLine("3. Additional Expense");
            Console.WriteLine("4. Calculate Total Expenses");
            Console.WriteLine("5. Exit...");
            Console.Write($"{userName}, choose option: ");
            option = Convert.ToChar(Console.ReadLine());

            passes++;
            return option;
        }
        static void CarTravel()
        {
            const double D_COST = 1.35, P_COST = 1.47;  //per km
            char fuelType = '0';
            double travelDistance, total, additionalExpense, fuelCost;

            while (true)
            {
                Console.Write("\nPlease enter fuel type (D > Disesel, P > Petrol): ");
                fuelType = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                if (fuelType == 'D' || fuelType == 'P')
                {
                    break;
                }
                Console.WriteLine("\nInvalid Input. Try again!\n");
            }
            Console.Write("Enter KM travelled: ");
            travelDistance = double.Parse(Console.ReadLine());


            if (carAge > 0 && carAge <= 4.99)
            {
                additionalExpense = 10.5;
            }
            else if (carAge >= 5 && carAge <= 9.99)
            {
                additionalExpense = 8.5;
            }
            else
            {
                additionalExpense = 5.5;
            }

            if (fuelType == 'D')
            {
                fuelCost = D_COST;
            }
            else
            {
                fuelCost = P_COST;
            }

            total = (travelDistance * fuelCost) + additionalExpense;

            carTravelTotal += total;

            Console.WriteLine($"\n== {userName} the cost of your car travel is: {total:c} ==");

        }
        static void Accomodation()
        {
            int noNights;
            double costPerNight, total;

            Console.Write("\nEnter the number of nights: ");
            noNights = int.Parse(Console.ReadLine());
            Console.Write("Enter cost per night: ");
            costPerNight = double.Parse(Console.ReadLine());

            total = noNights * costPerNight;

            accomodationTotal += total;

            Console.WriteLine($"\n== {userName} the cost of your accomodation is: {total:c} ==\n");
        }
        static void AdditionalExpense()
        {
            double aExpense;

            Console.Write("\nEnter additional expenses: ");
            aExpense = double.Parse(Console.ReadLine());

            additionalExpenseTotal += aExpense;

            Console.Write($"\n== {userName}, cost of our additional expenses is: {aExpense:c} ==");
        } 
        static void TotalExpense()
        {
            const string OUTPUT_TABLE = "{0,-15}{1,5}{2,15}";
            const double TAX = 0.04;
            double totalBeforeTax, taxValue;

            totalBeforeTax = carTravelTotal + accomodationTotal + additionalExpenseTotal;

            taxValue = totalBeforeTax * TAX;

            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine(OUTPUT_TABLE, "Expense", "|", "Cost");
            Console.WriteLine(OUTPUT_TABLE, "Car travel", "|", $"{carTravelTotal:c}");
            Console.WriteLine(OUTPUT_TABLE, "Accomodation", "|", $"{accomodationTotal:c}");
            Console.WriteLine(OUTPUT_TABLE, "Additional", "|", $"{additionalExpenseTotal:c}");
            Console.WriteLine(OUTPUT_TABLE, "Total", "|", $"{totalBeforeTax:c}");
            Console.WriteLine(OUTPUT_TABLE, $"Tax ({TAX:p})", "|", $"{taxValue:c}");
            Console.WriteLine("-------------------------------------\n");

        }
    }
}