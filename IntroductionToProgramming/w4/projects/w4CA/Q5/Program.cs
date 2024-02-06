/*
 * Project name: Employee commute
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: Calculates how much does employee travel each work week. Afterwards a "commute reward" is given based on distance travelled
 */
using System.ComponentModel;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            int everydayCommute, totalDistance;
            const int WORK_WEEK = 5;
            //Input
            Console.WriteLine("> Employee commute <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the distance you commute to work (in km)",-40}: ");
            everydayCommute = int.Parse(Console.ReadLine());
            //Processing & Output

            totalDistance = everydayCommute * WORK_WEEK;

            Console.WriteLine($"\nEvery week, you travel {totalDistance} km");

            if (totalDistance <= 100)
            {
                Console.WriteLine($"\nYou will recieve {10:c} voucher for your weekly commute!");
            }
            else
            {
                Console.WriteLine($"\nYou will recieve {50:c} voucher for your weekly commute!");
            }

            Console.WriteLine("\n******End of program******");
        }
    }
}