using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");
            Write("What is your age?");
            string input = ReadLine();


            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old.");
            }
            catch(FormatException)
            {
                WriteLine("The age you entered is not a valid format.");
            }
            catch(OverflowException)
            {
                WriteLine("Although your input was a valid number. The number you entered was too large or too small for integer.");
            }
            catch(Exception e)
            {
                WriteLine($"{e.GetType()} says {e.Message}");
            }
            WriteLine("After parsing.");
        }
    }
}
