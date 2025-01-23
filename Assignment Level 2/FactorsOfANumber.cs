using System;
class FactorsOfNumber {
    static void Main(string[] args) {
        // user input number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The factors of {number} are:");
        for (int i = 1; i <= number; i++) {
            // Check if number is divisible by i
            if (number % i == 0) {
                Console.WriteLine(i); // Print the factor
            }
        }
    }
}
