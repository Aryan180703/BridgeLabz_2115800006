using System;

class DivisionCalculator {
    static void Main() {
        try {
            Console.Write("Enter the first number : ");
            double numerator = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number : ");
            double denominator = Convert.ToDouble(Console.ReadLine());
            double result = numerator / denominator;
            Console.WriteLine("Result : " + result);
        } catch (DivideByZeroException) {
            Console.WriteLine("Error : Division by zero is not allowed");
        } catch (FormatException) {
            Console.WriteLine("Error :   Please enter int value");
        }
    }
}
