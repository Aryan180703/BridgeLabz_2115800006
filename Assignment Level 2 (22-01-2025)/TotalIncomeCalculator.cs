using System;
class TotalIncomeCalculator{
    static void Main(string[] args){
        Console.Write("Enter salary : ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter bonus : ");
        double bonus = Convert.ToDouble(Console.ReadLine());
        double totalIncome = CalculateIncome(salary, bonus);
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {totalIncome}");
    }
	// Method to calculate total income
    static double CalculateIncome(double salary, double bonus){
        return salary + bonus;
    }
}
