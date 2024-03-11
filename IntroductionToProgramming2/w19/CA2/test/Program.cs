/*
 * Name: test
 * Author: M.Strelec
 * Date: 3/2024
 * Purpose: CA2 Mock Questions
 */

using System.Reflection.Metadata.Ecma335;

namespace Q2
{
    internal class Program
    {



        static void Main(string[] args)
        {
            string jebej = "jebej-jebej-jebej";
            int index;
            int count = 0;
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            index = jebej.IndexOf('-');
            index = jebej.IndexOf('-', jebej.IndexOf('-') + 1);
            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}