using System;
class UnitConverter{
    public static double ConvertKmToMiles(double km){
        return 0.621371*km;
    }
    public static double ConvertMilesToKm(double miles){
        return 1.60934*miles;
    }
    public static double ConvertMetersToFeet(double meters){
        return 3.28084*meters;
    }
    public static double ConvertFeetToMeters(double feet){
        return 0.3048*feet;
    }
}