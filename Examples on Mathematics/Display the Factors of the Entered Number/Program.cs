/*
 * C# Program to Display the Factors of the Entered Number
 */
using System;

namespace Display_the_Factors_of_the_Entered_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            Console.Write("The factors are: ");
            for(int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.Write(number);
        }
    }
}
