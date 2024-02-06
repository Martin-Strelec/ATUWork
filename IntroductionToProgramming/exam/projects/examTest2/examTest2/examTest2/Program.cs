/*
 * Project examTest2 
 * Name: M. Strelec
 * Date 1/2024
 * Purpose: Preparation for exam
*/

using System.Data.Common;

namespace examTest2
{
    internal class Program
    {
        static string[] names = new string[4];
        static int[] grades = new int[4];
        static double averageGrade, highestGrade, qualifyingGrade;

        static void Main(string[] args)
        {
            //Declaration
            //Input
            //Processing
            //Output
            ParticipantsInput();
            MinimumGrade();
            HighestGrade();
            AverageGrade();    
            ClosestToAverage();
            ParticipantsList();
            CertificateHolders();

        }

        static void ParticipantsInput()
        {

            Console.Write("Please enter qualifying grade for certification: ");
            qualifyingGrade = int.Parse(Console.ReadLine());
       
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the participants {i+1} name: ");
                names[i] = Console.ReadLine();
                Console.Write("Enter their grades: ");
                grades[i] = int.Parse(Console.ReadLine());
            }        

        }
        static void AverageGrade()
        {
            double totalGrade = 0;
            int amountOfPeople = names.Length;

            for (int i = 0; i < names.Length; i++)
            {
                if (grades[i] == 0)
                {
                    amountOfPeople -= 1;
                }
                totalGrade += grades[i];
            }

            averageGrade = totalGrade / amountOfPeople;

            Console.WriteLine($"\nThe average grade is: {averageGrade}");
        }
        static void MinimumGrade()
        {
            int minimumGrade = grades[0], id = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] <= minimumGrade)
                {
                    minimumGrade = grades[i];
                    id = i;
                }
            }
            Console.WriteLine($"\nThe minimum grade for {names[id]} with {grades[id]}");
        }
        static void ClosestToAverage()
        {
            int closest = 0;
            double placeholder, closestValue = 20;
            
            for (int i = 0; i < grades.Length; i++)
            {
                placeholder = 0;

                placeholder = averageGrade - grades[i];

                if (placeholder < 0)
                {
                    placeholder = -placeholder;
                }

                if (placeholder < closestValue)
                {
                    closest = grades[i];
                    closestValue = placeholder;
                }
            }

            Console.WriteLine($"The closest grade to average is {closest}.");
        }  
        static void ParticipantsList()
        {
            Console.WriteLine("\nGrades of the participants: ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"{names[i]} has a grade of: {grades[i]}");
                if (grades[i] == highestGrade)
                {
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
        }
        static void HighestGrade()
        {
            int highestID = 0, highestGradePlace = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > highestGradePlace)
                {
                    highestID = i;
                    highestGrade = grades[i];
                }
            }

            highestGrade = grades[highestID];

            Console.WriteLine($"\nMax grade for {names[highestID]} with: {grades[highestID]}");
        }
        static void CertificateHolders()
        {
            int absolvents = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] >= qualifyingGrade) 
                {
                    absolvents += 1;
                }
            }

            Console.WriteLine($"\nTotal students to gain certificate is: {absolvents}.\n");
        }
    }

    
}