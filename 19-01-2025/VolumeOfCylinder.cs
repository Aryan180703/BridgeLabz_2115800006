using System;
class VolumeOfCylinder{
	static void Main(String[] args){
	Console.Write("Enter Radius : ");
	double r = double.Parse(Console.ReadLine());
	Console.Write("Enter Height : ");
	double h = double.Parse(Console.ReadLine());
	Console.Write("Volume of Cylinder = " + (Math.PI*r*r*h));
	}
}	