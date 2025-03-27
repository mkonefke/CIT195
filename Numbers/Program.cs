using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        var add = (double a, double b) => a + b;
        var multiply = (double a, double b) => a * b;
        var lesserValue = (double a, double b) => 
        {
                if (a < b)
                    return a;
                else
                    return b;
        };
        Console.WriteLine($"Sum of {num1} and {num2}: {add(num1, num2)}");
        Console.WriteLine($"Product of {num1} and {num2}: {multiply(num1, num2)}");
        Console.WriteLine($"Smaller number between {num1} and {num2}: {lesserValue(num1, num2)}");
    }
}