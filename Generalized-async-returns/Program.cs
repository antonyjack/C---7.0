using System;
using System.Collections;
using System.Collections.Generic;   
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Generalized_async_returns
{
    class Program
    {
        static void Main(string[] args)
        {
            string Names = "James, Raj, Hari, Antony, Arun, Andrews, Aravinda, Mani, Divya, Lavanya";
            Student student = new Student();
            foreach (var item in Names.Split(','))
            {
                student.AddStudent(item);                
            }
            Console.WriteLine($"Students count : {student.GetStudents().Count}");
        }
    }

    public class Student
    {
        List<string> Students = new List<string>();

        public ValueTask<bool> AddStudent(string name) => new ValueTask<bool>(Add(name));

        public async Task<bool> Add(string name)
        {            
            Students.Add(name);
            return true;
        }

        public List<string> GetStudents() => Students.Any() ? Students : new List<string>();
    }
}
