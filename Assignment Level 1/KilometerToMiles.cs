using System;
class KilometerToMiles{
    static void Main(){
        // enter distance in kilometers
        Console.Write("Enter the distance in kilometers : ");
        double km = Convert.ToDouble(Console.ReadLine());
		double miles = KilometersToMiles(km);
        // print the result
        Console.WriteLine($"The total miles is {miles} mile(s) for the given {km} km");
    }
	//this method converts kilometers to mile
	static double KilometersToMiles(double km){
		double miles = km / 1.6;
		return miles;
	}
}
