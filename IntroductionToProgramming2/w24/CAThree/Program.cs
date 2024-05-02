/*
*	Name: CAThree
*	Author: Martin Strelec
*	Date: 22/Apr/2024
*	Purpose: 
*/

using QEvents;
using System;
using Microsoft.Win32.SafeHandles;
using System.Globalization;

namespace CAThree
{
    internal class Program
    {

        static List<string[]> table;
        static List<Events> e = new List<Events>();
        static int fieldLength = 5;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console formatting command

            // Declaration
            // Input
            Console.WriteLine("CAThree");
            Console.WriteLine("******Start of program******");
            // Processing
            ReadEventData("./testData2.csv", fieldLength, ',');
            for (int i = 0; i < table.Count; i++)
            {
                Console.WriteLine($"{table[i][0]}");
            }
            CreateEvents();
            for (int i = 0; i < e.Count; i++)
            {
                Console.WriteLine($"{e[i].ToString()}");
            }

            //Testing
            // Events e = new Events("Something", "Concert", 15, 500);
            // Events e1 = new Events("Somethign", "Concert", 20, 500, 50);

            // Console.WriteLine($"{e.ToString()}");

            // e.Name = "Something2";
            // e.EType = "Musical";
            // e.TPrice = 20;
            // e.Capacity = 40;
            // e.SSold = 30;

            // Console.WriteLine($"{e.ToString()}");


            // Console.WriteLine($"{e.GetPriceClassification()}");
            // Console.WriteLine($"{e.GetPercentageSeatsSold()}%");
            // Console.WriteLine($"{e.BuySeats(10)}");

            // Output
            Console.WriteLine("******End of program******");
        }

        //Method for reading a file
        static void ReadEventData(string path, int dataFields, char sChar)
        {
            table = new List<string[]>();
            string[] data;

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()).Trim() != null)
                {
                    try
                    {
                        data = s.Split(sChar);
                        if (data.Length < dataFields - 1 || data.Length > dataFields)
                        {
                            Console.WriteLine("Incorrect file format!");
                        }
                        else
                        {
                            table.Add(data);
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
                }
            }
        }

        //Method for creating Events objects based on table variable
        static void CreateEvents()
        {
            for (int i = 0; i < table.Count; i++)
            {
                try
                {
                    if (table[i].Length == fieldLength)
                    {
                        e.Add(new Events(table[i][0], table[i][1], decimal.Parse(table[i][2]), int.Parse(table[i][3]), int.Parse(table[i][4])));
                    }
                    else
                    {
                        e.Add(new Events(table[i][0], table[i][1], decimal.Parse(table[i][2]), int.Parse(table[i][3])));
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}