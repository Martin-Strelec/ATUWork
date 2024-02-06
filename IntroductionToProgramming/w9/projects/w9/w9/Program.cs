/*
 * Name: Methods
 * Author: M.Strelec
 * Date: 11/2023
 * Purpose: Calls a method from Main() method.
 */

namespace Q1
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            const int TAB_INDENTATION = -20;
            string userName = "Tom";
            
            //Input
            Console.WriteLine("Methods 1");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name", TAB_INDENTATION}: ");
            userName = Console.ReadLine();

            //Output
            Greetings(userName); //calls Hello() method
            Console.WriteLine("\n******End of program******\n");
        }

        static private void Greetings(string name)
        {
            Console.WriteLine("Hi {0}!", name);
        }

    }
}