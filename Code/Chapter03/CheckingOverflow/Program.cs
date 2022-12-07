using System;
using static System.Console;

namespace CheckingOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked 
                {
                    int x = int.MaxValue - 1;
                    WriteLine($"The value of x is {x}");
                    x++;
                    WriteLine($"The value of x is {x}");
                    x++;
                    WriteLine($"The value of x is {x}");
                    x++;
                    WriteLine($"The value of x is {x}");
                }
            }
            catch (OverflowException)
            {
                WriteLine("The program overflowed but I caught it!");
            }

            unchecked
            {
                int y = int.MaxValue + 1;
                WriteLine($"The value of y is {y}");
                y--;
                WriteLine($"The value of y is {y}");
                y--;
                WriteLine($"The value of y is {y}");
            }
            
        }
    }
}
