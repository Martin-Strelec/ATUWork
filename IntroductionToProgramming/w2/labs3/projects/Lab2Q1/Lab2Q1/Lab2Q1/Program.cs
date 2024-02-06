/*
 * Program Name: Lab2Q1
 * Author: M. Strelec
 * Date: 9.28.2023
 * Purpose: Displays text 
 */

using System.Xml.Schema;

namespace Lab2Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int cars = 6;
            const int trains = 4;
            const int buses = 8;
            int sum;
            //Input
            //Processing
            sum = cars + trains + buses;
            //Output
            Console.WriteLine("Fleet management");
            Console.WriteLine("==================");
            Console.WriteLine("Company has " + cars + " cars");
            Console.WriteLine("Company leases " + buses + " buses");
            Console.WriteLine("Company rents " + trains + " trains");
            Console.WriteLine("Total number of vehicles: " + sum);
            Console.WriteLine("End of summary\n");
            Console.WriteLine($"{cars} cars and {trains} trains and {buses} in total makes {sum} vehicles");
            Console.WriteLine("\nIts more fun to compute");
        }
    }
}