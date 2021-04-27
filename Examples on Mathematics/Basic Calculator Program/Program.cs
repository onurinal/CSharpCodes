/*
 * C# Program to Perform Basic Calculator Program
 */
using System;

namespace Basic_Calculator_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, result = 0;
            char option;
            Console.Write("Enter the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Main Menu");
            Console.WriteLine("1.\t Addition");
            Console.WriteLine("2.\t Subtraction");
            Console.WriteLine("3.\t Multiplication");
            Console.WriteLine("4.\t Division");
            Console.Write("Enter the operation you want to perform: ");
            option = char.Parse(Console.ReadLine());
            switch (option)
            {
                case '1': result = number1 + number2;
                    Console.WriteLine("The result of addition is " + result);
                    break;
                case '2':
                    result = number1 - number2;
                    Console.WriteLine("The result of subtraction is " + result);
                    break;
                case '3':
                    result = number1 * number2;
                    Console.WriteLine("The result of multiplication is " + result);
                    break;
                case '4':
                    result = number1 / number2;
                    Console.WriteLine("The result of division is " + result);
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
