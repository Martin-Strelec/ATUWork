/*This class is used to validate specific data types. Work in progress..
*Fucntions: Test for data type > string, int, double, decimal
*Modes: Data type, Data type + range, Data type + match (only with string)
*/

namespace QValidation
{
    public class Validation
    {
        //Validates for integer between defined endpoints
        public int TestIntRange(int init, int end, string message)
        {
            int result;
            Console.Write($"{message}: ");

            if (init == 0 && end == 0)
            {
                while (!int.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
            else
            {
                while (!int.TryParse(Console.ReadLine(), out result) && !(result <= init && result >= end))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
        }

        //Validates for string that has to match defined string
        public string TestStringMatch(string match, string message)
        {
            bool exit = false;
            string result = "0";

            Console.Write($"{message}: ");
            while (exit == false)
            {
                result = Console.ReadLine();

                if (result != match)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                else
                {
                    exit = true;

                }
            }
            return result;
        }

        //Validates for double between defined endpoints
        public double TestDoubleRange(int init, int end, string message)
        {
            double result;
            Console.Write($"{message}: ");
            
            if (init == 0 && end == 0)
            {
                while (!double.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
            else
            {
                while (!double.TryParse(Console.ReadLine(), out result) && !(result <= init && result >= end))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
        }

        public decimal TestDecimalRange(int init, int end, string message)
        {
            decimal result;
            Console.Write($"{message}: ");

            if (init == 0 && end == 0)
            {
                while (!decimal.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
            else
            {
                while (!decimal.TryParse(Console.ReadLine(), out result) && !(result <= init && result >= end))
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                return result;
            }
        }
    }
}