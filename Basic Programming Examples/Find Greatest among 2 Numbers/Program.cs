/*
 * C# Program to Find Greatest among 2 numbers
 */
using System;

namespace Find_Greatest_among_2_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.Write("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());
            if(number1 > number2)
            {
                Console.WriteLine("{0} is the greatest number.", number1);
            }
            else if(number1 < number2)
            {
                Console.WriteLine("{0} is the greatest number.", number2);
            }
            else
            {
                Console.WriteLine("{0} and {0} are equal." , number1 , number2);
            }
        }
    }
   
}

