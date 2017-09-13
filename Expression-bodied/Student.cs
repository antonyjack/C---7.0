using System;

namespace Expression_bodied
{
    public class Student
    {
        //Expression bodied constructor
        public Student() => Console.WriteLine("Expression bodied constructor working fine.");
        
        //Expression bodied distructor
        ~Student() => Console.WriteLine("Expression bodied distructor working fine.");

        //Expression bodied property
        private string _Name;
        public string Name
        {
            get => _Name;
            set => _Name = value ?? "Default";
        }

        public void Display() => Console.WriteLine($"Welcome {this.Name}");                
    }
}