using System;
class OddEvenArrays
{
    static void Main(string[] args)
    {
        Console.Write("Enter a natural number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number (greater than 0).");
            return;
        }
        //calculate array size
        int maxSize = number / 2 + 1;
        int[] oddNumbers = new int[maxSize];
        int[] evenNumbers = new int[maxSize];
        int oddIndex = 0;
        int evenIndex = 0;
        // separate odd and even numbers
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }
        // Print odd array
        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }
        // Print even array
        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }

        Console.WriteLine();
    }
}
