using System;

namespace After_Properties
{
    class Student
    {
        private int _id;
        private string _name;
        private int _passmark = 40;
        public int PassMark
        {
            get
            {
                return _passmark;
            }
        }
        public int ID
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Student ID can not be negative.");
                }
                _id = value;
            }
            get
            {
                return _id;
            }
            
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name can not be null or empty.");
                }
                _name = value;
            }
            get
            {
                return _name;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ID = 1789;
            student.Name = "Onur";
            Console.WriteLine("Student id: " + student.ID);
            Console.WriteLine("Student name: " + student.Name);
            Console.WriteLine("PassMark is " + student.PassMark);
        }
    }
}
