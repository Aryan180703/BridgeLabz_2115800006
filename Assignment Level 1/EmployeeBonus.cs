using System;
class EmployeeBonus
{
    static void Main(string[] args)
    {
        //salary input
        Console.Write("Enter employee salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter years of service: ");
        int yearsOfService = Convert.ToInt32(Console.ReadLine());
        // Checking if eligible or not
        if (yearsOfService > 5)
        {
            double bonus = salary * 0.05;
            Console.WriteLine($"The bonus amount is: {bonus}");
        }
        else
        {
            // No Bonus for 5years or less
            Console.WriteLine("No Bonus for 5 years or less");
        }
    }
}
