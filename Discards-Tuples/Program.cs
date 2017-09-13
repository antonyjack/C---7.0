﻿using System;

namespace Discards_Tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Retrive only required information skip other information usind discards
            (string First, string Last, _, _) = MultipleReturns();
            Console.WriteLine($"First name : {First}, Last name : {Last}");

            if(int.TryParse("test",out int _))
            {
                Console.WriteLine("Valid number");
            }
        }

        private static (string, string, int, string) MultipleReturns()
        {
            return ("James", "Raj", 30, "Male");
        }
    }
}
