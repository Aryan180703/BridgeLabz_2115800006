using System;
class QuotientRemainderCalculator{
    static void Main(string[] args){
        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
		int quotient = CalculateQuotient(number1, number2);
        int remainder = CalculateRemainder(number1, number2);
        Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
    }
	//This method calculates Quotient
    static int CalculateQuotient(int number1, int number2){
        return number1 / number2;
    }
	//This method calculates Remainder
    static int CalculateRemainder(int number1, int number2){
        return number1 % number2;
    }
}
