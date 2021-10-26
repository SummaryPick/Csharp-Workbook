using System;
using static System.Console;

namespace formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfApples = 73;
            decimal pricePerApple = 0.35M;

            WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );

            string formatted = string.Format(
                format: "{0} apples cost {1:C}",
                arg0: numberOfApples,
                arg1: pricePerApple * numberOfApples
            );
            //Here you could potentially you could then do something like creating a function WriteToFile that writes a string to a .txt file and call: 'WriteToFile(formatted);'

            WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");
            int dollars = 1_000_000_000;
            WriteLine($"Good thing I have {dollars:C}!");
            WriteLine();

            string applesText = "Apples";
            int applesCount = 73;

            string bananasText = "Bananas";
            int bananasCount = 6731;

            WriteLine(
                format: "{0,-8} {1,6}",
                arg0: "Name",
                arg1: "Count");

            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: applesText,
                arg1: applesCount);
           
            WriteLine(
                format: "{0,-8} {1,6:N0}",
                arg0: bananasText,
                arg1: bananasCount);
            WriteLine();

            WriteLine("What is your name?");
            string firstName = ReadLine();

            WriteLine($"Hi {firstName}! What is your age?");
            string age = ReadLine();

            WriteLine($"Well {firstName}, you look pretty damn good for {age}!");
            WriteLine();


            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();
            WriteLine($"Key:{key.Key}, Char:{key.KeyChar}, Modifiers:{key.Modifiers}");
        }
    }
}
