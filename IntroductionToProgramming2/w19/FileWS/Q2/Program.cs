/*
 * Name: FileWS Q2
 * Author: M.Strelec
 * Date: 3/2024
 * Purpose: Working with files
 */

namespace Q2
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
            WriteFileDataToConsole(@"../../../temp.txt");
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static void WriteFileDataToConsole(string path)
        {
            const string DISPLAY_TAB = "{0,-12}{1,-12}";
            string[] data;

            Console.WriteLine("Temperature report");
            Console.WriteLine(DISPLAY_TAB, "Date", "Temperature");
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    while ((s = sr.ReadLine()) != null)
                    {
                        data = s.Split(',');
                        if (data.Length != 2)
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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}