using System; 
class BMIProgram { 
    static void Main(string[] args) { 
        //user input number of persons
        Console.Write("Enter the number of persons: "); 
        int numberOfPersons = int.Parse(Console.ReadLine()); 
        double[] height = new double[numberOfPersons]; 
        double[] weight = new double[numberOfPersons]; 
        double[] bmi = new double[numberOfPersons]; 
        string[] status = new string[numberOfPersons]; 
        // user input height and weight
        for (int i = 0; i < numberOfPersons; i++) { 
            Console.Write($"Enter height (m) of person {i + 1}: "); 
            height[i] = double.Parse(Console.ReadLine()); 
            Console.Write($"Enter weight (kg) of person {i + 1}: "); 
            weight[i] = double.Parse(Console.ReadLine()); 
        } 
        //calculate BMI
        for (int i = 0; i < numberOfPersons; i++) { 
            bmi[i] = weight[i] / (height[i] * height[i]); // BMI formula
            if (bmi[i] <= 18.4) 
                status[i] = "Underweight"; 
            else if (bmi[i] <= 24.9) 
                status[i] = "Normal"; 
            else if (bmi[i] <= 39.9) 
                status[i] = "Overweight"; 
            else 
                status[i] = "Obese"; 
        } 
        // print details of each person
        Console.WriteLine("\nResults:"); 
        for (int i = 0; i < numberOfPersons; i++) { 
            Console.WriteLine($"Person {i + 1}: Height = {height[i]}m, Weight = {weight[i]}kg, BMI = {bmi[i]:F2}, Status = {status[i]}"); 
        } 
    } 
}
