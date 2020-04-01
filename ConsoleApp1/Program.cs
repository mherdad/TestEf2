using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
        }
    }
    class Program
    {
        public static IList<Student> Db=new List<Student>()
        {
            new Student(){Id = 1,Name = "ali"},
            new Student(){Id = 2,Name = "hassan"}
        };

        public static void RegisterStudent(Student student)
        {
            Db.Add(student);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World 2!");
        }
    }
}