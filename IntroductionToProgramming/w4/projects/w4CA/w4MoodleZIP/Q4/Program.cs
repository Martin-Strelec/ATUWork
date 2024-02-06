/*
 * Project name: Average speed
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: Calculates average speed based on distance travelled and time it took.
 */
namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            double inputDistance, inputTime, averageSpeed;
            //Input
            Console.WriteLine("> Average speed <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the distance travelled (in km)", -40}: ");
            inputDistance = double.Parse(Console.ReadLine());
            Console.Write($"{"Enter the time it took (in hours)",-40}: ");
            inputTime = double.Parse(Console.ReadLine());
            //Processing & Output

            averageSpeed = Math.Round(inputDistance / inputTime,2);

            Console.WriteLine($"{"Your average speed was",-40}: {averageSpeed}");

            if (averageSpeed > 40)
            {
                Console.WriteLine("\nYou have been going faster than speed limit allows");
            }
            else
            {
                Console.WriteLine("\nYou have been going slower or equal to the speed limit");
            }

            Console.WriteLine("\n******End of program******");
        }
    }
}