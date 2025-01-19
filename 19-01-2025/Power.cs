using System;
class Power{
	static void Main(String[] args){
	Console.Write("Enter base : ");
	int bse = int.Parse(Console.ReadLine());
	Console.Write("Enter Exponent : ");
	int exponent = int.Parse(Console.ReadLine());
	double power = Math.Pow(bse,exponent);
	Console.WriteLine("Power : " + power);
	}
}	