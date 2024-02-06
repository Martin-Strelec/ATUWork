/*
 * Name: Time converter
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Converts Seconds to Hours, Minutes and Seconds
 */

namespace Q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -25;
            int inputValue;
            int[] units = {3600, 60, 1};
            int[] amountOfUnits = new int[units.Length];

            //Input
            Console.WriteLine("Time converter");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the seconds",TAB_INDENTATION}: ");    
            inputValue = int.Parse(Console.ReadLine());
            int leftover = inputValue;

            //Processing
            for (int i = 0; i < units.Length; i++)
            {
                    amountOfUnits[i] = leftover / units[i];
                    leftover %= units[i];     
            }

            //Output
            Console.WriteLine($"{inputValue} seconds equals to {amountOfUnits[0]} hours, {amountOfUnits[1]} minutes and {amountOfUnits[2]} seconds.");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}