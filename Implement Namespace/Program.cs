/*
 * C# Program to Implement Namespaces
 */
using System;

namespace BlockBreaker
{
    class Test
    {
        public  Test()
        {
            Console.WriteLine("Class to demonstrate namespace");
        }
    }
}

    class Program
    {
        static void Main(string[] args)
        {
            BlockBreaker.Test test = new BlockBreaker.Test();
        }
    }
