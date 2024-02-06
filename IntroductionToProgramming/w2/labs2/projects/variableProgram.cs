/* Program name: variableProgram.cs
   Author: M. Strelec
   Date Created: Sept 2023
   Purpose: Program to store and display variables
*/
using System;
class variableProgram 
{
	static void Main()
	{
		//Declaration and Initialization of variables
		string text = "Martin";
		int age = 20;
		double lunchCost = 5.99D; 

		//Output
		Console.WriteLine("My name is: " + text);
		Console.WriteLine("My age is: " + age);
		Console.WriteLine("The cost of the lunch is: " + lunchCost);
		
	}
}