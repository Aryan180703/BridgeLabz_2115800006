using System;
class EmployeeBonus
{
    static void Main(string[] args)
    {
        const int numberOfEmployees = 10;
        double[] salaries = new double[numberOfEmployees];
        double[] yearsOfService = new double[numberOfEmployees];
        double[] bonuses = new double[numberOfEmployees];
        double[] newSalaries = new double[numberOfEmployees];
        double totalBonus = 0.0;
        double totalOldSalary = 0.0;
        double totalNewSalary = 0.0;
        //user input salary and years of service 
        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"Enter details for Employee {i + 1}:");
            while (true)
            {
                Console.Write("Enter salary: ");
                if (double.TryParse(Console.ReadLine(), out double salary) && salary > 0)
                {
                    salaries[i] = salary;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid salary. Please enter a positive number.");
                }
            }
            while (true)
            {
                Console.Write("Enter years of service: ");
                if (double.TryParse(Console.ReadLine(), out double years) && years >= 0)
                {
                    yearsOfService[i] = years;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid years of service. Please enter a non-negative number.");
                }
            }
        }
        //calculate bonuse, new salaries, and totals
        for (int i = 0; i < numberOfEmployees; i++)
        {
            double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;
            bonuses[i] = salaries[i] * bonusPercentage;
            newSalaries[i] = salaries[i] + bonuses[i];

            totalBonus += bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
        }
        // print results
        Console.WriteLine("\nEmployee Details:");
        for (int i = 0; i < numberOfEmployees; i++)
        {
            Console.WriteLine($"Employee {i + 1}:");
            Console.WriteLine($"  Old Salary: {salaries[i]:C}");
            Console.WriteLine($"  Years of Service: {yearsOfService[i]}");
            Console.WriteLine($"  Bonus: {bonuses[i]:C}");
            Console.WriteLine($"  New Salary: {newSalaries[i]:C}");
        }
        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Total Bonus Payout: {totalBonus:C}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
        Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
    }
}
