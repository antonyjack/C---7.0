using System;
using static System.Console;

namespace ReturnRef
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Return of ref");
            string[] Names = {"james","raj","adrews","aravinda"};
            WriteLine($"{string.Join(",",Names)}");
            
            ref string Name = ref GetName(1, Names);
            WriteLine($"Reference fetched name : {Name}");
            Name = "Divya";
            WriteLine($"{string.Join(",",Names)}");

            string Name1 = GetName1(1, Names);
            WriteLine($"Fetched name : {Name1}");
            Name1 = "Arun";
            WriteLine($"Modified name : {Name1}");

            WriteLine($"{string.Join(",",Names)}");
        }

        static ref string GetName(int index, string[] names) 
        {
            return ref names[index];
        }

        static string GetName1(int index, string[] names) 
        {
            return names[index];
        } 
    }
}
