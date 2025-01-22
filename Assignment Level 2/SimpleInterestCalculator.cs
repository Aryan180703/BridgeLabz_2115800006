using System;
class SimpleInterestCalculator {
    public static void Main(string[] args) {
        Console.Write("Enter the Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Rate of Interest (%): ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = CalculateSimpleInterest(principal, rate, time);
        // Prints the results
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}% and Time {time} years.");
    }
	// Method to calculate Simple Interest
    public static double CalculateSimpleInterest(double principal, double rate, double time) {
        return (principal * rate * time) / 100;
    }
}
