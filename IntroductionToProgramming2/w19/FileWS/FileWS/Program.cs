/*
 * Name: FileWS Q1
 * Author: M.Strelec
 * Date: 3/2024
 * Purpose: Working with files
 */

namespace FileWSQ1
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
            FavouriteSongVerse(@"../../../FavouriteSongVerse.txt");
            Console.WriteLine("");
            DisplayFirstLine(@"../../../FavouriteSongVerse.txt");
            Console.WriteLine("");
            DisplaySingleLine(@"../../../FavouriteSongVerse.txt", 2);
            Console.WriteLine("");
            DisplayEverything(@"../../../FavouriteSongVerse.txt");
            Console.WriteLine("");
            //Output
            Console.WriteLine("\n******End of program******\n");
        }

        static void FavouriteSongVerse(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    throw new FileLoadException("File already exists!");
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("I have never killed myself to see my soul");
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            /*if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("I have never killed myself to see my soul");
                }
            }*/
        }
        static void DisplayFirstLine(string path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    string s;
                    if ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine($"{s}");
                    }                 
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        static void DisplaySingleLine(string path, int line)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    int count = 0;
                    string s;

                    //Cool method
                    /*if ((s = File.ReadLines(path).Skip(2).Take(1).First()) != null)
                    {
                        Console.WriteLine($"{s}");
                    }*/

                    while ((s = sr.ReadLine()) != null)
                    {
                        if (count == line)
                        {
                            Console.WriteLine($"Line {line} is: {s}");
                            break;
                        }
                        count++;
                    }
                    if (count != line)
                    {
                        Console.WriteLine("File is too short!");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
            /*catch (InvalidOperationException)
            {
                Console.WriteLine("File is too short!");
            }*/
        }
        static void DisplayEverything(string path)
        {
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    int count = 0;
                    string s;

                    while ((s = sr.ReadLine()) != null)
                    {

                        Console.WriteLine($"{s}");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found!");
            }
        }
    }
}