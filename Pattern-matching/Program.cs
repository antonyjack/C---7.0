using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Pattern_matching
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Pattern matching :");
            //const value matching pattern
            //else if statement pattern matching
            object a = 10;            
            if(a is string val)
                WriteLine($"string : {val}");
            else if(a is decimal val1)
                WriteLine($"decimal : {val1}");
            else if(a is int val2)
                WriteLine($"integer : {val2}");
            else
                WriteLine("Invalid datatype");  
            
            //Switch case pattern matching
            object b = "James";
            switch (b)
            {
                case int i:
                    WriteLine($"integer : {i}");
                    break;
                case string j:
                    WriteLine($"string : {j}");
                    break;
                case float k:
                    WriteLine($"float : {k}");
                    break;                
                default:
                    WriteLine("Invalid datatype");
                    break;
            }

            Matching(new Student()
            {
                FirstName = "Antony",
                LastName = "Samy"
            });

            Matching(new Person(){
                FirstName = "James",
                LastName = "Raj"
            });

            Matching(null);

            Matching(new List<int>());

            Matching(new List<int>(){10,20});
        }

        static void Matching(object e)
        {
            switch (e)
            {
                case Student s:
                    WriteLine($"Name of the student is :{s.LastName}, {s.FirstName}");
                    break;
                case Person p:
                    WriteLine($"Name of the person is : {p.LastName}, {p.FirstName}");
                    break;                
                case null:
                    WriteLine("Null object");
                    break; 
                case List<int> m when m.Any():
                    WriteLine($"Length of the List object is : {m.Count}");
                    break;
                default:
                    WriteLine("Invalid object");
                    break;
            }
        }
    }
}
