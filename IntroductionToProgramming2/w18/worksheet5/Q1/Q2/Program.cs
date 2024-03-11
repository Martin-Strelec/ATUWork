/*
 * Name: Q2
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: Methods
 */

using System.Globalization;
using System.Net.Http.Headers;

namespace Q2
{
    internal class Program
    {

        static string input = "babajaga";
        static string password = "Jedeme123";
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"{CharacterOccurence(input, '0')}");
            Console.WriteLine($"{PasswordChecker(password)}");
            Console.WriteLine($"{SumOfNumbers("1,2,3,4,5,6")}");
            Console.WriteLine("\n******End of program******\n");
        }

        static int CharacterOccurence(string inputString, char ch)
        {
            //For all the characters in the alphabet
            if (ch == '0')
            {
                int startingIndex = 97;
                int numberOfCharacters = 26;
                int[] occurence = new int[numberOfCharacters];
                
                char[] characters = new char[numberOfCharacters];
                for (int i = 0; i < numberOfCharacters; i++)
                {
                    characters[i] = (char)(startingIndex + i);
                }

                for (int i = 0; i < inputString.Length; i++)
                {
                    for (int j = 0; j < occurence.Length; j++)
                    {
                        if (inputString[i] == characters[j])
                        {
                            occurence[j]++;
                        }
                    }

                }

                for (int i = 0; i < occurence.Length; i++)
                {
                    Console.WriteLine($"{characters[i]}: {occurence[i]}");
                }
                return 0;
            }
            //For selected character
            else
            {
                int occurence = 0;
                for (int i = 0; i < inputString.Length; i++)
                {
                    if (inputString[i] == ch)
                    {
                        occurence++;
                    }
                }
                return occurence;
            }         
        }
        static bool PasswordChecker(string inputString)
        {
            bool isUpper = false, isLongEnough = false, isNumber = false, isLower = false;
            int UpperCaseOffset = -32;
            int numberStartingIndex = 48, numberEndIndex = numberStartingIndex + 9;
            int characterStartingIndex = 97, characterEndIndex = characterStartingIndex + 25;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (isUpper != true)
                {
                    if ((int)inputString[i] >= characterStartingIndex + UpperCaseOffset && (int)inputString[i] <= characterEndIndex + UpperCaseOffset)
                    {
                        isUpper = true;
                    }
                }

                if (isLongEnough != true)
                {
                    if (inputString.Length >= 6)
                    {
                        isLongEnough = true;
                    }
                }
                
                if (isNumber != true)
                {
                    if ((int)inputString[i] >= numberStartingIndex && (int)inputString[i] <= numberEndIndex)
                    {
                        isNumber = true;
                    }
                }
                
                if (isLower != true)
                {
                    if ((int)inputString[i] >= characterStartingIndex && (int)inputString[i] <= characterEndIndex)
                    {
                        isLower = true;
                    }
                }               
            }

            if ((isUpper && isLongEnough && isNumber && isLower) == true)
            {
                return true;
            }
            else
            {
                return false;
            }           
        }
        static int SumOfNumbers(string inputString)
        {
            string[] numbers = inputString.Split(',');
            int sum = 0;
            
            foreach (string n in numbers)
            {
                sum += int.Parse(n);
            }
            return sum;
        }
    }
}