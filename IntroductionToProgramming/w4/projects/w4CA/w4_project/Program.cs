/*
 * Project name: Mark decision
 * Author: M. Strelec
 * Date: 10/2023
 * Purpose: This program decides, if students passes or fails based on the marks he recieved 
 */
namespace w4_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int passGrade = 40;
            int mathGrade, programGrade;
            string userName;

            //Input
            Console.WriteLine("> Mark decision <");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write("Enter your name\t\t\t: ");
            userName = Console.ReadLine();
            Console.Write("Enter your math grade\t\t: ");
            mathGrade = int.Parse(Console.ReadLine());
            Console.Write("Enter your program grade\t: ");
            programGrade = int.Parse(Console.ReadLine());

            //Output & Processing

            Console.WriteLine($"\n{userName}'s results\n");

            if (programGrade == mathGrade)
            {
                Console.WriteLine("\nYou've scored equally in both!");
            }
            if (programGrade < 40)
            {
                Console.WriteLine("\nYou've failed programming!") ;
            }
            if (mathGrade < 40)
            {
                Console.WriteLine("\nYou've failed maths!");
            }
            if (programGrade < mathGrade)
            {
                Console.WriteLine("\nYou've scored higher in Maths!");
            }
            if (programGrade > mathGrade)
            {
                Console.WriteLine("\nYou've scored higher in Programming!");
            }
            if (programGrade >= 40)
            {
                Console.WriteLine("\nYou've passed Programming!");
            }
            if (mathGrade >= 40) 
            {
                Console.WriteLine("\nYou've passed Maths!");
            }
            if (programGrade < 40 && mathGrade < 40)
            {
                Console.WriteLine("\nYou've failed both classes!");
            }
            if (programGrade >= 40 && mathGrade >= 40)
            {
                Console.WriteLine("\nYou've passed both classes!");
            }

            Console.WriteLine("\n******End of program******");
        }
    }
}