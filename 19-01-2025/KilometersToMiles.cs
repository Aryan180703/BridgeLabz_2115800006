using System;
class KilometerToMiles{
	static void Main(String[] args){
	Console.Write("Enter Distance in Kilometers : ");
	double kilometers = double.Parse(Console.ReadLine());
	double miles = kilometers*0.621371;
	Console.WriteLine("Distance in Miles : " + miles);
	}
}	