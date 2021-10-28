using System;
using static System.Console;

namespace iterationstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }
            WriteLine();

            string password = string.Empty;

            int attempts = 0;
            do
            {
                Write("Enter your Password: ");
                password = ReadLine();
                attempts++;
            }
            while (password != "Pa$$w0rd" & attempts < 10);

            if(password == "Pa$$w0rd")
            {
                WriteLine("Correct!");
            } 
            else if (attempts == 10)
            {
                WriteLine("You ran out of attempts!");
            }
            WriteLine();

            for(int i = 1; i <= 10; i++)
            {
                WriteLine(i);
            }
            WriteLine();

            string[] names = {"Zach", "Emily", "Isabelle"};

            foreach(string name in names)
            {
                WriteLine($"{name} has {name.Length} characters!");
            }
        }
    }
}
