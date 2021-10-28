using System;
using static System.Console;

namespace bitwiseandshiftoperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; //0000 1010
            int b = 6; //0000 0110
            WriteLine($"a = {a}");
            WriteLine($"b = {b}");
            WriteLine($"a & b = {a & b}");
            WriteLine($"a | b = {a | b}");
            WriteLine($"a ^ b = {a ^ b}");
            WriteLine();

            WriteLine($"a << 3 = {a << 3}"); //Left-shift 3 bits 0101 0000
            WriteLine($"a * 8 = {a * 8}"); //Multiply by 8
            WriteLine($"b >> 1 = {b >> 1}"); //Right-shift 1 bit
            WriteLine();

            //Four operators here: =, ., (), []
            int age = 47;
            char firstDigit = age.ToString()[0];
        }
    }
}
