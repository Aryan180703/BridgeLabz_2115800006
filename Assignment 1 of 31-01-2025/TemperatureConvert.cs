using System;
class TemperatureConverter{
    static void Main(){
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Temperature in Celsius: " + FahrenheitToCelsius(fahrenheit) + " °C");
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Temperature in Fahrenheit: " + CelsiusToFahrenheit(celsius) + " °F");
    }
    static double FahrenheitToCelsius(double f){
        return (f - 32) * 5 / 9;
    }
    static double CelsiusToFahrenheit(double c){
        return (c * 9 / 5) + 32;
    }
}
