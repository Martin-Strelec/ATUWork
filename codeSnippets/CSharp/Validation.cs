/*
*Made by Martin Strelec
*This class is used to validate specific data types. Work in progress..
*Fucntions: Test for data type > string, int, double, decimal
*/

using System.ComponentModel;

namespace Task7
{
    public class Validation
    {

        /*
         * MODIFYING METHODS
         */

        //Modifies ints. Modifiers: Range, Prompt message
        public int ModifyIntRange(int init, int end, string message)
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

        //Modifies strings. Modifiers: Matching string, Prompt message
        public string ModifyStringMatch(string match, string message)
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

        //Modifies strings. Modifiers: Min and Max Length, lower or UPPER case, Checks if the string isn't a number only,Prompt message
        public string ModifyStringSpecific(int minLength, int maxLength, int modify, bool isText, string message)
        {
            string validOutput = "0";
            Console.Write($"{message}: ");
            string input = Console.ReadLine();

            if (minLength == 0 && maxLength == 0 && isText == true)
            {
                int result;
                while (int.TryParse(input, out result))
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("> ");
                }
                validOutput = input;
            }
            else
            {
                while (true)
                {
                    if (input.Length >= minLength && (input.Length <= maxLength || maxLength == 0))
                    {
                        validOutput = input;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.Write("> ");
                        input = Console.ReadLine();
                    }
                }
            }

            if (modify != 0)
            {
                validOutput = modify == 1 ? validOutput.ToUpper() : validOutput.ToLower();
            }

            return validOutput;
        }

        //Modifies characters. Modifiers: lower or UPPER case, prompt message, array of valid characters
        public char ModifySpecificChars(int modify, string message, params char[] validCharacters)
        {
            char validOutput = 'E';
            int count = 0;
            bool exit = false;
            char input;

            Console.Write($"{message}: ");
            input = Convert.ToChar(Console.ReadLine());

            while (exit == false)
            {
                count = 0;
                foreach (char c in validCharacters)
                {
                    if (input == validCharacters[count])
                    {
                        validOutput = input;
                        exit = true;
                        break;
                    }
                    count++;
                }
                if (exit == false)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                    while (!char.TryParse(Console.ReadLine(), out input))
                    {
                        Console.Write("> ");
                    }
                }
            }

            if (modify != 0)
            {
                validOutput = modify == 1 ? Char.ToUpper(input) : Char.ToLower(input);
            }
            return validOutput;
        }

        //Modifies double. Modifiers: Range, prompt message
        public double ModifyDoubleRange(int init, int end, string message)
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

        //Modifies decimal. Modifiers: Range, Prompt Message
        public decimal ModifyDecimalRange(int init, int end, string message)
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

        /*
         * TESTING METHODS
         */

        //Tests string. Modifiers: Range, output as Text?, Prompt Message
        public bool TestStringSpecific(int minLength, int maxLength, bool isText, string message)
        {
            Console.Write($"{message}: ");
            string input = Console.ReadLine();

            if (minLength == 0 && maxLength == 0 && isText == true)
            {
                int result;
                while (int.TryParse(input, out result))
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("> ");
                }
                return true;
            }
            else
            {
                while (true)
                {
                    if (input.Length >= minLength && (input.Length <= maxLength || maxLength == 0))
                    {
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input!");
                        Console.Write("> ");
                        input = Console.ReadLine();
                    }
                }
            }
        }

        //Tests chars. Modifiers: Message, Deafult option, Valid character array
        public bool TestSpecificChars(string message, char defaultOption, params char[] validCharacters)
        {
            char input;

            Console.Write($"{message}: ");

            if (!(char.TryParse(Console.ReadLine(), out input)) && input == '\0')
            {
                if (defaultOption == 'Y')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                foreach (char c in validCharacters)
                {
                    if (input == c)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

