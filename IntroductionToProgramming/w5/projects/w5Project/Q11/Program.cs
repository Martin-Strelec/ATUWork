/*
 * Name: ATM
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It allows you too withdraw money from your account after you enter your PIN code
 */

using System.Runtime.CompilerServices;

namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const string PIN = "1234";
            const int BALANCE = 500, TAB_INDENTATION = -40;
            bool access = false, sufficientFunds = false;
            string userPin;
            double withdrawal, remainings;

            //Input
            Console.WriteLine("ATM");
            Console.WriteLine("\n******Start of program******\n");
            Console.WriteLine("Welcome to ATM machine! If you want to continue, you need to enter your PIN code first.");

            //Checks if the PIN code is right
            while (access == false)
            {
                Console.Write($"{"\nYour PIN",TAB_INDENTATION}: ");
                userPin = Console.ReadLine();
                if (userPin == PIN)
                {
                    access = true;
                    Console.WriteLine("\nAccess Granted\n");
                }
                else
                {
                    Console.WriteLine("\nInvalid PIN");
                }
            }
            
            //Checks if user has enough funds to withdraw from his account
            while (sufficientFunds == false)
            {
                Console.Write($"{"\nHow much money do you want to withdraw?",TAB_INDENTATION}: ");
                withdrawal = double.Parse(Console.ReadLine());
                if (withdrawal > BALANCE)
                {
                    Console.WriteLine("\nInsufficent funds! Try again.");
                }
                else
                {
                    sufficientFunds = true;
                    remainings = BALANCE - withdrawal;
                    Console.WriteLine($"\nYou have withdrawn {withdrawal:c}");
                    Console.WriteLine($"There is {remainings:c} left on your account.");
                }
            }     
       
            Console.WriteLine("\n******End of program******\n");
        }
    }
}