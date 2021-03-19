/*
 * C# Program to Compute Average for the Set of Values
 */
using System;

namespace Compute_Average_for_the_Set_of_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int size,total = 0;
            float average;
            Console.Write("Enter the number of size in the list: ");
            size = int.Parse(Console.ReadLine());
            int[] list = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter the " + (i + 1) + ". number: ");
                list[i] = int.Parse(Console.ReadLine());
                total = total + list[i];
            }
            average = total / (float)size;
            Console.Write("Average is " + average);
        }
    }
}
