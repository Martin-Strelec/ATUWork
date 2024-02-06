/*
 * Project name: Height Conversion
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: Converts your height from inches to meters
 */
namespace Q2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            int feet, inches;
            const double INCHES_IN_METRES = 0.0254, FEET_IN_METRES = 0.3048; 
            double heightInFeet, heightInMetres;
            string name;
            //Input
            Console.WriteLine("> Height Conversion <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"\nYour name", -27}: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter your height: \n");
            Console.Write($"{"Enter feet", 25} : ");
            feet = int.Parse(Console.ReadLine());
            Console.Write($"{"Enter inches",25} : ");
            inches = int.Parse(Console.ReadLine());
            //Processing & Output

            heightInMetres = Math.Round((feet * FEET_IN_METRES) + (inches * INCHES_IN_METRES),2);

            Console.WriteLine($"\n{name}, your height in metres is: {heightInMetres}m");


            if (feet >= 5 && inches > 0)
            {
                Console.WriteLine($"\n{name}, you have grown!");
            }
            else
            {
                Console.WriteLine($"\n{name}, you have to grow more!");
            }

            Console.WriteLine("\n******End of program******");
        }
    }
}