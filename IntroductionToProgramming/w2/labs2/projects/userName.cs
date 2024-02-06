/* Program name: userName.cs
   Author: M. Strelec
   Date Created: Sept 2023
   Purpose: Input and Output a name
*/
using System;
class userName 
{
	static void Main()
	{
		//Declaration
		string name;
		//Input;
		Console.WriteLine("userName program");
		Console.Write("Enter your name: ");
		name = Console.ReadLine();
		//Processing
		//Output
		Console.WriteLine("Your name is: " + name);
		Console.WriteLine("******End of program******");
	}
}