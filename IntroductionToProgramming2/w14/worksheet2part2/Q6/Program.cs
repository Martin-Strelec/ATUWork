/*
 * Name: Q6
 * Author: M.Strelec
 * Date: 2/2024
 * Purpose: Card description
 */

namespace Q6
{
    internal class Program
    {
        static int nameIndex, colorIndex;
        static string[] cardNames = { "Ace", "2Two", "3Three", "4Four", "5Five", "6Six", "7Seven", "8Eight", "9Nine", "10Ten", "Jack", "Queen", "King" };
        static string[] cardColor = { "Clubs", "Diamonds", "Hearts", "Spades" };

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command
            //Input
            Console.WriteLine("Card annotation");
            Console.WriteLine("\n******Start of program******\n");
            InputHandlerer();
            //Output
            DisplayTab();
            Console.WriteLine("\n******End of program******\n");
        }

        static void InputHandlerer()
        {
            bool exit = false; //boolean for escaping the loop

            Console.Write($"Enter the card notation (QH, AS..): ");
            while (exit == false)
            {
                string input = Console.ReadLine();
                string processedInput = input.ToUpper(); //Making the letters capital
                char[] array = processedInput.ToCharArray(); //making string into char array 

                for (int i = 0; i < cardNames.Length; i++) //checking if the first character of string input is in the cardNames list
                {
                    if (cardNames[i].IndexOf(array[0]) == 0)
                    {
                        nameIndex = i;
                        for (int j = 0; j < cardColor.Length; j++) //checking if the second character of string input is in the cardColor list
                        {
                            if (cardColor[j].IndexOf(array[1]) == 0)
                            {
                                colorIndex = j;
                                exit = true;
                                break;
                            }
                        }
                    }
                }
                if (exit == false)
                {
                    Console.WriteLine("Invalid Input!");
                    Console.Write("> ");
                }
                
            }
               
        }
        static void DisplayTab()
        {
            if (nameIndex >= 1 && nameIndex <= 9)
            {
                Console.WriteLine($"\n{cardNames[nameIndex].Remove(0,1)} to {cardColor[colorIndex]}");
            }
            else
            {
                Console.WriteLine($"\n{cardNames[nameIndex]} to {cardColor[colorIndex]}");
            }          
        }
    }
}