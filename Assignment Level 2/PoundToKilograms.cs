using System;
class PoundToKilograms {
    public static void Main(string[] args) {
        // Input: Get the weight in pounds from the user
        Console.Write("Enter the weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());

        // Convert pounds to kilograms
        double weightInKg = ConvertToKilograms(weightInPounds);

        // Output the results
        Console.WriteLine($"The weight of the person in pounds is {weightInPounds} and in kg is {weightInKg:F2}");
    }

    // Method to convert weight from pounds to kilograms
    public static double ConvertToKilograms(double pounds) {
        return pounds / 2.2; // 1 pound = 2.2 kg
    }
}
