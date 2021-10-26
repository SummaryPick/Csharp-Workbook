using System;
using System.IO;
using System.Xml;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;
            object name = "Zach";
            Console.WriteLine($"{name} is {height} meters tall.");

            //int length1 = name.Length; (Cannot compile because the data type name is unknown to the compiler)
            int length2 = ((string)name).Length;
            Console.WriteLine($"{name} has {length2} characters");
            Console.WriteLine();

            //storing a string in a dynamic type.
            dynamic anotherName = "Emily";
            /* This compiles but would throw an exception at runtime if you later store
            a data type that does not have a property named 'Length' */
            int length = anotherName.Length;

            /* Two ways of declaring variables. Using var inferes the type from what follows the equals sign.
            without using var:
                int population = 325_000_000; //US population
                double weight = 280.0; // pounds
                decimal price = 4.99M; // dollars
                string fruit = "Apple";
                char letter = 'Z';
                bool happy = true; 
            Some programmers choose to avoid using var to make code more readable as the type is explicitly states */

            var population = 325_000_000;
            var weight = 280.0; 
            var price = 4.99M; 
            var fruit = "Apple";
            var letter = 'Z';
            var happy = true;

            //Example of good use for var and it's non-var counterpart:
            // var xml1 = new XmlDocument();
            // XmlDocument xml2 = new XmlDocument();

            //Example of bad use for var and it's non-var counterpart:
            // var file1 = File.CreateText(@"C:\something.txt");
            // StreamWriter file2 = File.CreateText(@"C:\something.txt");

            //targeted type so that you no longer need to repeat the type:
            //XmlDocument xml3 = new();


            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}
