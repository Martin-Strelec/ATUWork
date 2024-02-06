/* Program name: Sum.cs
   Author: M. Strelec
   Date Created: Sept 2023
   Purpose: Program to input 2 numbers, add numbers and display result
*/
using System;
class Sum
{
	static void Main()
	{
		//Declaration
		int firstNumber, secondNumber, result;
		//Input;
		Console.WriteLine("Sum program");
		Console.Write("Enter first number: ");
		firstNumber = int.Parse(Console.ReadLine());
		Console.Write("Enter second number: ");
		secondNumber = int.Parse(Console.ReadLine());
		//Processing
		result = firstNumber + secondNumber;
		//Output
		Console.WriteLine("The sum of " + firstNumber + " and " + secondNumber + " is: " + result);
		Console.WriteLine("******End of program******");
	}
}