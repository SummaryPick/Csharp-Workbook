using System;
using static System.Console;
using static System.Convert;

namespace castingconverting
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            double b = a; //an int can be safely cast into a double
            WriteLine(b);

            double c = 9.8;
            int d = (int)c; //explicit cast
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            double g = 9.8;
            int h = ToInt32(g);
            WriteLine($"g is {g} and h is {h}");

            double[] doubles = new[]
            {
                9.49, 9.5, 9.51, 10.49, 10.5, 10.51
            };

            foreach (double n in doubles)
            {
                WriteLine($"ToInt({n}) is {ToInt32(n)}");
            }

            foreach (double n in doubles)
            {
                WriteLine(format:
                    "Math.Round({0}, 0, MidpointRounding.AwwayFromZero) is {1}",
                    arg0: n,
                    arg1: Math.Round(value: n, digits:0,
                        mode: MidpointRounding.AwayFromZero)
                );
            }

            int number = 12;
            WriteLine(number.ToString());

            bool boolean = true;
            WriteLine(boolean.ToString());

            DateTime now = DateTime.Now;
            WriteLine(now.ToString());

            object me = new Object();
            WriteLine(me.ToString());


            byte[] binaryObject = new byte[128];

            (new Random()).NextBytes(binaryObject);
            WriteLine("Binary Object as bytes.");

            for(int i = 0; i < binaryObject.Length; i++)
            {
                Write($"{binaryObject[i]:X} ");
            }
            WriteLine();

            string encoded = Convert.ToBase64String(binaryObject);
            WriteLine($"Binary Object as Base64: {encoded}");


            int age = int.Parse("27");
            DateTime birthday = DateTime.Parse("28 March 1997");

            WriteLine($"I was born {age} years ago.");
            WriteLine($"My birthday is {birthday}.");
            WriteLine($"My birthday is {birthday:D}.");

            //int count = int.Parse("abc"); Throws an expection because it's in the wrong format.

            Write("How many eggs do you have? ");
            int count;
            string input = ReadLine();

            if(int.TryParse(input, out count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }

        }
    }
}
