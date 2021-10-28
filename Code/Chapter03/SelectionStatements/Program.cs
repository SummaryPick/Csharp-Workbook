using System;
using static System.Console;
using System.IO;

namespace selectionstatements
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0)
            {
                WriteLine("There are no arguments.");
            } 
            else
            {
                WriteLine("There is at least 1 argument.");
            }

            /*
            This code could be written as:

            if (args.Length == 0)
                WriteLine("There are no arguments.");
            else
                WriteLine("There is at least 1 argument");

            This should be avoided those as it can cause serious bugs.
            */

            object o = 3;
            int j = 4;

            if (o is int i) //safer than using the 'object o' because here we KNOW that i is an int.
            {
                WriteLine($"{i} x {j} = {i * j}");
            }
            else
            {
                WriteLine("o is not an int so it can't multiply!");
            }
            WriteLine();

            A_label:
            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            } //End of switch statement
            WriteLine();

            string path = @"C:\Users\Zacha\Documents\Csharp-Workbook\Code\Chapter03\SelectionStatements";

            Write("Press R for readonly or W for write: ");
            ConsoleKeyInfo key = ReadKey();
            WriteLine();

            Stream s = null;

            if (key.Key == ConsoleKey.R)
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Read
                );
            }
            else
            {
                s = File.Open(
                    Path.Combine(path, "file.txt"),
                    FileMode.OpenOrCreate,
                    FileAccess.Write
                );                              
            }

            string message = string.Empty;

            switch(s)
            {
                case FileStream writeable when s.CanWrite:
                    message = "The stream is a file that I can write to.";
                    break;
                case FileStream readOnlyFile:
                    message = "The steam is a read-only file.";
                    break;
                case MemoryStream memoryStream:
                    message = "The stream is a memory address.";
                    break;
                default:
                    message = "The stream is some other type.";
                    break;
                case null:
                    message = "The stream is null.";
                    break;
            }
            WriteLine(message);
        }
    }
}
