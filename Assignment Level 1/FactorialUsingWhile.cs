using System;

class FactorialUsingWhile
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int num = Convert.ToInt32(Console.ReadLine());

        // Check if negative integer
        if (num < 0)
        {
            Console.WriteLine("Enter a positive number");
            return;
        }

        // factorial using while loop
        int factorial = 1;
        int counter = num;

        while (counter > 0)
        {
            factorial *= counter;
            counter--;
        }

        Console.WriteLine($"The factorial of {num} is: {factorial}");
    }
}
