/*
 * C# Program to Count the Number of 1's in the Entered Number
 */
using System;

namespace Count_the_Number_of_1_s
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, count = 0;
            Console.Write("Enter the limit: ");
            size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i + 1) + ". number:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            foreach(int k in numbers)
            {
                if (k == 1)
                {
                    count++;
                }
            }
            Console.WriteLine("The total number of 1's: " + count);
        }
    }
}
