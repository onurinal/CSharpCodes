/*
 * C# Program to Demonstrate DivideByZero Exception
 */
using System;

namespace DivideByZero_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number = 6;
                int result = number / int.Parse("0");
            }
            catch (DivideByZeroException m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
