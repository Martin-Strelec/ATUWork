/*
 * Car refueling estimator
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: Calculates how often you have to refuel on a 2000km trip in a car with specific fuel tank
 */
using System.Diagnostics.CodeAnalysis;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Uses UTF-8 standard in command line

            //Declaration 
            const int fuelTank = 60, fuelConsumptionPerKm = 14, travelDistance = 2000;
            const double tenGallonsOnly = 45.5; //fuelTank is in Litres, fuelConsumption in l/km, travelDistance in km
            double refillCount, refillCountRestricted, distanceRestricted, test;

            //Input
            //Processing
            refillCount = Math.Round(travelDistance / (Convert.ToDouble((fuelTank * fuelConsumptionPerKm))) + 0.5); //formula for calculating refill count
            refillCountRestricted = Math.Round(tenGallonsOnly * fuelConsumptionPerKm + 0.5); //formula for less fuel
            distanceRestricted = tenGallonsOnly * fuelConsumptionPerKm; //Calculates distance with 10 gallons
            
            //Output
            Console.WriteLine("******Refill estimator******\n");
            Console.WriteLine($"You are travelling {travelDistance} km in a car with {fuelTank} litres of fuel. To complete the journey, you have to refuel {refillCount} times.\n");
            Console.WriteLine($"With restricted fuel tank to {tenGallonsOnly} litres. You can travel {distanceRestricted} km.");
            Console.WriteLine("\n******End of program******");
        }
    }
}