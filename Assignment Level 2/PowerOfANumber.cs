using System;
class PowerOfNumber {
    static void Main(string[] args) {
        // input base number
        Console.Write("Enter base number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());
        // result variable
        int result = 1;
        for (int i = 1; i <= power; i++) {
            result *= number; // Multiply result by the number
        }
        // print result
        Console.WriteLine($"{number} raised to the power {power} is {result}.");
    }
}
