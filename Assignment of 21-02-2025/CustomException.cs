using System;

class InvalidAgeException : Exception {
    public InvalidAgeException(string message) : base(message) {
    }
}
class AgeValidator {
    public static void ValidateAge(int age) {
        if (age < 18) {
            throw new InvalidAgeException("Age must be 18 or above.");
        } else {
            Console.WriteLine("Access granted!");
        }
    }
    static void Main() {
        try {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            ValidateAge(age);
        } catch (InvalidAgeException ex) {
            Console.WriteLine(ex.Message);
        } catch (FormatException) {
            Console.WriteLine("Error: Please enter a valid numeric age.");
        }
    }
}
