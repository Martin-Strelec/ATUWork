namespace tableTest
{
    internal class Program
    {



        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            const string outputTab = "{0,-10:c}{1,-10:c}{2,-10:c}{3,-10:c}{4,-10:c}";

            Console.WriteLine($"{"Salary",15}: {45500:c}");
            Console.WriteLine($"{"Second Salary",15}: {50000:c}");

            Console.WriteLine(outputTab, "20", "20", "20", "20", "20");

            Console.WriteLine("{0,15:}", 1234);
        }
    }
}