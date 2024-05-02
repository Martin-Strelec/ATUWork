/*
*	Name: CAMock3
*	Author: Martin Strelec
*	Date: 21/Apr/2024
*	Purpose: Getting ready for the CA3Mock
*/

using System;
using QSimpleDatabase;
using QMenu;
using QTeam;

namespace Q1
{
    internal class Program
    {
        static SimpleDatabase d = new SimpleDatabase("./results.csv", 4);
        static string[] teamNames = { "sligo", "mayo", "donegal", "leitrim", "roscommon", "longford" };
        static List<Team> t = new List<Team>();


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console formatting command

            // Declaration
            // Input
            Console.WriteLine("CAMock3");
            Console.WriteLine("******Start of program******");
            // Processing

            //Creation of teams
            for (int i = 0; i < teamNames.Length; i++)
            {
                t.Add(new Team(teamNames[i], i));
            }
            // Output
            Console.WriteLine("******End of program******");
        }
    }
}