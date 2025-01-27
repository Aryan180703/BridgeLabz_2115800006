using System;

class TrigonometricFnctions
{
    static void Main(){
        // Taking user input for the angle in degrees
        Console.Write("Enter the angle in degrees: ");
        double angleInDegrees = double.Parse(Console.ReadLine());
        double[] trigValues = CalculateTrigonometricFunctions(angleInDegrees);
        //print the results
        Console.WriteLine($"Sine of {angleInDegrees}: {trigValues[0]}");
        Console.WriteLine($"Cosine of {angleInDegrees}: {trigValues[1]}");
        Console.WriteLine($"Tangent of {angleInDegrees}: {trigValues[2]}");
    }

    public static double[] CalculateTrigonometricFunctions(double angle)
    {
        double angleInRadians = Math.PI * angle / 180;
        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(angleInRadians);
        double cosine = Math.Cos(angleInRadians);
        double tangent = Math.Tan(angleInRadians);
        double[] trigValues = { sine, cosine, tangent };
        return trigValues;
    }
}
