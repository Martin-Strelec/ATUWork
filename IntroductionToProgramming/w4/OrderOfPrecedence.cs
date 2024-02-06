using System;
using static System.Console;

namespace orderofPrecedence
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(2 + 3 * 5);
            WriteLine(9/4+10);
            WriteLine(10/3);
            WriteLine(21%10);
            WriteLine((5-1)*3);
            WriteLine(37/5);
            WriteLine(64%8);
            WriteLine(5+2*4-23*4);
            WriteLine(3*(2+5)/5);
            WriteLine(28%5-2);
            WriteLine(19/2/2);
            WriteLine(28/(2+4));

            WriteLine(5>4);

        }
    }
}
