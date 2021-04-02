/*
 * C#  Program to Generate Fibonacci Series
 */
using System;

namespace Generate_Fibonacci_Series
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            int number1 = 0, number2 = 1, number3;
            Console.Write("Enter the limit: ");
            limit = int.Parse(Console.ReadLine());
            Console.Write(number1 + " ");
            Console.Write(number2 + " ");
            while (limit > 0)
            {
                number3 = number1 + number2;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;
                limit--;
            }
        }
    }
}
