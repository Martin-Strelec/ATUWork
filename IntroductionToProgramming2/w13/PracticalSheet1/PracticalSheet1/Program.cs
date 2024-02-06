/*
 * Project name: Practical sheet 1
 * Name: M. Strelec
 * Date: 1/2024
 * Purpose: Some pracitce code
*/

namespace PracticalSheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FirstTask

            for (int i = 40; i <= 60; i++)
            {
                if (i == 46 || i == 48)
                {

                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }

            Console.WriteLine();

            //SecondTask

            for (int i = 60; i >= 40; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();

            //ThirdTask

            
            const int COUNT = 5;
            int odd = 0, smallest, highest, sum = 0;
            float average;
            int[] input = new int[COUNT];

            for (int i = 0; i < COUNT; i++)
            {
                Console.Write($"Enter a number {i + 1}: ");
                input[i] = int.Parse(Console.ReadLine());
                if (input[i] % 2 == 0)
                {
                    odd++;
                }
                sum += input[i];
            }

            average = sum / COUNT;

            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The number of odd numbers is: {odd}");
            
            //SixthTask

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}