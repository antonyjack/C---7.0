using System;
using static System.Console;

namespace Out_Enhancement
{
    class Program
    {
        static void Main(string[] args)
        {
            string Number = ReadLine();
            
            int num;
            if(int.TryParse(Number, out num)) // Old way use out parameter, variable must be declare before use.
            {
                WriteLine("C# Old Version :" + num);
            }
            else
            {
                WriteLine("Invalid integer");
            }

            if(int.TryParse(Number, out int newNum)) //C# 7.0 we can declare variable inside parameter 
            {
                WriteLine("C# 7.0 out feature: " + newNum);
            }
            else
            {
                WriteLine("Invalid integer");
            }

            WriteLine(ConvertToInt(Number));

        }

        private static string ConvertToInt(string number)
        {
            if(int.TryParse(number,out int num))
                return "Valid integer";
            return "Invalid integer";
        }
    }    
}
