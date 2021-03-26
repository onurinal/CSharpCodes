/*
 * C# Program to Demonstrate Pass by Reference Parameter 
 */
using System;

namespace Pass_by_Reference_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 4;
            Console.WriteLine("Value before: " + value);
            DontChangeValue(value);
            Console.WriteLine("Value before ref parameter: " + value);
            ChangeValue(ref value);
            Console.Write("Value after ref parameter: " + value);
        }

        static void ChangeValue(ref int value)
        {
            value *= 5;
        }

        static void DontChangeValue(int value)
        {
            value *= 5;
        }
    }
}
