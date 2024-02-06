/*
 * Name: Q12
 * Author: M.Strelec
 * Date: 1/2024
 * Purpose: worksheet task...
 */

using System.Text;

namespace Q12
{
    internal class Program
    {

        static string inputSentence;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Processing
            //Output
            Console.WriteLine($"Your new encrypted string: {StringEncrypt(inputSentence)}");
            Console.WriteLine("\n******End of program******\n");
        }
    
            static void InputHandlerer()
            {
                int inputSentenceLength;

                Console.Write("Enter a text you want to encrypt: ");
                inputSentence = Console.ReadLine();
                inputSentenceLength = inputSentence.Length;
                while (inputSentenceLength <= 0 || inputSentenceLength > 20)
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write("> ");
                    inputSentence = Console.ReadLine();
                    inputSentenceLength = inputSentence.Length;
                }
            }
            static string StringEncrypt(string input)
            {
                char[] array = input.ToCharArray();
                array[array.Length - 1] = array[0];
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                return new string(array);
            }
    }
}