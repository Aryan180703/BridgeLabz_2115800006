using System;

class BMIProgram {
    static void Main(string[] args) {
        //user input for weight in kg
        Console.Write("Enter your weight (in kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        // user input for height in cm
        Console.Write("Enter your height (in cm): ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        // Convert height- cm to meters
        double heightMeters = heightCm / 100;
        // Calculate BMI
        double bmi = weight / (heightMeters * heightMeters);
        // print BMI
        Console.WriteLine($"\nYour BMI is: {bmi}");
        string status;
        if (bmi <= 18.4) {
            status = "Underweight";
        } else if (bmi <= 24.9) {
            status = "Normal";
        } else if (bmi <= 39.9) {
            status = "Overweight";
        } else {
            status = "Obese";
        }
        // Display status
        Console.WriteLine($"Weight Status: {status}");
    }
}
