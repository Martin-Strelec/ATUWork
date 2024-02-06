/*
 * Name: Methods 2
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Showcase of basic methods
 */

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -30;
            string userName, userAge;

            //Input
            Console.WriteLine("Methods 2");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name", TAB_INDENTATION}: ");
            userName = Console.ReadLine();
            Console.Write($"{"Enter your age", TAB_INDENTATION}: ");
            userAge = Console.ReadLine();

            //Processing
            //Output
            Greetings(userName, userAge);
            Console.WriteLine("\n******End of program******\n");
        }

        static private void Greetings(string name, string age)
        {
            Console.WriteLine($"\nHi {name}. You are {age} years old!");
        }
    }
}