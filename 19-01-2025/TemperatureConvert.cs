using System;
class TemperatureConvert{
	static void Main(String[] args){
	Console.Write("Enter temperature in celsius : ");
	double cel = double.Parse(Console.ReadLine());
	Console.Write("Temperature in Fahrenheit : " + (cel*(9.0/5.0) +32.0));
	}
}	
	