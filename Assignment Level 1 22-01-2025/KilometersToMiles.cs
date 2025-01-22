using System;
class KilometersToMiles{
	static void Main(String[] args){
		double kilometers = 10.8;
		double miles = KilometersToMiles.ConvertKilometersToMiles(kilometers);
		Console.WriteLine($"The distance 10.8 km in miles is {miles}");
	}
	// This method Converts Kilometers To Miles
	static double ConvertKilometersToMiles(double kilometers){
		double miles = (double)0.621371*kilometers;
		return miles;
	}
}
	