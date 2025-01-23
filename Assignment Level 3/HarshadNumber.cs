using System;

class HarshadNumber {
    static void Main(string[] args) {
        // user input
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
        //sum and originalNumber variables
        int sum = 0;
        int originalNumber = number;
        number = Math.Abs(number);
        // loop to calculate sum of digits
        while (number != 0){
            int digit = number % 10;
            sum += digit
            number /= 10;
        }
        if (originalNumber % sum == 0) {
            Console.WriteLine($"{originalNumber} is a Harshad Number.");
        } else {
            Console.WriteLine($"{originalNumber} is not a Harshad Number.");
        }
    }
}
