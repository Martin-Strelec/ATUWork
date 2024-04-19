/*
*	Name: Fleet Report
*	Author: Martin Strelec
*	Date: 19/Apr/2024
*	Purpose: Generates fleet report based on a reading from a file
*/


using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Runtime.CompilerServices;
using QMenu;
using QShip;
using QSimpleDatabase;
using QValidation;

namespace ConsoleApp
{
    public class Program
    {

        
        static string[] options = { "Vessel Report", "Location Analysis Report", "Seach for a Vessel" }; //Creates descriptions for menu
        static List<Ship> fleet = new List<Ship>(); //Creates list of objects based on data from database
        static SimpleDatabase d = new SimpleDatabase("./FrenchMF.TXT", 5); //Creates database object

        public static void Main(string[] args)
        {
            bool exit = false;

            //Creating menu object
            Menu n = new Menu(options, "French fleet");

            //Menu loop
            while (exit == false)
            {
                //Initializes objects based on data from the database
                CreateFleet();
                //Prints out the menu
                n.MenuPrint();

                switch (n.GetMenuOption())
                {
                    case 1:
                        FleetReport();
                        break;
                    case 2:
                        LocationAnalysis();
                        break;
                    case 3:
                        Console.WriteLine(SearchFor());
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }
        }

        //Prints out every vessel. Further specififcation can be found in Ship class
        static void FleetReport()
        {
            Console.WriteLine("");
            for (int i = 0; i < fleet[0].Locations.Length; i++)
            {
                Console.WriteLine($"Location: {fleet[0].Locations[i]}");
                for (int j = 0; j < d.LineCount; j++)
                {
                    fleet[j].VesselReport(i + 1);
                }
            }
        }

        //Prints out number of ships in each reagion
        static void LocationAnalysis()
        {
            //Declaration
            const string TAB = "{0,-15}{1,15}"; //Output Tab
            int[] locationsCount = new int[fleet[0].Locations.Length]; //Number of locations specified in Ship class
            int total = 0; 

            //Counts the fleet
            for (int i = 0; i < d.LineCount; i++)
            {
                locationsCount[fleet[i].LocationCode - 1]++;
            }

            //Displays the number of vessels in each reagion and then does a total sum of those vessels
            Console.WriteLine("");
            Console.WriteLine(TAB, "Location", "Count");
            for (int i = 0; i < fleet[0].Locations.Length; i++)
            {
                Console.WriteLine(TAB, $"{fleet[0].Locations[i]}: ", $"{locationsCount[i]}");
                total += locationsCount[i];
            }
            Console.WriteLine(TAB, "\nTotal: ", $"{total}");
            Console.WriteLine("");
        }

        //Searches for vessels via user prompt
        static string SearchFor()
        {
            Console.Write("Enter the ship's name: ");
            string input = (Console.ReadLine()).ToLower();
            for (int i = 0; i < d.LineCount; i++)
            {
                if ((fleet[i].Name).ToLower() == input)
                {
                    return ($"Location: {fleet[i].Location}\n");
                }
            }

            return "Ship not found!\n";
        }

        // Function for initializing objects that rely on data from the database
        static void CreateFleet()
        {
            for (int i = 0; i < d.LineCount; i++)
            {
                fleet.Add(new Ship(d.Table[i][0], int.Parse(d.Table[i][1]), int.Parse(d.Table[i][2]), int.Parse(d.Table[i][3]), int.Parse(d.Table[i][4])));
            }
        }
    }
}