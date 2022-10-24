using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] names;
            names = new int[10];

            for(int i = 0; i < names.Length; i++){
                Console.WriteLine(names[i]);
            }
        }
    }
}
