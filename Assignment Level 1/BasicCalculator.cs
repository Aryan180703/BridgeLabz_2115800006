using System;
class BasicCalculator{
	static double addition;
	static double subtraction;
	static double multiplication;
	static double division;
    static void Main(string[] args){
        Console.Write("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
		//print result
		Calculation(number1,number2);
        Console.WriteLine($"The addition, subtraction, multiplication, and division value of {number1} and {number2} is {addition}, {subtraction}, {multiplication}, and {division}");
    }
	//this method performs calculations
	static void Calculation(double num1, double num2){
		addition = num1 + num2;
        subtraction = num1 - num2;
        multiplication = num1 * num2;
        division = num1/num2;
	}
}
