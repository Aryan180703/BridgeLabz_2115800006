using System;
class FahrenheitToCelsius{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
		double celsiusResult = ConvertFahrenheitToCelsius(fahrenheit);
		Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius");
    }
	// Method to convert Fahrenheit to Celsius
    static double ConvertFahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }
}
