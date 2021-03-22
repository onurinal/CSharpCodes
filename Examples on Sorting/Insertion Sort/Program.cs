/*
 * C# Program to Perform a Insertion Sort
 */
using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, key, j;
            Console.Write("Enter the size of array: ");
            size = int.Parse(Console.ReadLine());
            int[] list = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i + 1) + ". number of array: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("The array before insertion sort: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 1; i < size; i++)
            {
                key = list[i];
                j = i - 1;
                while(j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;
            }
            Console.Write("The array after insertion sort: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
