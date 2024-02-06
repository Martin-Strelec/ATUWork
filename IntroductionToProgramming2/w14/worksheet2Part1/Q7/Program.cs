/*
 * Name: Q7
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet tasks...
 */

namespace Q7
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
            Console.WriteLine($"Product cost: {ProductCost("ABC")}");
            Console.WriteLine("\n******End of program******\n");
        }

        static double ProductCost(string product)
        {
            double cost;

            switch (product)
            {
                case "ABC":
                    cost = 10.10;
                    break;

                case "XYZ":
                    cost = 69.34;
                    break;

                case "FR45":
                    cost = 34.0;
                    break;

                case "S34":
                    cost = 5;
                    break;

                case "G65":
                    cost = 5;
                    break;

                case "F34":
                    cost = 5;
                    break;

                default:
                    cost = -999;
                    break;
            }

            return cost;
        }
    }
}