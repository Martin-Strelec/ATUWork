/* 
 * Sterling convertor
 * Name: M. Strelec
 * Date: 10/2023
 * Purpose: Converts Euros to Sterling
 */
using System.Diagnostics.CodeAnalysis;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Declaration
            const double sterlingRate= 0.987;
            double enteredAmount, sum;
            //Input
            Console.Write("Enter the amount of Euros: ");
            enteredAmount = double.Parse(Console.ReadLine());
            //Processing
            sum = enteredAmount * sterlingRate;
            //Output
            Console.WriteLine($"You've entered { enteredAmount:c}");
            Console.WriteLine($"You've exchanged {enteredAmount:c} for {sum} Sterlings");
            Console.WriteLine("End of program");
        }
    }
}