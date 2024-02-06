/*
 * Name: Methods 4 (Calculation of an area of circle)
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Calculates the area of a circle
 */

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -25;
            double userInput;
            //Input
            Console.WriteLine("Circle area");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the radius of a circle",TAB_INDENTATION}: ");
            userInput = double.Parse(Console.ReadLine());

            //Processing
            //Output
            Console.WriteLine($"\nThe area of an circle with radius {userInput}m is {CircleArea(userInput)}m^2");
            Console.WriteLine("\n******End of program******\n");
        }

        static private double CircleArea(double radius)
        {
            return (Math.Round(Math.PI * (Math.Pow(radius, 2)), 2));
        }
    }

    
}