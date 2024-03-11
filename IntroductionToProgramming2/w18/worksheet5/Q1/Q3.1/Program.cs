/*
 * Name: 
 * Author: M.Strelec
 * Date:
 * Purpose: 
 */

namespace Q3._1
{
    internal class Program
    {

        static int[] scores = { 3, 60, 40, 3, 4, 7, 82 };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command
            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            //Output
            Console.WriteLine($"The average is: {ArrayAverage(scores):N2}");
            Console.WriteLine("\n******End of program******\n");
        }

        static double ArrayAverage(int[] array)
        {
            bool isValid = true;
            double average, sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (isValid != false)
                {
                    try
                    {
                        if (array[i] < 0 || array[i] > 100)
                        {
                            throw new FormatException("Value has to be between 0 - 100");
                        }
                        if (array.Length==0)
                        {
                            throw new ArithmeticException("Cannot divide by zero");
                        }
                        sum += array[i];
                    }
                    catch (FormatException myError)
                    {
                        Console.WriteLine(myError.Message);
                        isValid = false;

                    }
                    catch (IndexOutOfRangeException myError)
                    {
                        Console.WriteLine(myError.Message);
                        isValid = false;
                    }  
                    catch (ArithmeticException myError)
                    {
                        Console.WriteLine(myError.Message);
                        isValid = false;
                    }
                }
                else
                {
                    break;
                }
                
            }

            return sum / array.Length;
        }
    }
}