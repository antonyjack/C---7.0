using System;

namespace LocalFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            void Internal() => 
                Console.WriteLine("Hello World!");
            Internal();
        }
    }
}
