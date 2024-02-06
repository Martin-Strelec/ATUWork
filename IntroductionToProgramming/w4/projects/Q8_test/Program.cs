/* Project Name: Number Multiplication
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: It multiplies entered number from 1 up to 10
 */
namespace Q8_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            double inputNumber, output;
            //Input
            Console.WriteLine("Number Multiplication");
            Console.WriteLine("\n******Start of Program******\n");
            Console.Write("Enter a number you want to multiply: ");
            inputNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            //Processing
            for (int i = 1; i <= 10; i++)
            {
                output = inputNumber * i;
                Console.WriteLine($"{inputNumber} * {i} = {output}");
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}