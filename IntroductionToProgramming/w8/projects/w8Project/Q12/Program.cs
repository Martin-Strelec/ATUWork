/*
 * Name: Book delivery
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Calculates the cost of the book delivery service
 */

using System.Diagnostics.Metrics;

namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -50;
            const double BASE_COST = 2.5, EXPRESS_DELIVERY = 1.5;
            int userInputWeigh, counter = 0, userWeighDisplay = 0;
            double[] feeRates = {0.025, 0.03, 0.05};
            int[] weighRates = { 2000, 3000 };
            char userInputDelivery, continueDecision;
            bool exit = false;
            double fee = 0, totalFee;

            //Input
            Console.WriteLine("Delivery service for literature");
            Console.WriteLine("\n******Start of program******\n");

            while (true)
            {
                Console.WriteLine("-------------------------------------------------------");
                Console.Write($"{"Enter the weigh in of book(s) in grams (100 to 50000)", TAB_INDENTATION}: ");//Weigh input
                userInputWeigh = int.Parse(Console.ReadLine());

                //Checking for invalid input
                if (userInputWeigh < 100 && userInputWeigh > 50000)
                {
                    Console.WriteLine("Invalid Input!. Try again!");
                    break;
                }

                userWeighDisplay = userInputWeigh; //Assigns user inputed weight to another variable for calculation purposes
                Console.Write($"{"Delivery > Express (x)/ Standard (s)?",TAB_INDENTATION}: ");
                userInputDelivery = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

                //While loop for calculating fees
                while (!(userInputWeigh <= 0))
                {
                    int i = 0;
                    userInputWeigh -= weighRates[i];
                    if (!(userInputWeigh < 0))
                    {
                        fee += weighRates[i] * feeRates[i];
                    }
                    else
                    {
                        fee += (weighRates[i] + userInputWeigh) * feeRates[i];
                    }                  
                }

                //Adds express delivery fee to total fee
                if (userInputDelivery == 'X')
                {
                    totalFee = BASE_COST + fee + EXPRESS_DELIVERY;
                }

                //Displays total fee
                totalFee = BASE_COST + fee;     
                Console.WriteLine($"\nThe cost of books weighting {userWeighDisplay} is {totalFee:c}");
                Console.WriteLine("-------------------------------------------------------");
                counter++;
                
                //Asks if usesr wants to calculate another delivery
                Console.Write($"{"\nCalculate another? Y / N", TAB_INDENTATION}: ");
                continueDecision = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                if (continueDecision == 'N')
                {
                    break;
                }
                Console.WriteLine("\n");
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}