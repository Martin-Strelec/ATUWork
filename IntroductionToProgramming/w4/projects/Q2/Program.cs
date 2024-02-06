/*
 * Project name: Temperature condition
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: This program decides, if the temperature is ok or if it is too hot 
 */
namespace Q2_temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            int temp;
            //Input
            Console.WriteLine("> Temperature Condition <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write("Enter the temperature\t\t: ");
            temp = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            //Processing & Output
            if (temp > 40)
            {
                Console.WriteLine("It's too hot!");
            }
            else
            {
                Console.WriteLine("It's ok or cold");
            }

            Console.WriteLine("\n******End of program******");
        }
    }
}