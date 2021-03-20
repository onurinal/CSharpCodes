/*
 *  C# Program to Illustrate Hierarchical Inheritance
 */
using System;

namespace Illustrate_Hierarchial_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            school.Discipline();
            Teacher teacher = new Teacher();
            teacher.Discipline();
            teacher.Teach();
            Student student = new Student();
            student.Discipline();
            student.Learn();
        }
    }
    class School
    {
        public void Discipline()
        {
            Console.WriteLine("Discipline");
        }
    }
    class Teacher : School
    {
        public void Teach()
        {
            Console.WriteLine("Teach");
        }
    }
    class Student : School
    {
        public void Learn()
        {
            Console.WriteLine("Learn");
        }
    }
}
