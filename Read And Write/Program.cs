using System;

namespace Read_And_Write
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name and surname");
            string user = Console.ReadLine();
            Console.WriteLine("Enter your number");
            int userNumber = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("Your name and surname: " + user + "\nYour number: " + userNumber );
        }
    }
}
