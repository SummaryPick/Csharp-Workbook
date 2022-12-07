using System;
using static System.Console;

namespace WritingFunctions
{
    class Program
    {
        //Time Tables Functions
        static void TimesTables(byte number)
        {
            WriteLine($"This is the {number} times table:");
            for (int i = 0; i <= 12; i++)
            {
                WriteLine($"{i} x {number} = {i * number}");
            }
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);

                if (isNumber)
                {
                    TimesTables(number);
                }
                else
                {
                    WriteLine("You did not enter a valid number.");
                }
            }
            while(isNumber);
        }

        //Sales Tax Calculator
        static decimal CalculateTax(decimal amt, string twoLetterCode)
        {
            decimal rate = 0.0M;

            switch (twoLetterCode)
            {
                case "CH":
                    rate = 0.08M;
                    break;
                case "DK":
                case "NO":
                    rate = 0.25M;
                    break;
                case "GB":
                case "FR":
                    rate = 0.2M;
                    break;
                case "HU":
                    rate = 0.27M;
                    break;
                case "OR":
                case "AK":
                case "MT":
                    rate = 0.0M;
                    break;
                case "ND":
                case "WI":
                case "ME":
                case "VA":
                    rate = 0.05M;
                    break;
                case "CA":
                    rate = 0.0825M;
                    break;
                default:
                    rate = 0.06M;
                    break;
            }

            return amt * rate;
        }

        static void RunCalculateTax()
        {
            Write("Enter an amount: ");
            string amountInText = ReadLine();

            Write("Enter a two-letter region code: ");
            string region = ReadLine();

            if (decimal.TryParse(amountInText, out decimal amount))
            {
                decimal taxToPay = CalculateTax(amount, region);
                WriteLine($"You must pay ${taxToPay} in sales tax.");
            } 
            else 
            {
                WriteLine("You did not enter a valid amount.");
            }
        }

        //Cardinal to Ordinal numbers
        /// <summary>
        /// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
        /// </summary>
        /// <param name="number">Number is a cardinal value e.g. 1, 2, 3 and so on.</param>
        /// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
        static string CardinalToOrdinal(int number)
        {
            switch (number)
            {
                case 11:
                case 12:
                case 13:
                    return $"{number}th";
                default:
                    int lastDigit = number % 10;

                    string suffix = lastDigit switch
                    {
                        1 => "st",
                        2 => "nd",
                        3 => "rd",
                        _ => "th"
                    };
                    return $"{number}{suffix}";
            }
        }

        static void RunCardinalNumber()
        {
            for (int number = 1; number <= 40; number++){
                WriteLine($"{CardinalToOrdinal(number)}");
            }
        }

        static int Factorial(int number)
        {
            if (number < 1)
            {
                return 1;
            }
            else if (number == 1)
            {
                return 1;
            } 
            else
            {
                checked
                {
                    return number * Factorial(number - 1);
                }
            }
        }

        static void RunFactorial()
        {
            for (int i = 0; i < 15; i++)
            {
                try
                {
                    WriteLine($"{i}! = {Factorial(i):N0}");
                }
                catch (OverflowException)
                {
                    WriteLine($"{i}! is too big for a 32-bit integer!");
                }
            }
        }

        /// <summary>
        /// Returns the integer for that term in the Fibonacci sequence.
        /// </summary>
        /// <param name="term">Is the term that should be written out.</param>
        /// <returns>Writes out the value for that term of the Fibonacci sequence.</returns>
        static int FibImperative(int term)
        {
            if (term == 1){
                return 0;
            }
            else if (term == 2)
            {
                return 1;
            }
            else 
            {
                return FibImperative(term - 1) + FibImperative(term - 2);
            }
        }

        static void RunFibImpaterative()
        {
            for (int i = 1; i <= 30; i++)
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: FibImperative(term: i));
            }
        }

        static int FibFunctional(int term) => 
        term switch 
        {
            1 => 0,
            2 => 1,
            _ => FibFunctional(term - 1) + FibFunctional(term - 2)
        };

        static void runFibFunctional()
        {
            for (int i = 1; i <= 30; i++)
            {
                WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
                arg0: CardinalToOrdinal(i),
                arg1: FibFunctional(term: i));
            }
        }
        static void Main(string[] args)
        {
            //RunTimesTable();
            //RunCalculateTax();
            //RunCardinalNumber();
            //RunFactorial();
            //RunFibImpaterative();
            //runFibFunctional();
        }
    }
}
