#nullable enable
using System;

namespace nullhandling
{

    class Address
    {
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }
    class Program
    {
        static void Main(string[] args)
        {
        /*  Causes a compile error because int cannot be null unless suffixed by a ?:
            int cantBeNull = 4;
            cantBeNull = null; 
        */

            int? couldBeNull = null;
            Console.WriteLine(couldBeNull);
            Console.WriteLine(couldBeNull.GetValueOrDefault());

            couldBeNull = 7;
            Console.WriteLine(couldBeNull);
            Console.WriteLine(couldBeNull.GetValueOrDefault()); 
            Console.WriteLine();
            //Note: When running this the console puts out a blank line first, that line being the null value.

            if(couldBeNull != null)
            {
                //if it's not null then do XYZ.
                Console.WriteLine($"couldBeNull is not null, it's value is {couldBeNull}");
                Console.WriteLine();
            } 
            else
            {
                Console.WriteLine("couldBeNull is Null");
                Console.WriteLine();
            }

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "NRH";
            address.Region = null; 

            //Note: int x = authorName.Length would throw a NullReferenceException.
            //?? is used to set a default value to a variable if that variable happens to be null.
            string authorName = null;
            int? y = authorName?.Length;  
            var result = authorName?.Length ?? 3;
            Console.WriteLine($"author name length: {result}");    
        }
    }
}
