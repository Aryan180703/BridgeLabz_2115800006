using System;
class DateFormatting{
    static void Main(){
        Console.Write("Enter a date (yyyy-MM-dd): ");
        DateTime inputDate;
        while (!DateTime.TryParse(Console.ReadLine(), out inputDate))
        {
            Console.Write("Invalid format. Please enter a date (yyyy-MM-dd): ");
        }
        DateTime modifiedDate = inputDate.AddDays(7).AddMonths(1).AddYears(2);
        Console.WriteLine("After adding 7 days, 1 month, and 2 years: " + modifiedDate.ToString("yyyy-MM-dd"));
        DateTime finalDate = modifiedDate.AddDays(-21);
        Console.WriteLine("After subtracting 3 weeks: " + finalDate.ToString("yyyy-MM-dd"));
        DateTime currentDate = DateTime.Now;
        Console.WriteLine("Date in dd/MM/yyyy format: " + currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine("Date in yyyy-MM-dd format: " + currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine("MMM dd, yyyy format: " + currentDate.ToString("ddd, MMM dd, yyyy"));
    }
}
