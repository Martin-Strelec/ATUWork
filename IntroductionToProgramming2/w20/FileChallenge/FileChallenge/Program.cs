/*
 * Name: FileChallenge
 * Author: M.Strelec
 * Date: 3/2024
 * Purpose: Reading from .csv file 
 */

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
            const string DISPLAY_TAB = "{0,-12}{1,-12}";
            string[] data;

            Console.WriteLine("Energy Consumption per capita (in kg of oil)");
            Console.WriteLine(DISPLAY_TAB, "Country", "Temperature");
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        data = s.Split(',');
                        if (data.Length != 22)
                        {
                            throw new Exception("Incorrect file format!");
                        }
                        Console.WriteLine(DISPLAY_TAB, $"{data[0]}", $"{data[1]}");
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