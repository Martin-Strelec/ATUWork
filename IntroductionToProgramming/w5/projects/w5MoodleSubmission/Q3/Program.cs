/*
 * Name: BMI calculator
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Calculates the BMI value of a user
 */

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -35;
            const double EAT_VALUE = 18.5;
            string userName;
            double height, weight, bmiResult;

            //Input
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name", TAB_INDENTATION}: ");
            userName = Console.ReadLine();
            Console.Write($"{"Enter your weight in kilograms", TAB_INDENTATION}: ");
            weight = double.Parse(Console.ReadLine());
            Console.Write($"{"Enter your height in metres",TAB_INDENTATION}: ");
            height = double.Parse(Console.ReadLine());

            //Processing

            bmiResult = Math.Round(weight / (height*2),2); //Formula for calculating BMI

            Console.WriteLine($"\nYour BMI is {bmiResult}.");

            if (bmiResult < EAT_VALUE)
            {
                Console.WriteLine("\nYou need to eat more!!");
                Console.WriteLine("\nYou are underweight!");
            }
            else if (bmiResult > EAT_VALUE)
            {
                Console.WriteLine("\nYou should eat less!");
            }

            if (bmiResult > 18.6 && bmiResult < 24.9)
            {
                Console.WriteLine("\nYou are normal (weight wise :D)!");
            }
            else if (bmiResult > 25 && bmiResult < 29.9)
            {
                Console.WriteLine("\nYou are overweight");
            }
            else if (bmiResult > 30)
            {
                Console.WriteLine("\nYou are obese!");
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}