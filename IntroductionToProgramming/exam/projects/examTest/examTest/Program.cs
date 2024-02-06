/*
 * Project: Exam Test 
 * Name: M. Strelec
 * Date: 1/2024
 * Purpose: Exam test file 
*/

using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace examTest
{
    internal class Program
    {
        const double BUCKET_COST =5.2, SPADE_COST = 11.7, SHOVEL_COST = 12.5, BRUSH_COST = 9;
        const int VOUCHER_ONE = 5, VOUCHER_TWO = 10, VOUCHER_THREE = 15;
        static double totalCost, totalAmount, averageCost;
        static void Main(string[] args)
        {
            //Declaration

            int discount = 0;
            string userName, userProduct;
            char calculateAnother = 'o';
            bool exit = false;
            double finalCost;


            //Input
            Console.WriteLine("****** Market calculator******\n");
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            //Processing

            while (exit == false)
            {
                CostCalculation(userName);
                
                while (exit == false)
                {
                    Console.Write("Do you wish to calculate another?(y/n): ");
                    calculateAnother = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    if (calculateAnother != 'Y' && calculateAnother != 'N')
                    {
                        Console.WriteLine("Wrong Input. Try again!");
                    }
                    else
                    {
                        exit = true;
                    }
                }

                exit = false;

                if (calculateAnother == 'N')
                {
                    exit = true;
                }
            }

            if (totalCost >= 70 && totalCost <= 89.99)
            {
                discount = VOUCHER_ONE;
            }
            else if (totalCost >= 90 && totalCost <= 119.99)
            {
                discount = VOUCHER_TWO;
            }
            else if (totalCost >= 120)
            {
                discount = VOUCHER_THREE;
            }

            averageCost = totalCost / totalAmount;

            //Output

            Console.WriteLine("\n");
            Console.WriteLine($"\n{userName}, your total purchase of {totalCost:c} and you recieve {discount:c} voucher");
            Console.WriteLine($"\nAverage of all purchases is: {averageCost:N2}$\n");
            Console.WriteLine("\n");
        }


        static void CostCalculation(string name)
        {
            bool exit = false;
            double productPrice = 0, finalPrice;
            string userInputProductName = "0", productName;
            int userInputAmount = 0;

            while(exit == false)
            {
                Console.Write($"\n{name}, enter product(Shovel/Spade/Bucket/Brush): ");
                userInputProductName = Console.ReadLine();
                productName = userInputProductName.ToUpper();
                
                switch(productName)
                {
                    case "SHOVEL":
                        productPrice = SHOVEL_COST;
                        exit = true;
                        break;
                    case "BUCKET":
                        productPrice = BUCKET_COST;
                        exit = true;
                        break;
                    case "SPADE":
                        productPrice = SPADE_COST;
                        exit = true;
                        break;
                    case "BRUSH":
                        productPrice = BRUSH_COST;
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("\nWrong input. Try again!\n");
                        break;
                }
            }

            exit = false;

            while (exit == false)
            {
                Console.Write($"{name}, enter the amount: ");
                userInputAmount = int.Parse(Console.ReadLine());
                if (userInputAmount >= 0 && userInputAmount <= 50)
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("\nWrong Input. Try again!\n");
                }
            }

            finalPrice = productPrice * userInputAmount;

            totalAmount += userInputAmount;
            totalCost += finalPrice;

            Console.WriteLine($"\nTotal cost for {userInputAmount} {userInputProductName} is: {finalPrice:c}.\n");
        }
    }    
}