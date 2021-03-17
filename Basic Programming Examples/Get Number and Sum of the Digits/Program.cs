/*
 * C# Program to Get a Number and Display the Sum of the Digits 
 */
using System;

namespace Get_Number_and_Sum_of_the_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp, sum = 0;
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                temp = number % 10;
                sum = sum + temp;
                number = number / 10;
            }
            Console.Write("Sum of Digits of the Number: " + sum);

        }
    }
}
