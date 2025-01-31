using System;
class DateComparison{
    static void Main(){
        Console.Write("Enter the first date: ");
        DateTime firstDate;
        while (!DateTime.TryParse(Console.ReadLine(), out firstDate)){
            Console.Write("Invalid format.");
        }
        Console.Write("Enter the second date: ");
        DateTime secondDate;
        while (!DateTime.TryParse(Console.ReadLine(), out secondDate)){
            Console.Write("Invalid format");
        }
        int comparisonResult = DateTime.Compare(firstDate, secondDate);
        if (comparisonResult < 0){
            Console.WriteLine("first date is before the second date");
        }
        else if (comparisonResult > 0){
            Console.WriteLine("first date is after the second date");
        }
        else{
            Console.WriteLine("two dates are the same.");
        }
    }
}
