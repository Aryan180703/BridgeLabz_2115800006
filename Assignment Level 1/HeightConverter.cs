using System;
class HeightConverter{
    static int feet;
    static double inches;
	static void Main(string[] args){
        Console.Write("Height in centimeters: ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());
        ConvertHeightToFeetInches(heightInCm);
        Console.WriteLine($"Your height in cm is {heightInCm}, while in feet it is {feet} feet and {inches} inches");
    }

    // Convert height in feet and inches
    static void ConvertHeightToFeetInches(double heightInCm){
        double heightInInches = heightInCm / 2.54;
        feet = (int)(heightInInches / 12); 
        inches = heightInInches % 12; 
    }
}
