/*
 * Name: Methods 3
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Showcase of basic methods (Calculates the area of a rectangle)
 */

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -20;
            double width, height; 

            //Input
            Console.WriteLine("Rectangle Area");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the height", TAB_INDENTATION}: ");
            height = int.Parse(Console.ReadLine());
            Console.Write($"{"Enter the width", TAB_INDENTATION}: ");
            width = int.Parse(Console.ReadLine());

            //Processing
            //Output
            Console.WriteLine($"\nThe area of a rectangle with dimensions of {height}m and {width}m is {Area(height, width)}m^2");
            Console.WriteLine("\n******End of program******\n");
        }

        static double Area(double height, double width)
        {
            return (height * width);
        }
    }
}