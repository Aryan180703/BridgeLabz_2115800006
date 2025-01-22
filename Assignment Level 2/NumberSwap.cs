using System;

class SwapNumbers
{
    static void Main(string[] args){
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        Swap(ref number1, ref number2);
		//Prints Swapped Numbers
		Console.WriteLine($"The swapped numbers are {number1} and {number2}");
    }
	// Method to swap two numbers
    static void Swap(ref double number1, ref double number2)
    {
        double temp = number1;
        number1 = number2;
        number2 = temp;
    }
}
