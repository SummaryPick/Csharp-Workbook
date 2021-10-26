using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            names = new string[4];

            names[0] = "Zach";
            names[1] = "Emily";
            names[2] = "Isabelle";
            names[3] = "McArthur";

            for(int i = 0; i < names.Length; i++){
                Console.WriteLine(names[i]);
            }
        }
    }
}
