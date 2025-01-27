using System;

class WindChillCalculator
{
    static void Main()
    {
        Console.Write("Enter the temperature (in Fahrenheit): ");
        double temperature = double.Parse(Console.ReadLine());
        Console.Write("Enter the wind speed (in mph): ");
        double windSpeed = double.Parse(Console.ReadLine());
        if (windSpeed < 3)
        {
            Console.WriteLine("Wind speed must be 3 mph or greater");
            return;
        }
        double windChill = CalculateWindChill(temperature, windSpeed);
        //print the result
        Console.WriteLine($"The wind chill temperature is: {windChill:F2}°F");
    }

    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        //wind chill formula
        double windChill = 35.74 
                         + 0.6215 * temperature 
                         + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill; // Returning the calculated wind chill
    }
}