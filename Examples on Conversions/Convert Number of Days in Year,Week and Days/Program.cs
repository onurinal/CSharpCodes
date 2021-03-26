/*
 * C# Program to Convert a Given Number of Days in terms of 
 * Years, Weeks & Days
 */
using System;

namespace Convert_Number_of_Days_in_Year_Week_and_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,year,week,day;
            Console.Write("Enter the number of days: ");
            number = int.Parse(Console.ReadLine());
            year = number / 365;
            week = (number % 365) / 7;
            day = (number % 365) % 7;
            Console.Write(number + " is equivalent to " + year + " year" +
                                 ", " + week + " week and " + day + " day"   );
        }
    }
}
