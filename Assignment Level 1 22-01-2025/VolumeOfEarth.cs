using System;
class VolumeOfEarth{
	static void Main(String[] args){
		double radiusInKms = 6378;
		double radiusInMiles =radiusInKms*0.621371;
		double volumeInKms = Volume(radiusInKms);
		double volumeInMiles = Volume(radiusInMiles);
		Console.WriteLine($"The volume of earth in cubic kilometers is {volumeInKms} and cubic miles is {volumeInMiles}");
	}
	static double Volume(double radius){
		double volumeOfEarth = (4.0/3.0)*Math.PI*Math.Pow(radius,3);
		return volumeOfEarth;
	}	
}			