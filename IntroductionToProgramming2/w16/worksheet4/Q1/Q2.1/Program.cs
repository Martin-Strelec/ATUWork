/*
 * Name: Q2.1
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: Input Handeling
 */

using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Xml;

namespace Q2._1
{
    internal class Program
    {

        static string inputString = "Hula hup$$.com";
        static string inputStringPhoneNumber = "999000111222333444";
        static char[] removeCharacters = { '$', '%', ' ' };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            PrintCharacters(inputString);
            Console.WriteLine("");
            PrintEveryThirdCharacter(inputString);
            Console.WriteLine("");
            Appearance(inputString, 'O', 'G');
            Console.WriteLine("");
            AlternateString(inputString);
            Console.WriteLine("");
            Console.WriteLine($"{isFirstLetterANumber(inputString)}");
            Console.WriteLine("");
            Console.WriteLine($"{AddDash(inputStringPhoneNumber)}");
            Console.WriteLine("");
            Console.WriteLine($"{RemoveCharacters(inputString, removeCharacters)}");
            Console.WriteLine("");
            Console.WriteLine($"{ContainsDomain(inputString)}");



            Console.WriteLine("\n******End of program******\n");
        }

        static void PrintCharacters(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{input[i]}");
            }
        }

        static void PrintEveryThirdCharacter(string input)
        {
            for (int i = 2; i < input.Length; i += 3)
            {

                Console.Write($"{input[i]}");

            }
        }

        static void Appearance(string input, char fisrtLetter, char secondLetter)
        {
            input = input.ToUpper();
            int ch1 = 0, ch2 = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == fisrtLetter)
                {
                    ch1++;
                }
                if (input[i] == secondLetter)
                {
                    ch2++;
                }
            }
            Console.WriteLine($"Appearance of {fisrtLetter}: {ch1}");
            Console.WriteLine($"Appearance of {secondLetter}: {ch2}");
        }
        static void AlternateString(string input)
        {
            int i = 0, counter = 0;

            while (i < input.Length)
            {
                if (i + 3 >= input.Length - 1)
                {
                    Console.Write($"{input[i]}");
                    i++;
                }
                else
                {
                    Console.Write($"{input[i]}");
                    counter++;
                    if (counter == 3)
                    {
                        i += 3;
                        counter = 0;
                    }
                    i++;
                }

            }
        }
        static bool isFirstLetterANumber(string input)
        {
            bool isNumber = false;

            for (int i = 0; i < 10; i++)
            {
                if (input[0] == i)
                {
                    isNumber = true;
                }
            }
            return isNumber;
        }
        static string AddDash(string phoneNumber)
        {
            int counter = 3, stringLength = phoneNumber.Length;
            string output = phoneNumber;


            for (int i = 3; i < stringLength; i++)
            {
                if (counter == 3)
                {
                    output = new string(output.Insert(i, "-"));
                    counter = -1;
                    stringLength++;
                }
                counter++;
            }

            return output;
        }

        static string RemoveCharacters(string input, char[] signs)
        {
            string temp = "";
            bool isSign = false;

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < signs.Length; j++)
                {
                    if (input[i] == signs[j])
                    {
                        isSign = true;
                    }
                }
                if (isSign == false)
                {
                    temp += input[i];
                }
                isSign = false;
            }
            return temp;
        }

        static bool ContainsDomain(string input)
        {
            string domain = ".com";
            string inputDomain = input.Substring(input.Length - (domain.Length), domain.Length);
            bool containsDomain = false;

            if (inputDomain == domain)
            {
                containsDomain = true;
            }

            return containsDomain;
        }
    }
}