using System;
class AreaOfCircle{
	static void Main(String[] args){
	Console.Write("Enter the value of Radius : ");
	float r = float.Parse(Console.ReadLine());
	float Area = (float)Math.PI*r*r;
	Console.WriteLine($"Area of Circle : {Area}");
	}
}