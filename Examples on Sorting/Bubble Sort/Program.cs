/*
 * C# Program to Perform Bubble Sort
 */
using System;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size,temp;
            Console.Write("Enter the size of array: ");
            size = int.Parse(Console.ReadLine());
            int[] list = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i + 1) + ". number of array: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("The array is: ");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for(int i = 0; i < size - 1; i++)
            {
                for(int k = 0; k < size - i - 1; k++)
                {
                   if(list[k] > list[k + 1])
                    {
                        temp = list[k];
                        list[k] = list[k + 1];
                        list[k + 1] = temp;
                    }
                }
            }
            Console.Write("The sorted array: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
