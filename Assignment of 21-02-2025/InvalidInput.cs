using System;

class InterestCalculator {
    static double CalculateInterest(double amount, double rate, int years) {
        if (amount < 0 || rate < 0) {
            throw new ArgumentException("Amount and rate must be positive");
        }

        double interest = amount * rate * years / 100;
        return interest;
    }

    static void Main() {
        try {
            Console.Write("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the interest rate : ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the number of years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            double interest = CalculateInterest(amount, rate, years);

            Console.WriteLine("Calculated Interest: " + interest);
        } catch (ArgumentException ex) {
            Console.WriteLine("Invalid input: " + ex.Message);
        } catch (FormatException) {
            Console.WriteLine("Invalid input : Please enter numeric values");
        }
    }
}
