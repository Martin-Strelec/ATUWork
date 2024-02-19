/*
 * Name: Q2.1
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: Input Handeling
 */

using System.Reflection.PortableExecutable;
using System.Xml;

namespace Q2._1
{
    internal class Program
    {

        static string inputString = "Jebingos";

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
            Console.WriteLine("\n");
            PrintEveryThirdCharacter(inputString);
            Console.WriteLine("\n");
            Appearance(inputString, 'O', 'G');
            Console.WriteLine("\n");
            AlternateString(inputString);
            Console.WriteLine("\n");

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

            while (i <= input.Length)
            {
                if (i >= )
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
}