using System;
class BMICalculator {
    //this method will calculate BMI
    public static double FindBMI(double weight, double heightInCm) {
        double heightInMeters = heightInCm / 100; // Convert height from cm to meters
        double bmi = weight / (heightInMeters * heightInMeters); // BMI formula
        return bmi;
    }

    //determine status 
    public static string BMIStatus(double bmi) {
        if (bmi <= 18.4) {
            return "Underweight";
        } else if (bmi >= 18.5 && bmi <= 24.9) {
            return "Normal";
        } else if (bmi >= 25.0 && bmi <= 39.9) {
            return "Overweight";
        } else {
            return "Obese";
        }
    }
    public static void Main(string[] args) {
        double[,] bmi = new double[10, 3]; 
        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"Enter weight and weight of person {i + 1} :");
            Console.Write("Enter weight : ");
            bmi[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height : ");
            bmi[i, 1] = Convert.ToDouble(Console.ReadLine());
            bmi[i, 2] = FindBMI(bmi[i, 0], bmi[i, 1]);
        }
        Console.WriteLine("\nPerson Details (Weight, Height, BMI, Status):");
        for (int i = 0; i < 10; i++) {
            string status = BMIStatus(bmi[i, 2]); // Get BMI status
            Console.WriteLine($"Person {i + 1} = Weight = {bmi[i, 0]} , height = {bmi[i, 1]} , BMI = {bmi[i, 2]:0.00}, status = {status}");
        }
    }
}
