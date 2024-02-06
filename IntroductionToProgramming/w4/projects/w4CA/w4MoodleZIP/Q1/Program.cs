/*
 * Project name: Temperature condition
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: This program decides, if the temperature is ok or if it is too hot 
 */
namespace Q2._1_pwd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string pwd;
            int pass = 0;
            //Input
            Console.WriteLine("> Secret password <");
            Console.WriteLine("\n******Start of program******");
            //Processing & Output
            while (pass == 0)
            {
                Console.Write("\nEnter the secret password\t\t: ");
                pwd = Console.ReadLine();

                if (pwd == "secret")
                {
                    Console.WriteLine("\n> Correct. You're in");
                    pass++;
                }
                else
                {
                    Console.WriteLine("\n> Not authenticated");
                }
            }

            Console.WriteLine("\n******End of program******");
        }
    }
}