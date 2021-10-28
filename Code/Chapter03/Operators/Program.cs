using System;
using static System.Console;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = a++;
            WriteLine($"a is {a} and b is {b}");

            int c = 3;
            int d = ++c;
            WriteLine($"c is {c} and d is {d}");
            WriteLine();

            int e = 11;
            int f = 3;
            WriteLine($"e is {e} and f is {f}");
            WriteLine($"e + f is {e + f}");
            WriteLine($"e - f is {e - f}");
            WriteLine($"e * f is {e * f}");
            WriteLine($"e / f is {e / f}");
            WriteLine($"e % f is {e % f}");
            WriteLine();

            double g = 11.0;
            WriteLine($"g is {g:N1} and f is {f}");
            WriteLine($"g / f is {g / f}");
            WriteLine();

            //The assignment operator = can be combined with other operators such as:
            int p = 3;
            p += 3; //p = p + 3
            p -= 3; //p = p - 3
            p *= 3; //p = p * 3
            p /= 3; //p = p / 3
            WriteLine($"p is {p}");
        }
    }
}
