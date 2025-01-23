using System;
class GreatestFactor {
    static void Main(string[] args) {
        // user input integer
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // check if number is greater than 1
        if (number <= 1) {
            Console.WriteLine("Please enter an integer greater than 1.");
            return;
        }
        int greatestFactor = 1;
        // loop runs from number - 1 to 1
        for (int i = number - 1; i >= 1; i--) {
            // Check if the number is perfectly divisible by i
            if (number % i == 0) {
                greatestFactor = i; // Assign i to greatestFactor
                break; // Exit the loop after finding the greatest factor
            }
        }
        // print greatest factor
        Console.WriteLine($"The greatest factor of {number} beside itself is {greatestFactor}.");
    }
}
