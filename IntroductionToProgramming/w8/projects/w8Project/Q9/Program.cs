/*
 * Name: Calculator
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Basic calculator (+,-,*,/)
 */

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -30;
            int selector = 0;
            double numberOne, numberTwo, result = 0;

            //Input
            Console.WriteLine("Calculator");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the first number",TAB_INDENTATION}: ");
            numberOne = double.Parse(Console.ReadLine());
            Console.Write($"{"Enter the second number", TAB_INDENTATION}: ");
            numberTwo = double.Parse(Console.ReadLine());

            while (selector != 5)
            {
                Console.WriteLine("\nPlease select the operation you want to perform");
                Console.WriteLine("---------------");
                Console.WriteLine("1. Add (+)");
                Console.WriteLine("2. Subtract (-)");
                Console.WriteLine("3. Multiply (*)");
                Console.WriteLine("4. Divide (/)");
                Console.WriteLine("5. Exit");
                Console.WriteLine("---------------");
                selector = int.Parse(Console.ReadLine());
                if (selector >= 1 && selector <= 5)
                {
                    switch (selector)
                    {
                        case 1:
                            result = numberOne + numberTwo;
                            break;
                        case 2:
                            result = numberOne - numberTwo;
                            break;
                        case 3:
                            result = numberOne * numberTwo;
                            break;
                        case 4:
                            result = numberOne / numberTwo;
                            break;
                        default:
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("\nNot a valid option. Try again!\n");
                }
            }
            //Processing
            //Output
            Console.WriteLine($"{"\nThe result is",TAB_INDENTATION}: {result}");
            Console.WriteLine("\n******End of program******\n");

        }
    }
}