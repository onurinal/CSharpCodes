/*
 * C# Program to Sort a List of Names in Alphabetical Order
 */
using System;

namespace Sort_a_List_of_Names_in_Alphabetical_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            string temp;
            Console.Write("Enter the size of array: ");
            size = int.Parse(Console.ReadLine());
            string[] list = new string[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i + 1) + ". element in array: ");
                list[i] = (Console.ReadLine());
            }
            for (int k = 0; k < size - 1; k++)
            {
                // size - k - 1 is for comparisons of elements which have aldready been compared in earlier
                for (int i = 0; i < size - k - 1; i++)
                {
                    if (list[i][0] > list[i + 1][0])
                    {
                        temp = list[i];
                        list[i] = list[i + 1];              // using bubble sort algorithm..
                        list[i + 1] = temp;
                    }
                }
            }
            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
