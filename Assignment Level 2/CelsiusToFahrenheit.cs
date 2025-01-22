using System;
class CelsiusToFahrenheit{
    static void Main(string[] args){
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
		double fahrenheit = ConvertCelsiusToFahrenheit(celsius);
		Console.WriteLine($"The {celsius} Celsius is {fahrenheit} Fahrenheit");
    }
	// Method to convert temperature
    static double ConvertCelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }
}
