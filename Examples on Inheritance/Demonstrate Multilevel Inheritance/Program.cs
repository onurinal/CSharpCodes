/*
 * C# Program to Demonstrate Multilevel Inheritance
 */
using System;

namespace Demonstrate_Multilevel_Inheritance
{
    class Program : Student
    {
        public void School()
        {
            Console.WriteLine("Discipline");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.School();
            program.Teach();
            program.Learn();
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
