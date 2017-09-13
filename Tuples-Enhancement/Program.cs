using System;
using static System.Console;

namespace Tuples_Enhancement
{
    class Program
    {
        static void Main(string[] args)
        {
            //semantic named tuples
            (string Name, int Age) = ("James", 30);
            WriteLine($"Name is : {Name}");
            WriteLine($"Age is : {Age}");

            //Named tuples
            var NamesValues = (Name:"Andrews", Age:32);
            WriteLine($"Name is : {NamesValues.Name}");
            WriteLine($"Age is : {NamesValues.Age}");

            //Below line is wrong
            //(string Name, string Gender) = (First: "Aravinda", Second:"Male");
            
            var E = new Example(2,22);
            (int One, int Two, string Message) = E;
            WriteLine(Message);
            
            (int add, int mul) = E.GroupFunction();
            WriteLine($"Addition : {add}");
            WriteLine($"Multiplication : {mul}");
        }
    }    
}
