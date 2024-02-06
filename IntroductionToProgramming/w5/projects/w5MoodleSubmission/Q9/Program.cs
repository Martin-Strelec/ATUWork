/*
 * Name: Lottery game
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It gives you reward based on how many numbers you've guessed right
 */

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int TAB_INDENTATION = -35;
            int[] userGuessedNumbers, winningNumbers = {3,6,8};
            int inputNumbersCount = winningNumbers.Length, reward = 1;
            int correctGuess = 0;

            userGuessedNumbers = new int[inputNumbersCount];

            //Input
            Console.WriteLine("Lottery Game");
            Console.WriteLine("\n******Start of program******\n");
            Console.WriteLine($"Guess {inputNumbersCount} numbers\n");
            for (int i = 1; i <= inputNumbersCount; i++)
            {
                Console.Write($"{$"Enter the number {i}",TAB_INDENTATION}: ");
                userGuessedNumbers[i-1] = int.Parse(Console.ReadLine());
            }
            //Processing

            //Compares the input numbers with the "winning numbers". If the numbers are the same it adds one to the correctGuess variable
            for (int i = 0; i < inputNumbersCount; i++)
            {
                int result = userGuessedNumbers[i] - winningNumbers[i];
                if(result == 0)
                {
                    correctGuess++;
                }
            }
            
            //Calculates the final reward based on the count of correctly guessed numbers
            for (int i = 0; i < correctGuess; i++)
            {
                reward *= 10;
            }

            //Output
            Console.WriteLine("\n");
            Console.Write($"{"You've guessed these numbers",TAB_INDENTATION}: ");

            for (int i = 0; i < inputNumbersCount; i++)
            {
                Console.Write($"{userGuessedNumbers[i]}, ");
            }

            Console.WriteLine("\n");
            Console.Write($"{"These are the winning numbers",TAB_INDENTATION}: ");

            for (int i = 0; i < inputNumbersCount; i++)
            {
                Console.Write($"{winningNumbers[i]}, ");
            }

            Console.WriteLine("\n");
            Console.WriteLine($"\nYou've guessed {correctGuess} numbers right");
            Console.WriteLine($"Your prize is therefore {reward:c}");     
            Console.WriteLine("\n******End of program******\n");
        }
    }
}