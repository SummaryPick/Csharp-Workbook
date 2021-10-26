using System;

namespace numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint naturalNumber = 23; //uint = unsigned integer (positive integer including 0)
            int integerNumber = -23; //int = integer (positive or negative whole number)
            float realNumber = 2.3F; //float = single-precision floating point. The suffix F makes it a float literal
            double anotherRealNumber = 2.3; //double = double-precision floating point.

            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{binaryNotation == hexadecimalNotation}");

            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers from {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers from {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"int uses {sizeof(decimal)} bytes and can store numbers from {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");
            Console.WriteLine();

            Console.WriteLine("Using doubles:");
            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3)
            {
                Console.WriteLine($"{a} + {b} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{a} + {b} does NOT equals 0.3");
            }
            Console.WriteLine();

            Console.WriteLine("Using decimals:");
            decimal c = 0.1M;
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {
                Console.WriteLine($"{c} + {d} equals 0.3");
            }
            else
            {
                Console.WriteLine($"{c} + {d} does NOT equals 0.3");
            }
            Console.WriteLine();
            
        }
    }
}
