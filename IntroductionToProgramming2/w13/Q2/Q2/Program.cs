using System.Diagnostics;

namespace Q2
{
    internal class Program
    {
        static bool exit = false;

        static void Main(string[] args)
        {
            Console.WriteLine("\n****** Leap Year Estimator ******\n");

            int input;
            while (exit == false)
            {
                Console.Write("\nEnter the year (Enter -999 to exit): ");
                input = int.Parse(Console.ReadLine());
                LeapYear(input);
            }

            Console.WriteLine("\n****** End of program ******\n");
        }
        static void LeapYear(int userInput)
        {
            if (userInput == -999)
            {
                exit = true;
            }
            else
            {
                if (userInput <= 1582)
                {
                    if ((userInput % 4) == 0)
                    {
                        Console.WriteLine("This year is a leap year!");
                    }
                    else
                    {
                        Console.WriteLine("This year is not a leap year");
                    }
                }
                else
                {
                    if (!((userInput % 100) == 0) && !((userInput % 400) == 0))
                    {
                        if ((userInput % 4) == 0)
                        {
                            Console.WriteLine("This year is a leap year!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This year is not a leap year");
                    }

                }
            }            

        }

    }
}