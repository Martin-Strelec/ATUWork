/*
*	Name: Inheritance Q2
*	Author: Martin Strelec
*	Date: 25/Apr/2024
*	Purpose: 
*/

using QShape;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console formatting command

            // Declaration

            Shape[] Shapes = new Shape[5];

            Shapes[0] = new Circle(5);
            Shapes[1] = new Rectangle(3, 6);
            Shapes[2] = new Circle(8);
            Shapes[3] = new Rectangle(1, 8);
            Shapes[4] = new Circle(2);

            // Input
            Console.WriteLine("Inheritance Q2");
            Console.WriteLine("******Start of program******");
            // Processing
            // Output
            for (int i = 0; i < Shapes.Length; i++)
            {
                Console.WriteLine($"\nShape: {Shapes[i].Type}");
                Console.WriteLine($"Area: {Shapes[i].CalcArea():N2}cm^2");
                Console.WriteLine($"Perimeter: {Shapes[i].CalcPerimeter():N2}cm\n");
            }

            Console.WriteLine("******End of program******");
        }
    }
}