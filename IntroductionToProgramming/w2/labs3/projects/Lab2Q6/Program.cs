/*
 * Program Name: Lab2Q2
 * Author: M. Strelec
 * Date: 9.28.2023
 * Purpose: Converts from Euros to Sterling currency 
 */


namespace Lab2Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration 
            const double amountOfEuros = 2323.4, sterlingRate = 0.92;
            double exchange;
            //Input
            //Processing
            exchange = Math.Round((amountOfEuros * sterlingRate));
            //Output
            Console.WriteLine("******Sterling Calculator******");
            Console.WriteLine($"You've exchanged {amountOfEuros} euros for {exchange} sterlings");
            Console.WriteLine("End of program");
        }
    }
}