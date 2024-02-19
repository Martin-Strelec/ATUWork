/*
 * Name: Q4
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

using System.Buffers;

namespace Q4
{
    internal class Program
    {

        static string inputSequence;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine("Q4");
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Processing
            //Output
            if (IsPalindrome(inputSequence) == false)
            {
                Console.WriteLine("\nThe entered character sequence is not a palindrome.");
            }
            else
            {
                Console.WriteLine("\nThe entered character sequence is a palindrome.");
            }
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            Console.Write("Enter sequence of characters: ");
            inputSequence = Console.ReadLine();          
        }
        static bool IsPalindrome(string userInput)
        {
            bool isPalindrome = true;
            int j = 0;

            char[] array = userInput.ToCharArray();
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (array[j] != array[i])
                {
                    isPalindrome = false;
                    break;
                }
                j++;
            }
            return isPalindrome;
        }
    }
}