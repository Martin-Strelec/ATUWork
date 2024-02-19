/*
 * Name: Q2
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

using System.ComponentModel.DataAnnotations;

namespace Q2
{

    internal class Program
    {

        static int range = 5;
        static int[] counter = new int[range];

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Processing
            //Output
            DisplaTab();
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            double value = 0;

            while (value != -999)
            {
                Console.Write("Enter sale amount (-999 to exit): ");
                while (!double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Invalid input. Try again!");
                    Console.Write("> ");
                }

                if (value > 0 && value <= 99.99)
                {
                    counter[0]++; 
                }
                else if (value >= 100 && value <= 199.99)
                {
                    counter[1]++;
                }
                else if (value >= 200 && value <= 399.99)
                {
                    counter[2]++;
                }
                else if (value >= 400 && value <= 599.99)
                {
                    counter[3]++;
                }
                else if (value >= 600)
                {
                    counter[4]++;
                }
            }
        }

        static void DisplaTab()
        {
            const string OUTPUT_TAB = "{0,-15} {1,-5} {2,-15}";

            Console.WriteLine("\nSale amount report\n");
            Console.WriteLine(OUTPUT_TAB, "Range", "|", "Number in range");
            Console.WriteLine(OUTPUT_TAB, "000-99.99", "|",$"{counter[0]}");
            Console.WriteLine(OUTPUT_TAB, "100-199.99", "|", $"{counter[1]}");
            Console.WriteLine(OUTPUT_TAB, "200-399.99", "|", $"{counter[2]}");
            Console.WriteLine(OUTPUT_TAB, "400-599.99", "|", $"{counter[3]}");
            Console.WriteLine(OUTPUT_TAB, "600+", "|", $"{counter[4]}");
        }


    }

}
