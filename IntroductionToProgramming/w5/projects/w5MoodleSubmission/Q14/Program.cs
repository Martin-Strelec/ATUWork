/*
 * Name: Sligo Multiplex
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It displays the available films and decides, if the user is old enough to see them
 */

using System.ComponentModel.Design;

namespace Q14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string[] nameOfTheFilm = { "Made in Dagenham", "Buried", "Despicable Me", "The Other Guys", "Takers" };
            string[] ageRestriction = {"15", "18", "U", "12A", "12A"};
            string userAge;
            int filmNumber;
            bool validInput = true;

            //Input
            Console.WriteLine("Sligo Multiplex");
            Console.WriteLine("\n******Start of program******\n");
            Console.WriteLine("Welcome to Sligo Multiplex!\n");           
            Console.WriteLine("We are presently showing:");

            //Outputs the entire film list 
            for(int i = 0; i < nameOfTheFilm.Length; i++)
            {
                Console.WriteLine("{0,5}{1,-30}","",$"{i + 1}. {nameOfTheFilm[i]} ({ageRestriction[i]})");
            }

            Console.Write("\nWhich film would you like to see?: ");
            filmNumber = int.Parse(Console.ReadLine());
            Console.Write("How old are you?: ");
            userAge = Console.ReadLine();

            //Processing & Output

            //Checks if user entered valid age value
            if (int.Parse(userAge) < 1 || int.Parse(userAge) > 120)
            {
                validInput = false;
                Console.WriteLine("\nInvalid input!");
            }
            
            //Decides if user is old enough to see the film
            if (validInput == true)
            {
                //if the film is rated for "U" 
                if (ageRestriction[filmNumber - 1] == "12A")
                {
                    if (int.Parse(userAge) >= 12)
                    {
                        Console.WriteLine("\nEnjoy the film :)");
                    }
                    else
                    {
                        Console.WriteLine("\nAccess denied - you are too young!");
                    }
                }

                else if (int.Parse(userAge) < int.Parse(ageRestriction[filmNumber-1]))
                {
                    Console.WriteLine("\nAccess Denied - you are too young!");
                }

                else
                {
                    Console.WriteLine("\nEnjoy the film :)");
                }             
            }
            Console.WriteLine("\n******End of program******\n");
        }
    }
}