/*
 * Name: FileHandling - sales
 * Author: M.Strelec
 * Date: 3/2024
 * Purpose: FileHandling practice...
 */

using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow;
using System.Transactions;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            bool exit = false;
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            while (exit == false)
            {
                string storeName = Input("Enter the store name: ");
                string[] temp = DataRead("../../../sales.csv", storeName);
                Console.WriteLine($"{StoreRating(Convert.ToInt32(temp[temp.Length - 1]))}");
                Console.Write("Check another?: ");
                exit = Repeat(Console.ReadLine().ToUpper());
            }
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static string[] DataRead(string path, string town)
        {
            int dataLength = 3;
            string[] data = new string[dataLength];

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        if (s.ToUpper().Contains(town) == true)
                        {
                            data = s.Split(',');
                            if (data.Length != dataLength)
                            {
                                throw new Exception("Incorrect data format!");
                            }
                            return data;
                        } 
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return data;
        }
        static string Input(string message)
        {
            string name;

            Console.Write(message);
            name = Console.ReadLine().ToUpper();

            return name;
        }
        static string StoreRating(int rating)
        {
            string[] ratingString = { "Sales are booming!", "Sales are steady!", "Sales are low :("};

            if (rating >= 20000)
            {
                return ratingString[0];
            }
            else if (rating >= 10000 && rating < 20000)
            {
                return ratingString[1];
            }
            else if (rating > 0 && rating < 10000)
            {
                return ratingString[3];
            }
            else
            {
                return "Invalid value!";
            }
        }
        static bool Repeat(string response)
        {
            if (response != "YES" || response != "Y")
            {
                return false;
            }
            else
            {
                return true;
            }          
        }
    }
}