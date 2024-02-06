/*
 * Name: Car pool
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It checks, if student lives in carpooling town
 */

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -25;
            int i;
            string[] towns = {"BOYLE", "CARRICK ON SHANNON", "COLLOONEY"};
            string studentTown, studentName;
            bool isLiving = false;

            //Input
            Console.WriteLine("Car pool");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter your name:", TAB_INDENTATION}: ");
            studentName = (Console.ReadLine());
            Console.Write($"{"Enter your town name", TAB_INDENTATION}: ");
            studentTown = Console.ReadLine().ToUpper();

            //Processing

            //Goes through every town in towns[] array to check, if it is the same as the inputted town name
            for (i = 0 ; i < towns.Length; i++)
            {
                if (studentTown == towns[i])
                {
                    isLiving = true;
                    break;
                }
            }
            
            //Decides if student is living in carpooling towm. Then it displays the appropriate message
            if (isLiving == true)
            {
                Console.WriteLine($"\n{studentName}, you live in a carpooling town called {towns[i]}");
            }
            else
            {
                Console.WriteLine($"\n{studentName}, you do not live in carpooling town. You live in {studentTown}");
            }

            //Output
            Console.WriteLine("\n******End of program******\n");
        }
    }
}