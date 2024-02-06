/*
 * Name: Q4
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

namespace Q4
{
    internal class Program
    {

        static int organismsCount, days;
        static float percentage;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Input
            Console.WriteLine("Organism spread");
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Output
            Console.WriteLine("");
            OrganismSpread();
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            Console.Write("Enter the number of organisms (whole number): ");
            while (!int.TryParse(Console.ReadLine(), out organismsCount))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }

            Console.Write("Enter the period of their multiplication (in days): ");
            while (!int.TryParse(Console.ReadLine(), out days))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }

            Console.Write("Pefcentage increase in population for each day (in %): ");
            while (!float.TryParse(Console.ReadLine(), out percentage))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }



        }
        static void OrganismSpread()
        {
            float population = organismsCount;

            for (int i = 0; i < days; i++)
            {
                population += ((population/100)*(percentage));
                Console.WriteLine($"Day {i+1}  Population: {population:N0}");                
            }
        }
    }
}