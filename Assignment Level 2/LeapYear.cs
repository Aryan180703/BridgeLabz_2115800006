using System;

class LeapYear
{
    static void Main(string[] args){
        // user input year
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        // Checking if year is greater than or equal to 1582
        if (year < 1582){
            Console.WriteLine("Year must be greater than or equal to 1582.");
        }
        else{
            //Checking using multiple if-else statements
            Console.WriteLine("Checking with if-else statements:");
            CheckLeapYearUsingIfElse(year);
            //Checking using a single if statement
            Console.WriteLine("\nChecking with a single if statement:");
            CheckLeapYearUsingSingleIf(year);
        }
    }

    //Checking Leap Year using multiple if else statements
    static void CheckLeapYearUsingIfElse(int year){
        if (year % 400 == 0){
            Console.WriteLine($"{year} is a leap year");
        }
        else if (year % 100 == 0){
            Console.WriteLine($"{year} is not a leap year.");
        }
        else if (year % 4 == 0){
            Console.WriteLine($"{year} is a leap year.");
        }
        else{
            Console.WriteLine($"{year} is not a leap year.");
        }
    }

    //Checking using a single if statement with nested condition
    static void CheckLeapYearUsingSingleIf(int year){
        if (year % 4 == 0){
            if (year % 100 != 0){
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else{
                if (year % 400 == 0){
                    Console.WriteLine($"{year} is a Leap Year.");
                }
                else{
                    Console.WriteLine($"{year} is not a Leap Year.");
                }
            }
        }
        else{
            Console.WriteLine($"{year} is not a Leap Year.");
        }
    }
}
