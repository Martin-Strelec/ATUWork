/*
 * Project name: Fahrenheit to Celsius converter
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: 
 */
using System.ComponentModel;

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            double fahrenheit, celsius;
            //Input
            Console.WriteLine("> Fahrenheit to Celsius converter <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the the temperature in Fahrenheits",-40}: ");
            fahrenheit = double.Parse(Console.ReadLine());
            //Processing & Output

            celsius = Math.Round((5 * (fahrenheit - 32) / 9),1);

            Console.WriteLine($"\nYour temperature is {celsius} Celsius.");

            if (celsius >= 38)
            {
                Console.WriteLine($"\nYour temperature is above 38 Celsius. This can be one of the symptoms for being infected by COVID-19.");
            }

            Console.WriteLine("\n******End of program******");
        }
    }
}