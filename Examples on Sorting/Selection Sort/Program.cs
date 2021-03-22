/*
 * C# Program to Perform a Selection Sort
 */
using System;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, temp, min_key;
            Console.Write("Enter the size of array: ");
            size = int.Parse(Console.ReadLine());
            int[] list = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i + 1) + ". number of array: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("The array before selection sort: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < size - 1; i++)
            {
                min_key = i;
                for(int k = i + 1; k < size; k++)
                {
                    if(list[k] < list[min_key])
                    {
                        min_key = k;
                    }
                }
                temp = list[i];
                list[i] = list[min_key];
                list[min_key] = temp;
            }
            Console.Write("The array after selection sort: ");
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
