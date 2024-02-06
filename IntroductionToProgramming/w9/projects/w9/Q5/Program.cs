/*
 * Name: Methods (McDonald's takeaway)
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Method decides if you can order an exact number of nuggets
 */

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -30;
            int userInput;

            //Input
            Console.WriteLine("Methods (McDonald's takeaway)");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the amount of nuggets you want to order",TAB_INDENTATION}: ");
            userInput = int.Parse(Console.ReadLine());

            //Processing
            //Output
            displayMessage(nuggetDecision(userInput)); //Displays corresponding message based on the nuggetDecision() result
        }
        static bool nuggetDecision(int value)
        {
           Boolean validOrder;
           if ((value % 6) == 0 || (value % 9) == 0 || (value % 20) == 0)
           {
              validOrder = true;
           }
           else
           {
              validOrder = false;
           }
           return validOrder;
        }

        static void displayMessage(bool result)
        {
            if (result == true)
            {
               Console.WriteLine($"\nYou can order this amount of nuggies");
            }
            else
            {
               Console.WriteLine("\nYou can not order this amount of nuggies");
            }

        }

    }
}