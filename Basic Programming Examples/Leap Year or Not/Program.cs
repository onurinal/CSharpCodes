/*
 * C# Program to Check Whether the Entered Year is a Leap Year or Not
 */
using System;

namespace Leap_Year_or_Not
{
    class LeapYear
    {
        public static bool CheckYear(int year)
        {
            return (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.Write("Enter a year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine(LeapYear.CheckYear(year) ? year + " is a leap year." : year + " is not a leap year.");
        }
    }
}
