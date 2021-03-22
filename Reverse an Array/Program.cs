/*
 * C# Program to Reverse an Array
 */
using System;

namespace Reverse_an_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, count = 0;
            Console.Write("Enter size of the array: ");
            size = int.Parse(Console.ReadLine());
            int[] list = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i + 1) + ". element of array: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            int[] list2 = new int[size];
            for (int i = size - 1; i >= 0; i--)
            {
                list2[i] = list[count];
                count++;
            }
            Console.Write("Reversed array: ");
            foreach (int i in list2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
