/*
 * Name: Calculating programming results
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Calculates your Programming mark value  
 */

using System.Transactions;
using System.Xml.Serialization;

namespace Q7
{
    internal class Program
    {
        const int TAB_INDENTATION = -35;
        static double totalResult;
        static string totalExams;
        static char choice = '0';

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");

            while (choice != 'X') //Common Loop
            {
                choice = DisplayMenu();
                switch (choice)
                {
                    case 'A':
                        Quiz();
                        break;
                    case 'B':
                        CA();
                        break;
                    case 'C':
                        Quiz();
                        break;
                    case 'D':
                        CA();
                        break;
                    case 'E':
                        Console.WriteLine($"\nTotal for {totalExams} is: {totalResult:N2}");
                        break;
                    case 'X':
                        Console.WriteLine("\nExiting...");
                        break;
                    default:
                        break;
                }
            }        
            Console.WriteLine("\n******End of program******\n");
        }

        static char DisplayMenu()
        {
         
           //Displays Menu

            char option = '0';

            Console.WriteLine("\nChoose an option: \n");
            Console.WriteLine("[A] Enter Quiz 1 Result (out of 5)");
            Console.WriteLine("[B] Enter CA 1 Result worth 10% (out of 100)");
            Console.WriteLine("[C] Enter Quiz 2 Result (out of 5)");
            Console.WriteLine("[D] Enter CA 2 Result wort 10% (out of 100)");
            Console.WriteLine("[E] Display total so far (all entered out of 35%)");
            Console.WriteLine("[X] Exit...");
            Console.Write($"{"Enter an option",TAB_INDENTATION}: ");
            while (true) 
            {
                option = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
                if ((Char.IsLetter(option) == true) && ((option >= 'A' && option <= 'E') || option == 'X'))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Try again!");
                Console.Write($"{"Enter an option", TAB_INDENTATION}: ");                
            }
            return option;
        }
        static double Quiz()
        {
            int i = 0;
            //Calculates mark from quiz
            if (choice == 'A')
            {
                double result;
                Console.Write($"{"\nEnter your mark for quiz 1",TAB_INDENTATION}: ");
                result = double.Parse(Console.ReadLine());                               
                totalExams += "Quiz 1,";
                totalResult += result;
                return result;                                                   
            }
            else
            {
                double result;
                Console.Write($"{"\nEnter your mark for quiz 2",TAB_INDENTATION}: ");
                result = double.Parse(Console.ReadLine());
                totalExams += "Quiz 2,";
                totalResult += result;
                return result;
            }            
        }
        static double CA()
        {

            //Calculates mark from CA1

            double mark, result;
            int i = 0;
            Console.Write($"{"\nEnter your mark for CA 1",TAB_INDENTATION}: ");
            mark = double.Parse(Console.ReadLine());
            if (i == 0)
            {
                if (choice == 'B')
                {
                    result = mark / 10;
                    totalExams += "CA1,";
                    totalResult += result;
                    return mark;
                }
                else
                {
                    result = mark / 15;
                    totalExams += "CA2";
                    totalResult += result;
                    return mark;
                }
            }
            else
            {
                Console.WriteLine("Already Inputted");
                return 0;
            }        
        }
    }
}