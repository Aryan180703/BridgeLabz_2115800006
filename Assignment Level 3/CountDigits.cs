using System;

class CountDigits {
    static void Main(string[] args) {
        // user input for number
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        number = Math.Abs(number);
        //loop to count the digits
        do {
            // Remove last digit
            number /= 10;
            count++;
        } while (number != 0);
        Console.WriteLine($"The number of digits is: {count}");
    }
}
