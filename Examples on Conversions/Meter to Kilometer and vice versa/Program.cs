/*
 * C# Program to Perform Conversions of Meter to Kilometer and vice versa
 */
using System;

namespace Meter_to_Kilometer_and_vice_versa
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            Console.Write("Enter a meter to convert kilometer: ");
            number = double.Parse(Console.ReadLine());
            Console.WriteLine("Meter\t::\tKilometer");
            Console.WriteLine(number + "\t" + "::" + "\t" + ConvertDistance.ConvertKilometerToMeter(number));
            Console.Write("Enter a kilometer to convert meter: ");
            number = double.Parse(Console.ReadLine());
            Console.WriteLine("Kilometer\t::\tMeter");
            Console.WriteLine(number + "\t" + "::" + "\t" + ConvertDistance.ConvertMeterToKilometer(number));

        }
    }
    public static class ConvertDistance
    {
        public static double ConvertKilometerToMeter(double number)
        {
            return number / 1000;
        }
        public static double ConvertMeterToKilometer(double number)
        {
            return number * 1000;
        }
    }
}
