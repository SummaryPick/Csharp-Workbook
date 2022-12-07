using System;
<<<<<<< HEAD

namespace handlingexceptions
=======
using static System.Console;

namespace HandlingExceptions
>>>>>>> parent of 99c5390 (Revert "Chapter 4 and start of 5")
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Before parsing");
            Console.Write("What is your age?");
            string input = Console.ReadLine();
=======
            WriteLine("Before parsing");
            Write("What is your age?");
            string input = ReadLine();
>>>>>>> parent of 99c5390 (Revert "Chapter 4 and start of 5")

            try
            {
                int age = int.Parse(input);
<<<<<<< HEAD
                Console.WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                Console.WriteLine("The age you entered is not a valid number format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your age is a valid number but is either too big or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            Console.WriteLine("After Parsing.");
=======
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
>>>>>>> parent of 99c5390 (Revert "Chapter 4 and start of 5")
        }
    }
}
