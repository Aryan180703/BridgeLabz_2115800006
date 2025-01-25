using System;
class MultiplicationTable
{
    static void Main(string[] args)
    {
        // User input to enter a number
        Console.WriteLine("Enter a number :");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] multiplicationResult = new int[4];
        // Calculate the multiplication results
        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
        }
        // prints multiplication table
        Console.WriteLine($"Multiplication table of {number} from 6 to 9:");
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }
}
