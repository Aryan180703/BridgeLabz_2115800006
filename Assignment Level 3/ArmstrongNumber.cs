using System;

class ArmstrongNumberProgram {
    static void Main(string[] args) {
        // user input 
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0; 
        int originalNumber = number;
        while (originalNumber != 0) {
            int remainder = originalNumber % 10;
            sum += remainder * remainder * remainder
            originalNumber /= 10;
        }
        // Check if the original number equals the sum of cubes of its digits
        if (number == sum) {
            Console.WriteLine($"{number} is an Armstrong number.");
        } else {
            Console.WriteLine($"{number} is not an Armstrong number.");
        }
    }
}
