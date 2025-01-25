using System;
class FizzBuzz
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // check if the input is a positive integer
        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a positive integer.");
            return;
        }
        string[] results = new string[number + 1];
        for (int i = 0; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString();
            }
        }
        // print the result
        Console.WriteLine("\nFizzBuzz Results:");
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}
