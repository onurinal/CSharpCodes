/*
 * C# Program to Perform Celsius to Fahrenheit Conversion
 */
using System;

namespace Celsius_to_Fahrenheit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, fahrenheit;
            Console.Write("Enter the temperature in Celsius(°C): ");
            celsius = int.Parse(Console.ReadLine());
            fahrenheit = ((celsius * 9) / 5) + 32;
            Console.Write("Temperature in Fahrenheit(°F) is " + fahrenheit);
        }
    }
}
