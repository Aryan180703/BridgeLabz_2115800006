using System; 
class BMIProgram2D { 
    static void Main(string[] args) { 
        Console.Write("Enter the number of persons: "); 
        int numberOfPersons = int.Parse(Console.ReadLine()); 
        double[][] personData = new double[numberOfPersons][]; 
        for (int i = 0; i < numberOfPersons; i++) 
            personData[i] = new double[3]; 
        string[] weightStatus = new string[numberOfPersons]; 
        //user input height and weight
        for (int i = 0; i < numberOfPersons; i++) { 
            do { 
                Console.Write($"Enter height (m) of person {i + 1}: "); 
                personData[i][0] = double.Parse(Console.ReadLine()); 
                if (personData[i][0] <= 0) Console.WriteLine("Height must be positive."); 
            } while (personData[i][0] <= 0); 
            
            do { 
                Console.Write($"Enter weight (kg) of person {i + 1}: "); 
                personData[i][1] = double.Parse(Console.ReadLine()); 
                if (personData[i][1] <= 0) Console.WriteLine("Weight must be positive."); 
            } while (personData[i][1] <= 0); 
        } 
        //calculate BMI
        for (int i = 0; i < numberOfPersons; i++) { 
            personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]); // BMI formula
            if (personData[i][2] <= 18.4) 
                weightStatus[i] = "Underweight"; 
            else if (personData[i][2] <= 24.9) 
                weightStatus[i] = "Normal"; 
            else if (personData[i][2] <= 39.9) 
                weightStatus[i] = "Overweight"; 
            else 
                weightStatus[i] = "Obese"; 
        } 
        //print result
        Console.WriteLine("\nResults:"); 
        for (int i = 0; i < numberOfPersons; i++) { 
            Console.WriteLine($"Person {i + 1}: Height = {personData[i][0]}m, Weight = {personData[i][1]}kg, BMI = {personData[i][2]:F2}, Status = {weightStatus[i]}"); 
        } 
    } 
}
