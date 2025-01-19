using System;
class AverageOfThreeNumbers{
	static void Main(String[] args){
	Console.Write("Enter first number : ");
	int num1 = int.Parse(Console.ReadLine());
	Console.Write("Enter second number : ");
	int num2 = int.Parse(Console.ReadLine());
	Console.Write("Enter third number : ");
	int num3 = int.Parse(Console.ReadLine());
	float Average = (float)(num1+num2+num3)/3;
	Console.WriteLine("Average Of Three Numbers is : "+Average);
	}
}