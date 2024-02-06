/*
 * Name: Area of shapes
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Calculates the area of circle, square and cylinder
 */

namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            while (true)
            {
                char selector = DisplayMenu();
                if (selector == '4')
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    AreaCalculator(selector);
                }
            }      
            Console.WriteLine("\n******End of program******\n");
        }

        static char DisplayMenu()
        {
            char value;
            while (true)
            {
                
                Console.WriteLine("[1] Area of rectangle");
                Console.WriteLine("[2] Area of circle");
                Console.WriteLine("[3] Area of cylinder");
                Console.WriteLine("[4] Exit...");
                Console.WriteLine("Choose an option: ");
                value = Convert.ToChar(Console.ReadLine());
                if ((Char.IsDigit(value)) && (value >= '1' && value <= '4')) {
                   
                    break;
                }
                Console.WriteLine("\nInvalid input | Try again!");
                value = '0';
            }
            return value;
        }

        static double AreaCalculator(char choice)
        {
            if (choice == '1')
            {
                double a, b;
                Console.WriteLine("\nEnter the parameters: ");
                Console.WriteLine("B: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("A: ");
                b = double.Parse(Console.ReadLine());
                return (a * b);
            }
            else if (choice == '2')
            {
                double r;
                Console.WriteLine("\nEnter the parameters: ");
                Console.Write("R: ");
                r = double.Parse(Console.ReadLine());
                return (Math.PI * Math.Sqrt(r));
            }
            else
            {
                double r, h;
                Console.WriteLine("\nEnter the parameters: ");
                Console.WriteLine("R: ");
                r = double.Parse(Console.ReadLine());
                Console.WriteLine("H: ");
                h = double.Parse(Console.ReadLine());
                result
                Console.WriteLine($"The are of a cylinder is: {}")
            }
        }
        
    }
}