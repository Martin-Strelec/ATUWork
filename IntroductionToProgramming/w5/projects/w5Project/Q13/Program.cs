/*
 * Name: League tables
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Writes down a table with football teams I guess
 */

namespace Q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const string OUTPUT_TAB = "{0,-10}{1,-5}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}{7,-10}";
            const int TAB_INDENTATION = -35;
            string[] teamNames; //array for the team names
            string[] questions = { "\nHow many times they've won: ", "\nHow many times they've lost: ", "\nHow many times they've had a draw: " }; //array for questions 
            double[] percentage; //array for percentage score for each team
            int[,] teamStatistics; //array for statistics of each team
            int teamsCount, index = 0;

            //Input
            Console.WriteLine("League tables");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"How many teams you want to put in?",TAB_INDENTATION}: ");
            teamsCount = int.Parse(Console.ReadLine());

            teamStatistics = new int[teamsCount, 8];
            teamNames = new string[teamsCount];
            percentage = new double[teamsCount];

            //Processing & Output

            for (int i = 0; i < teamsCount; i++)
            {
                Console.Write($"{$"Name of the team {i + 1}",TAB_INDENTATION}: ");
                teamNames[i] = Console.ReadLine();
            }

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"{$"{questions[i]}",TAB_INDENTATION}");
                for (int j = 0; j < teamsCount; j++)
                {
                    Console.Write($"{$"Team {teamNames[j]}",TAB_INDENTATION}: ");
                    teamStatistics[j, i] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < teamsCount; i++)
            {
                //formula for calculating the final score. 3 points for win, 1 for draw, 0 for loss
                teamStatistics[i, 4] = ((teamStatistics[i, 0]) * 3) + teamStatistics[i, 2];
                //formula for how many games each team played
                teamStatistics[i, 5] = teamStatistics[i, 0] + teamStatistics[i, 1] + teamStatistics[i, 2];
                //formula for calculating of how much point potential (in %) each team had
                double maxPoints = teamStatistics[i, 5];
                percentage[i] = (teamStatistics[i, 4] / ((maxPoints * 3) / 100));
            }

            //Output table
            Console.WriteLine("\n----------------------------------------------------------------------------");
            Console.WriteLine(OUTPUT_TAB, "Team", "|", "Played", "Wins", "Losses", "Draws", "Points", "Percenatge");
            Console.WriteLine("----------------------------------------------------------------------------");
            for (int i = 0; i < teamsCount; i++)
            {
                Console.WriteLine(OUTPUT_TAB, teamNames[i], "|", teamStatistics[i, 5], teamStatistics[i, 0], teamStatistics[i, 1], teamStatistics[i, 2], teamStatistics[i, 4], $"{(percentage[i]/100):p}");
            }
            Console.WriteLine("----------------------------------------------------------------------------\n");

            Console.WriteLine("\n******End of program******\n");
        }
    }
}