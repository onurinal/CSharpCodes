/*
 * C# Program to Check Whether the Entered Number is an Armstrong Number or Not
 */
using System;

namespace Armstrong_Number_or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, temp;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            for(int i = number; i > 0; i = i / 10)
            {
                temp = i % 10;
                sum = sum + (temp * temp * temp);
            }
            if(number == sum)
            {
                Console.WriteLine(number + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(number + " is not an Armstrong number.");
            }
        }
    }
}
