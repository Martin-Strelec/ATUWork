/* Program name: sterlingConverter.cs
   Author: M. Strelec
   Date Created: Sept 2023
   Purpose: Converts inputted amount from Euros to Sterling currency
*/
using System;
class sterlingConverter 
{
	static void Main()
	{
		//Declaration
		float amountOfEuros;
		float sterlingRate = 0.92f;
		float result;
		//Input
		Console.WriteLine("SterlingConverter program");
		Console.Write("Enter the amount of Euros you want to convert: ");
		amountOfEuros = float.Parse(Console.ReadLine());	
		//Processing
		result = amountOfEuros*sterlingRate;
		//Output
		Console.WriteLine("You've exchanged " + amountOfEuros + " Euros for " + result +" sterlings");
		Console.WriteLine("******End of program******");	
	}
}