/* Program name: wageCalculator.cs
   Author: M. Strelec
   Date Created: Sept 2023
   Purpose: Counts wage based on fixed rates and number of hours worked
*/
using System;
class wageCalculator 
{
	static void Main()
	{
		//Declaration
		int baseHourlyRate = 25;
		int baseNumberOfHours = 40;
		float overtimeHourlyRate = 37.5f;
		int overtimeNumberOfHours = 10;
		int baseWage;
		float overtimeWage, sum;
		//Input
		//Processing
		baseWage = baseHourlyRate * baseNumberOfHours;
		overtimeWage = overtimeHourlyRate * overtimeNumberOfHours;
		sum = baseWage + overtimeWage;
		//Output
		Console.WriteLine("WageCalculator program");
		Console.WriteLine("Your base wage for this month is: " + baseWage + " euros");
		Console.WriteLine("Your overtime wage for this month is: " + overtimeWage +" euros");
		Console.WriteLine("In total you have " + sum +" euros");
		Console.WriteLine("******End of program******");	
	}
}