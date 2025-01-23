using System;

class Calculator{
    static void Main(string[] args)
    {
        double first, second, result = 0;
        string op;
        // user input for numbers operator
        Console.Write("Enter the first number: ");
        first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the operator (+, -, *, /): ");
        op = Console.ReadLine();
        Console.Write("Enter the second number: ");
        second = Convert.ToDouble(Console.ReadLine());
        // operation based on the operator using switch-case
        switch (op)
        {
            case "+":
                result = first + second;
                break;
            case "-":
                result = first - second;
                break;
            case "*":
                result = first * second;
                break;
            case "/":
                // division by zero check
                if (second != 0)
                {
                    result = first / second;
                }
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Invalid Operator");
                return;
        }
        //print result
        Console.WriteLine($"The result of {first} {op} {second} is: {result}");
    }
}
