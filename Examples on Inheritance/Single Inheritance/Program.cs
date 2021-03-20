/*
 *  C# Program to Illustrate Single Inheritance
 */
using System;

namespace Single_Inheritance
{  
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.Teach();
            Student student = new Student();
            student.Teach(); // You can see, this student variable can access Teach() and Learn() function
            student.Learn(); // because of inheritance
        }
    }
    class Teacher
    {
        public void Teach()
        {
            Console.WriteLine("Teach");
        }
    }
    class Student : Teacher
    {
        public void Learn()
        {
            Console.WriteLine("Learn");
        }
    }
}
