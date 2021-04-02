/*
 * C# Program to Generate the Factorial of  Given Number 
 */
using System;

namespace Generate_the_Factorial_of_Given_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 1;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                sum = sum * number;
                number--;
            }
            Console.WriteLine("Factorial of given number is " + sum);
        }
    }
}
