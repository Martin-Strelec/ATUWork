/*
 * TemperatureConverter
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: This program converts from Fahrenheit to Celsius
 */
using System.Diagnostics.CodeAnalysis;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaration
            int Fahrenheit;
            double Celsius;
            Console.WriteLine("*This program converts Fahrenheits into Celsius");
            Console.WriteLine($"\n******Temperature Converter******\n");
            Console.Write("Enter the temperature in Fahrenheits: ");
            Fahrenheit = int.Parse(Console.ReadLine());
            //Processing
            Celsius = 5 * (Fahrenheit - 32) / 9; //Formula for converting from farenheits to celsius
            //Output
            Console.WriteLine($"\nEntered value in Fahrenheits: \t\t{Fahrenheit}F");
            Console.WriteLine($"Converted value in Celsius:  \t\t{Celsius}C");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"\nYou've entered {Fahrenheit}F Fahrenheits which is equal to {Celsius}C Celsius");
            Console.WriteLine("\n******End of program******");
        }
    }
}