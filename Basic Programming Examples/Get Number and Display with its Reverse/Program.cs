using System;

namespace Get_Number_and_Display_with_its_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, reverse = 0;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + number % 10;
                number = number / 10;
            }
            Console.Write("Reversed of entered number is: " + reverse);
        }
    }
}
