using System;
class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int digitCount = 0, temp = number;
        //count number of digits
        while (temp > 0)
        {
            digitCount++;
            temp /= 10;
        }
        int[] digits = new int[digitCount];
        int index = 0;
        //store in array
        while (number > 0)
        {
            digits[index++] = number % 10;
            number /= 10;
        }
        //print reversed number
        Console.WriteLine("Reversed number:");
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(digits[i]);
        }
    }
}
