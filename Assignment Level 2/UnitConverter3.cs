using System;
class UnitConverter{
    public static double ConvertFahrenheitToCelsius(double fahrenheit) {
        return (5.0 / 9) * (fahrenheit - 32);
    }
    public static double ConvertCelsiusToFahrenheit(double celsius) {
        return (9.0 / 5) * celsius + 32;
    }
    public static double ConvertPoundsToKilograms(double pounds) {
        return 0.453592 * pounds;
    }
    public static double ConvertKilogramsToPounds(double kilograms) {
        return 2.20462 * kilograms;
    }
    public static double ConvertGallonsToLiters(double gallons) {
        return 3.78541 * gallons;
    }
    public static double ConvertLitersToGallons(double liters) {
        return 0.264172 * liters;
    }
}
