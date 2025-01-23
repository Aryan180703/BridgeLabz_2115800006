using System;

class LeapYearUsingOperators
{
    static void Main(string[] args)
    {
        // input year
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        // Checking  year is greater than or equal to 1582
        if (year < 1582)
        {
            Console.WriteLine("Year must be greater than or equal to 1582.");
        }
        else
        {
            // Checking Year using a one if statement and logical operators
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
    }
}
