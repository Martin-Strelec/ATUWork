/*
 * Name: Telephone company charge rate
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: It takes how many minutes you've called, the area code of the user and the area code of the person who they are calling to. After
 *          that it calculates, how expensive their call was.
 */

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const int BASE_PRICE = 1, BASE_TIME = 21, PRICE_AFTER = 13, TAB_INDENTATION = -35;
            int numberOfSeconds, callerAreaCode, recieverAreaCode, preciseTimeMinutes;
            double totalCost, preciseTimeSeconds;

            //Input
            Console.WriteLine("Telephone Company Charge Rate");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Call length",TAB_INDENTATION}: ");
            numberOfSeconds = int.Parse(Console.ReadLine());
            Console.Write($"{"Enter your area code",TAB_INDENTATION}: ");
            callerAreaCode = int.Parse(Console.ReadLine());
            Console.Write($"{"Enter the reciever's area code", TAB_INDENTATION}: ");
            recieverAreaCode = int.Parse(Console.ReadLine());

            //Processing

            //Decides what price will the caller pay (depends on the area code and the length of the call)
            if (callerAreaCode == recieverAreaCode && numberOfSeconds <= BASE_TIME)
            {
                totalCost = (numberOfSeconds * BASE_PRICE);
            }
            else
            {
                totalCost = (numberOfSeconds * PRICE_AFTER);
            }

            //Calculates call time in minutes and seconds
            preciseTimeSeconds = numberOfSeconds % 60;
            preciseTimeMinutes = numberOfSeconds / 60;

            //Output
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($"{"Caller area code",TAB_INDENTATION}: {callerAreaCode}");
            Console.WriteLine($"{"Reciever area code",TAB_INDENTATION}: {recieverAreaCode}");
            Console.WriteLine($"{"Call duration",TAB_INDENTATION}: {preciseTimeMinutes}m {preciseTimeSeconds}s");
            Console.WriteLine($"{"Total cost",TAB_INDENTATION}: {(totalCost / 100):c}");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}