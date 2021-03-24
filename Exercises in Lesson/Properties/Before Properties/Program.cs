using System;

namespace Properties
{
    class Student
    {
        private int _id;
        private string _name;
        private int _passmark = 40;
        public int GetPassMark()
        {
            return _passmark;
        }
        public void SetId(int id)
        {
            if (id < 0) {
                throw new Exception("Student ID can not be negative.");
            }
            _id = id;
        }
        public int GetId()
        {
            return _id;
        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name can not be null or empty.");
            }
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SetId(1789);
            student.SetName("Onur");
            Console.WriteLine("Student id: " + student.GetId());
            Console.WriteLine("Student name: " + student.GetName());
            Console.WriteLine("PassMark is " + student.GetPassMark());
        }
    }
}
