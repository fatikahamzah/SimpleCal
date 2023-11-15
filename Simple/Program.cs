using System;

namespace SimpleConsoleApp
{
    public class Calculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Divide(double number1, double number2)
        {
            if (number2 == 0)
            {
                throw new ArgumentException("Cannot divide by zero.");
            }
            return number1 / number2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Simple Calculator App");
            Console.WriteLine("--------------------");
            Console.WriteLine("Addition (1)");
            Console.WriteLine("Subtraction (2)");
            Console.WriteLine("Multiplication (3)");
            Console.WriteLine("Division (4)");
            Console.WriteLine("--------------------");
            Console.Write("Enter your choice: ");

            char choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double number1, number2, result;
            switch (choice)
            {
                case '1':
                    Console.Write("Enter first number: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    result = calculator.Add(number1, number2);
                    Console.WriteLine($"Result: {result}");
                    break;
                case '2':
                    Console.Write("Enter first number: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    result = calculator.Subtract(number1, number2);
                    Console.WriteLine($"Result: {result}");
                    break;
                case '3':
                    Console.Write("Enter first number: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    result = calculator.Multiply(number1, number2);
                    Console.WriteLine($"Result: {result}");
                    break;
                case '4':
                    Console.Write("Enter first number: ");
                    number1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    number2 = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        result = calculator.Divide(number1, number2);
                        Console.WriteLine($"Result: {result}");
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                    break;
            }

            Console.WriteLine("Thank you for using the Simple Calculator App.");
            Console.ReadLine();
        }
    }
}
