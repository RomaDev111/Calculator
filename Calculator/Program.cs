using System;
using Calculator;
using static Calculator.Operations;

namespace Lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation:");
            Console.WriteLine("1. Addition (+)");
            Console.WriteLine("2. Subtraction (-)");
            Console.WriteLine("3. Multiplication (*)");
            Console.WriteLine("4. Division (/)");

            Console.Write("Enter the operation number: ");
            string choice = (Console.ReadLine());

            double result = 0;


            switch (choice)
            {
                case "+":
                    result =  Operations.Add(num1, num2);
                    break;
                case "-":
                    result = Operations.Substract(num1, num2);
                    break;
                case "*":
                    result = Operations.Multiply(num1, num2);
                    break;
                case "/":
                    result = Operations.Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            Console.WriteLine($"Result: {result}");
        }
    }
}
