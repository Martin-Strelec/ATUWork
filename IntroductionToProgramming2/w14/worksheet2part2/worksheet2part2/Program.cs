/*
 * Name: Q1
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

namespace Q1
{
    internal class Program
    {

        static int time;
        static float distance;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Input
            Console.WriteLine("Distance counter");
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Output
            Console.WriteLine();
            Distance(time, distance);
            Console.WriteLine("\n******End of program******\n");
        }

        static void Distance(int time, float speed)
        {
            float distance;

            for (int i = 1; i <= time; i++) 
            {
                distance = i * speed;
                Console.WriteLine($"Hour {i}  Distance: {distance}km");
            }

        }

        static void InputHandlerer()
        {
            Console.Write("Enter the speed of the vehicle: ");
            while (!float.TryParse(Console.ReadLine(), out distance))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }

            Console.Write("Enter the duration: ");
            while (!int.TryParse(Console.ReadLine(), out time))
            {
                Console.WriteLine("Invalid input!");
                Console.Write("> ");
            }
        }
    }
}