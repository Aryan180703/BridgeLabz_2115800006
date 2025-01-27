using System;

class SpringSeason{
    static void Main(string[] args)
    {
        // Taking month and day as input 
        Console.Write("Enter month : ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter day : ");
        int day = Convert.ToInt32(Console.ReadLine());
        Season(month , day);
    }
    // Checking if Spring Season (March 20 to June 20)
    static void Season(int month, int day){
            if ((month == 3 && day >= 20) || 
            (month == 4) || 
            (month == 5) || 
            (month == 6 && day <= 20))
        {
            Console.WriteLine("It's a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
        }
}
