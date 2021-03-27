/*
 * C# Program to Demonstrate Multiple Exceptions
 */
using System;

namespace Multiple_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2;
            double result = 0;
            char op;
            try
            {
                Console.Write("Enter your first number: ");
                number1 = double.Parse(Console.ReadLine());
                Console.Write("Enter an operator (+, -, * or /): ");
                op = char.Parse(Console.ReadLine());
                if(op != '+' && op != '-' &&
                    op != '*' && op != '/')
                {
                    throw new Exception(op.ToString());
                }
                Console.Write("Enter your second number: ");
                number2 = double.Parse(Console.ReadLine());
                if (op == '/')
                {
                    if(number2 == 0)
                    {
                        throw new DivideByZeroException();
                    }
                }
                result = Calculater(number1, number2, op);
                Console.WriteLine(number1 + " " + op + " " + number2 + " = " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("The number you typed is not valid");
            }
            catch (DivideByZeroException m)
            {
                Console.WriteLine(m.Message);
            }
            catch (Exception m)
            {
                Console.WriteLine("Operation error: " + m.Message + " is not a valid operator");
            }
        }
        static double Calculater(double number1, double number2, char op)
        {
            double result = 0;
            switch (op)
            {
                case '+': result = number1 + number2;
                    break;
                case '-': result = number1 - number2;
                    break;
                case '*': result = number1 * number2;
                    break;
                case '/': result = number1 / number2;
                    break;
            }
            return result;
        }
    }
}
