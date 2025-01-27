using System;

class QuotientAndRemainder
{
    public static void Main()
    {
        Console.Write("Enter the first number (dividend): ");
        int number = int.Parse(Console.ReadLine());        
        Console.Write("Enter the second number (divisor): ");
        int divisor = int.Parse(Console.ReadLine());
        if (divisor == 0)
        {
            Console.WriteLine("Divisor cannot be zero.");
            return;
        }
        int[] result = FindRemainderAndQuotient(number, divisor);
        // PRINT RESULT
        Console.WriteLine($"Quotient: {result[0]}, Remainder: {result[1]}");
    }

    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        //array to store the quotient and remainder
        int[] result = new int[2];
        // Calculating quotient and remainder
        result[0] = number / divisor; // Quotient
        result[1] = number % divisor; // Remainder
        return result; // Returning the array
    }
}
