/*
 * C# Program to Check Whether the Entered Number is a Perfect Number or Not
 */
using System;

namespace Perfect_Number_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            for(int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if(sum == number)
            {
                Console.WriteLine("Entered number is a perfect number.");
            }
            else
            {
                Console.Write("Entered number is not a perfect number.");
            }
        }
    }
}
