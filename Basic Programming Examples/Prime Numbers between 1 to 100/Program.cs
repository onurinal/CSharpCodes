/*
 * C# Program to Display All the Prime Numbers Between 1 to 100
 */
using System;

namespace Prime_Numbers_between_1_to_100
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.Write("Prime numbers:  ");
            for(int i = 2; i <= 100; i++)
            {
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }    
                }
                if (isPrime)
                {
                    if(i == 97) // for last number
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + ", ");
                    }
                }
                isPrime = true;
            }
        }
    }
}
