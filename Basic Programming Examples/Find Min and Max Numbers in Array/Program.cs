/*
 * C# Program to Find Minimum and Maximum of Numbers
 */
using System;

namespace Find_Min_and_Max_Numbers_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 9,100,-35,652,0,10,-100 };
            int max = list[0];
            int min = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] > max)
                {
                    max = list[i];
                }
                if (min > list[i])
                {
                    min = list[i];
                }
            }
            Console.WriteLine("Maximum number in list: " + max );
            Console.WriteLine("Minimum number in list: " + min);
        }
    }
}
