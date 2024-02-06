using System.Data;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Xml.Schema;

namespace Q3
{
    internal class Program
    {

        static bool exit = false;
        static double booksFee, deliveryFee;

        static void Main(string[] args)
        {          
            Console.WriteLine("\n****** Book delivery service ******\n");           
            while (exit == false)
            {
                Console.Write("\nEnter the weight of books: ");
                BookFeeCalculation(Console.ReadLine());

                Console.WriteLine();
                Console.Write("Enter the delivery option:");
                Console.WriteLine("Express = EX");
                Console.WriteLine("Super Express = SEX");
                Console.WriteLine("Super Super Express = SSEX:");
                Console.WriteLine();
                Console.Write(": ");
                DeliveryCalculation(Console.ReadLine());

                Console.WriteLine($"\nThe total for shipping is: {TotalFee(booksFee, deliveryFee):c}");

                Console.Write("\nCalculate another? (Y/N): ");
                Repeat(Console.ReadLine());
            }

            Console.WriteLine("\n****** End of program ******\n");

        }
        static void Repeat(string input)
        {
            char answer;

            while (exit == false)
            {
                answer = Char.ToUpper(Convert.ToChar(input));
                if (answer == 'Y' || answer == 'N')
                {
                    if (answer == 'N')
                    {
                        exit = true;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Wrong input. Try again!");
                }
            }
        }
        static void BookFeeCalculation(string input)
        {

            const double FEE_RATEL = 0.025, FEE_RATEM = 0.03, FEE_RATEH = 0.05;

            int weight = int.Parse(input);

            if (weight > 0 && weight <= 2000)
            {
                booksFee = 2.5 + (weight * FEE_RATEL);
            }
            else if (weight >= 2001 && weight <= 5000)
            {
                booksFee = 2.5 + (2000 * FEE_RATEL) + ((weight - 2000) * FEE_RATEM);
            }
            else
            {
                booksFee = 2.5 + (2000 * FEE_RATEL) + ((weight - 3000) * FEE_RATEM) + ((weight - 5000) * FEE_RATEL);
            }
        }
        static void DeliveryCalculation(string input)
        {

            const double EXPRESS = 0, SEXPRESS = 2.5, SSEXPRESS = 3.5;

            while (exit == false)
            {

                string delivery = input.ToUpper();

                if (delivery == "EX")
                {
                    deliveryFee = EXPRESS;
                    exit = true;
                }
                else if (delivery == "SEX")
                {
                    deliveryFee = SEXPRESS;
                    exit = true;
                }
                else if (delivery == "SSEX")
                {
                    deliveryFee = SSEXPRESS;
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Wrong Input. Try again!");
                }
            }
            exit = false;
        }
        static double TotalFee(double bookFee, double deliveryFee)
        {
            double total = bookFee + deliveryFee;
            return total;
        }
    }
}