/*
 * Name: CA3
 * Author: M.Strelec
 * Date: 12/2023
 * Purpose: Mock exam for CA3 
 */

namespace CA3
{
    internal class Program
    {

        static string userName;
        static double userRate, glassCost = 0, windowCost = 0, doorCost = 0;
        static int passes = 0;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            bool exit = false;
            //Input
            Console.WriteLine("CA3 Mock");
            Console.WriteLine("\n******Start of program******\n");
            while (exit == false)
            {
                switch (DisplayMenu())
                {
                    case 'A':
                        GlassCost();
                        break;
                    case 'B':
                        WindowCost();
                        break;
                    case 'C':
                        DoorCost();
                        break;
                    case 'D':
                        TotalExpenses();
                        break;
                    case 'E':
                        exit = true;
                        break;
                    default:
                        break;
                }
            }

            //Processing
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static void GlassCost()
        {
            const double sGlaze = 25.5, dGlaze = 35.5, tGlaze = 45.5;
            double glassArea, glassRate, result;
            int numberOfGlassPanes;
            char glassType;

            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.Write("Enter the area of glass in m^2: ");
            glassArea = double.Parse(Console.ReadLine());
            Console.Write("Enter the type of glass (T = Triple, D = Double, S = Single glaze): ");
            glassType = Char.ToUpper(Convert.ToChar(Console.ReadLine()));          

            while (true)
            {
                if (glassType == 'D')
                {
                    glassRate = glassArea * dGlaze;
                    break;
                }
                else if (glassType == 'T')
                {
                    glassRate = glassArea * tGlaze;
                    break;
                }
                else if (glassType == 'S') 
                {
                    glassRate = glassArea * sGlaze;
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong input. Try again!");
                }
            }

            Console.Write("Enter the number of panes: ");
            numberOfGlassPanes = int.Parse(Console.ReadLine());
           
            result = glassRate * numberOfGlassPanes;

            Console.WriteLine($"\n== {userName}, your glass costs: {result:c} ==");
            Console.WriteLine("---------------------------------------------------------------------\n");

            glassCost += result;
        }

        static void WindowCost()
        {
            const double labourTimeEstimate = 2.5, materialCost = 45.5; //hours, $
            double result;
            int userInput;

            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.Write("Enter the amount of windows: ");
            userInput = int.Parse(Console.ReadLine());

            result = ((userRate * labourTimeEstimate) * userInput) + (userInput * materialCost);
            windowCost += result;

            Console.WriteLine($"\n== {userName}, the labour cost of your windows is: {result:c} ==");
            Console.WriteLine("---------------------------------------------------------------------\n");
        }

        static void DoorCost()
        {
            const double doorPrice = 95.5;
            int userInput;
            double result;

            Console.WriteLine("\n---------------------------------------------------------------------");
            Console.Write("Enter the amount of doors you want: ");
            userInput = int.Parse(Console.ReadLine());

            result = doorPrice * userInput;

            Console.WriteLine($"\n== {userName}, cost of doors is: {result:c} ==");
            Console.WriteLine("---------------------------------------------------------------------\n");

            doorCost += result;          
        }

        static void TotalExpenses()
        {
            const string OUTPUT_TAB = "{0,-30}, {1,5}, {2, 30}";
            double discount, totalCost, totalCostExDiscount, discountAmount;

            totalCostExDiscount = glassCost + doorCost + windowCost;

            if (totalCostExDiscount >= 0 && totalCostExDiscount <= 400)
            {
                discount = 0.02;
            }
            else if (totalCostExDiscount > 400 && totalCostExDiscount <= 500)
            {
                discount = 0.05;
            }
            else
            {
                discount = 0.06;
            }

            discountAmount = (totalCostExDiscount * discount);
            totalCost = totalCostExDiscount - discountAmount;

            Console.WriteLine($"\n{userName}s Quote");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Qoute", "|", "Cost");
            Console.WriteLine(OUTPUT_TAB, "Glass", "|", $"{glassCost:c}");
            Console.WriteLine(OUTPUT_TAB, "Window(s)", "|", $"{windowCost:c}");
            Console.WriteLine(OUTPUT_TAB, "Door(s)", "|", $"{doorCost:c}");
            Console.WriteLine(OUTPUT_TAB, "Total", "|", $"{totalCostExDiscount:c}");
            Console.WriteLine(OUTPUT_TAB, $"Discount {discount:p}", "|", $"{discountAmount:c}");
            Console.WriteLine(OUTPUT_TAB, $"Quote", "|", $"{totalCost:c}");
            Console.WriteLine("---------------------------------------------------------------------\n");
        }
       
        static char DisplayMenu()
        {
            if (passes < 1)
            {
                Console.Write("Enter your name: ");
                userName = Console.ReadLine();
                Console.Write($"{userName}, enter your labour cost: ");
                userRate = double.Parse(Console.ReadLine());
            }

            char choice;
            Console.WriteLine("\nChoose the option:");
            Console.WriteLine("A. Glass cost");
            Console.WriteLine("B. Window cost");
            Console.WriteLine("C. Door cost");
            Console.WriteLine("D. Display total cost");
            Console.WriteLine("E. Exit...");
            Console.Write("\nEnter the option: ");
            choice = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            passes++;

            return choice;
        }
    }
}