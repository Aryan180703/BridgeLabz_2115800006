using System;
class PositiveNegativeOrZero
{
    static void Main(string[] args)
    {
        int[] number = new int[5];
        //loop to take user input of 5 numbers
        for (int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToInt32(Console.ReadLine());
        }
        //this loop will tell if number is positive, negative or zero
        foreach (int i in number)
        {
            if (i > 0)
            {
                //if the number is posiive it will check for even or odd
                Console.WriteLine((i % 2 == 0) ?
                    $"{i} is Even positive number"
                    : $"{i} is Odd positive number");
            }
            //if the number is negative
            else if (i < 0)
            {
                Console.WriteLine($"{i} is negative number");
            }
            //check if number is zero
            else
            {
                Console.WriteLine("Zero");
            }
        }
        //compare first and last element of the array
        int firstNumber = number[0];
        int lastNumber = number[number.Length - 1];
        if (firstNumber == lastNumber)
        {
            Console.WriteLine("first and last element are equal");
        }
        else
        {
            Console.WriteLine((firstNumber > lastNumber) ?
                "first number is greater than last number"
                : "last number is greater than first number");
        }
    }
}