using System;
using static System.Console;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 25; i++)
            {
                WriteLine();
            }
            WriteLine(
                format:"{1}\n{0}\n{1}", 
                arg0: "                         Different Data Types                          ",
                arg1: "-----------------------------------------------------------------------");
            WriteLine($"sbyte has {sizeof(sbyte)} byte(s) in memory.  It's min is {sbyte.MinValue} and it's max is {sbyte.MaxValue}");
            WriteLine($"byte has {sizeof(byte)} byte(s) in memory.  It's min is {byte.MinValue} and it's max is {byte.MaxValue}");
            WriteLine($"short has {sizeof(short)} byte(s) in memory.  It's min is {short.MinValue} and it's max is {short.MaxValue}");
            WriteLine($"ushort has {sizeof(ushort)} byte(s) in memory.  It's min is {ushort.MinValue} and it's max is {ushort.MaxValue}");
            WriteLine($"int has {sizeof(int)} byte(s) in memory.  It's min is {int.MinValue} and it's max is {int.MaxValue}");
            WriteLine($"uint has {sizeof(uint)} byte(s) in memory.  It's min is {uint.MinValue} and it's max is {uint.MaxValue}");
            WriteLine($"long has {sizeof(long)} byte(s) in memory.  It's min is {long.MinValue} and it's max is {long.MaxValue}");
            WriteLine($"ulong has {sizeof(ulong)} byte(s) in memory.  It's min is {ulong.MinValue} and it's max is {ulong.MaxValue}");
            WriteLine($"float has {sizeof(float)} byte(s) in memory.  It's min is {float.MinValue} and it's max is {float.MaxValue}");
            WriteLine($"double has {sizeof(double)} byte(s) in memory.  It's min is {double.MinValue} and it's max is {double.MaxValue}");
            WriteLine($"decimal has {sizeof(decimal)} byte(s) in memory.  It's min is {decimal.MinValue} and it's max is {decimal.MaxValue}");
            WriteLine();
            WriteLine();
        }
    }
}
