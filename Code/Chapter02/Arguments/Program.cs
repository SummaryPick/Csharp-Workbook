using System;
using static System.Console;

namespace arguments
{
    class Program
    {
        //Wont actually change the cursor size on windows.
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                WriteLine("You must specify 3 arguments: [Background color:string] [Foreground color:string] [cursor size:int]");
                WriteLine("Example: dotnet run red blue 50");
                return; //stop running    
            }

            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true
            );

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true
            );

            CursorSize = int.Parse(args[2]);
            
        }
    }
}
