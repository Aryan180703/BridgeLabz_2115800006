using System;
class LeapYear{
    static void Main(string[] args){
        Console.WriteLine("Enter a year : ");
        int year = Convert.ToInt32(Console.ReadLine());
        CheckLeapYear(year);
    }
    //this method will check if a year is leap year or not
    static void CheckLeapYear(int year){
        if(year<1582){
            Console.WriteLine("Enter year more than 1581");
        }
        else if((year%4 == 0 && year%100 != 0)|| year % 400 == 0){
            Console.WriteLine("It is a leap Year");
        }
        else{
            Console.WriteLine("Not a leap year");
        }
    }
}