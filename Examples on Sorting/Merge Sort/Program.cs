/*
 *  C# Program to Perform Merge Sort
 */
using System;

namespace Merge_Sort
{
    class MergeSort
    {
        // Merges two subarrays of []array.
        // First subarray is array[left..middle]
        // Second subarray is array[middle+1..right]
        public void Merge(int[] array, int left, int middle, int right) {

            // Find sizes of two
            // subarrays to be merged
            int size1 = middle - left + 1;
            int size2 = right - middle;

            //Create temp arrays
            int[] L = new int[size1];
            int[] R = new int[size2];
            int i, j;
            //Copy data to temp arrays
            for(i = 0; i < size1; i++)
            {
                L[i] = array[left + i];
            }
            for(j = 0; j < size2; j++)
            {
                R[j] = array[middle + 1 + j];
            }
            //Initial indexes of first
            //and second subarray
            i = 0;
            j = 0;
            int k = left;

            while (i < size1 && j < size2)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }
            // Copy remaining elements
            // of L[] if any
            while (i < size1)
            {
                array[k] = L[i];
                i++;
                k++;
            }
            // Copy remaining elements
            // of R[] if any
            while (j < size2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
        public void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;  // Find the middle point

                //Sort first and second subarrays
                Sort(array, left, middle);
                Sort(array, middle + 1, right);

                //Merge the sorted subarrays
                Merge(array, left, middle, right);
            }
        }
        //Print the array
        public static void PrintArray(int[] array)
        {
            Console.Write("Array: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Enter the size of array: ");
            size = int.Parse(Console.ReadLine());
            int[] list = new int[size];
            for(int i = 0; i < size; i++)
            {
                Console.Write("Enter " + (i + 1) + ". number in array: ");
                list[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Before sorting\n");
            MergeSort.PrintArray(list);
            MergeSort mergeSort = new MergeSort();
            mergeSort.Sort(list, 0, size - 1);
            Console.WriteLine();
            Console.Write("After sorting\n");
            MergeSort.PrintArray(list);
        }
    }
}
