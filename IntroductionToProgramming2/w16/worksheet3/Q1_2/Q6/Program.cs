/*
 * Name: Q6
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: worksheet tasks...
 */

namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            var rnd = new Random();
            int count = 10000;
            int j = 0, k = 0, l = 0, m = 0;
            double onesPercentage, twosPercentage, threesPercentage, foursPercentage;
            int[] array = new int[count];
            List<int> one = new List<int>();
            List<int> two = new List<int>();
            List<int> three = new List<int>();
            List<int> four = new List<int>();
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            for (int i = 0; i < count; i++)
            {
                array[i] = rnd.Next(1, 5);               
            }
            for (int i = 0; i < count; i++)
            {
                if (array[i] == 1)
                {
                    j++;
                }
                else if (array[i] == 2)
                {
                    k++;
                }
                else if (array[i] == 3)
                {
                    l++;
                }
                else if (array[i] == 4)
                {
                    m++;
                }
            }
            onesPercentage = j / (count / 100);
            twosPercentage = k / (count / 100);
            threesPercentage = l / (count / 100);
            foursPercentage = m / (count / 100);

            Console.WriteLine($"The percentage of ones: {onesPercentage:N2}%");
            Console.WriteLine($"The percentage of twos: {twosPercentage:N2}%");
            Console.WriteLine($"The percentage of threes: {threesPercentage:N2}%");
            Console.WriteLine($"The percentage of fours: {foursPercentage:N2}%");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}