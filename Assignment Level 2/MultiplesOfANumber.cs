using System;
class MultiplesOfNumber {
    static void Main(string[] args) {
        // uaer input number
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The multiples of {number} below 100 are:");
        for (int i = 100; i >= 1; i--) {
            // Check if i is divisible by the number
            if (i % number == 0) {
                Console.WriteLine(i); 
            }
        }
    }
}
