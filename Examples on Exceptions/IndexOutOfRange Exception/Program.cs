/*
 * C# Program to Demonstrate IndexOutOfRange Exception
 */
using System;

namespace IndexOutOfRange_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] list = { 5, 10, 15, 20, 25 };
            try
            {
                for(int i = 0; i <= list.Length; i++)
                {
                    sum = sum + list[i];
                }
                Console.WriteLine("Sum is " + sum);
            }
            catch(IndexOutOfRangeException m)
            {
                Console.WriteLine(m.Message);
            }
        }
    }
}
