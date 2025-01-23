using System;
class MultiplicationTable
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // Multiplication table from 6 to 9
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
