using System;
using static UserInputFunctions.UserInputFunctions;

namespace bowling
{
    internal class Bowling
    {
        static void Main(string[] args)
        {
            int outs;
            ReadInt("Gimme int: ", out outs);
            Console.WriteLine($"You wrote {outs}");
        }
    }
}

