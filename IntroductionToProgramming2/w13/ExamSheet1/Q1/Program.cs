/*
 * Project name: Q1
 * Name: Martin Strelec
 * Date: 1/2024
 * Purpose: Bike store purchase cost calculation
*/

namespace Q2
{
    internal class Program
    {
        static string[] itemName = { "KIDS BIKE",
            "HYBRID BIKE",
            "MOUNTAIN BIKE",
            "RACING BIKE",
            "ELECTRIC BIKE" };
        static string[] itemNameCheck = new string[itemName.Length];
        static int[] itemPrice = { 100,
            400,
            400,
            750,
            1000};

        static bool exit = false;
        static string customerNameInput, itemDescriptionInput;

        static void Main(string[] args)
        {
            DatabaseInit();
            InputManager();



        }

        static void InputManager()
        {

            const int TAB_INDENTATION = -30;
            const string INPUT_TAB = "{0,-15}{1,5}{2,10}";
            string itemDescriptionCheck;

            while (exit == false)
            {
                Console.Write($"{"Please enter customer name",TAB_INDENTATION}: ");
                customerNameInput = Console.ReadLine();
                if (customerNameInput.Length < 2 && customerNameInput.Length > 20)
                {
                    Console.WriteLine("Wrong Input. Try Again!");
                }
                else
                {
                    exit = true;
                }
            }
            exit = false;

            while (exit == false)
            {
                Console.WriteLine("\n******************************");
                Console.WriteLine(INPUT_TAB, "ITEM_NAME", "|", "COST");
                Console.WriteLine("------------------------------");
                for (int i = 0; i < itemName.Length; i++)
                {
                    Console.WriteLine(INPUT_TAB, $"{itemName[i]}", "|", $"{itemPrice[i]}");
                }
                Console.WriteLine("******************************\n");

                Console.Write($"{"Please select an item",TAB_INDENTATION}: ");
                itemDescriptionInput = Console.ReadLine();
                itemDescriptionCheck = FormatInput(itemDescriptionInput);


                for (int i = 0; i < itemName.Length; i++)
                {

                    if (itemDescriptionCheck == itemNameCheck[i])
                    {
                        exit = true;
                        break;
                    }                  
                    if (i == itemName.Length - 1)
                    {
                        Console.WriteLine("\n**! Item does not exist. Try selecting a new one !**");
                    }
                }

            }
        }
        static void DatabaseInit()
        {
            int removeIndex;

            for (int i = 0; i < itemName.Length; i++)
            {
                itemNameCheck[i] = FormatInput(itemName[i]);
            }
        }
        static string FormatInput(string input)
        {
            int removeIndex;
            string result = input;

            input = input.ToLower();
            removeIndex = input.IndexOf(" ");
            if (removeIndex != -1)
            {
                result = input.Remove(removeIndex, 1);
            }
            return result;

        }//Good base for checking input format
    }
}