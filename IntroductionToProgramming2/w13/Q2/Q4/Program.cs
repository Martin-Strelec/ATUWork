namespace Q4
{
    internal class Program
    {

        static bool exit = false;
        static char status;
        static double grossIncomeValue;

        static void Main(string[] args)
        {
            Console.WriteLine("\n****** Taxes calculator ******\n");
            while (exit == false)
            {

                Console.Write("\nEnter your relationship status (single = S/married = M): ");
                MartialStatus(Console.ReadLine());

<<<<<<<<< Temporary merge branch 1

=========
                
>>>>>>>>> Temporary merge branch 2

            }
        }

        static void Repeat (string input)
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
        static void MartialStatus(string input)
        {
            while (exit == false)
            {
                status = Char.ToUpper(Convert.ToChar(input));
                if (status == 'S' || status == 'M')
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("Wrong input. Try again!");
                }
            }
            exit = false;
        }
        static void GrossIncome(string input)
        {
            while (exit == false)
            {               
                grossIncome = double.Parse(input);
                if (grossIncome < 0)
                {
                    Console.WriteLine("Wrong input. Try again!");
                }
                else
                {
                    exit = true;
                }
            }
            exit = false;
        }
        static void TaxCalculation(char status, double grossIncome)
        {

            double finalTax;

            if (status == 'S')
            {
                if (grossIncome > 0 && grossIncome < 8000)
                {
                    finalTax = grossIncome * 0.1;
                }
                else if (grossIncome >= 8000 && grossIncome < 32000)
                {
                    finalTax = (grossIncome * 0.15) + 800;
                }
                else
                {
                    finalTax = (grossIncome * 0.25) + 4400;
                }
            }
            else
            {
                if (grossIncome > 0 && grossIncome < 16000)
                {
                    finalTax = grossIncome * 0.1;
                }
                else if (grossIncome >= 16000 && grossIncome < 64000)
                {
                    finalTax = (grossIncome * 0.15) + 1600;
                }
                else
                {
                    finalTax = (grossIncome * 0.25) + 8800;
                }
            }

            Console.WriteLine($"\nYour final tax is: {finalTax:c}");
        }
    }
}