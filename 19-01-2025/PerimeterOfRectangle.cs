using System;
class PerimeterOfRectangle{
	static void Main(String[] args){
	Console.Write("Enter Length : ");
	double length = double.Parse(Console.ReadLine());
	Console.Write("Enter width : ");
	double width = double.Parse(Console.ReadLine());
	double perimeter = 2*(length+width);
	Console.WriteLine("Perimeter of rectangle = "+perimeter);
	}
}	
	