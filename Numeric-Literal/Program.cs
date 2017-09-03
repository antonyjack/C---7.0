using System;

namespace Numeric_Literal
{
    class Program
    {
        static void Main(string[] args)
        {
            int One = 0b0001;
            int Two = 0b0010;
            int Four = 0b0100;
            int Eight = 0b1000;
            int Sixteen =   0b0001_0000;
            int ThirtyTwo = 0b0010_0000;
            int SixtyFour = 0b0100_0000;
            int OneHundredTwentyEight = 0b1000_0000;
            Console.WriteLine($"{Sixteen}");
        }
    }
}
