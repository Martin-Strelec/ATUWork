/*
*	Name: 
*	Author: Martin Strelec
*	Date: 02/May/2024
*	Purpose: 
*/

namespace WS9Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console formatting command

            // Declaration
            CurrentAccount cAccount = new CurrentAccount(20);
            // Input
            Console.WriteLine("");
            Console.WriteLine("******Start of program******");
            // Processing
            Console.WriteLine(cAccount.Lodge(40));
            Console.WriteLine(cAccount.WhitdrawFunds(61));;
            // Output
            Console.WriteLine("******End of program******");
        }
    }
}