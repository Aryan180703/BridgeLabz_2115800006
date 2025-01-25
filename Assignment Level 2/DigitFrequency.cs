using System;
class DigitFrequency
{
    static void Main(string[] args)
    {
        //user input the number
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        // array to store digits 
        int[] digits = new int[10];
        int temp = number;
        while (temp != 0)
        {
            int digit = temp % 10;  // Get the last digit
            digits[digit]++;        // Increment the count for that digit
            temp /= 10;             // Remove the last digit
        }
        //prints the frequency of each digit
        Console.WriteLine("\nFrequency of each digit in the number:");
        for (int i = 0; i < 10; i++)
        {
            if (digits[i] > 0)
                Console.WriteLine($"Digit {i}: {digits[i]} times");
        }
    }
}
