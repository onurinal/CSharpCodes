/*
 * C# Program to Copy a Section of One Array to Another
 */
using System;


namespace Copy_Section_of_One_Array_to_Another
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray, sizeOfTarget, section;
            Console.Write("Enter the size of array: ");
            sizeOfArray = int.Parse(Console.ReadLine());
            int[] list = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                Console.Write("Enter the " + (i + 1) + ". element in array: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter the size of the target array: ");
            sizeOfTarget = int.Parse(Console.ReadLine());
            int[] target = new int[sizeOfTarget];
            Console.Write("Enter the section of the first array that has to be copied: ");
            section = int.Parse(Console.ReadLine());
            for(int i = 0; i < section; i++)
            {
                target[i] = list[i];
            }
            Console.WriteLine("New array with the specified of the elements in the first array: ");
            foreach(int i in target)
            {
                    Console.Write(i + " ");
            }
        }
    }
}
