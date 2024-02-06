/*
 * Window Cost
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: Calculates the area of a window required for cutting thee glass plane and the perimeter of the frame. Then it calculates the total cost.
 */
using System.Diagnostics.CodeAnalysis;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaration
            int height, width, glassArea, windowPerimeter;
            double glassPrice, woodPrice, glassCost, woodCost, windowCost;

            //Input
            Console.WriteLine($"\n******Window Calculator******\n");
            Console.Write("Enter the height of the window (in mm): ");
            height = int.Parse(Console.ReadLine());
            Console.Write("Enter the width (in mm): ");
            width = int.Parse(Console.ReadLine());
            Console.WriteLine($"You've entered following parameters: \n");
            Console.WriteLine($"Window height: \t{height}mm");
            Console.WriteLine($"Window width: \t{width}mm");
            Console.WriteLine("\nIn order to calculate the cost of the whole window, you need to enter the following details: \n");
            Console.Write("Cost of glass per square meter (in dollars): ");
            glassPrice = double.Parse(Console.ReadLine());
            Console.Write("Cost of wood per meter (in dollars): ");
            woodPrice = double.Parse(Console.ReadLine());

            //Processing
            glassArea = (width * height)/1000000; //calculates the area of the glass plane and then converts it to square meters
            windowPerimeter = 2 * (width + height)/1000; //calculates the perimeter of the window frame
            woodCost = windowPerimeter * woodPrice; //Calculates the cost of the wood
            glassCost = glassArea * glassPrice; //Calculates the cost of the glass 
            windowCost = glassCost + woodCost; //Calculates the cost of the whole window

            //Output
            Console.WriteLine($"\nGlass area: \t\t{glassArea} square m");
            Console.WriteLine($"Frame perimeter:  \t{windowPerimeter}m");
            Console.WriteLine($"Price of the glass: \t{glassCost:c}");
            Console.WriteLine($"Price of the wood: \t{woodCost:c}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Total price of the window: {windowCost:c}\n");
            Console.WriteLine($"The window is {width} mm wide and {height} mm high. The area of the glass plane is {glassArea} square meters. It is surrounded by {windowPerimeter} metres long frame. The total cost of the windows is {windowCost:c}.");
            Console.WriteLine("\n******End of program******");
        }
    }
}