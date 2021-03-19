/*
 * C# Program to Find Magnitude of Integer
 */
using System;

namespace Find_Magnitude_of_İnteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, magnitude = 0;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + number);
            while (number > 0)
            {
                magnitude++;
                number /= 10;
            }
            Console.Write("Magnitude: " + magnitude);
        }
    }
}
