/*
 * Name: Q1
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: String formatting...
 */

using System.Runtime.InteropServices;

namespace Q1
{
    internal class Program
    {

        static string input = "Some thing nny";

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"{RemoveTrailSpace(input)}");
            Console.WriteLine($"{ShowIndex(input,'g')}");
            LastAndFirstCharacter(input);
            Console.WriteLine($"{EndsWithNNY(input)}");
            Console.WriteLine($"{IsEqual(input,"I love Sligo")}");
            BreakIntoWords(input);
            Console.WriteLine($"{DumbEncrypt(input, 'b', 's')}");
            Console.WriteLine("\n******End of program******\n");
        }

        static string RemoveTrailSpace(string inputString)
        {
            string newString = inputString.Trim();

            return newString;
        }

        static int ShowIndex(string inputString, char selectedChar)
        {
            int indexOfChar = inputString.IndexOf(selectedChar);

            //int indexOfChar = inputString.IndexOf(selectedChar, 10);

            return indexOfChar;
        }
        static void LastAndFirstCharacter(string inputString)
        {
            Console.Write($"First: {inputString[0]}, Last: {inputString[inputString.Length - 1]}\n");
        }

        static bool EndsWithNNY(string inputString)
        {
            string endOfString = inputString.Substring(inputString.Length - 3).ToUpper();
            if (endOfString == "NNY")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsEqual(string inputString, string matchingString)
        {
            if (inputString == matchingString)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void BreakIntoWords(string inputString)
        {
            string[] words = inputString.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{words[i]}");
            }
        }

        static string DumbEncrypt(string inputString, char ch1, char ch2) 
        {
            string encryptedString = inputString.Replace('a', ch1);
            encryptedString = encryptedString.Replace('t', ch2);

            return encryptedString;
        }
    }
}