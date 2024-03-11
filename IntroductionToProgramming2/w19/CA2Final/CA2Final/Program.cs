/*
 * Name: CA2Fina
 * Author: M.Strelec
 * Date: 3/2024
 * Purpose: CA2
 */

using System.ComponentModel;
using System.Threading.Tasks.Sources;

namespace CA2Final
{
    internal class Program
    {

        static List<string> idNumber = new List<string>();
        static List<double> scores = new List<double>();
        static int[] scoreValueCount = new int[5];
        static int totalReviews;
        static double[] scoreValueSum = new double[5];
        static double highestRating = 0, sum;
        static string highestID = "0";
        static bool exit = false;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //Console formatting command

            //Declaration
            int count = 0; //For counting number of inputs

            //Input
            Console.WriteLine(/*Name of the project or its purpose*/);
            Console.WriteLine("\n******Start of program******\n");
            while (count < 10 && exit == false) //Loop will end when user will exceed entering more than ten books and also when he enters the code -999
            {
                BookID();            
                if (exit == false)
                {
                    BookScore();
                    Console.WriteLine($"\nBook with ID {idNumber[count]} is rated: {RatingMessage(scores[count])}\n");
                    count++;
                    totalReviews++;
                }
            }
            //Processing & output
            BookReport(idNumber, scores);
            RatingReport();
            Console.WriteLine("\n******End of program******\n");
        }

        static string BookID()
        {
            string bookID;
            bool exitLocal = false;

            try //Format exception handeling for Arithmetic and Format exceptions 
            {
                while (exitLocal == false)
                {
                    Console.Write("Enter the book ID: ");
                    bookID = Console.ReadLine();
                    if (bookID[0] == 'B' && bookID.Length == 8)
                    {
                        idNumber.Add(bookID);
                        return bookID;
                    }
                    else if (bookID == "-999")
                    {
                        exit = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input!");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Format!");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Math Error!");
            }

            return "0";

        }//Method for entering valid Book ID
        static double BookScore()
        {
            double rating = -1;

            try //Format exception handeling for Arithmetic and Format exceptions 
            {
                Console.Write("Enter rating: ");
                while (!double.TryParse(Console.ReadLine(), out rating) || !(rating >= 0 && rating <= 5))
                {
                    Console.WriteLine("Wrong Input!");
                    Console.Write("> ");
                }                
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong Format!");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Math Error!");
            }

            sum += rating;
            scores.Add(rating);
            if (rating > highestRating)
            {
                highestRating = rating;
                highestID = idNumber.Last();
            }
            return rating;
        }//Method for entering valid rating
        static string RatingMessage(double score)
        {
            if (score >= 0 && score < 1)
            {
                scoreValueSum[0] += score;
                scoreValueCount[0]++;
                return "Poor";
            }
            else if (score > 1 && score <= 2)
            {
                scoreValueSum[1] += score; //Adds score to the global array with scores for each rating range
                scoreValueCount[1]++; //Adds number of reviews in that rating range
                return "Fair"; //Return text for corresponding score 
            }
            else if (score > 2 && score <= 3)
            {
                scoreValueSum[2] += score;
                scoreValueCount[2]++;
                return "Good";
            }
            else if (score > 3 && score <= 4)
            {
                scoreValueSum[3] += score;
                scoreValueCount[3]++;
                return "Very Good";
            }
            else if (score > 4 && score <= 5)
            {
                scoreValueSum[4] += score;
                scoreValueCount[4]++;
                return "Excellent";
            }
            return "0";
        }//Method for displaying corresponding rating message
        static void BookReport(List<string> BookID, List<double> BookScore)
        {
            const string DISPLAY_TAB = "{0,-12}{1,12}";

            Console.WriteLine("\nBook Report");
            Console.WriteLine(DISPLAY_TAB, "Book ID", "Rating");
            for (int i = 0; i < BookID.Count; i++)
            {
                Console.WriteLine(DISPLAY_TAB, $"{BookID[i]}", $"{BookScore[i]}");
            }
            Console.WriteLine();
        }//Brief report of all of the entered books and their score
        static void RatingReport()
        {
            const string DISPLAY_TAB = "{0,-12}{1,-25}{2,-12}";
            string[] rates = { "0-1", "1+ - 2", "2+ - 3", "3+ - 4", "4+ - 5" };

            try
            {
                double totalAverage = sum / totalReviews;

                Console.WriteLine("");
                Console.WriteLine(DISPLAY_TAB, "Rating", "Books in this rating", "Average Rating");

                for (int i = 0; i < rates.Length; i++)
                {
                    Console.WriteLine(DISPLAY_TAB, $"{rates[i]}", $"{scoreValueCount[i]}", $"{scoreValueSum[i] / scoreValueCount[i]:N2}");
                }

                Console.WriteLine($"Total reviews: {totalReviews}");
                Console.WriteLine($"Overall average: {totalAverage}");
                Console.WriteLine($"Book with ID {highestID} has the highest score: {highestRating}");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Math Error!");
            }
            

            

        }//Complete summarization of entered values 
    }


}
