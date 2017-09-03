using System;

namespace Throws_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            try
            {                
                student.Name = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Student student1 = student.CreateObject();
            student1.Name = "James";

            Console.WriteLine($"Welcome {student1.Name}");

            try
            {
                student1.CheckValues();
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }
    }

    class Student
    {
        private string _Name;
        public string Name
        {
            get => _Name;
            set => _Name = value ?? throw new ArgumentNullException(paramName : nameof(Name), message: $"{nameof(Name)} can not be null.");
        }

        public Student CreateObject() => new Student() ?? throw new Exception("Invalid operation");
        public int[] CheckValues() => GetValues() ?? throw new Exception("Something went wrong");
        public int[] GetValues()
        {
            return null;
        }
    }
}
