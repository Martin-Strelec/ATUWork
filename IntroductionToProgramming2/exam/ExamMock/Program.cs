/*
*	Name: Exam Mock
*	Author: Martin Strelec
*	Date: 13/May/2024
*	Purpose: Just to practice (Reading csv and creating classes/objects)
*/

namespace examMock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; // Console formatting command

            // Declaration
            Property property = new Property("D12345", 400, 4);
            Property property1 = new Property("D1234", 600, 6);
            CommercialProperty cProperty = new CommercialProperty("D22222", 300, 4, 'B');
            // Input
            Console.WriteLine("Exam Mock");
            Console.WriteLine("******Start of program******");
            // Processing
            // Output
            Console.WriteLine(property.ToString());
            Console.WriteLine(property1.ToString());
            Console.WriteLine(cProperty.ToString());

            Console.WriteLine("******End of program******");
        }
    }
}