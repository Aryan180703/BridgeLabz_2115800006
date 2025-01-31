using System;
class BasicCalculator{
    static void Main(){
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double result = 0;
        if (operation == '+'){
            result = Add(num1, num2);
        }
        else if (operation == '-'){
            result = Subtract(num1, num2);
        }
        else if (operation == '*'){
            result = Multiply(num1, num2);
        }
        else if (operation == '/'){
            result = Divide(num1, num2);
        }
        Console.WriteLine("Result: " + result);
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }
}
