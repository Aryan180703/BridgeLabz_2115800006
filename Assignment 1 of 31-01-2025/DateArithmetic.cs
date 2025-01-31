using System;
class Program{
    static void Main(){
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate;
        while (!DateTime.TryParse(Console.ReadLine(), out inputDate)){
            Console.Write("Invalid format");
        }
        DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        Console.WriteLine("After adding 7 days, 1 month, and 2 years: " + modifiedDate.ToString("yyyy-MM-dd"));
        DateTime finalDate = modifiedDate.AddDays(-21);
        Console.WriteLine("After subtracting 3 weeks: " + finalDate.ToString("yyyy-MM-dd"));
    }
}