/*
 * Name: Password checker
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Prompts the user to enter a password. Goes infinitely until the user enters the right password
 */

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -35, ATTEMPTS = 5;
            const string PWD = "verysecretpassword";
            string userInput = "0";
            int counter = 0;
            bool isValid = false;

            //Input
            Console.WriteLine("Password checker");
            Console.WriteLine("\n******Start of program******\n");

            //Processing

            for (int i = 1; i <= ATTEMPTS; i++)
            {
                Console.Write($"{"Enter password",TAB_INDENTATION}: ");
                userInput = Console.ReadLine();
                if (userInput == PWD)
                {
                    isValid = true;
                    counter = i;
                    break;
                }
                Console.WriteLine("Wrong password, Try again!\n");
                counter = i;
            }
            
            //Output
            if (isValid) 
            {               
                Console.WriteLine($"\nCorrect password after {counter} attempts");
            }
            else
            {
                Console.WriteLine($"\nYou've entered the password {ATTEMPTS} times wrong. Exiting...");
            }           
            Console.WriteLine("\n******End of program******\n");
        }
    }
}