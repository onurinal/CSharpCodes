/*
 *  C# Program to Convert Digits to Words
 */
using System;

namespace Convert_Digit_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, count = 0, temp;
            string[] digits =  { "zero", "one", "two", "three",
                                 "four", "five", "six", "seven",
                                 "eight", "nine"};
            Console.Write("Enter the number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + number);
            temp = number;
            while (temp > 0)
            {
                temp = temp / 10;
                count++;
            }
            string[] nextDigit = new string[count];
            count = 0;
            while (number > 0)
            {
                temp = number % 10;
                nextDigit[count] = digits[temp];
                number /= 10;
                count++;
            }
            Console.Write("Number in words: ");
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(nextDigit[i] + " ");
            }

        }
    }
}
