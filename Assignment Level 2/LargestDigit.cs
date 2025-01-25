using System;
class LargestDigits
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int maxDigit = 10, index = 0, largest = 0, secondLargest = 0;
        int[] digits = new int[maxDigit];
        while (number != 0 && index < maxDigit)
        {
            digits[index++] = number % 10;
            number /= 10;
        }
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }
        Console.WriteLine($"Largest: {largest}, Second Largest: {secondLargest}");
    }
}
