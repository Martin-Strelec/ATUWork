/* Program name: fruit.cs
   Author: M. Strelec
   Date Created: Sept 2023
   Purpose: Displays number of each fruit and then sums everything
*/
using System;
class fruit 
{
	static void Main()
	{
		//Declaration
		int apples = 6;
		int oranges = 8;
		int sum;
		//Input
		//Processing
		sum = apples + oranges;
		//Output
		Console.WriteLine("You have " + apples + " apples");
		Console.WriteLine("You have " + oranges + " oranges");
		Console.WriteLine("In total you have " + sum + " pieces of fruit");
		Console.WriteLine("******End of program******");	
	}
}