using System;

class DivisionExample {
    static void Main() {
        int numerator = 0;
        int denominator = 0;
        int result = 0;
        try {
            Console.Write("Enter the numerator: ");
            numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the denominator: ");
            denominator = Convert.ToInt32(Console.ReadLine());
            result = numerator / denominator;
            Console.WriteLine("Result of division : " + result);
        } catch (DivideByZeroException) {
            Console.WriteLine("Error : Cannot divide by zero");
        } finally {
            Console.WriteLine("Operation completed");
        }
    }
}
