
using System;
class UnitConverter{
    public static double ConvertYardsToFeet(double yards){
        return 3.0*yards;
    }
    public static double ConvertFeetToYards(double feet){
        return 0.333333*feet;
    }
    public static double ConvertMetersToInches(double meters){
        return 39.3701;*meters;
    }
    public static double ConvertInchesToMeters(double inches){
        return  0.0254*inches;
    }
    public static double ConvertInchesToCm(double inches){
        return  2.54*inches;
    }
}