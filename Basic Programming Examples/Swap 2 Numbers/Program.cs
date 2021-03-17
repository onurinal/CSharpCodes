using System;

namespace Swap2Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("After swapping numbers...");
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("First number is: " + num1 + " and second number is: " + num2);
        }
    }
}
