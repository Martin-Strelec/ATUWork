/*
 * Name: Cost of Tile calculator
 * Author: M.Strelec
 * Date: 10/2023
 * Purpose: Calculates cost to tile wall
 */

using System.Runtime.CompilerServices;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            const double ROOM_LENGTH = 5.1, ROOM_WIDTH = 3.9, DOOR_AREA = 2.5; //In m and m^2
            const int ROOM_HEIGHT = 3, TAB_INDENTATION = -35;
            int numberOfRooms;
            double costOfTile, wallArea, floorArea, totalArea, tileCostFloor, tileCostWalls, totalTileCost, vatCost, costPerRoom, totalCostAllRooms, vatPercentage;
            string voucher;

            //Input
            Console.WriteLine("Cost of Tile calculator");
            Console.WriteLine("\n******Start of program******\n");
            Console.Write($"{"Enter the number of rooms",TAB_INDENTATION}: ");
            numberOfRooms = int.Parse(Console.ReadLine());
            Console.Write($"{"Enter the cost of tile per m^2",TAB_INDENTATION}: ");
            costOfTile = double.Parse(Console.ReadLine());

            //Processing

            //Decides if tilling company is eligible for 100$ voucher based on parameters specified in condition
            if (numberOfRooms > 3 || costOfTile > 40)
            {
                voucher = ("100$");
            }
            else
            {
                voucher = ("NONE");
            }

            //Formulas for calculating all necessary values
            wallArea = ((2 * (ROOM_HEIGHT * ROOM_LENGTH)) + (2 * (ROOM_HEIGHT * ROOM_WIDTH)) - DOOR_AREA);

            floorArea = ROOM_LENGTH * ROOM_WIDTH;

            totalArea = wallArea + (2 * floorArea);

            tileCostWalls = wallArea * costOfTile;

            tileCostFloor = floorArea * costOfTile;

            totalTileCost = tileCostWalls + (2 * tileCostFloor);
      
            //Decides what VAT value to use when calculating final price based on a combined price of gross cost of all rooms
            if ((totalTileCost*numberOfRooms) < 500)
            {
                vatPercentage = 0.01;
            }
            else if ((totalTileCost * numberOfRooms) >= 500 && (totalTileCost * numberOfRooms) <= 900)
            {
                vatPercentage = 0.025;
            }
            else if ((totalTileCost * numberOfRooms) > 900 && (totalTileCost * numberOfRooms) <= 1100)
            {
                vatPercentage = 0.075;
            }
            else
            {
                vatPercentage = 0.085;
            }

            vatCost = totalTileCost * vatPercentage;

            costPerRoom = totalTileCost + vatCost;

            totalCostAllRooms = costPerRoom * numberOfRooms;
 
            //Output

            //Output table
            Console.WriteLine($"\nCalculation of Cost to tile {numberOfRooms} rooms costing {costOfTile:c}/m^2 per room");
            Console.WriteLine("=================================================================\n");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "Tile cost per m^2", "|", $"{costOfTile:c} $/m^2");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "The floor and Celling area is", "|", $"{totalArea} m^2");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "Wall area is", "|", $"{wallArea} m^2");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "","", "==========");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "Cost to tiles floor","|", $"{tileCostFloor:c}");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "Cost to tiles celling", "|", $"{tileCostFloor:c}");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "Cost to tiles wall", "|", $"{tileCostWalls:c}");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "", "", "==========");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "Total cost", "|", $"{totalTileCost:c}");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "VAT Percentage", "|", $"{vatPercentage:p}");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "VAT Cost", "|", $"{vatCost:c}");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "", "", "==========");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "Cost per one room", "|", $"{costPerRoom:c}");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "Voucher", "|", $"{voucher}");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", "", "", "==========");
            Console.WriteLine("{0,-30}{1,5}{2, 30}", $"Total cost for all {numberOfRooms} rooms", "|", $"{totalCostAllRooms:c}");
            Console.WriteLine("\n=================================================================");
            Console.WriteLine("\n******End of program******\n");
        }
    }
}