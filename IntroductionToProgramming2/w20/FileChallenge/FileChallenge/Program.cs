/*
 * Name: FileChallenge
 * Author: M.Strelec
 * Date: 3/2024
 * Purpose: Reading from .csv file 
 */

using Microsoft.VisualBasic;

namespace FileChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            //Processing
            WriteFileDataToConsole(@"../../../energy.csv");
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static void WriteFileDataToConsole(string path)
        {
            int dataLength = 22;
            string[] data = new string[dataLength];  

            Console.WriteLine("Energy Consumption per capita (in kg of oil)");
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    sr.ReadLine();
                    while ((s = sr.ReadLine()) != null)
                    {
                        data = s.Split(',');
                        if (data.Length != 22)
                        {
                            throw new Exception("Incorrect file format!");
                        }
                        Console.WriteLine("----------------");
                        Console.WriteLine($"{data[0]}");
                        Console.WriteLine("----------------");
                        for (int i = 1; i < data.Length; i++)
                        {
                            Console.Write($"Year {i} = {data[i]} kg");
                            Console.WriteLine("");
                        }
                        Console.WriteLine("");    
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
        }

    }
}