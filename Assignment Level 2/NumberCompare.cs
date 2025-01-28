using System;
class NumberChecking {
    // this method will tell number positive or negative
    public static string IsPositive(int number) {
        if (number < 0) {
            return "Negative";
        } else {
            return "Positive";
        }
    }
    // this method will tell number is even or odd
    public static string IsEven(int number) {
        if (number % 2 == 0) {
            return "Even";
        } else {
            return "Odd";
        }
    }
    //this method will return -1,1,0 based on caparison result
    public static int Compare(int number1, int number2) {
        if (number1 > number2) {
            return 1;
        } else if (number1 == number2) {
            return 0;
        } else {
            return -1;
        }
    }
    public static void Main(string[] args) {
        int[] numbers = new int[5];
        // input 5 number
        Console.WriteLine("Enter 5 numbers : ");
        for (int i = 0; i < numbers.Length; i++) {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++) {
            string positiveOrNegative = IsPositive(numbers[i]);
            if (positiveOrNegative == "Positive") {
                string evenOrNot = IsEven(numbers[i]);
                Console.WriteLine($"{numbers[i]} is Positive and {evenOrNot}.");
            } else {
                Console.WriteLine($"{numbers[i]} is Negative.");
            }
        }
        int compare = Compare(numbers[0], numbers[4]);
        if (compare == 1) {
            Console.WriteLine($"first number ({numbers[0]}) is greater than the last number ({numbers[4]})");
        } else if (compare == 0) {
            Console.WriteLine($"first number ({numbers[0]}) is equal to the last number ({numbers[4]})");
        } else {
            Console.WriteLine($"first number ({numbers[0]}) is less than the last number ({numbers[4]})");
        }
    }
}
