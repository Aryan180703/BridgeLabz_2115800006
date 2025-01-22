using System;
class TriangleAreaCalculator{
    static void Main(string[] args){
        Console.Write("Enter the base in cm : ");
        double baseInCm = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the height in cm : ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());
        double areaInCm = CalculateArea(baseInCm, heightInCm);
        double areaInInches = areaInCm / Math.Pow(2.54, 2);
		Console.WriteLine($"The area of the triangle is {areaInCm} square centimeters and {areaInInches} square inches.");
    }
	// Method to calculate area
    static double CalculateArea(double baseInCm, double heightInCm){
        return 0.5 * baseInCm * heightInCm;
	}
}
